using ERP_FISCAL;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Repositories.Fiscal.AlteraDataDocumentoMovimentoTotvs
{
    public class AlteraDataDocumentoMovimentoTotvsRepositories
    {
        public async Task<DataTable> ConsultaMovimentoTotvs(int codColigada,DateTime dtInicio, DateTime dtFim)
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
        public async Task<DataTable> AlteraDataDocumentoTotvs(DataTable dtIdMovs)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspFisAlteraDataDocumentoTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        var param = cmd.Parameters.AddWithValue("@tblIDMovsNovaData", dtIdMovs);
                        param.SqlDbType = SqlDbType.Structured;
                        param.TypeName = "dbo.IDMovimentoParaTrocarData";

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
