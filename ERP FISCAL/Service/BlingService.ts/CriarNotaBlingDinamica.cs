using ERP_FISCAL.Models;
using ERP_FISCAL.service;
using ERP_FISCAL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.NotaDinamicaBling
{
    public class CriarNotaBlingDinamica
    {
        public async Task<HttpResponseMessage> ExecutarCriacaoNota(NotaProdutoDTO nota)
        {
            BlingService blingService = new BlingService();
            DateTime dataAtual = DateTime.Now;            
            string dataAtualFormatada = dataAtual.ToString("yyyy-MM-dd");

            var response = new HttpResponseMessage();
            NotaFiscal notaFiscal = new NotaFiscal();
            NotaFiscal novaNotaFiscal = new NotaFiscal
            {
                Tipo = 1,
                Serie = 5,
                NaturezaOperacao = new NaturezaOperacao
                {
                    Id = 15101770690
                },
                DataOperacao = dataAtualFormatada,
                Finalidade = 4,
                //inserir no campo observação o estoque de referencia
                Observacoes = $"",
                Modelo = 55,
                DocumentoReferenciados = new List<DocumentoReferenciado>
                    {
                        new DocumentoReferenciado
                        {
                            Modelo = 55,
                            Numero = nota.NumeroNota,
                            ChaveAcesso = nota.ChaveAcesso,
                            Serie = 1,
                            ContadorOrdemOperacao= 1,
                            Data = nota.DataEmissao.ToShortDateString()
                        },
                    },
                //DocumentoReferenciado = new DocumentoReferenciado
                //{
                //    Modelo = 55,
                //    Numero = primeiraLinha.NumDocumento,
                //    ChaveAcesso = primeiraLinha.ChaveAcesso,
                //    Serie = 1,
                //    ContadorOrdemOperacao = 1,
                //    Data = primeiraLinha.DataDocumento.ToShortDateString()
                //},
                Contato = new Contato
                {
                    NumeroDocumento = nota.CnpjCpf,
                    Nome = nota.Nome,
                    tipoPessoa = nota.CpfCnpj.Length > 11 ? "F" : "J" ,
                    contribuinte = 1,
                    ie = long.Parse(nota.InscricaoEstadualDestinatario),
                    endereco = new EnderecoCliente
                    {
                        endereco = nota.NumeroEnderecoDestinatario,
                        numero = 0,
                        bairro = nota.BairroEnderecoDestinatario,
                        cep = nota.CepEnderecoDestinatario,
                        municipio = nota.NomeMunicipioEnderecoDestinatario,
                        uf = nota.UfEnderecoDestinatario

                    }
                },
                Transporte = new Transporte
                {
                    FretePorConta = 0,
                    Frete = "0",
                    Veiculo = new Veiculo
                    {
                        Placa = "",
                        Uf = "",
                        Marca = ""
                    },
                    Transportador = new Transportador
                    {
                        Nome = nota.CnpjCpf,
                        NumeroDocumento = "",
                        Ie = nota.InscricaoEstadualDestinatario,
                        Endereco = new Endereco
                        {
                            Uf = "",
                            EnderecoStr = "",
                            Municipio = ""
                        }
                    },
                    Volume = new Volume
                    {
                        Quantidade = 0,
                        Especie = 2,
                        Numero = "",
                        PesoBruto = 0,
                        PesoLiquido = 0
                    }
                },
                CondicaoPagamento = "32",
                Parcelas = new List<Parcela>
                {
                    new Parcela
                    {
                        Data= dataAtual.ToShortDateString(),
                        Valor =0,
                        Observacoes="",
                        Caut="",
                        FormaPagamento= new FormaPagamento
                        {
                            Id = 6574120
                        }

                    }
                },
                Itens = new List<Item>
                {
                    new Item
                    {                        
                        Codigo = nota.CodigoProduto.ToString(),
                        Unidade = "UN",
                        Quantidade = nota.QtdParaDevolver,
                        Valor = nota.ValorTotalProduto
                    }
                }
            };
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(novaNotaFiscal, Newtonsoft.Json.Formatting.Indented);
            
            response = await blingService.CriarNotaAsync(novaNotaFiscal);
            await Task.Delay(7000);
            
            return response;
            
        }
    }
}
