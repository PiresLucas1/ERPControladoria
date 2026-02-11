using ERP_FISCAL;
using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.ConsultaMovDataPagamentoSTxDataEntrada
{
    public class ConsultaMovDataPagamentoSTxDataEntrada
    {
        public async Task<DataTable> Consultar(int codColigada, DateTime dtInicio, DateTime dtFim)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("ConfereDataPagametoSTComDataENtradaFiscal", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INintCODCOLIGADA", codColigada);
                        cmd.Parameters.AddWithValue("@INdatDataInicio", dtInicio);
                        cmd.Parameters.AddWithValue("@INdatDataFim", dtFim);

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
    }
}
