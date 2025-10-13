using ERP_FISCAL.Repositories.RepositoriesAlterarContaDebito;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Controller.ContaDebitoFreteController
{
    public class AlteraContaDebitoController
    {
        public async Task<DataTable> PesuisarNotas(DateTime dataInicio, DateTime dataFim)
        {
            if (dataInicio <= dataFim)
            {
                AlteraContaDebitoRepositories alteraContaDebitoRepositories = new AlteraContaDebitoRepositories();
                DataTable dataTableRetorno = await alteraContaDebitoRepositories.PesquisarNotas(dataInicio, dataFim);
                DataTable tabelaFormatada = IdentificaItens(dataTableRetorno);
                return tabelaFormatada;
            }
            else
            {
                throw new ArgumentException("A data de início deve ser anterior ou igual à data de fim.");
            }
        }
        public DataTable IdentificaItens(DataTable tabela)
        {
            string[] ordemColunas = new string[]{
            "Filial",
            "Documento",
             "Data Lançamento",
            "Nome CFO",
            "Cod. TMV",
            "Remetente Filial",
            "Destinatario Filial",
            "Remetente Cod. CFO",
            "Remetente Nome",
            "Destinatario Cod. CFO",
            "Destinatario Nome",
            "Chave Acesso NFE",
            "Calor Contabíl",
            "Cód Natureza",
            /*colunas extras*/
            "Tipo Frete",
            "CFOP",
            "Situação",
            "Conta Débito Atual"
            //"Conta Débito Correta"
            }; 
            DataTable novo = new DataTable();

            // cria colunas na ordem certa
            foreach (string nome in ordemColunas)
            {
                if (tabela.Columns.Contains(nome))
                    novo.Columns.Add(nome, tabela.Columns[nome].DataType);
                else
                    novo.Columns.Add(nome, typeof(string));
            }


            //  lógica para identificar itens
            foreach (DataRow row in tabela.Rows)
            {
                DataRow novaLinha = novo.NewRow();

                foreach (string nome in ordemColunas)
                {
                    if (tabela.Columns.Contains(nome))
                    {
                        novaLinha[nome] = row[nome];
                    }
                    else
                    {
                        if (nome == "Tipo Frete")
                        {
                            // Usa conversão segura para evitar erro de tipo
                            int destinatarioFilial = row["Destinatario Filial"] != DBNull.Value
                                ? Convert.ToInt32(row["Destinatario Filial"])
                                : 0;

                            novaLinha[nome] = destinatarioFilial <= 10 && destinatarioFilial >=1
                                ? "Compra/Transferência"
                                : "Venda";
                        }
                        else if (nome == "CFOP")
                        {
                            // Garante que o campo existe e não é nulo
                            if (tabela.Columns.Contains("CFOP") && row["CFOP"] != DBNull.Value)
                            {
                                string cfop = row["CFOP"].ToString();
                                novaLinha[nome] = cfop.Length >= 5 ? cfop.Substring(0, 5) : cfop;
                            }
                            else
                            {
                                novaLinha[nome] = string.Empty;
                            }
                        }
                        else if (nome == "Situação")
                        {
                            string codtmv = row["Cod. TMV"]?.ToString() ?? string.Empty; // valida se não é nlo
                            string tipoFrete = novaLinha.Table.Columns.Contains("Tipo Frete")
                                ? novaLinha["Tipo Frete"]?.ToString() ?? string.Empty
                                : string.Empty;

                            if (codtmv == "1.2.61" && tipoFrete == "Venda")
                            {
                                novaLinha[nome] = "CORRIGIR";
                            }
                            else if (codtmv=="1.2.62" && tipoFrete !="Venda")
                            {
                                novaLinha[nome] = "CORRIGIR";
                            }
                            else
                            {
                                novaLinha[nome] = "OK";
                            }
                        }
                        else if(nome == "Conta Débito Atual")
                        {
                            string codtmv = row["Cod. TMV"]?.ToString() ?? string.Empty;
                            if (codtmv == "1.2.61")
                                novaLinha[nome] = "1.1.1.06.000001";
                            if (codtmv == "1.2.62")
                                novaLinha[nome] = "3.3.1.07.000028";
                        }
                    }
                }

                novo.Rows.Add(novaLinha);
            }
            return novo;

        }
    }
}

