using ERP_FISCAL;
using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.ConsultaListaIDMovTotvs
{
    public class ConsultaListaIDMovTotvs
    {
        public async Task<DataTable> Consulta(string codMovimento)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisConsultaListaIDMov", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // SqlParameter p;   
                        cmd.Parameters.AddWithValue("@vchIDMov", codMovimento);
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
