using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.Repositories.AlteraTipoMovimentoRepositories
{
    public class AlteraTipoMovimentoRepositories
    {
        public async Task<DataTable> ConsultaMovimentoTotvs(int codMovimento, int coligada)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadConsultaIDMovTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                       // SqlParameter p;
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
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadAlteraCodMovimentoTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //SqlParameter p;
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

        public async Task<DataTable> AlteraTipoMovimentoEmBloco(int codMovimento, int coligada, string codTmovimento)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadAlteraEmBlocoCodMovimentoTotvsTESTE", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //SqlParameter p;
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

        public async Task<DataTable> ConsultaMultiplosMovimentoTotvs(string codMovimento, int coligada)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspCadConsultaMultiplosIDMovTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                       // SqlParameter p;
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

        public async Task<DataTable> ConsultaListaIDMovimentosTotvs(string codMovimento)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisConsultaListaIDMov", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // SqlParameter p;   
                        cmd.Parameters.AddWithValue("@vchIDMov", codMovimento);                        
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
        public async Task<DataTable> AlteraListaMovimento(DataTable data)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisAlteraTipoMovimento", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;                        
                        cmd.Parameters.AddWithValue("@TMP", data);
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

            MessageBox.Show("Alterações realizadas com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return tabela;
        }
    
    }
}

//uspCadAlteraEmBlocoCodMovimentoTotvsTESTE