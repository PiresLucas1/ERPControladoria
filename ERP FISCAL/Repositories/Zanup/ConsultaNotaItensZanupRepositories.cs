using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Repositories.ConsultaSaldoNotasZanup
{
    public class ConsultaNotaItensZanupRepositories
    {
        public async Task<DataTable> ConsultaNotaItens(DateTime dataInicio, DateTime dataFim,string cnpjCpf ,string idProduto = null)
        {
            //uspZanConsultaNotaItens
            DataTable dataTable = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using(SqlCommand cmd = new SqlCommand("dbo.uspZanConsultaNotaItens", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@INdatDataEmissaoInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdatDataEmissaoFim", dataFim);
                        cmd.Parameters.AddWithValue("@INvchCnpjCpf", cnpjCpf);
                        if(idProduto != null)
                        {
                            cmd.Parameters.AddWithValue("@INintIdProduto", idProduto);
                        }
                        
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dataTable.Load(reader);
                        }
                    }

                    conexaoBanco.FecharConexao(conn);
                }                
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return dataTable;

        }

        public void CriaNotasItensZanup()
        {

        }
        public async Task<DataTable> BuscaInformacoesCnpjZanup(string cnpj)
        {
            DataTable dataTable = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspConsultaDestinatarioInformacoesZanup", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@INvchCNPJ", cnpj);                       
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dataTable.Load(reader);
                        }
                    }

                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return dataTable;
        }
    }
}
