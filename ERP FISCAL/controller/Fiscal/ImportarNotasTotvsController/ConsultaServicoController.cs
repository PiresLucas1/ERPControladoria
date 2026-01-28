using ERP_FISCAL.Repositories.Fiscal.ImportarNotasTotvsRepositories;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_FISCAL.Controller.Fiscal.ImportarNotasTotvsController
{
    public class ConsultaServicoController
    {
        public async Task<(string codigoServico, string descricaoServico, string codigoNatureza, string descricaoNatureza)> Executar(string cnpjValor, int valorTipo)
        {

            DataTable Retorno = await new ConsultaServicoRepositories().Executar(cnpjValor, valorTipo);

            var row = Retorno.AsEnumerable()
                             .FirstOrDefault(r => r.Field<string>("CNPJ") == cnpjValor);

            if (row == null)
            {
                return ("", "","","");
            }

            string codigoServico = row.Field<string>("CODSERVICOTOTVS");
            string descricaoServico = row.Field<string>("DESCRICAO");
            string codigoNatureza = row.Field<string>("CODNATUREZA");
            string descricaoNatureza = row.Field<string>("DESCRICAOCOMPLETA");


            return (codigoServico, descricaoServico, codigoNatureza, descricaoNatureza);

        }
    }
}
