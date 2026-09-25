using SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    public class CriaNotaUsoConsumoNaTotvs
    {
        public class NotaCapa
        {
            public string IDQiveArquivoXml { get; set; }
            public string ChaveAcesso { get; set; }
            public string CnpjFornecedor { get; set; }
            public string IDErpContasPagar { get; set; }
            public string NumDocumento { get; set; }
            public DateTime? DataDocumento { get; set; } // Adicionado para cobrir todos os parâmetros da procedure
            public DateTime? DataLancamento { get; set; } 
            public string SerieDocumento { get; set; } // Adicionado para cobrir todos os parâmetros da procedure   
        }
        public string CfopValue { get; set; }

        public async Task<(DataTable,int)> Execute(NotaCapa nota, DataTable itens)
        {
            CriaNotaUsoConsumoNaTotvsRepositorio repo = new CriaNotaUsoConsumoNaTotvsRepositorio();

            var notaCapaRepo = new CriaNotaUsoConsumoNaTotvsRepositorio.NotaCapa
            {
                IDQiveArquivoXml = nota.IDQiveArquivoXml,
                ChaveAcesso = nota.ChaveAcesso,
                CnpjFornecedor = nota.CnpjFornecedor,
                IDErpContasPagar = nota.IDErpContasPagar,
                NumDocumento = nota.NumDocumento,

                // Campos que existem só no Repositório - sem valor disponível aqui ainda
                CodColigada = 2,
                SerieDocumento = nota.SerieDocumento,
                DataEmissao = nota.DataDocumento,
                DataLancamento = nota.DataLancamento,                
                CodCCFO = null,
                CodFilial = null,
                CodTipoMovimento = null,
                CodMunServico = null,
                CodEtdMunServ = null,
                IdNatMov = null,
                CodTdo = null
            };

            // Converte o DataTable recebido para a estrutura tipada que o TVP espera
            var itensTvp = MontaDataTableTvp(itens);
            notaCapaRepo.CodNat = CfopValue;
            var (dtResult, idMovGerado) = await repo.Executar(notaCapaRepo, itensTvp);
            return (dtResult, idMovGerado);
        }

        /// <summary>
        /// Converte o DataTable de entrada (colunas tipo object) para o DataTable
        /// com os tipos e a estrutura exigidos pelo TVP dbo.TVPItensNotaUsoConsumo.
        /// </summary>
        private DataTable MontaDataTableTvp(DataTable itens)
        {
            var tabelaTvp = new DataTable();
            tabelaTvp.Columns.Add("IDPRD", typeof(int));
            tabelaTvp.Columns.Add("QUANTIDADE", typeof(decimal));
            tabelaTvp.Columns.Add("VALORUNITARIO", typeof(decimal));
            tabelaTvp.Columns.Add("CODNAT", typeof(string));
            tabelaTvp.Columns.Add("CODUND", typeof(string));
            tabelaTvp.Columns.Add("CODCCUSTO", typeof(string));
            tabelaTvp.Columns.Add("ALIQUOTAICMS", typeof(decimal));
            tabelaTvp.Columns.Add("BASEICMS", typeof(decimal));
            

            foreach (DataRow row in itens.Rows)
            {
                var novaLinha = tabelaTvp.NewRow();

                novaLinha["IDPRD"] = Convert.ToInt32(row["IDProduto"]);
                novaLinha["QUANTIDADE"] = Convert.ToDecimal(row["Quantidade"]);
                novaLinha["VALORUNITARIO"] = Convert.ToDecimal(row["Valor"]);
                novaLinha["CODNAT"] = row["Natureza"]?.ToString() ?? (object)DBNull.Value;
                novaLinha["CODUND"] = row["UnidadeComercial"]?.ToString() ?? (object)DBNull.Value;

                // TODO: confirmar de onde vêm esses 3 valores
                novaLinha["CODCCUSTO"] = DBNull.Value;
                novaLinha["ALIQUOTAICMS"] = DBNull.Value;
                novaLinha["BASEICMS"] = DBNull.Value;

                //valida
                

                tabelaTvp.Rows.Add(novaLinha);
            }
            CfopValue = ObterPrefixoNatureza(itens);

            return tabelaTvp;
        }
        private string ObterPrefixoNatureza(DataTable itens)
        {
            var prefixos = itens.AsEnumerable()
                .Select(r => (r["Natureza"]?.ToString() ?? "").Replace(".", "").Trim())
                .Where(s => s.Length > 0)
                .Select(s => s.Length >= 4 ? s.Substring(0, 4) : s)
                .ToList();

            if (prefixos.Count == 0)
                return "";

            // Todos iguais → mantém os 4 dígitos (ex.: "1556")
            if (prefixos.Distinct().Count() == 1)
                return prefixos[0];

            // Algum diferente → só o primeiro caractere (ex.: "1")
            return prefixos[0].Substring(0, 1);
        }
    }
}