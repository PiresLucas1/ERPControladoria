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

                            // IBS / CBS (reforma tributária) - valores já lidos da grade.
                            // A uspImportaNotaServico ainda não tem esses parâmetros: quando criar, descomente
                            // as linhas abaixo e ajuste o nome de cada parâmetro (@...) para o da procedure.
                            string cstIbsCbs = row["CST IBS/CBS"]?.ToString() ?? "";
                            string cClassTribIbsCbs = row["cClassTrib IBS/CBS"]?.ToString() ?? "";
                            decimal baseIbsCbs = ValorDecimal(row, "Base Cálculo IBS/CBS");
                            decimal aliquotaIbsUF = ValorDecimal(row, "Alíq. IBS UF");
                            decimal valorIbsUF = ValorDecimal(row, "Valor IBS UF");
                            decimal aliquotaIbsMun = ValorDecimal(row, "Alíq. IBS Mun");
                            decimal valorIbsMun = ValorDecimal(row, "Valor IBS Mun");
                            decimal valorIbs = ValorDecimal(row, "Valor IBS");
                            decimal aliquotaCbs = ValorDecimal(row, "Alíq. CBS");
                            decimal valorCbs = ValorDecimal(row, "Valor CBS");

                            cmd.Parameters.Add("@INvchCSTIBSCBS", SqlDbType.VarChar, 3).Value = cstIbsCbs;
                            cmd.Parameters.Add("@INvchcClassTribIBSCBS", SqlDbType.VarChar, 6).Value = cClassTribIbsCbs;
                            cmd.Parameters.Add("@INnumIBSCBSBaseCalculo", SqlDbType.Decimal).Value = baseIbsCbs;
                            cmd.Parameters.Add("@INnumIBSUFAliquota", SqlDbType.Decimal).Value = aliquotaIbsUF;
                            cmd.Parameters.Add("@INnumIBSUFValor", SqlDbType.Decimal).Value = valorIbsUF;
                            cmd.Parameters.Add("@INnumIBSMunAliquota", SqlDbType.Decimal).Value = aliquotaIbsMun;
                            cmd.Parameters.Add("@INnumIBSMunValor", SqlDbType.Decimal).Value = valorIbsMun;
                            cmd.Parameters.Add("@INnumIBSValor", SqlDbType.Decimal).Value = valorIbs;
                            cmd.Parameters.Add("@INnumCBSAliquota", SqlDbType.Decimal).Value = aliquotaCbs;
                            cmd.Parameters.Add("@INnumCBSValor", SqlDbType.Decimal).Value = valorCbs;

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

        // Coluna ausente ou vazia vale zero (notas no layout ABRASF não têm IBS/CBS)
        private static decimal ValorDecimal(DataRow row, string coluna)
        {
            if (!row.Table.Columns.Contains(coluna) || row[coluna] == DBNull.Value || string.IsNullOrWhiteSpace(row[coluna].ToString()))
                return 0m;

            return DecimalParse.ParseDecimal(row[coluna]);
        }
    }
}
