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

            try
            {

                using (SqlConnection conexao = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.UspQiveConsultaNFSe", conexao))
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
            }
            catch (Exception e )
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                throw new ArgumentException("Falha ao executar a operação", e);
                
            }

            return tabela;
        }

        public DataTable FindUniqueNote(string noteId)
        {
            DataTable table = new DataTable();
            ConexaoBancoDeDadosDfe connectionDataBase = new ConexaoBancoDeDadosDfe();

            using (SqlConnection conn = connectionDataBase.AbrirConexao())
            {
                using (SqlCommand cmd = new SqlCommand("uspQiveProcuraNotaIndividual", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@INvchrChaveDeAcesso", noteId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }

                connectionDataBase.FecharConexao(conn);
            }
            return table;
        }
    }
}
