using SolfarmaGp.Repositorios.Fiscal.EntradasComFiltro;

namespace SolfarmaGp.Controllers.UseCase.Fiscal.BuscaEntradasComFiltroUseCase
{
    public class ValidaColigadaFilialUseCase
    {
        /// <summary>
        /// Confere se a coligada (e a filial, quando informada) existem. Filial 0 significa "todas" e não é validada.
        /// Devolve null quando está tudo certo, ou a mensagem explicando o que não existe.
        /// </summary>
        public async Task<string?> Execute(int coligada, int filial)
        {
            var existentes = await new ConsultaColigadasFiliais().ExecutarAsync();

            var filiaisDaColigada = existentes.Where(f => f.Coligada == coligada).ToList();

            if (filiaisDaColigada.Count == 0)
            {
                string validas = string.Join(", ", existentes.Select(f => f.Coligada).Distinct().OrderBy(c => c));
                return $"A coligada {coligada} não existe.\n\nColigadas disponíveis: {validas}.";
            }

            if (filial != 0 && !filiaisDaColigada.Any(f => f.Filial == filial))
            {
                string validas = string.Join(", ", filiaisDaColigada.Select(f => f.Filial).OrderBy(x => x));
                return $"A filial {filial} não existe na coligada {coligada}.\n\nFiliais disponíveis nessa coligada: {validas}.";
            }

            return null;
        }
    }
}
