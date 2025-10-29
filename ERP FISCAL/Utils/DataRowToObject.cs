using ERP_FISCAL.service;
using ERP_FISCAL.Service.BlingService.ts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Utils
{
    public class DataRowToObject
    {
        public async void TranformaDataRowToObject(DataRow row)
        {
            Console.WriteLine(row);

            DtoBlingNotaFiscal novaNotaFiscal = new DtoBlingNotaFiscal
            {
                Tipo = 2,
                Numero = row["NumDocumento"].ToString(),
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

            BlingService blingService = new BlingService();
            await blingService.CriarNotaAsync(novaNotaFiscal);



        }
    }
}
