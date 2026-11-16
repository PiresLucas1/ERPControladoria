using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolfarmaGp.Repositorios.Fiscal.BaseCheia
{
    public class AlteracaoBaseCheia
    {
        public async Task<bool> Execute(DateTime dataInicio, DateTime dataFim)
        {
            DataTable dtRetorno = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspFisArrumaBaseCheiaTotvs", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INdtDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INdtDataFim", dataFim);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            dtRetorno.Load(reader);
                        }
                    }
                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }
            return true;
        }
    }
}
