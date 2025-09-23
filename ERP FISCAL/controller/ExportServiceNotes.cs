using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeuProjeto;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;

namespace ERP_FISCAL.controller
{
    public class ExportServiceNotes
    {

        public async Task<DataTable> ListServiceNotesAsync(DateTime valueDate1, DateTime valueDate2)
        {
            DataTable notas = await Task.Run(() =>
            {
                Carregar_Colunas util = new Carregar_Colunas();
                return util.ObterNotas(valueDate1, valueDate2);
            });



            return notas;

        }

        public async void ExportToTotvs(DataTable dtToImport)
        {
            try
            {
                var conexaoBanco = new ConexaoBancoDeDadosTOTVS();

                using (SqlConnection conexao = conexaoBanco.AbrirConexao())
                {
                    foreach (DataRow row in dtToImport.Rows)
                    {
                        using (SqlCommand cmd = new SqlCommand("uspImportaNotaServico", conexao))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Parâmetros de entrada
                            cmd.Parameters.AddWithValue("@INvchCPFCNPJPrestador", row["CNPJ Prestador"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchCPFCNPJTomador", row["CNPJ Tomador"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchNumeroDocumento", row["Documento"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INdatDataEmissao", row["Dt.Hora Emissão"] != DBNull.Value
                                ? Convert.ToDateTime(row["Dt.Hora Emissão"])
                                : DateTime.MinValue);
                            cmd.Parameters.AddWithValue("@INvchDiscriminacaoServico", row["Descriminação"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchCodigoVerificacao", row["Código Verificação"]?.ToString() ?? "");

                            cmd.Parameters.AddWithValue("@INnumValorServico", row["Total Serviços"] != DBNull.Value
                                ? Convert.ToDecimal(row["Total Serviços"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumValorBrutoServico", row["Valor Líquido"] != DBNull.Value
                                ? Convert.ToDecimal(row["Valor Líquido"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumISSBaseCalculo", row["Base Cálculo"] != DBNull.Value
                                ? Convert.ToDecimal(row["Base Cálculo"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumISSValor", row["Valor ISS"] != DBNull.Value
                                ? Convert.ToDecimal(row["Valor ISS"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumPISValor", row["Valor Pis"] != DBNull.Value
                                ? Convert.ToDecimal(row["Valor Pis"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumCOFINSValor", row["Valor Cofins"] != DBNull.Value
                                ? Convert.ToDecimal(row["Valor Cofins"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumCSLLValor", row["Valor Csll"] != DBNull.Value
                                ? Convert.ToDecimal(row["Valor Csll"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumIRRFValor", row["Valor IR"] != DBNull.Value
                                ? Convert.ToDecimal(row["Valor IR"])
                                : 0);
                            cmd.Parameters.AddWithValue("@INnumINSSValor", row["Valor INSS"] != DBNull.Value
                                ? Convert.ToDecimal(row["Valor INSS"])
                                : 0);

                            cmd.Parameters.AddWithValue("@INvchCodProduto", row["Cód. Serviço TOTVS"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INvchCFOP", row["CFOP"]?.ToString() ?? "");
                            cmd.Parameters.AddWithValue("@INdatDataLancamento", row["Data Lançamento"] != DBNull.Value
                                ? Convert.ToDateTime(row["Data Lançamento"])
                                : DateTime.MinValue);

                            // Parâmetros de saída
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

                            // Executa a procedure
                            await cmd.ExecuteNonQueryAsync();

                            row["Retorno"] = msgRetorno.Value?.ToString();
                            row["IDMov"] = idMov.Value != DBNull.Value ? (int)idMov.Value : 0;
                        }
                    }

                    MessageBox.Show(
                        "Importação concluída com sucesso!",
                        "Sucesso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro durante a importação: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public async Task<DataTable> FindUniqueNoteAsync(string noteId)
        {
            try
            {

                DataTable nota = await Task.Run(() =>
                {
                    Carregar_Colunas util = new Carregar_Colunas();
                    return util.FindUniqueNote(noteId);
                });

                return nota;

            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel retornar nota", ex);

            }
        }


        public DataTable ReorganizarDataTable(DataTable original)
        {
           // ordem desejada (já inclui as colunas novas)
           string[] ordemColunas = new string[]{
            "Documento",
            "Código Verificação",
            "Dt.Hora Emissão",
            "Base Cálculo",
            "Aliquota",
            "Valor Líquido",
            "CNPJ Prestador",
            "Razão Social Prestador",
            "UF Prestador",
            "Total Serviços",
            "Valor Pis",
            "Valor Cofins",
            "Valor IR",
            "Valor Csll",
            "Valor INSS",
            "Valor ISS",
            "Item Lista Serviço",
            "Descriminação",
            "CNPJ Tomador",
            "Razão Social Tomador",
            "UF Tomador",
            "CodColigada",
            "NomeColigada",
            "CodFilial",
            "NomeFilial",
            "IDContasPagar",
            "IDMov",
            "Cód. Serviço TOTVS",
            // >>> Colunas novas que você quer incluir <<<
            "Descrição",
            "CFOP",
            "CFOP Descrição",
            "Data Lançamento",
            // <<< ------------------------------- >>>
            "Retorno"
             };

            DataTable novo = new DataTable();

            // cria colunas na ordem certa
            foreach (string nome in ordemColunas)
            {
                if (original.Columns.Contains(nome))
                {
                    novo.Columns.Add(nome, original.Columns[nome].DataType);
                }
                else
                {
                    // adiciona colunas extras como string (ou outro tipo se preferir)
                    novo.Columns.Add(nome, typeof(string));
                }
            }

            // copia linhas
            foreach (DataRow row in original.Rows)
            {
                DataRow novaLinha = novo.NewRow();
                foreach (string nome in ordemColunas)
                {
                    if (original.Columns.Contains(nome))
                    {
                        novaLinha[nome] = row[nome];
                    }
                    else
                    {
                        // aqui você pode calcular/preencher colunas novas
                        if (nome == "Data Lançamento")
                            novaLinha[nome] = DateTime.Now.ToShortDateString(); // exemplo
                        else
                            novaLinha[nome] = ""; // valor inicial vazio
                    }
                }
                novo.Rows.Add(novaLinha);
            }

            return novo;
        }



    }

}
