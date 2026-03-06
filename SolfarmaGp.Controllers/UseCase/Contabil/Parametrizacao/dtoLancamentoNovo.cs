namespace SolfarmaGp.Controllers.UseCase.Contabil.Parametrizacao
{
    public class DtoLancamentoNovo
    {
        public int IDContaContabilDebito {get; set;}
        public int IDContaContabilCredito {get; set;}
        public int IDHistorico {get; set;}
        public int IDComplemento {get; set;}
        public string DescricaoExtrato {get; set;}
        public int Filial {get; set;}
        public int CodColigada { get; set; }
    }
}
