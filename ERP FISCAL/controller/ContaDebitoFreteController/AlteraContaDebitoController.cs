using ERP_FISCAL.Repositories.RepositoriesAlterarContaDebito;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Controller.ContaDebitoFreteController
{
    public class AlteraContaDebitoController
    {
        public async Task<DataTable> PesuisarNotas(DateTime dataInicio, DateTime dataFim)
        {
            if (dataInicio <= dataFim)
            {
               AlteraContaDebitoRepositories alteraContaDebitoRepositories = new AlteraContaDebitoRepositories();
                DataTable dataTableRetorno =  await alteraContaDebitoRepositories.PesquisarNotas(dataInicio, dataFim));
                return dataTableRetorno;
            }
            else
            {
                throw new ArgumentException("A data de início deve ser anterior ou igual à data de fim.");
            }
        }
    }
}
