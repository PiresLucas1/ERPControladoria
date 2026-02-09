using System.Data;

namespace SolfarmaGp.Controllers.UseCase.ImportarNotasServicoParaTotvs.ConsultaNotasServico
{
    public class ReorganizaTabelaNotasServico
    {
        public DataTable Executar(DataTable original)
        {
            // ordem desejada (já inclui as colunas novas)
            string[] ordemColunas = new string[]{
        "Documento",
        "Razão Social Prestador",
        "CNPJ Prestador",
        "Código Verificação",
        "Dt.Hora Emissão",
        "Base Cálculo",
        "Aliquota",
        "Valor Líquido",
        "UF Prestador",
        "Total Serviços",
        "Valor Pis",
        "Valor Cofins",
        "Valor IR",
        "Valor Csll",
        "Valor INSS",
        "Valor ISS",
        "Item Lista Serviço",
        "Descriminação",
        "CNPJ Tomador",
        "Razão Social Tomador",
        "UF Tomador",
        "CodColigada",
        "NomeColigada",
        "CodFilial",
        "NomeFilial",
        "IDContasPagar",
        "IDMov",
        "Cód. Serviço TOTVS",
        // >>> Colunas novas que você quer incluir <<<
        "Descrição",
        "CFOP",
        "CFOP Descrição",
        "Data Lançamento",
        // <<< ------------------------------- >>>
        "Retorno",
        // Colunas invisíveis para tratativas
        "ErpSitucaoContasPagar",
        "IdErpTitulo",
        "ErpSitucaoTitulo"
    };

            DataTable novo = new DataTable();

            // cria colunas na ordem certa
            foreach (string nome in ordemColunas)
            {
                if (original.Columns.Contains(nome))
                    novo.Columns.Add(nome, original.Columns[nome].DataType);
                else
                    novo.Columns.Add(nome, typeof(string));
            }

            // copia linhas
            foreach (DataRow row in original.Rows)
            {
                DataRow novaLinha = novo.NewRow();

                foreach (string nome in ordemColunas)
                {
                    if (original.Columns.Contains(nome))
                    {
                        novaLinha[nome] = row[nome];
                    }
                    else
                    {
                        // aqui você pode calcular/preencher colunas novas
                        if (nome == "Data Lançamento")
                        {
                            if (original.Columns.Contains("Dt.Hora Emissão") && row["Dt.Hora Emissão"] != DBNull.Value)
                            {
                                DateTime dataEmissao;
                                if (DateTime.TryParse(row["Dt.Hora Emissão"].ToString(), out dataEmissao))
                                    novaLinha[nome] = dataEmissao.ToShortDateString(); // apenas a data
                                else
                                    novaLinha[nome] = DateTime.Now.ToShortDateString(); // fallback
                            }
                            else
                                novaLinha[nome] = "";
                        }
                        else
                        {
                            novaLinha[nome] = "";
                        }
                    }
                }

                // adiciona a linha apenas uma vez
                novo.Rows.Add(novaLinha);
            }

            return novo;
        }

    }
}
