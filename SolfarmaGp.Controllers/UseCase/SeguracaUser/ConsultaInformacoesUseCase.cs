
using SolfarmaGp.Repositorios.SegurancaUserRepositories;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.SeguracaUser
{
    public class ConsultaInformacoesUseCase
    {
        public async Task<DataTable> Executar(string nomeUsuario, int tipoPesquisa)
        {
            ListaInformacoesRepo segCadastroRepositories = new ListaInformacoesRepo();
            DataTable retorno = new DataTable();
            if (tipoPesquisa == 1)
            {
                retorno = await segCadastroRepositories.ListaDadosPorNome(nomeUsuario);
            }
            if (tipoPesquisa == 2)
            {
                retorno = await segCadastroRepositories.ListaDadosPorPerfil(nomeUsuario);
            }
            if (tipoPesquisa == 3)
            {
                retorno = await segCadastroRepositories.ListaDadosPorMenu(nomeUsuario);
            }

            return retorno;

        }
    }
}
