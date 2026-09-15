using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Contabil.Tiktok
{
    public class BuscaParametrizacaoContabilTiktok
    {
        public class DtoObjetoPesquisaTiktok
        {
            public int CodColigada { get; set; }
            public int Filial { get; set; }
            public int IDBanco { get; set; }
        }

        public async Task<DataTable> Execute(DtoObjetoPesquisaTiktok objeto)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    string query = @"
                        SELECT
                            tblConConfRecConConDeb.CodigoReduzido  [CodContaDebito],
                            tblConConfRecConConCre.CodigoReduzido  [CodContaCredito],
                            tblConConfRecHis.CodigoHistorico       [CodHistorico],
                            tblConConReCom.IDComplemento           [IDComplemento],
                            tblConConReCom.descricaoComplemento    [Complemento],
                            tblConfRecLanPar.filial                [Filial],
                            tblConfRecLanPar.CodColigada           [CodColigada],
                            tblConConfRecConConCre.PlanoContas     [ContaCompletaCredito],
                            tblConConfRecConConDeb.PlanoContas     [ContaCompletaDebito],
                            tblConfRecLanPar.IDBanco               [CodBanco],
                            tblConfRecLanPar.Sinal                 [Sinal]
                        FROM
                            tblContabilConferenciaRecebimentosLancamentosParametrizados tblConfRecLanPar (NOLOCK)
                        LEFT JOIN
                            tblContabilConferenciaRecebimentosComplemento tblConConReCom (NOLOCK) ON tblConConReCom.IDComplemento = tblConfRecLanPar.IDComplemento
                        LEFT JOIN
                            tblContabilConferenciaRecebimentosHistorico tblConConfRecHis (NOLOCK) ON tblConConfRecHis.IDHistorico = tblConfRecLanPar.IDHistorico
                        LEFT JOIN
                            tblContabilConferenciaRecebimentosContaContabil tblConConfRecConConCre (NOLOCK) ON tblConConfRecConConCre.IDContaContabil = tblConfRecLanPar.IDContaContabilCredito
                        LEFT JOIN
                            tblContabilConferenciaRecebimentosContaContabil tblConConfRecConConDeb (NOLOCK) ON tblConConfRecConConDeb.IDContaContabil = tblConfRecLanPar.IDContaContabilDebito
                        WHERE
                            tblConfRecLanPar.IDBanco = @IDBanco
                            AND tblConfRecLanPar.CodColigada = @CodColigada
                            AND tblConfRecLanPar.filial = @Filial
                     ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@IDBanco", objeto.IDBanco);
                        cmd.Parameters.AddWithValue("@CodColigada", objeto.CodColigada);
                        cmd.Parameters.AddWithValue("@Filial", objeto.Filial);

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
