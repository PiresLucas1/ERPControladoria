using SolfarmaGp.Repositorios.SegurancaUserRepositories;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.SeguracaUser
{
    internal class InsereUsuarioUseCase
    {
        public async Task<DataTable> Executar(string nomeUsuario, int perfilUsuario)
        {
            InsereUsuarioRepo segCadastroRepositories = new InsereUsuarioRepo();
            DataTable retorno = new DataTable();
            retorno = await segCadastroRepositories.Executar(nomeUsuario);
            return retorno;
        }
    }
}
