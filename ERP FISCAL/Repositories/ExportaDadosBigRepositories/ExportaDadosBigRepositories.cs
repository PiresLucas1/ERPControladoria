using ERP_FISCAL.controller;
using SeuProjeto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Repositories.ExportaDadosBigRepositories
{
    internal class ExportaDadosBigRepositories
    {
        public async Task<DataTable> BuscaNotasDoBigNaoEncontradoNaTotvs(DateTime dataInicio, DateTime dataFim, int filial, char conferida)
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosDfe conexaoBanco = new ConexaoBancoDeDadosDfe();

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspConsultaNotasBigNaoEncontradasTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //SqlParameter p;
                        cmd.Parameters.AddWithValue("@INdatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataFim", dataFim);
                        if(filial == 0)
                        {
                           cmd.Parameters.AddWithValue("@INintFilial", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@INintFilial", filial);
                        }
                        cmd.Parameters.AddWithValue("@INchaNaoConferida", conferida);
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

        public async Task<RetornoExportaBigRepository> ImportaNotaBigParaTotvs(string notas, DateTime dataInicio, DateTime dataFim, int substituir, int conferida, int filial)
        {
            ConexaoBancoDeDadosGestaoProcessos  conexaoBanco = new ConexaoBancoDeDadosGestaoProcessos();
            DataTable tabelaRetorno = new DataTable();
            RetornoExportaBigRepository retornoExportaBigRepository = new RetornoExportaBigRepository();
            string retornoMensagem = "";
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexaoRm())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.upsIntegracaoTotvsExportaNotaFiscalSat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 1600;
                        //SqlParameter p;
                        cmd.Parameters.AddWithValue("@INdatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataFim", dataFim);                    
                        cmd.Parameters.AddWithValue("@INintFilial", filial);                        
                        cmd.Parameters.AddWithValue("@INbitSubstituir", substituir);
                        cmd.Parameters.AddWithValue("@INbitNaoConferida", conferida);
                        cmd.Parameters.AddWithValue("@INvchNumeroDocumentos", notas);

                        var msgRetorno = new SqlParameter("@OUTvchMsgRetorno", SqlDbType.VarChar, 1000)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(msgRetorno);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            tabelaRetorno.Load(reader);
                        }

                        retornoMensagem = msgRetorno.Value?.ToString();
                    }
                    string retorno = tabelaRetorno.Rows[0].ToString() ?? "Nada Encontrado";
                    conexaoBanco.FecharConexao(conn);
                    retornoExportaBigRepository.MensagemRetorno = retornoMensagem;
                    retornoExportaBigRepository.DtRetorno = tabelaRetorno;
                    return retornoExportaBigRepository;
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
        }
    }
    
}
