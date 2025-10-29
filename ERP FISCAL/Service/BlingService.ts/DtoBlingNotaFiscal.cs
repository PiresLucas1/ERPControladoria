using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ERP_FISCAL.Service.BlingService.ts
{
    public interface IDtoBlingNotaFiscal
    {
        int Tipo { get; set; }
        string Numero { get; set; }
        DateTime DataOperacao { get; set; }
        IContato Contato { get; set; }
        List<IItens> Itens { get; set; }
        string NaturezaOperacao { get; set; }
    }

    public class DtoBlingNotaFiscal : IDtoBlingNotaFiscal
    {
        [JsonProperty("tipo")]
        public int Tipo { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("dataOperacao")]
        public DateTime DataOperacao { get; set; }

        [JsonProperty("naturezaOperacao")]
        public string NaturezaOperacao { get; set; }

        [JsonProperty("contato")]
        public IContato Contato { get; set; }

        [JsonProperty("itens")]
        public List<IItens> Itens { get; set; }
    }

    public interface IContato
    {
        string NumeroDocumento { get; set; }
        string Nome { get; set; }
    }

    public class Contato : IContato
    {
        [JsonProperty("numeroDocumento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }
    }

    public interface IItens
    {
        string Codigo { get; set; }
        string Descricao { get; set; }
        string Unidade { get; set; }
        int Quantidade { get; set; }
        string Valor { get; set; }
    }

    public class Itens : IItens
    {
        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("unidade")]
        public string Unidade { get; set; }

        [JsonProperty("quantidade")]
        public int Quantidade { get; set; }

        [JsonProperty("valor")]
        public string Valor { get; set; }
    }
}
