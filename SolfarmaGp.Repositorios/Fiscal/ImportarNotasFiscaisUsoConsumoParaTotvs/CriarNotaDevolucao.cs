using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisParaTotvs
{
    public class CriarNotaDevolucao
    {
        public async Task<int> Executar(
         int intCodColigada,
         int intCodFilial,
         string vchCodCCFO,
         string vchSerieDocumento,
         string vchCodTipoMovimento,
         string INvchNumeroDocumento,
         string INvchChaveAcesso,
         DateTime INdatDataEmissao,
         DateTime INdatDataLancamento,
         DataTable tvpItens,
         string vchCODMUNSERVICO = null,
         string vchCODETDMUNSERV = null,
         int? inIDNatMov = null,
         string vchCODTDO = "NF-e")
        {
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);
            int idMovGerado;

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspUsuNotaUsoConsumoInclusaoGP", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@intCodColigada", intCodColigada);
                        cmd.Parameters.AddWithValue("@intCodFilial", intCodFilial);
                        cmd.Parameters.AddWithValue("@vchCodCCFO", vchCodCCFO);
                        cmd.Parameters.AddWithValue("@vchSerieDocumento", vchSerieDocumento);
                        cmd.Parameters.AddWithValue("@vchCodTipoMovimento", vchCodTipoMovimento);
                        cmd.Parameters.AddWithValue("@INvchNumeroDocumento", INvchNumeroDocumento);
                        cmd.Parameters.AddWithValue("@INvchChaveAcesso", INvchChaveAcesso);
                        cmd.Parameters.AddWithValue("@INdatDataEmissao", INdatDataEmissao);
                        cmd.Parameters.AddWithValue("@INdatDataLancamento", INdatDataLancamento);
                        cmd.Parameters.AddWithValue("@vchCODMUNSERVICO", (object)vchCODMUNSERVICO ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@vchCODETDMUNSERV", (object)vchCODETDMUNSERV ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@inIDNatMov", (object)inIDNatMov ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@vchCODTDO", vchCODTDO);

                        // Parâmetro TVP - table-valued parameter
                        SqlParameter tvpParam = cmd.Parameters.AddWithValue("@tvpItens", tvpItens);
                        tvpParam.SqlDbType = SqlDbType.Structured;
                        tvpParam.TypeName = "dbo.TVPItensNotaUsoConsumo";

                        // Parâmetro de saída
                        SqlParameter outputParam = new SqlParameter("@OUTintIDMOV", SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(outputParam);

                        await cmd.ExecuteNonQueryAsync();

                        idMovGerado = (int)outputParam.Value;
                    }
                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return idMovGerado;
        }
    }
}
