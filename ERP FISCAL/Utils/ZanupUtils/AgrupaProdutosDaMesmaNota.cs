using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ERP_FISCAL.Service.BlingService.ts.DtoDataRowToDocumentoNota;

namespace ERP_FISCAL.Utils
{
    public class AgrupaProdutosDaMesmaNota
    {
        public List<List<DataRow>> AgruparProdutos(List<DataRow> listaDeLinhas, string pesquisa)
        {
            var notasAgrupadas = new Dictionary<string, List<DataRow>>();
            foreach (var linha in listaDeLinhas)
            {
                string chave = linha["chaveAcesso"].ToString();
                if (!notasAgrupadas.ContainsKey(chave))
                {
                    notasAgrupadas[chave] = new List<DataRow>();
                }
                notasAgrupadas[chave].Add(linha);
            }
            return notasAgrupadas.Values.ToList();
        }

        public List<List<ItemDocumento>> AgrupaProdutosDaMesmaChave(List<DataRow> listRow)
        {
            var lista = listRow
                .GroupBy(r => r["ChaveAcesso"].ToString())
                .Select(grupo => grupo
                    .Select(row => ConverterParaItemDocumento(row))
                    .ToList())
                .ToList();

            return lista;
        }
        public ItemDocumento ConverterParaItemDocumento(DataRow row)
        {
            return new ItemDocumento
            {
                NumDocumento = Convert.ToInt32(row["NumDocumento"]),
                ChaveAcesso = row["ChaveAcesso"].ToString(),
                IDProduto = Convert.ToInt32(row["IDProduto"]),
                DescProduto = row["DescProduto"].ToString(),
                DataDocumento = Convert.ToDateTime(row["DataDocumento"]),
                CFOPVenda = Convert.ToInt32(row["CFOP VENDA"]),
                CSTICMS = Convert.ToInt32(row["CST ICMS"]),
                CFOPZanup = Convert.ToInt32(row["CFOP ZANUP"]),
                QuantidadeVenda = Convert.ToDecimal(row["Quantidade Venda"]),
                Devolucao = Convert.ToDecimal(row["Devolução"]),
                SaldoRestante = Convert.ToDecimal(row["Saldo Restante"]),
                ValorUnitario = Convert.ToDecimal(row["ValorUnitario"]),
                IcmsBaseValorUnidade = Convert.ToDecimal(row["Icms base Valor unidade"]),
                IcmsBase = Convert.ToDecimal(row["IcmsBase"]),
                IcmsAliquota = Convert.ToDecimal(row["IcmsAliquota"]),
                IcmsValorUnidade = Convert.ToDecimal(row["Icms Valor Unidade"]),
                IcmsValor = Convert.ToDecimal(row["IcmsValor"]),
                PisValor = Convert.ToDecimal(row["PisValor"]),
                CofinsValor = Convert.ToDecimal(row["CofinsValor"]),
                QtdParaDevolver = Convert.ToDecimal(row["Qtd para Devolver"]),
                EstoqueOrigem = row["Estoque origem"].ToString()
            };
        }




    }
}
