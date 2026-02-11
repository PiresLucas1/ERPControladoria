namespace SolfarmaGp.Controllers.Utils.Validacoes
{
    internal class ValidaNatureza
    {
        public bool ValidaCodigoNaturezaFilial(string valor, int filial, string ufTomador, string ufPrestador)
        {            
            bool retorno = false;
            string[] arrayNaturezaFilialMatrizDentroEstado = {
               "1.933.001",
               "1.933.003",
               "1.933.004",
               "1.933.005",
               "1.933.006",
               "1.933.007",
               "1.933.009",
               "1.933.010",
               "1.933.011",
               "1.933.012",
               "1.933.013",
               "1.933.014",
               "1.933.015",
               "1.933.016"
               };

            string[] arrayNaturezaFilialMatrizOutroEstado =
            {
                "2.933.001",
                "2.933.002",
                "2.933.003",
                "2.933.004",
                "2.933.005"
            };
            switch (filial)
            {
                case 1:
                    bool validacaoUf = ValidaMesmoEstado(ufTomador, ufPrestador);
                    if (validacaoUf)
                    {
                        bool verificaSeExisteValorDentroDoArray = arrayNaturezaFilialMatrizDentroEstado.Contains(valor);
                        if (!verificaSeExisteValorDentroDoArray)
                        {
                            
                            return false;
                            //throw new ArgumentException("Natureza de Filial inválida para Filial Matriz dentro do estado.");                           
                        }
                        retorno = true;
                        break;
                    }
                    else
                    {
                        bool verificaSeExisteValorForaDoArray = arrayNaturezaFilialMatrizOutroEstado.Contains(valor);
                        if (!verificaSeExisteValorForaDoArray)
                        {
                            
                            return false;
                            //throw new ArgumentException("Natureza de Filial inválida para Filial Matriz fora do estado.");
                        }
                        retorno = true;
                        break;
                    }
                case 5:
                case 7:
                case 8:
                case 9:
                case 10:
                    bool validacaoUfOutraFilial = ValidaMesmoEstado(ufTomador, ufPrestador);
                    if (validacaoUfOutraFilial)
                    {
                        if (valor != "1.933.008")
                        {
                            
                            return false;
                            //throw new ArgumentException("Natureza de Filial inválida para Filial dentro do estado.");
                        }
                        retorno = true;
                        break;
                    }
                    else
                    {
                        if (valor != "2.933.006")
                        {
                            
                            return false;
                            //throw new ArgumentException("Natureza de Filial inválida para Filial fora do estado.");
                        }
                    }
                    retorno = true;
                    break;

            }
            return retorno;
            //outras filiais dentro do estado = 1.933.008
            // filiais fora do estado = 2.933.006
        }
        public bool ValidaMesmoEstado(string ufTomador, string ufPrestador)
        {
            return ufTomador == ufPrestador;

        }
    }
}
