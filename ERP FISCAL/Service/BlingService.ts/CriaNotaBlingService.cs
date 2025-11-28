using ERP_FISCAL.Models;
using ERP_FISCAL.service;
using ERP_FISCAL.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ERP_FISCAL.Utils
{
    public class CriaNotaBlingService
    {
        public string varreduraDeCriacao { get; set; }
        public async Task TranformaDataRowToObject(List<DataRow> listRow, ConsultaSaldoNotasFiscais form)
        {
            

            BlingService blingService = new BlingService();
            

            DateTime dataAtual = DateTime.Now;
            DateTime dataFutura = dataAtual.AddDays(32);
            string dataAtualFormatada = dataAtual.ToString("yyyy-MM-dd");
            string dataFuturaFormatada = dataFutura.ToString("yyyy-MM-dd");


            AgrupaProdutosDaMesmaNota agrupaProdutosDaMesmaNota = new AgrupaProdutosDaMesmaNota();
            var grupoDeDocumento = agrupaProdutosDaMesmaNota.AgrupaProdutosDaMesmaChave(listRow);

            await Task.Delay(3000);

            int contadorDeNotasCriadas = 0;            

            foreach (var itemGrupo in grupoDeDocumento)
            {
                var primeiraLinha = itemGrupo.First();



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
                    Observacoes = $"Dev. ref. a NF {primeiraLinha.NumDocumento} em {primeiraLinha.DataDocumento}, compra de mercadoria sob a chave de acesso: {primeiraLinha.ChaveAcesso}, Estoque origem: {primeiraLinha.EstoqueOrigem}",
                    Modelo = 55,
                    DocumentoReferenciado = new List<DocumentoReferenciado>
                {
                    new DocumentoReferenciado
                    {
                        Modelo = 55,
                        Numero = primeiraLinha.NumDocumento,
                        ChaveAcesso = primeiraLinha.ChaveAcesso
                    },
                },
                    Contato = new Contato
                    {
                        NumeroDocumento = "46.054.219/0001-74",
                        Nome = "SOLFARMA COMERCIO DE PRODUTOS FARMACEUTICOS S.A.",
                        tipoPessoa = "J",
                        contribuinte = 1,
                        ie= 210030251111,
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
                        Data= dataFuturaFormatada,
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
                // fim da criação do objeto

                // adiciona os itens no objeto
                foreach (var item in itemGrupo)
                {
                    novaNotaFiscal.Itens.Add(new Item
                    {
                        Codigo = item.IDProduto.ToString(),
                        Unidade = "UN",
                        Quantidade = item.QtdParaDevolver,
                        Valor = item.ValorUnitario
                    });
                }

               string json = Newtonsoft.Json.JsonConvert.SerializeObject(novaNotaFiscal, Newtonsoft.Json.Formatting.Indented);
                

                var response = await blingService.CriarNotaAsync(novaNotaFiscal);

                if (response.IsSuccessStatusCode)
                {
                    form.MarcaLinhaImportadaParaOBling(primeiraLinha.NumDocumento, primeiraLinha.IDProduto, primeiraLinha.QtdParaDevolver);

                }

                contadorDeNotasCriadas++;                

                varreduraDeCriacao = $" {contadorDeNotasCriadas} criadas de {grupoDeDocumento.Count}";

                //informa no form o progresso da criação das notas
                form.GeraTextoDeCriacaoDeNotas(varreduraDeCriacao);

                await Task.Delay(7000); 



            }
            // limpa tabela de itens selecionados
            form.LimpaDataGridViewItensSelecionados();
            MessageBox.Show("Notas Criadas", "Dados enviados para criação da nota", MessageBoxButtons.OK, MessageBoxIcon.Information);


            return;



        }
    }
}
