using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;
using System.Diagnostics;

namespace SolfarmaGp.Repositorios.Fiscal.EntradasComFiltro
{
    public class BuscaEntradasComFiltro
    {
        public async Task<DataTable> ExecutarAsync(DateTime dataInicio, DateTime dataFim,int Coligada,int Filial,string EntradaSaida)
        {
            DataTable dt = new DataTable();

            DbConexaoConfig conexao =
                new DbConexaoConfig(DbName.Totvs);

            try
            {
                using (SqlConnection conn = conexao.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspUsuConsultaNotasEntradaComFiltro",conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 0;

                        cmd.Parameters.Add( "@INdatDataInicial",SqlDbType.DateTime).Value = dataInicio;

                        cmd.Parameters.Add("@INdatDataFinal",SqlDbType.DateTime).Value = dataFim;

                        cmd.Parameters.Add("@INintCodColigada",SqlDbType.Int).Value = Coligada;

                        cmd.Parameters.Add("@INintCodFilial",SqlDbType.Int).Value = Filial;

                        cmd.Parameters.Add("@INVCharEntradaSaida", SqlDbType.VarChar).Value = EntradaSaida;

                        //Debug.WriteLine("========== PROCEDURE ==========");
                        //Debug.WriteLine(
                        //    $"@INdatDataInicial = {cmd.Parameters["@INdatDataInicial"].Value}"
                        //);
                        //Debug.WriteLine(
                        //    $"@INdatDataFinal = {cmd.Parameters["@INdatDataFinal"].Value}"
                        //);
                        //Debug.WriteLine(
                        //    $"@INintCodColigada = {cmd.Parameters["@INintCodColigada"].Value}"
                        //);
                        //Debug.WriteLine(
                        //    $"@INintCodFilial = {cmd.Parameters["@INintCodFilial"].Value}"
                        //);
                        //Debug.WriteLine(
                        //    $"Tipo Data Inicial = {cmd.Parameters["@INdatDataInicial"].SqlDbType}"
                        //);
                        //Debug.WriteLine(
                        //    $"Tipo Data Final = {cmd.Parameters["@INdatDataFinal"].SqlDbType}"
                        //);
                        //Debug.WriteLine("===============================");

                        using (SqlDataReader reader =
                            await cmd.ExecuteReaderAsync())
                        {
                            dt.Load(reader);
                        }
                    }

                    conexao.FecharConexao(conn);
                }
            }
            catch (SqlException ex)
            {
                throw new ArgumentException(
                    "ERRO INTERNO: " + ex.Message,
                    ex);
            }

            return dt;
        }
    }
}