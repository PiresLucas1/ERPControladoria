using SeuProjeto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL
{
    internal class Carregar_Colunas
    {

        public DataTable ObterNotas(DateTime dataInicio, DateTime dataFim)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosDfe conexaoBanco = new ConexaoBancoDeDadosDfe();

            using (SqlConnection conexao = conexaoBanco.AbrirConexao())
            {
                using (SqlCommand cmd = new SqlCommand("UspQiveConsultaNFSe", conexao))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 1200; /* 20 minutos */
                    cmd.Parameters.AddWithValue("@INDatDataInicio", dataInicio);
                    cmd.Parameters.AddWithValue("@INDatDataFim", dataFim);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(tabela);
                }

                conexaoBanco.FecharConexao(conexao);
            }

            return tabela;
        }
    }
}
