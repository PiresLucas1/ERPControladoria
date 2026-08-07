using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolfarmaGp.UI.Utils
{
    public class ConveteParaTabela
    {
        public static DataTable ListaObjetoParaDataTable(List<object> lista)
        {
            var dataTable = new DataTable();

            if (lista == null || lista.Count == 0)
                return dataTable;

            // Pega as propriedades do primeiro item (todos os itens vêm do mesmo tipo anônimo)
            var propriedades = lista[0].GetType().GetProperties();

            // Cria as colunas
            foreach (var prop in propriedades)
            {
                dataTable.Columns.Add(prop.Name, typeof(object)); // object aceita DBNull também
            }

            // Preenche as linhas
            foreach (var item in lista)
            {
                var novaLinha = dataTable.NewRow();
                foreach (var prop in propriedades)
                {
                    var valor = prop.GetValue(item);
                    novaLinha[prop.Name] = valor ?? DBNull.Value;
                }
                dataTable.Rows.Add(novaLinha);
            }

            return dataTable;
        }
    }
}
