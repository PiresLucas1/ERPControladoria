using ERP_FISCAL.Models;
using ERP_FISCAL.service;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_FISCAL.Utils
{
    public class DataRowToObject
    {
        public async Task TranformaDataRowToObject(List<DataRow> ListRow)
        {
            Console.WriteLine(ListRow);

            BlingService blingService = new BlingService();
            NotaFiscal notaFiscal = await blingService.ConsultarNotaAsync();

            //DateTime dataConvertida = DateTime.ParseExact(row["DataDocumento"].ToString(), "dd/MM/YYYY", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dataAtual = DateTime.Now;
            DateTime dataFutura = dataAtual.AddDays(32);
            string dataAtualFormatada = dataAtual.ToString("yyyy-MM-dd");
            string dataFuturaFormatada = dataFutura.ToString("yyyy-MM-dd");

            foreach (DataRow row in ListRow)
            {

                NotaFiscal novaNotaFiscal = new NotaFiscal
                {
                    Tipo = 1,
                    Serie = 5,
                    Numero = (Convert.ToInt32(notaFiscal.Numero) + 1).ToString(),
                    NaturezaOperacao = new NaturezaOperacao
                    {
                        Id = 15101770690
                    },
                    DataOperacao = dataAtualFormatada,
                    Finalidade = 4,
                    //inserir no campo observação o estoque de referencia
                    Observacoes = $"Dev. ref. a NF {row["NumDocumento"].ToString()} em {row["DataDocumento"].ToString()}, compra de mercadoria sob a chave de acesso: {row["ChaveAcesso"].ToString()}",
                    Modelo = 55,
                    DocumentoReferenciado = new List<DocumentoReferenciado>
                {
                    new DocumentoReferenciado
                    {
                        Modelo = 55,
                        Numero = (int)row["NumDocumento"],
                        ChaveAcesso = row["ChaveAcesso"].ToString()
                    },
                },
                    Contato = new Contato
                    {
                        NumeroDocumento = "46.054.219/0001-74",
                        Nome = "SOLFARMA COMERCIO DE PRODUTOS FARMACEUTICOS S.A."
                    },
                    Itens = new List<Item>
                {
                    new Item
                    {
                        Codigo = row["IDProduto"].ToString(),
                        Unidade = "UN",
                        Quantidade = (int)row["Qtd para Devolver"],
                        Valor =  (decimal)row["ValorUnitario"],
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
                }


                };


              string json = Newtonsoft.Json.JsonConvert.SerializeObject(novaNotaFiscal, Newtonsoft.Json.Formatting.Indented);
              var response = await blingService.CriarNotaAsync(novaNotaFiscal);

                if (response == 0)
                {

                    break;
                }


            }
            MessageBox.Show("Notas Criadas", "Dados enviados para criação da nota", MessageBoxButtons.OK, MessageBoxIcon.Information);


            return;



        }
    }
}
