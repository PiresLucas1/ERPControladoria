using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ERP_FISCAL.Repositories.GPCampanhaRepositories.BuscaParametros
{
    public class BuscaParametrosRepositories
    {
        public async Task<DataTable> BuscaParametros(int Valor) 
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao()) // <<< apenas cria
                {
                    await conn.OpenAsync(); // <<< abre uma vez aqui

                    using (SqlCommand cmd = new SqlCommand("dbo.uspUsuConsultaValidacaoContabilFrete", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INdatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataFim", dataFim);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }
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
}
