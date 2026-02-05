
using SolfarmaGp.Repositorios.Fiscal.ImportaDadosBigParaTotvs.ConsultaServico;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ConsultaServico
{
    public class ConsultaServico
    {
        public async Task<(string codigoServico, string descricaoServico, string codigoNatureza, string descricaoNatureza)> Executar(string cnpjValor, int valorTipo)
        {

            DataTable Retorno = await new ConsultaServicoRelacionadoAoCliente().Executar(cnpjValor, valorTipo);

            var row = Retorno.AsEnumerable()
                             .FirstOrDefault(r => r.Field<string>("CNPJ") == cnpjValor);

            if (row == null)
            {
                return ("", "", "", "");
            }

            string codigoServico = row.Field<string>("CODSERVICOTOTVS");
            string descricaoServico = row.Field<string>("DESCRICAO");
            string codigoNatureza = row.Field<string>("CODNATUREZA");
            string descricaoNatureza = row.Field<string>("DESCRICAOCOMPLETA");


            return (codigoServico, descricaoServico, codigoNatureza, descricaoNatureza);

        }
    }
}
