using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;

namespace SolfarmaGp.Repositorios.Contabil.Parametrizacao
{
    public class ConsultaLancamentoContabilParametrizadoDados
    {
        public class DtoObjetoPesquisaDados
        {
            public int CodColigada { get; set; }
            public int filial { get; set; }
            public int banco { get; set; }
            public int reduzidoCredito { get; set; }
            public int reduzidoDebito { get; set; }

        }
        public async Task<DataTable> Execute(DtoObjetoPesquisaDados objeto)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpWithLoginTotvs);
            try
            {

                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    using (SqlCommand cmd = new SqlCommand("uspContabilConferenciaRecebimentosLancamentosParametrizadosDados", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //reduzidoDebito
                        if(objeto.reduzidoDebito == 0)
                            cmd.Parameters.AddWithValue("@INchCodigoContaDebito", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@INchCodigoContaDebito", objeto.reduzidoDebito);
                        //ReduzidoCredito
                        if(objeto.reduzidoCredito == 0)
                            cmd.Parameters.AddWithValue("@INchCodigoContaCredito", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@INchCodigoContaCredito", objeto.reduzidoCredito);                       
                        cmd.Parameters.AddWithValue("@INchCodigoHistorico", DBNull.Value);
                        cmd.Parameters.AddWithValue("@INvchDescricaoComplemento", DBNull.Value);
                        cmd.Parameters.AddWithValue("@INvchDescricaoExtrato", DBNull.Value);
                        //FILIAL
                        if(objeto.filial == 0)
                            cmd.Parameters.AddWithValue("@INintFilial", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@INintFilial", objeto.filial);
                        //CodColigada
                        if (objeto.CodColigada == 0)                        
                            cmd.Parameters.AddWithValue("@INintCodColigada", DBNull.Value);                        
                        else                        
                            cmd.Parameters.AddWithValue("@INintCodColigada", objeto.CodColigada);
                        //CodigoBanco
                        if(objeto.banco ==0)
                            cmd.Parameters.AddWithValue("@INIntCodigoBanco", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@INIntCodigoBanco", objeto.banco);


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
