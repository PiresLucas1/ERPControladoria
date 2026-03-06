using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Contabil
{
    public class AdicionarLancamentoParametrizado
    {
        public class LancamentoParametrizado
        {
            public int IDContaContabilDebito { get; set; }
            public int IDContaContabilCredito { get; set; }
            public int IDHistorico { get; set; }
            public int IDComplemento { get; set; }
            public string DescricaoExtrato { get; set; }
            public int Filial { get; set; }
            public int CodColigada { get; set; }
        }
        public async Task<DataTable> Execute(LancamentoParametrizado novoLancamento)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspContabilConferenciaRecebimentosCadastraLancamento", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@INidContaDebito",novoLancamento.IDContaContabilDebito );
                        cmd.Parameters.AddWithValue("@INidContaCredito", novoLancamento.IDContaContabilDebito);
                        cmd.Parameters.AddWithValue("@INidHistorico", novoLancamento.IDHistorico);
                        cmd.Parameters.AddWithValue("@INidComplemento", novoLancamento.IDComplemento);
                        cmd.Parameters.AddWithValue("@INvchDescricaoExtrato",novoLancamento.DescricaoExtrato);
                        cmd.Parameters.AddWithValue("@INintFilial", novoLancamento.Filial);
                        cmd.Parameters.AddWithValue("@INinCodColigada",novoLancamento.CodColigada);


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
