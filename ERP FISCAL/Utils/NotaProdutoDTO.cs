using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Utils
{
    public class NotaProdutoDTO
    {
        public string CnpjCpf { get; set; }
        public string Nome { get; set; }
        public int NumeroNota { get; set; }
        public string Serie { get; set; }
        public DateTime DataEmissao { get; set; }
        public int CodigoProduto { get; set; }
        public string Produto { get; set; }
        public decimal ValorTotalProduto { get; set; }
        public decimal IcmsBase { get; set; }
        public decimal IcmsAliquota { get; set; }
        public decimal IcmsValor { get; set; }
        public string ChaveAcesso { get; set; }

        //opcionais
        public string? CpfCnpj { get; set; }
        public string? Destinatario { get; set; }
        public string? InscricaoEstadualDestinatario { get; set; }
        public string? NumeroEnderecoDestinatario { get; set; }
        public string? BairroEnderecoDestinatario { get; set; }
        public string? CepEnderecoDestinatario { get; set; }
        public string? NomeMunicipioEnderecoDestinatario { get; set; }
        public string? UfEnderecoDestinatario { get; set; }
    }

}
