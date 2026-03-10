using SolfarmaGp.Communication.Zanup.Bling;
using SolfarmaGp.Repositorios.Zanup;
using SolfarmaGp.Services.Zanup.Bling.CriaNotaDevolucao;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Zanup
{
    public class CriaNotasDevolucaoUseCase
    {
        public string varreduraDeCriacao { get; set; }

        public async Task<DataTable> Execute(List<DataRow> listRow, IProgress<ProgressoCriacaoNota> progress)
        {
            var token = await new PegaTokenApiBling().Execute();
            DataTable result = await new CriaNotaDevolucaoService().Execute(listRow, token, progress);
            return result;
        }

    }
}
