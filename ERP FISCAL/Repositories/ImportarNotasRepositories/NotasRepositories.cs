using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ERP_FISCAL
{
    internal class Carregar_Colunas
    {

        public DataTable ObterNotas(DateTime dataInicio, DateTime dataFim, int codColigada, int bitExisteErp)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);            

            try
            {

                using (SqlConnection conexao = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.(\r\n    @INintTipoReembolso IN (1,2)\r\n    AND tblConVen.DataFaturamento \r\n        BETWEEN @INintDataFaturamentoInicio AND @INintDataFaturamentoFim\r\n)\r\nOR\r\n(\r\n    @INintTipoReembolso NOT IN (1,2)\r\n    AND tblConVen.Data \r\n        BETWEEN @INintDataFaturamentoInicio AND @INintDataFaturamentoFim\r\n)", conexao))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 1200; /* 20 minutos */
                        cmd.Parameters.AddWithValue("@INDatDataInicio", dataInicio);
                        cmd.Parameters.AddWithValue("@INDatDataFim", dataFim);
                        cmd.Parameters.AddWithValue("@INCodColigada", codColigada);
                        cmd.Parameters.AddWithValue("@INTBitConstaNoErp", bitExisteErp);


                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(tabela);
                    }

                    conexaoBanco.FecharConexao(conexao);
                }
            }
            catch (Exception e )
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
                MessageBox.Show(e.Message);
                throw new ArgumentException("Falha ao executar a operação", e);
                
            }

            return tabela;
        }

        public DataTable FindUniqueNote(string noteId)
        {
            DataTable table = new DataTable();
            DbConexaoConfig connectionDataBase = new DbConexaoConfig(DbName.DfeTotvs);  

            using (SqlConnection conn = connectionDataBase.AbrirConexao())
            {
                using (SqlCommand cmd = new SqlCommand("uspQiveProcuraNotaIndividual", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@INvchrChaveDeAcesso", noteId);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }

                connectionDataBase.FecharConexao(conn);
            }
            return table;
        }
    }
}
