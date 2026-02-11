namespace SolfarmaGp.Repositorios.Zanup.Interfaces
{
    public class ControleNotaBling
    {
        public static List<JsonParaDadoTabela> jsonNotasParaRegistro = new List<JsonParaDadoTabela>();
        public class JsonParaDadoTabela
        {
            public long id { get; set; }
            public string numero { get; set; }
            public string serie { get; set; }
            public string contato { get; set; }
            //public object alertas { get; set; }
        }
        public class RootObject
        {
            public DataJsonResponse data { get; set; }
        }
        public class DataJsonResponse
        {
            public string id { get; set; }
            public string numero { get; set; }
            public string serie { get; set; }
            public ContatoReponse contato { get; set; }
        }

        public class ContatoReponse
        {
            public string nome { get; set; }
        }

        public void AdicionarNotaCriada(JsonParaDadoTabela notaCriada)
        {
            jsonNotasParaRegistro.Add(notaCriada);
        }
        public void LimparNotasCriadas()
        {
            jsonNotasParaRegistro.Clear();
        }
    }
}
