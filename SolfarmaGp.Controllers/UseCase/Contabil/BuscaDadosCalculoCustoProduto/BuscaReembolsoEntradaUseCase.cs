using SolfarmaGp.Repositorios.Contabil.BuscaDadosCalculoCustoProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolfarmaGp.Controllers.UseCase.Contabil.BuscaDadosCalculoCustoProduto
{
    public class BuscaReembolsoEntradaUseCase
    {
        public async Task<string> ExecuteAsync(DateTime dataInicio, DateTime dataFim)
        {
            // Lógica para buscar dados de reembolso de entrada
            BuscaReembolsoEntrada repo = new BuscaReembolsoEntrada();
            var resultado = await repo.ExecutarAsync(dataInicio, dataFim);            
            string mensagem = resultado.Rows[0][0].ToString() ?? "Não obteve retorno";
            return mensagem;
        }
    }
}
