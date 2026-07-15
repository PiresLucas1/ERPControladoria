namespace SolfarmaGp.Services.Utils
{
    public class RetornaEnderecoFilial
    {
        public class Endereco
        {
            public string EnderecoFilial { get; set; }
            public int NumeroEnderecoFilial { get; set; }
            public string BairroEnderecoFilial { get; set; }
            public string CepEnderecoFilial { get; set; }
            public string MunicipioEnderecoFilial { get; set; }
            public string UfEnderecoFilial { get; set; }
        }

        public Endereco RetornaEnderecoFilialPorCodigo(int codigoFilial)
        {
            Endereco endereco = new Endereco();

            switch (codigoFilial)
            {
                case 1:
                    endereco.EnderecoFilial = "Avenida João Ferreira Penna";
                    endereco.NumeroEnderecoFilial = 147;
                    endereco.BairroEnderecoFilial = "DISTRITO INDUSTRIAL III";
                    endereco.CepEnderecoFilial = "14707-002";
                    endereco.MunicipioEnderecoFilial = "Bebedouro";
                    endereco.UfEnderecoFilial = "SP";
                    break;
                case 9:
                    endereco.EnderecoFilial = "Belmiro Dias Baptista";
                    endereco.NumeroEnderecoFilial = 778;
                    endereco.BairroEnderecoFilial = "DISTRITO INDUSTRIAL I";
                    endereco.CepEnderecoFilial = "14711-000";
                    endereco.MunicipioEnderecoFilial = "Bebedouro";
                    endereco.UfEnderecoFilial = "SP";
                    break;
                // Adicione mais casos conforme necessário
                default:
                    throw new ArgumentException("Código de filial inválido.");
            }

            return endereco;
        }
    }
}
