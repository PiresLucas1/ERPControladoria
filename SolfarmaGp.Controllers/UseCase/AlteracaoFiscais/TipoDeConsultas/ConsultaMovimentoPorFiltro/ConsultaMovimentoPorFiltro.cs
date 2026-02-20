using SolfarmaGp.Repositorios.Fiscal.AlteracoesFiscais.TiposDeConsultas.ConsultaMovDataPagamentoSTxDataEntrada;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.AlteracaoFiscais.TipoDeConsultas.ConsultaMovimentoPorFiltro
{
    public class ConsultaMovimentoPorFiltro
    {
        public async Task<DataTable> Executar(int codcoligada, DateTime dtInicio, DateTime dtFim)
        {
            var retorno = await new ConsultaMovDataPagamentoSTxDataEntrada().Executar(codcoligada, dtInicio, dtFim);

            return retorno;
        }
    }
}
