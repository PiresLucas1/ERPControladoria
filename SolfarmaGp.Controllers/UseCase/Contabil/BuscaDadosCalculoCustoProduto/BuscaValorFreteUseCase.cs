using SolfarmaGp.Repositorios.Contabil.BuscaDadosCalculoCustoProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolfarmaGp.Controllers.UseCase.Contabil.BuscaDadosCalculoCustoProduto
{
    public class BuscaValorFreteUseCase
    {
        public async Task<string> ExecuteAsync(DateTime dataInicio, DateTime dataFim)
        {
            // Lógica para buscar dados de valor de frete
            BuscaValorFrete repo = new BuscaValorFrete();
            var resultado = await repo.ExecutarAsync(dataInicio, dataFim);
            return resultado.ToString();
        }   
    }
}
