using SolfarmaGp.Repositorios.Contabil.Tiktok;
using System.Data;

namespace SolfarmaGp.Controllers.UseCase.Contabil.Tiktok
{
    public class BuscaParametrizacaoContabilTiktokUseCase
    {
        public class ObjetoPesquisaParametrosTiktok
        {
            public int CodColigada { get; set; }
            public int Filial { get; set; }
        }

        public async Task<DataTable> Execute(ObjetoPesquisaParametrosTiktok objeto)
        {
            BuscaParametrizacaoContabilTiktok repo = new BuscaParametrizacaoContabilTiktok();
            BuscaParametrizacaoContabilTiktok.DtoObjetoPesquisaTiktok dto = new BuscaParametrizacaoContabilTiktok.DtoObjetoPesquisaTiktok
            {
                CodColigada = objeto.CodColigada,
                Filial = objeto.Filial
            };
            DataTable result = await repo.Execute(dto);
            return result;
        }
    }
}
