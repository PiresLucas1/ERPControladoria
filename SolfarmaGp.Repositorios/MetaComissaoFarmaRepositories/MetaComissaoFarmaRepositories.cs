using Microsoft.Data.SqlClient;
using SolfarmaGp.Infraestrutura;
using System.Data;
using static SolfarmaGp.Repositorios.MetaComissaoFarmaRepositories.IMetaComissaoObjetoPesquisa;

namespace ERP_FISCAL.Repositories.MetaComissaoFarmaRepositories
{
    public class MetaComissaoFarmaRepositories
    {
        public async Task<DataTable> ConsultaComissaoMetasFarma(ObjetoPesquisa obj)
        {
            DataTable tabela = new DataTable();
            DbConexaoConfig conexaoBanco = new DbConexaoConfig(DbName.GpDbsol);

            try
            {
                using (SqlConnection conn = conexaoBanco.AbrirConexao())
                {
                    await conn.OpenAsync();

                    using (SqlCommand cmd = new SqlCommand(
                        "dbo.uspUsuConsultarProjecaoMetaVendasPorSetorPorEmpresaFoco",
                        conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // ===============================
                        // PARÂMETROS
                        // ===============================

                        cmd.Parameters.Add("@INdatDatabase", SqlDbType.DateTime)
                            .Value = obj.INdatDatabase ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaTotal", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaTotal ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaHPC", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaHPC ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaGenerico", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaGenerico ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaNestle", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaNestle ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaLoreal", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaLoreal ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaEtico", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaEtico ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaEmpresaFoco1", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaEmpresaFoco1 ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaEmpresaFoco2", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaEmpresaFoco2 ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaEmpresaFoco3", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaEmpresaFoco3 ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaEmpresaFoco4", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaEmpresaFoco4 ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INnumMetaReceitaLiquidaEmpresaFoco5", SqlDbType.Decimal)
                            .Value = obj.INnumMetaReceitaLiquidaEmpresaFoco5 ?? (object)DBNull.Value;
;

                        cmd.Parameters.Add("@INintNroMeses", SqlDbType.Int)
                            .Value = obj.INintNroMeses ?? (object)DBNull.Value;

                        cmd.Parameters.Add("@INvchIDSetorDesconsiderar", SqlDbType.VarChar, 500)
                            .Value = (object?)obj.INvchIDSetorDesconsiderar ?? DBNull.Value;

                        cmd.Parameters.Add("@INvchIDPessoaSupervisoresRateio", SqlDbType.VarChar, 500)
                            .Value = (object?)obj.INvchIDPessoaSupervisoresRateio ?? DBNull.Value;

                        cmd.Parameters.Add("@INvchPercentualRateioSupervisores", SqlDbType.VarChar, 500)
                            .Value = (object?)obj.INvchPercentualRateioSupervisores ?? DBNull.Value;

                        cmd.Parameters.Add("@INvchPercentualRateioSupervisoresHPC", SqlDbType.VarChar, 500)
                            .Value = (object?)obj.INvchPercentualRateioSupervisoresHPC ?? DBNull.Value;

                        cmd.Parameters.Add("@INvchPercentualRateioSupervisoresGenerico", SqlDbType.VarChar, 500)
                            .Value = (object?)obj.INvchPercentualRateioSupervisoresGenerico ?? DBNull.Value;

                        cmd.Parameters.Add("@INvchPercentualRateioSupervisoresNestle", SqlDbType.VarChar, 500)
                            .Value = (object?)obj.INvchPercentualRateioSupervisoresNestle ?? DBNull.Value;

                        cmd.Parameters.Add("@INvchPercentualRateioSupervisoresLoreal", SqlDbType.VarChar, 500)
                            .Value = (object?)obj.INvchPercentualRateioSupervisoresLoreal ?? DBNull.Value;

                        cmd.Parameters.Add("@INvchPercentualRateioSupervisoresEtico", SqlDbType.VarChar, 500)
                            .Value = (object?)obj.INvchPercentualRateioSupervisoresEtico ?? DBNull.Value;

                        cmd.Parameters.Add("@INvchIDFabricantesIndustriasGolden", SqlDbType.VarChar, 500)
                            .Value = (object?)obj.INvchIDFabricantesIndustriasGolden ?? DBNull.Value;

                        cmd.Parameters.Add("@INvchIDProdutoLinhaIndustriasGolden", SqlDbType.VarChar, 500)
                            .Value = (object?)obj.INvchIDProdutoLinhaIndustriasGolden ?? DBNull.Value;

                        // ===============================
                        // EXECUÇÃO
                        // ===============================

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            tabela.Load(reader);
                        }
                    }
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
