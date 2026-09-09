using SolfarmaGp.Repositorios.Fiscal.ImportaNotasServicoTotvs.FabricanteNfeServico;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.ImportarNotasServicoParaTotvs.CadastroFornecedor
{
    public class ConsultaFabricanteNfeServicoPorCodigoUseCase
    {
        public async Task<(string situacao, string mensagem, string codCfo)> Executar(string codigoVerificacao)
        {
            DataTable retorno = await new ConsultaFabricanteNfeServicoPorCodigo().Executar(codigoVerificacao);

            if (retorno.Rows.Count == 0)
            {
                return ("ERRO", "A procedure não retornou nenhum resultado.", "");
            }

            DataRow row = retorno.Rows[0];

            string situacao = row.Field<string>("Situacao") ?? "";
            string mensagem = row.Field<string>("Mensagem") ?? "";
            string codCfo = retorno.Columns.Contains("CODCFO") ? row.Field<string>("CODCFO") ?? "" : "";

            return (situacao, mensagem, codCfo);
        }
    }
}
