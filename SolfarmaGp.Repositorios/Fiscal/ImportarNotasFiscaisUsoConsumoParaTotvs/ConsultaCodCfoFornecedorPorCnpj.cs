using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    public class ConsultaCodCfoFornecedorPorCnpj
    {
        public async Task<string> Executar(string cnpjFornecedor)
        {
            string codCfo = null;
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            const string sql = @"
                select
                    fornecedor.CODCFO
                from
                    CORPORERM_TESTE.dbo.FCFO fornecedor (NOLOCK)
                where
                    fornecedor.CODCOLIGADA = 2
                    and REPLACE(REPLACE(REPLACE(fornecedor.CGCCFO, '.', ''), '/', ''), '-', '') = @Cnpj";

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@Cnpj", SqlDbType.VarChar, 20).Value = cnpjFornecedor;

                        var resultado = await cmd.ExecuteScalarAsync();
                        if (resultado != null && resultado != DBNull.Value)
                            codCfo = resultado.ToString();
                    }

                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return codCfo;
        }
    }
}
