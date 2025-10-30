using ERP_FISCAL.service;
using ERP_FISCAL.Service.BlingService.ts;
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
        public async void TranformaDataRowToObject(DataRow row)
        {
            Console.WriteLine(row);

            BlingService blingService = new BlingService();
            DtoBlingNotaFiscal notaFiscal = await blingService.ConsultarNotaAsync();


            DtoBlingNotaFiscal novaNotaFiscal = new DtoBlingNotaFiscal
            {
                Tipo = 2,
                Numero = notaFiscal.Numero + 1,
                DataOperacao = Convert.ToDateTime(row["DataDocumento"].ToString()),
                Contato = new Contato
                {
                    Nome = "cliente 9999",
                    NumeroDocumento = "teste"
                },
                NaturezaOperacao = "99999",
                Itens = new List<IItens>
                {
                    new Itens
                    {
                        Codigo = row["IDProduto"].ToString(),
                        Descricao = row["DescProduto"].ToString(),
                        Quantidade = Convert.ToInt32(row["Quantidade Venda"].ToString()),
                        Unidade = row["Devolução"].ToString(),
                        Valor = row["ValorUnitario"].ToString()
                    }
                }
            };
            //Console.WriteLine(novaNotaFiscal);
  //          string json = Newtonsoft.Json.JsonConvert.SerializeObject(novaNotaFiscal, Newtonsoft.Json.Formatting.Indented);

          
            await blingService.CriarNotaAsync(novaNotaFiscal);

            //MessageBox.Show(json, "Dados enviados para criação da nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;



        }
    }
}
