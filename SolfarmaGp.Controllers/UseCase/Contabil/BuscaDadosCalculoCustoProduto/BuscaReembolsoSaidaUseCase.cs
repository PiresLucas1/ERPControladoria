using SolfarmaGp.Repositorios.Contabil.BuscaDadosCalculoCustoProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolfarmaGp.Controllers.UseCase.Contabil.BuscaDadosCalculoCustoProduto
{
    public class BuscaReembolsoSaidaUseCase
    {
        public async Task<string> ExecuteAsync(DateTime dataInicio, DateTime dataFim)
        {
            // Lógica para buscar dados de reembolso de saída
            BuscaReembolsoSaida repo = new BuscaReembolsoSaida();
            var resultado = await repo.ExecutarAsync(dataInicio, dataFim);
            return resultado.ToString();
        }   
    }
}
