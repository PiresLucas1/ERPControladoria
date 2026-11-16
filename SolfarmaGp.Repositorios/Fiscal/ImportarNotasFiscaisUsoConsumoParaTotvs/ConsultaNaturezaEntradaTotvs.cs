using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    public class ConsultaNaturezaEntradaTotvs
    {
        // @INTipoConsulta = 2 -> consulta para uso e consumo (todas as naturezas de entrada, sem o filtro 933)
        private const int TipoConsultaUsoEConsumo = 2;

        // Sem código e sem descrição lista todas as naturezas de entrada da coligada
        public async Task<DataTable> Executar(int codColigada, string codNat, string descricao)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspFisConsultaNaturezaFiscal", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@INCodColigada", SqlDbType.Int).Value = codColigada;
                        cmd.Parameters.Add("@INTipoConsulta", SqlDbType.Int).Value = TipoConsultaUsoEConsumo;
                        cmd.Parameters.Add("@INvchIDNatureza", SqlDbType.VarChar, 20).Value =
                            !string.IsNullOrWhiteSpace(codNat) ? (object)codNat.Trim() : DBNull.Value;
                        cmd.Parameters.Add("@INvchDescricaoNatureza", SqlDbType.VarChar, 50).Value =
                            !string.IsNullOrWhiteSpace(descricao) ? (object)descricao.Trim() : DBNull.Value;

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
