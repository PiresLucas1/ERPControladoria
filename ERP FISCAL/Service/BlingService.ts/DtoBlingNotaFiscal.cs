using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ERP_FISCAL.Models
{
    public class Root
    {
        [JsonProperty("data")]
        public List<NotaFiscal> Data { get; set; }
    }
    public class NotaFiscal
    {
        [JsonProperty("tipo")]
        public int Tipo { get; set; }

        [JsonProperty("serie")]
        public int Serie { get; set; }

        //[JsonProperty("numero")]
        //public string Numero { get; set; }

        [JsonProperty("naturezaOperacao")]
        public NaturezaOperacao NaturezaOperacao { get; set; }

        [JsonProperty("dataOperacao")]
        public string DataOperacao { get; set; }

        [JsonProperty("finalidade")]
        public int Finalidade { get; set; }

        [JsonProperty("observacoes")]
        public string Observacoes { get; set; }

        [JsonProperty("modelo")]
        public int Modelo { get; set; }

        [JsonProperty("documentoReferenciados")]
        public List<DocumentoReferenciado> DocumentoReferenciados { get; set; }

        [JsonProperty("documentoReferenciado")]
        public DocumentoReferenciado DocumentoReferenciado { get; set; }

        [JsonProperty("contato")]
        public Contato Contato { get; set; }

        [JsonProperty("itens")]
        public List<Item> Itens { get; set; }

        [JsonProperty("transporte")]
        public Transporte Transporte { get; set; }

        [JsonProperty("condicaoPagamento")]
        public string CondicaoPagamento { get; set; }

        [JsonProperty("parcelas")]
        public List<Parcela> Parcelas { get; set; }
    }

    public class NaturezaOperacao
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }

    public class DocumentoReferenciado
    {
        [JsonProperty("modelo")]
        public int Modelo { get; set; }

        [JsonProperty("numero")]
        public int Numero { get; set; }

        [JsonProperty("chaveAcesso")]
        public string ChaveAcesso { get; set; }

        [JsonProperty("serie")]
        public int Serie { get; set; }

        [JsonProperty("contadorOrdemOperacao")]
        public int ContadorOrdemOperacao { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

    }

    public class Contato
    {
        [JsonProperty("numeroDocumento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("tipoPessoa")]
        public string tipoPessoa { get; set; }

        [JsonProperty("contribuinte")]
        public int contribuinte { get; set; }
        [JsonProperty("ie")]
        public long ie { get; set; }

        [JsonProperty("endereco")]
        public EnderecoCliente endereco { get; set; }


    }

    public class Item
    {
        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("unidade")]
        public string Unidade { get; set; }

        [JsonProperty("quantidade")]
        public decimal Quantidade { get; set; }

        [JsonProperty("valor")]
        public decimal Valor { get; set; }
    }

    public class Transporte
    {
        [JsonProperty("fretePorConta")]
        public int FretePorConta { get; set; }

        [JsonProperty("frete")]
        public string Frete { get; set; }

        [JsonProperty("veiculo")]
        public Veiculo Veiculo { get; set; }

        [JsonProperty("transportador")]
        public Transportador Transportador { get; set; }

        [JsonProperty("volume")]
        public Volume Volume { get; set; }
    }

    public class Veiculo
    {
        [JsonProperty("placa")]
        public string Placa { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }

        [JsonProperty("marca")]
        public string Marca { get; set; }
    }

    public class Transportador
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("numeroDocumento")]
        public string NumeroDocumento { get; set; }

        [JsonProperty("ie")]
        public string Ie { get; set; }

        [JsonProperty("endereco")]
        public Endereco Endereco { get; set; }
    }

    public class Endereco
    {
        [JsonProperty("endereco")]
        public string EnderecoStr { get; set; }

        [JsonProperty("municipio")]
        public string Municipio { get; set; }

        [JsonProperty("uf")]
        public string Uf { get; set; }
    }

    public class Volume
    {
        [JsonProperty("quantidade")]
        public int Quantidade { get; set; }

        [JsonProperty("especie")]
        public int Especie { get; set; }

        [JsonProperty("numero")]
        public string Numero { get; set; }

        [JsonProperty("pesoBruto")]
        public decimal PesoBruto { get; set; }

        [JsonProperty("pesoLiquido")]
        public decimal PesoLiquido { get; set; }
    }

    public class Parcela
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("valor")]
        public decimal Valor { get; set; }

        [JsonProperty("observacoes")]
        public string Observacoes { get; set; }

        [JsonProperty("caut")]
        public string Caut { get; set; }

        [JsonProperty("formaPagamento")]
        public FormaPagamento FormaPagamento { get; set; }
    }

    public class FormaPagamento
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
    public class  EnderecoCliente 
    {
        [JsonProperty("endereco")]
        public string endereco { get; set; }

        [JsonProperty("numero")]
        public int numero { get; set; }

        [JsonProperty("bairro")]
        public string bairro { get; set; }

        [JsonProperty("cep")]
        public string cep { get; set; }

        [JsonProperty("municipio")]
        public string municipio { get; set; }

        [JsonProperty("uf")]
        public string uf { get; set; }

    }
}
