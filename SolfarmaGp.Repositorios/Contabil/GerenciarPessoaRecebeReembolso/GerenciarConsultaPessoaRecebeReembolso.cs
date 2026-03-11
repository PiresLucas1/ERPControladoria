using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Contabil.GerenciarPessoaRecebeReembolso
{
    public class GerenciarConsultaPessoaRecebeReembolso
    {
        public async Task<DataTable> Execute()
        {
            DataTable dt = new DataTable();
            DbConexaoConfig conexao = new DbConexaoConfig(DbName.GpDbsol);

            try
            {
                using(SqlConnection conn = conexao.AbrirConexao())
                {
                    using(SqlCommand cmd = new SqlCommand("uspContabilConsultaPessoaRecebeReembolsoFinanceiro", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        
                        using(SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dt.Load(reader);
                        }
                    }
                    conexao.FecharConexao(conn);
                }
                
            }catch(SqlException ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
            return dt;
        }
    }
}
