using SolfarmaGp.Repositorios.SegurancaUserRepositories;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.SeguracaUser
{
    public class ConsultaUnicoUsuarioUseCase
    {
        public async Task<DataTable> Executar(string nomeUsuario)
        {
            ConsultarUnicoUsuarioRepo segCadastroRepositories = new ConsultarUnicoUsuarioRepo();
            DataTable retorno = new DataTable();
            retorno = await segCadastroRepositories.Executar(nomeUsuario);
            return retorno;
        }
    }
}
