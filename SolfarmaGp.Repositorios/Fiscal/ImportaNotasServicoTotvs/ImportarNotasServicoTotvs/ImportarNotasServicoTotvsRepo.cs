using SolfarmaGp.Infraestrutura;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportaNotasServicoTotvs.ImportarNotasServicoTotvs
{
    public class ImportarNotasServicoTotvsRepo
    {
        public async Task Executar(DataTable dtOriginal, List<DataRow> linhasSelecionadas)
        {
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.Totvs);

            try
            {

                using (SqlConnection conexao = conexaoBanco.AbrirConexao())
                {
                    foreach (DataRow row in linhasSelecionadas)
                    {
                        using (SqlCommand cmd = new SqlCommand("dbo.uspImportaNotaServico", conexao))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            // ... (parâmetros)
                            cmd.Parameters.AddWithValue("@INvchCPFCNPJPrestador", row["CNPJ Prestador"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchCPFCNPJTomador", row["CNPJ Tomador"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchNumeroDocumento", row["Documento"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INdatDataEmissao", row["Dt.Hora Emissão"] != DBNull.Value
                                ? Convert.ToDateTime(row["Dt.Hora Emissão"])
                                : DateTime.MinValue);
                            cmd.Parameters.AddWithValue("@INvchDiscriminacaoServico", row["Descriminação"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchCodigoVerificacao", row["Código Verificação"]?.ToString() ?? "");

                            cmd.Parameters.AddWithValue("@INnumValorServico", row["Total Serviços"] != DBNull.Value
                                ? DecimalParse.ParseDecimal(row["Total Serviços"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumValorBrutoServico", row["Valor Líquido"] != DBNull.Value
                                ? DecimalParse.ParseDecimal(row["Valor Líquido"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumISSBaseCalculo", row["Base Cálculo"] != DBNull.Value
                                ? DecimalParse.ParseDecimal(row["Base Cálculo"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumISSValor", row["Valor ISS"] != DBNull.Value
                                ? DecimalParse.ParseDecimal(row["Valor ISS"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumPISValor", row["Valor Pis"] != DBNull.Value
                                ? DecimalParse.ParseDecimal(row["Valor Pis"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumCOFINSValor", row["Valor Cofins"] != DBNull.Value
                                ? DecimalParse.ParseDecimal(row["Valor Cofins"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumCSLLValor", row["Valor Csll"] != DBNull.Value
                                ? DecimalParse.ParseDecimal(row["Valor Csll"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumIRRFValor", row["Valor IR"] != DBNull.Value
                                ? DecimalParse.ParseDecimal(row["Valor IR"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumINSSValor", row["Valor INSS"] != DBNull.Value
                                ? DecimalParse.ParseDecimal(row["Valor INSS"])
                                : 0);

                            cmd.Parameters.AddWithValue("@INvchCodProduto", row["Cód. Serviço TOTVS"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchCFOP", row["CFOP"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INdatDataLancamento", row["Data Lançamento"] != DBNull.Value
                                ? Convert.ToDateTime(row["Data Lançamento"])
                                : DateTime.MinValue);

                            // Parâmetros de saída  @OUTvchMsgRetorno
                            var msgRetorno = new SqlParameter("@OUTvchMsgRetorno", SqlDbType.VarChar, 1000)
                            {
                                Direction = ParameterDirection.Output
                            };
                            var idMov = new SqlParameter("@OUTintIDMOV", SqlDbType.Int)
                            {
                                Direction = ParameterDirection.Output
                            };

                            cmd.Parameters.Add(msgRetorno);
                            cmd.Parameters.Add(idMov);

                            await cmd.ExecuteNonQueryAsync();

                            row["Retorno"] = msgRetorno.Value?.ToString() ?? "";
                            row["IDMov"] = idMov.Value != DBNull.Value ? (int)idMov.Value : 0;
                        }
                    }
                }               
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao importar notas de serviço: " + ex.Message, ex);
            }

        }
    }
}
