using SolfarmaGp.Repositorios.Contabil.Parametrizacao;
using System.Data;
using static SolfarmaGp.Repositorios.Contabil.Parametrizacao.ConsultaLancamentoContabilParametrizadoDados;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao.Dados
{
    public class ConsultaLancamentoContabilParametrizadoDadosUseCase
    {
        public class ObjetoPesquisaParametrosContabilDados
        {
            public int CodColigada { get; set; }
            public int filial { get; set; }
            public int banco { get; set; }
            public int reduzidoCredito { get; set; }
            public int reduzidoDebito { get; set; }

        }
        public async Task<DataTable> Execute(ObjetoPesquisaParametrosContabilDados objeto)
        {

            ConsultaLancamentoContabilParametrizadoDados repositorio = new ConsultaLancamentoContabilParametrizadoDados();

            DtoObjetoPesquisaDados dto = new DtoObjetoPesquisaDados
            {
                reduzidoDebito = objeto.reduzidoDebito,
                reduzidoCredito = objeto.reduzidoCredito,
                banco = objeto.banco,
                CodColigada = objeto.CodColigada,
                filial = objeto.filial
            };
            DataTable resultado = await repositorio.Execute(dto);
            DataTable novo = resultado.Clone();

            novo.Columns["CodContaDebito"].DataType = typeof(int);
            novo.Columns["CodContaCredito"].DataType = typeof(int);
            novo.Columns["CodHistorico"].DataType = typeof(int);
            novo.Columns["Complemento"].DataType = typeof(int);
            novo.Columns["Filial"].DataType = typeof(int);
            novo.Columns["CodColigada"].DataType = typeof(int);

            foreach (DataRow row in resultado.Rows)
            {
                DataRow novaRow = novo.NewRow();

                novaRow["CodContaDebito"] = Convert.ToInt32(row["CodContaDebito"]);
                novaRow["CodContaCredito"] = Convert.ToInt32(row["CodContaCredito"]);
                novaRow["CodHistorico"] = Convert.ToInt32(row["CodHistorico"]);
                novaRow["Complemento"] = Convert.ToInt32(row["Complemento"]);
                novaRow["DescricaoExtrato"] = (row["DescricaoExtrato"]);
                novaRow["CodBanco"] = row["CodBanco"] == DBNull.Value ? row["CodBanco"] : Convert.ToInt32(row["CodBanco"]);
                novaRow["Filial"] = Convert.ToInt32(row["Filial"]);
                novaRow["CodColigada"] = Convert.ToInt32(row["CodColigada"]);

                novo.Rows.Add(novaRow);
            }

            return novo;
        }
    }
}