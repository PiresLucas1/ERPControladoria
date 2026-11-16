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
            public string CodTipoMovimento { get; set; }
            public int CodColigada { get; set; }
            public int CodFilial { get; set; }
            public TotaisNotaXml TotaisXml { get; set; } = new TotaisNotaXml();
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
                CodColigada = nota.CodColigada,
                SerieDocumento = nota.SerieDocumento,
                DataEmissao = nota.DataDocumento,
                DataLancamento = nota.DataLancamento,                
                CodCCFO = null,
                CodFilial = nota.CodFilial,
                CodTipoMovimento = nota.CodTipoMovimento,
                CodMunServico = null,
                CodEtdMunServ = null,
                IdNatMov = null,
                CodTdo = null,
                CodNat = null
            };

            // Converte o DataTable recebido para a estrutura tipada que o TVP espera
            var itensTvp = MontaDataTableTvp(itens);
            notaCapaRepo.CodNat = CfopValue;
            notaCapaRepo.IdNatMov = await ObterIdNatMov(nota.CodColigada, CfopValue);
            var (dtResult, idMovGerado) = await repo.Executar(notaCapaRepo, itensTvp);
            return (dtResult, idMovGerado);
        }

        // Retorna os itens exatamente como serão enviados na TVP (usado na conferência antes de lançar)
        public DataTable MontarItensParaEnvio(DataTable itens)
        {
            return MontaDataTableTvp(itens);
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
            // Impostos e valores do item vindos do XML.
            // ATENÇÃO: a ordem das colunas precisa ser a mesma do tipo dbo.TVPItensNotaUsoConsumo
            tabelaTvp.Columns.Add("VALORICMS", typeof(decimal));
            tabelaTvp.Columns.Add("BASEICMSST", typeof(decimal));
            tabelaTvp.Columns.Add("ALIQUOTAICMSST", typeof(decimal));
            tabelaTvp.Columns.Add("VALORICMSST", typeof(decimal));
            tabelaTvp.Columns.Add("BASEIPI", typeof(decimal));
            tabelaTvp.Columns.Add("ALIQUOTAIPI", typeof(decimal));
            tabelaTvp.Columns.Add("VALORIPI", typeof(decimal));
            tabelaTvp.Columns.Add("BASEPIS", typeof(decimal));
            tabelaTvp.Columns.Add("ALIQUOTAPIS", typeof(decimal));
            tabelaTvp.Columns.Add("VALORPIS", typeof(decimal));
            tabelaTvp.Columns.Add("BASECOFINS", typeof(decimal));
            tabelaTvp.Columns.Add("ALIQUOTACOFINS", typeof(decimal));
            tabelaTvp.Columns.Add("VALORCOFINS", typeof(decimal));
            tabelaTvp.Columns.Add("VALORFRETE", typeof(decimal));
            tabelaTvp.Columns.Add("VALORDESCONTO", typeof(decimal));
            tabelaTvp.Columns.Add("VALOROUTRAS", typeof(decimal));

            foreach (DataRow row in itens.Rows)
            {
                var novaLinha = tabelaTvp.NewRow();

                decimal quantidade = Convert.ToDecimal(row["Quantidade"]);
                decimal valorTotalItem = Convert.ToDecimal(row["Valor"]); // ValorItem do XML é o total do item

                if (quantidade <= 0)
                    throw new ArgumentException($"Item {row["IDProduto"]} está com quantidade zerada.");

                // TVP tem VALORUNITARIO DECIMAL(18,4)
                decimal valorUnitario = Math.Round(valorTotalItem / quantidade, 4);

                novaLinha["IDPRD"] = Convert.ToInt32(row["IDProduto"]);
                novaLinha["QUANTIDADE"] = quantidade;
                novaLinha["VALORUNITARIO"] = valorUnitario;
                novaLinha["CODNAT"] = ValorOuNulo(row["Natureza"]);
                novaLinha["CODUND"] = ValorOuNulo(row["UnidadeComercial"]);

                // TODO: confirmar de onde vem o centro de custo
                novaLinha["CODCCUSTO"] = DBNull.Value;

                // Impostos do item no XML; item sem correspondência no XML vai com tudo zerado
                ImpostoItemXml imposto = itens.Columns.Contains("Impostos") ? row["Impostos"] as ImpostoItemXml : null;
                imposto ??= new ImpostoItemXml();

                novaLinha["BASEICMS"] = imposto.BaseIcms;
                novaLinha["ALIQUOTAICMS"] = imposto.AliquotaIcms;
                novaLinha["VALORICMS"] = imposto.ValorIcms;
                novaLinha["BASEICMSST"] = imposto.BaseIcmsST;
                novaLinha["ALIQUOTAICMSST"] = imposto.AliquotaIcmsST;
                novaLinha["VALORICMSST"] = imposto.ValorIcmsST;
                novaLinha["BASEIPI"] = imposto.BaseIpi;
                novaLinha["ALIQUOTAIPI"] = imposto.AliquotaIpi;
                novaLinha["VALORIPI"] = imposto.ValorIpi;
                novaLinha["BASEPIS"] = imposto.BasePis;
                novaLinha["ALIQUOTAPIS"] = imposto.AliquotaPis;
                novaLinha["VALORPIS"] = imposto.ValorPis;
                novaLinha["BASECOFINS"] = imposto.BaseCofins;
                novaLinha["ALIQUOTACOFINS"] = imposto.AliquotaCofins;
                novaLinha["VALORCOFINS"] = imposto.ValorCofins;
                novaLinha["VALORFRETE"] = imposto.ValorFrete;
                novaLinha["VALORDESCONTO"] = imposto.ValorDesconto;
                novaLinha["VALOROUTRAS"] = imposto.ValorOutrasDespesas;


                tabelaTvp.Rows.Add(novaLinha);
            }
            CfopValue = ObterPrefixoNatureza(itens);

            return tabelaTvp;
        }
        // Busca o IDNAT da natureza do movimento (natureza do primeiro item) na coligada da nota
        private async Task<int> ObterIdNatMov(int codColigada, string codNat)
        {
            //string codNat = itens.AsEnumerable()
            //    .Select(r => r["Natureza"]?.ToString()?.Trim())
            //    .FirstOrDefault(n => !string.IsNullOrEmpty(n));

            return await new ConsultaIDNatPorColigada().Executar(codColigada, codNat);
        }

        // DBNull.ToString() devolve "", então trata vazio como nulo
        private static object ValorOuNulo(object valor)
        {
            string texto = valor?.ToString()?.Trim();
            return string.IsNullOrEmpty(texto) ? DBNull.Value : texto;
        }

        private string ObterPrefixoNatureza(DataTable itens)
        {
            // Mantém os pontos e pega só os dois primeiros níveis: "1.556.003" → "1.556"
            var prefixos = itens.AsEnumerable()
                .Select(r => (r["Natureza"]?.ToString() ?? "").Trim())
                .Where(s => s.Length > 0)
                .Select(s => string.Join(".", s.Split('.').Take(2)))
                .ToList();

            if (prefixos.Count == 0)
                return "";

            // Todos iguais → mantém os dois níveis (ex.: "1.556")
            if (prefixos.Distinct().Count() == 1)
                return prefixos[0];

            // Algum diferente → só o primeiro nível (ex.: "1")
            return prefixos[0].Split('.')[0];
        }
    }
}