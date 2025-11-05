using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Service.BlingService.ts
{
    public class DtoDataRowToDocumentoNota
    {
        public class ItemDocumento
        {
            public int NumDocumento { get; set; }
            public string ChaveAcesso { get; set; }
            public int IDProduto { get; set; }
            public string DescProduto { get; set; }
            public DateTime DataDocumento { get; set; }
            public int CFOPVenda { get; set; }
            public int CSTICMS { get; set; }
            public int CFOPZanup { get; set; }
            public decimal QuantidadeVenda { get; set; }
            public decimal Devolucao { get; set; }
            public decimal SaldoRestante { get; set; }
            public decimal ValorUnitario { get; set; }
            public decimal IcmsBaseValorUnidade { get; set; }
            public decimal IcmsBase { get; set; }
            public decimal IcmsAliquota { get; set; }
            public decimal IcmsValorUnidade { get; set; }
            public decimal IcmsValor { get; set; }
            public decimal PisValor { get; set; }
            public decimal CofinsValor { get; set; }
            public decimal QtdParaDevolver { get; set; }
            public string EstoqueOrigem { get; set; }
        }

    }
}
