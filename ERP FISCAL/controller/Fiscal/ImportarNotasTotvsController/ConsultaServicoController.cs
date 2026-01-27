using ERP_FISCAL.Repositories.Fiscal.ImportarNotasTotvsRepositories;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ERP_FISCAL.Controller.Fiscal.ImportarNotasTotvsController
{
    public class ConsultaServicoController
    {
        public async Task<string> Executar(string valor)
        {

            DataTable Retorno = await new ConsultaServicoRepositories().Executar(valor);

            var row = Retorno.AsEnumerable()
                             .FirstOrDefault(r => r.Field<string>("CNPJ") == valor);

            string valorServico = row.Field<string>("CODSERVICOTOTVS");
            string valorDescServico = row.Field<string>("DESCRICAOSERVICOTOTVS");
            return valorServico;

        }
    }
}
