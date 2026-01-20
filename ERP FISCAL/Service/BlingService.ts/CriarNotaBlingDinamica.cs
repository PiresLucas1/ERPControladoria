using ERP_FISCAL.Models;
using ERP_FISCAL.service;
using ERP_FISCAL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.NotaDinamicaBling
{
    public class CriarNotaBlingDinamica
    {
        public async Task ExecutarCriacaoNota(NotaProdutoDTO nota)
        {
            BlingService blingService = new BlingService();
            DateTime dataAtual = DateTime.Now;            
            string dataAtualFormatada = dataAtual.ToString("yyyy-MM-dd");


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
                    NumeroDocumento = "46.054.219/0001-74",
                    Nome = "SOLFARMA COMERCIO DE PRODUTOS FARMACEUTICOS S.A.",
                    tipoPessoa = "J",
                    contribuinte = 1,
                    ie = 210030251111,
                    endereco = new EnderecoCliente
                    {
                        endereco = "Avenida João Ferreira Penna",
                        numero = 147,
                        bairro = "DISTRITO INDUSTRIAL III",
                        cep = "14707-002",
                        municipio = "Bebedouro",
                        uf = "SP"

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
                        Nome = "SOLFARMA COMERCIO DE PRODUTOS FARMACEUTICOS S.A.",
                        NumeroDocumento = "",
                        Ie = "",
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
                        Data= dataAtual,
                        Valor =0,
                        Observacoes="",
                        Caut="",
                        FormaPagamento= new FormaPagamento
                        {
                            Id = 6574120
                        }

                    }
                },
                Itens = new List<Item>()
            };
            //await blingService.CriarNotaFiscalDinamica(nota);
        }
    }
}
