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
        }

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
                CodFilial = null,
                CodCCFO = null,
                SerieDocumento = null,
                CodTipoMovimento = null,
                DataEmissao = null,
                DataLancamento = null,
                CodMunServico = null,
                CodEtdMunServ = null,
                IdNatMov = null,
                CodTdo = null
            };

            // Converte o DataTable recebido para a estrutura tipada que o TVP espera
            var itensTvp = MontaDataTableTvp(itens);

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

                tabelaTvp.Rows.Add(novaLinha);
            }

            return tabelaTvp;
        }
    }
}