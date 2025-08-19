using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using SeuProjeto;

namespace ERP_FISCAL.repositories
{
   internal class CarregarCFOPRepositories
    {
        public DataTable CarregarCFOPs()
        {
            DataTable tabela = new DataTable();
            ConexaoBancoDeDadosDfe conexaoBanco = new ConexaoBancoDeDadosDfe();

            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspConsultaNaturezaFiscal", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 1200;

                        SqlParameter p = new SqlParameter("@INvchIDNatureza", SqlDbType.NVarChar);
                        p.Value = DBNull.Value;
                        cmd.Parameters.Add(p);
                        //cmd.CommandType = CommandType.Text;
                        //cmd.CommandText = "SELECT DB_NAME() AS DatabaseName, SUSER_SNAME() AS UserName";
                        //cmd.ExecuteReader();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(tabela);
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
