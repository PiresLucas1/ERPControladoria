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

            novo.Columns["Cod. Conta Debito"].DataType = typeof(int);
            novo.Columns["Cod. Conta Credito"].DataType = typeof(int);
            novo.Columns["Cod. Historico"].DataType = typeof(int);
            novo.Columns["Complemento"].DataType = typeof(int);                        
            novo.Columns["Filial"].DataType = typeof(int);
            novo.Columns["Cod. Coligada"].DataType = typeof(int);

            foreach (DataRow row in resultado.Rows)
            {
                DataRow novaRow = novo.NewRow();

                novaRow["Cod. Conta Debito"] = Convert.ToInt32(row["Cod. Conta Debito"]);
                novaRow["Cod. Conta Credito"] = Convert.ToInt32(row["Cod. Conta Credito"]);
                novaRow["Cod. Historico"] = Convert.ToInt32(row["Cod. Historico"]);
                novaRow["Complemento"] = Convert.ToInt32(row["Complemento"]);
                novaRow["Descricão Extrato"] = (row["Descricão Extrato"]);
                novaRow["Cod. Banco"] = row["Cod. Banco"] == DBNull.Value ? row["Cod. Banco"] :  Convert.ToInt32(row["Cod. Banco"]);
                novaRow["Filial"] = Convert.ToInt32(row["Filial"]);
                novaRow["Cod. Coligada"] = Convert.ToInt32(row["Cod. Coligada"]);

                novo.Rows.Add(novaRow);
            }

            return novo;            
        }
    }
}
