using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Zanup.ExportaNotasFiscais
{
    /// <summary>
    /// Busca, no banco Zanup, os dados do XML (emitente, destinatário e itens) das notas que deram erro,
    /// para mostrar ao usuário o que precisa ser cadastrado. Somente leitura.
    /// </summary>
    public class ConsultaDadosNotasZanup
    {
        private const int TamanhoLote = 500;

        public async Task<DataTable> ExecutarAsync(IEnumerable<string> chavesAcesso)
        {
            var resultado = new DataTable();
            var chaves = chavesAcesso.Where(c => !string.IsNullOrWhiteSpace(c)).Distinct().ToList();
            if (chaves.Count == 0)
                return resultado;

            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.ZanupTotvs);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    // Em lotes e parametrizado: o IN não passa de 500 itens e nada é concatenado no SQL.
                    foreach (var lote in chaves.Chunk(TamanhoLote))
                    {
                        string parametros = string.Join(",", lote.Select((_, i) => $"@c{i}"));
                        string sql = $@"
SELECT
    tblArq.ChaveAcesso,
    tblArq.CNPJEmitente,
    tblArq.NomeEmitente,
    tblArq.CPFDestinatario,
    tblArq.CNPJDestinatario,
    tblArq.NomeDestinatario,
    tblArq.UFEnderecoDestinatario,
    tblArqIte.CodigoProduto,
    tblArqIte.DescricaoProduto,
    tblArqIte.CFOP,
    tblArqIte.QuantidadeTributavel,
    tblArqIte.ValorTotalProduto
FROM
    tblArquivoXMLInformacoes tblArq (NOLOCK)
LEFT JOIN
    tblArquivoXMLInformacoesItens tblArqIte (NOLOCK) ON tblArqIte.IDArquivoXML = tblArq.IDArquivoXML
WHERE
    tblArq.ChaveAcesso IN ({parametros})";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandTimeout = 120;
                            for (int i = 0; i < lote.Length; i++)
                                cmd.Parameters.AddWithValue($"@c{i}", lote[i]);

                            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                            {
                                resultado.Load(reader); // acumula os lotes na mesma tabela
                            }
                        }
                    }
                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (SqlException ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return resultado;
        }
    }
}
