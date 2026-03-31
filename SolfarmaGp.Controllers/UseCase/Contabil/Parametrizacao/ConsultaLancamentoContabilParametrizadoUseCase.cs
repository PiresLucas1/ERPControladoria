using SolfarmaGp.Repositorios.Contabil.Parametrizacao;
using System.Data;
using static SolfarmaGp.Repositorios.Contabil.Parametrizacao.ConsultaLancamentoContabilParametrizado;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao
{
    public class ConsultaLancamentoContabilParametrizadoUseCase
    {
        public class ObjetoPesquisaParametrosContabil
        {
            public int CodColigada { get; set; }
            public int filial { get; set; }
            public int banco { get; set; }
            public int reduzidoCredito { get; set; }
            public int reduzidoDebito { get; set; }

        }
        public async Task<DataTable> Execute(ObjetoPesquisaParametrosContabil objeto)
        {
            
            ConsultaLancamentoContabilParametrizado repositorio = new ConsultaLancamentoContabilParametrizado();

            DtoObjetoPesquisa dto = new DtoObjetoPesquisa
            {
                reduzidoDebito = objeto.reduzidoDebito,
                reduzidoCredito = objeto.reduzidoCredito,
                banco = objeto.banco,
                CodColigada = objeto.CodColigada,
                filial = objeto.filial
            };
            DataTable resultado = await repositorio.Execute(dto);
            DataTable novo = resultado.Clone();

            novo.Columns.Remove("CodContaDebito");
            novo.Columns.Add("CodContaDebito", typeof(int));
            novo.Columns.Remove("CodContaCredito");
            novo.Columns.Add("CodContaCredito", typeof(int));

            novo.Columns["Filial"].DataType = typeof(int);
            novo.Columns["CodColigada"].DataType = typeof(int);

            foreach (DataRow row in resultado.Rows)
            {
                DataRow novaRow = novo.NewRow();

                novaRow["CodContaDebito"] = Convert.ToInt32(row["CodContaDebito"].ToString().Trim());
                novaRow["CodContaCredito"] = Convert.ToInt32(row["CodContaCredito"].ToString().Trim());
                novaRow["CodHistorico"] = (row["CodHistorico"]).ToString().Trim();
                novaRow["Complemento"] = (row["Complemento"]).ToString().Trim();
                novaRow["DescricAoExtrato"] = (row["DescricaoExtrato"]).ToString().Trim();
                novaRow["Filial"] = Convert.ToInt32(row["Filial"]);
                novaRow["CodColigada"] = Convert.ToInt32(row["CodColigada"]);
                novaRow["ContaCompletaDebito"] = row["ContaCompletaDebito"].ToString().Trim();
                novaRow["ContaCompletaCredito"] = row["ContaCompletaCredito"].ToString().Trim();
                novaRow["CodBanco"] = row["CodBanco"] == DBNull.Value ? row["CodBanco"] :  Convert.ToInt32(row["CodBanco"]);

                novo.Rows.Add(novaRow);
            }

            return novo;            
        }
    }
}
