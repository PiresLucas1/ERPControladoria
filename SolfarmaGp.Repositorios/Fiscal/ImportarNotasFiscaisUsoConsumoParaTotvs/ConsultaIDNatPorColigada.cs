using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    public class ConsultaIDNatPorColigada
    {
        public async Task<int> Executar(int codColigada, string codNat)
        {
            int idNat = 0;
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspConsultaIDNatPorColigada", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intCodColigada", SqlDbType.Int).Value = codColigada;
                        cmd.Parameters.Add("@vchCodNat", SqlDbType.VarChar, 30).Value =
                            !string.IsNullOrWhiteSpace(codNat) ? (object)codNat.Trim() : DBNull.Value;

                        var outputParam = cmd.Parameters.Add("@OUTintIDNat", SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;

                        // A procedure gera RAISERROR quando a natureza não existe, o que cai no catch abaixo
                        await cmd.ExecuteNonQueryAsync();

                        idNat = outputParam.Value != DBNull.Value ? (int)outputParam.Value : 0;
                    }

                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return idNat;
        }
    }
}
