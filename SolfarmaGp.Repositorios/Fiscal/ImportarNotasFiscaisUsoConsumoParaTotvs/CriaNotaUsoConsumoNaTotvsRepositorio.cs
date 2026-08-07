using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Fiscal.ImportarNotasFiscaisUsoConsumoParaTotvs
{
    public class CriaNotaUsoConsumoNaTotvsRepositorio
    {
        public class NotaCapa
        {
            // Já existentes
            public string IDQiveArquivoXml { get; set; }
            public string ChaveAcesso { get; set; }
            public string CnpjFornecedor { get; set; }
            public string IDErpContasPagar { get; set; }
            public string NumDocumento { get; set; }

            // Adicionados para cobrir todos os parâmetros da procedure
            public int? CodColigada { get; set; }
            public int? CodFilial { get; set; }
            public string CodCCFO { get; set; }
            public string SerieDocumento { get; set; }
            public string CodTipoMovimento { get; set; }
            public DateTime? DataEmissao { get; set; }
            public DateTime? DataLancamento { get; set; }
            public string CodMunServico { get; set; }
            public string CodEtdMunServ { get; set; }
            public int? IdNatMov { get; set; }
            public string CodTdo { get; set; } // default 'NF-e' na procedure
        }

        public async Task<(DataTable Resultado, int IdMov)> Executar(NotaCapa nota, DataTable itens)
        {
            DataTable dataTable = new DataTable();
            int idMovGerado = 0;

            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("dbo.uspUsuNotaUsoConsumoInclusaoGP", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@intCodColigada", SqlDbType.Int).Value =
                            nota.CodColigada.HasValue ? (object)nota.CodColigada.Value : DBNull.Value;

                        cmd.Parameters.Add("@intCodFilial", SqlDbType.Int).Value =
                            nota.CodFilial.HasValue ? (object)nota.CodFilial.Value : DBNull.Value;

                        cmd.Parameters.Add("@vchCodCCFO", SqlDbType.VarChar, 20).Value =
                            !string.IsNullOrEmpty(nota.CodCCFO) ? (object)nota.CodCCFO : DBNull.Value;

                        cmd.Parameters.Add("@vchSerieDocumento", SqlDbType.VarChar, 5).Value =
                            !string.IsNullOrEmpty(nota.SerieDocumento) ? (object)nota.SerieDocumento : DBNull.Value;

                        cmd.Parameters.Add("@vchCodTipoMovimento", SqlDbType.VarChar, 3).Value =
                            !string.IsNullOrEmpty(nota.CodTipoMovimento) ? (object)nota.CodTipoMovimento : DBNull.Value;

                        cmd.Parameters.Add("@INvchNumeroDocumento", SqlDbType.VarChar, 20).Value =
                            !string.IsNullOrEmpty(nota.NumDocumento) ? (object)nota.NumDocumento : DBNull.Value;

                        cmd.Parameters.Add("@INvchChaveAcesso", SqlDbType.VarChar, 250).Value =
                            !string.IsNullOrEmpty(nota.ChaveAcesso) ? (object)nota.ChaveAcesso : DBNull.Value;

                        cmd.Parameters.Add("@INdatDataEmissao", SqlDbType.DateTime).Value =
                            nota.DataEmissao.HasValue ? (object)nota.DataEmissao.Value : DBNull.Value;

                        cmd.Parameters.Add("@INdatDataLancamento", SqlDbType.DateTime).Value =
                            nota.DataLancamento.HasValue ? (object)nota.DataLancamento.Value : DBNull.Value;

                        cmd.Parameters.Add("@vchCODMUNSERVICO", SqlDbType.VarChar, 10).Value =
                            !string.IsNullOrEmpty(nota.CodMunServico) ? (object)nota.CodMunServico : DBNull.Value;

                        cmd.Parameters.Add("@vchCODETDMUNSERV", SqlDbType.VarChar, 2).Value =
                            !string.IsNullOrEmpty(nota.CodEtdMunServ) ? (object)nota.CodEtdMunServ : DBNull.Value;

                        cmd.Parameters.Add("@inIDNatMov", SqlDbType.Int).Value =
                            nota.IdNatMov.HasValue ? (object)nota.IdNatMov.Value : DBNull.Value;

                        // Tem default 'NF-e' na procedure, então só manda se tiver valor
                        cmd.Parameters.Add("@vchCODTDO", SqlDbType.VarChar, 10).Value =
                            !string.IsNullOrEmpty(nota.CodTdo) ? (object)nota.CodTdo : DBNull.Value;

                        // Parâmetro TVP (table-valued)
                        var tvpParam = cmd.Parameters.Add("@tvpItens", SqlDbType.Structured);
                        tvpParam.TypeName = "dbo.TVPItensNotaUsoConsumo";
                        tvpParam.Value = itens;

                        // Parâmetro OUTPUT
                        var outputParam = cmd.Parameters.Add("@OUTintIDMOV", SqlDbType.Int);
                        outputParam.Direction = ParameterDirection.Output;

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            DataTable tabela1 = new DataTable();
                            tabela1.Load(reader);
                            dataTable = tabela1;
                        }

                        idMovGerado = outputParam.Value != DBNull.Value ? (int)outputParam.Value : 0;
                    }
                    conexaoBanco.FecharConexao(conn);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("ERRO INTERNO: " + ex.Message, ex);
            }

            return (dataTable, idMovGerado);
        }
    }
}
