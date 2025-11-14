using ERP_FISCAL.Repositories.SegCadastroRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Controller.SegCadastroController
{
    public class SegCadastroController
    {
        public async Task<DataTable> ListaDados(string nomeUsuario, int tipoPesquisa)
        {
            SegCadastroRepositories segCadastroRepositories = new SegCadastroRepositories();
            DataTable retorno = new DataTable();
            if (tipoPesquisa == 1)
            {
                 retorno = await segCadastroRepositories.ListaDadosPorNome(nomeUsuario);
            }
            if(tipoPesquisa == 2)
            {
                 retorno = await segCadastroRepositories.ListaDadosPorPerfil(nomeUsuario);
            }
            if(tipoPesquisa == 3)
            {
                 retorno = await segCadastroRepositories.ListaDadosPorMenu(nomeUsuario);
            }
            
            return retorno;

        }

        public async Task<DataTable> InseriInformacao(string descricao, string subDescricao = null)
        {
            SegCadastroRepositories segCadastroRepositories = new SegCadastroRepositories();
            DataTable retorno = new DataTable();
            if(subDescricao == null)
            {
                 retorno = await segCadastroRepositories.InserirPerfil(descricao);
            }
            else
            {
                 retorno = await segCadastroRepositories.InserirMenu(descricao, subDescricao);
            }
            return retorno;
        } 
        public async Task<DataTable> ConsultaUnicoUsuario(string nomeUsuario)
        {
            SegCadastroRepositories segCadastroRepositories = new SegCadastroRepositories();
            DataTable retorno = new DataTable();
            retorno = await segCadastroRepositories.ConsultaUnicoUsuario(nomeUsuario);
            return retorno;
        }
        public async Task<DataTable> InseriUsuario(string nomeUsuario, int perfilUsuario)
        {
            SegCadastroRepositories segCadastroRepositories = new SegCadastroRepositories();
            DataTable retorno = new DataTable();
            retorno = await segCadastroRepositories.InserirUsuario(nomeUsuario, perfilUsuario);
            return retorno;
        }
    }
}
