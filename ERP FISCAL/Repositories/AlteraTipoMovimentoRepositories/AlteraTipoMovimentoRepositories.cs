using SeuProjeto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Repositories.AlteraTipoMovimentoRepositories
{
    internal class AlteraTipoMovimentoRepositories
    {
        public async Task<DataTable> ConsultaMovimentoTotvs(int codMovimento, int coligada)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosGestaoProcessos conexaoBanco = new ConexaoBancoDeDadosGestaoProcessos();

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadConsultaIDMovTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p;
                        cmd.Parameters.AddWithValue("@INintIDMOV", codMovimento);
                        if (coligada == 0)
                        {
                            cmd.Parameters.AddWithValue("@INintCodColigada", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@INintCodColigada", coligada);
                        }
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }

                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }


            return tabela;
        }

        public async Task<DataTable> AlteraTipoMovimento(int codMovimento, int coligada, string codTmovimento)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosGestaoProcessos conexaoBanco = new ConexaoBancoDeDadosGestaoProcessos();

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadAlteraCodMovimentoTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p;
                        cmd.Parameters.AddWithValue("@INintIDMov", codMovimento);
                        cmd.Parameters.AddWithValue("@INintCodColigada", coligada);
                        cmd.Parameters.AddWithValue("@INvchCodTmv", codTmovimento);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }

                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }


            return tabela;
        }
    }
}

