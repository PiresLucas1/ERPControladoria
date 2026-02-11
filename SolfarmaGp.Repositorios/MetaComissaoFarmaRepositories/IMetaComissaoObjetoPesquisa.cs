using System.Data;

namespace SolfarmaGp.Repositorios.MetaComissaoFarmaRepositories
{
    public class IMetaComissaoObjetoPesquisa
    {
        public class ObjetoPesquisa
        {
            public DateTime? INdatDatabase { get; set; }

            public decimal? INnumMetaReceitaLiquidaTotal { get; set; }
            public decimal? INnumMetaReceitaLiquidaHPC { get; set; }
            public decimal? INnumMetaReceitaLiquidaGenerico { get; set; }
            public decimal? INnumMetaReceitaLiquidaNestle { get; set; }
            public decimal? INnumMetaReceitaLiquidaLoreal { get; set; }
            public decimal? INnumMetaReceitaLiquidaEtico { get; set; }

            public decimal? INnumMetaReceitaLiquidaEmpresaFoco1 { get; set; }
            public decimal? INnumMetaReceitaLiquidaEmpresaFoco2 { get; set; }
            public decimal? INnumMetaReceitaLiquidaEmpresaFoco3 { get; set; }
            public decimal? INnumMetaReceitaLiquidaEmpresaFoco4 { get; set; }
            public decimal? INnumMetaReceitaLiquidaEmpresaFoco5 { get; set; }

            public string? INvchIDFabricanteEmpresaFoco1 { get; set; }
            public string? INvchIDFabricanteEmpresaFoco2 { get; set; }
            public string? INvchIDFabricanteEmpresaFoco3 { get; set; }
            public string? INvchIDFabricanteEmpresaFoco4 { get; set; }
            public string? INvchIDFabricanteEmpresaFoco5 { get; set; }

            public string? INvchIDSetorDesconsiderar { get; set; }
            public int? INintNroMeses { get; set; }

            public string? INvchIDPessoaSupervisoresRateio { get; set; }
            public string? INvchPercentualRateioSupervisores { get; set; }
            public string? INvchPercentualRateioSupervisoresHPC { get; set; }
            public string? INvchPercentualRateioSupervisoresGenerico { get; set; }
            public string? INvchPercentualRateioSupervisoresNestle { get; set; }
            public string? INvchPercentualRateioSupervisoresLoreal { get; set; }
            public string? INvchPercentualRateioSupervisoresEtico { get; set; }

            public string? INvchIDProdutoLinhaEmpresaFoco1 { get; set; }
            public string? INvchIDProdutoLinhaEmpresaFoco2 { get; set; }
            public string? INvchIDProdutoLinhaEmpresaFoco3 { get; set; }
            public string? INvchIDProdutoLinhaEmpresaFoco4 { get; set; }
            public string? INvchIDProdutoLinhaEmpresaFoco5 { get; set; }

            public decimal? INnumMetaTotalIndustriasGolden { get; set; }
            public string? INvchIDFabricantesIndustriasGolden { get; set; }
            public string? INvchIDProdutoLinhaIndustriasGolden { get; set; }
        }


      
    }
}
