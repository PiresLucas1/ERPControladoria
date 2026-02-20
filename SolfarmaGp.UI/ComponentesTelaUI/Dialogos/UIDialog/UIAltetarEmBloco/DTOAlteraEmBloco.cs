namespace SolfarmaGp.UI.ComponentesTelaUI.Dialogos.UIDialog.UIAltetarEmBloco
{
    public class DTOAlteraEmBloco
    {
        public string TextLabel1 { get; set; }
        //public string TextLabel2 { get; set; }
      
        public DTOAlteraEmBloco() { }

        // Construtor que recebe outro DTO para copiar dados
        public DTOAlteraEmBloco(DTOAlteraEmBloco data)
        {
            if (data != null)
            {
                TextLabel1 = data.TextLabel1;
                //TextLabel2 = data?.TextLabel2;
                //TextLabel2 = data?.TextLabel2;
            }
        }
    }
}
