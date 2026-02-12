using System.Data;

namespace SolfarmaGp.Controllers.Utils.AjudataDataGrid
{
    public class AjustaDataGridView
    {
        public DataTable AjusteDataGrid(DataTable dataTable)
        {

            var resultado = new DataTable();
            resultado.Columns.Add("COD. COLIGADA", typeof(int));
            resultado.Columns.Add("COD. NATUREZA", typeof(string));
            resultado.Columns.Add("DESCRIÇÃO NATUREZA", typeof(string));
            resultado.Columns.Add("TIPO CONTABILIZAÇÃO", typeof(string));
            resultado.Columns.Add("COD. CONTA", typeof(string));
            foreach (DataRow row in dataTable.Rows)
            {



                var coligada = row["COD. COLIGADA"];
                var idNatureza = row["COD. NATUREZA"].ToString();
                var natureza = row["DESCRIÇÃO NATUREZA"].ToString();
                var tipoContabilizacao = row["TIPO CONTABILIZAÇÃO"].ToString();
                var codConta = row["COD. CONTA"].ToString();

                // cria uma nova linha no DataTable destino
                DataRow novaLinha = resultado.NewRow();
                novaLinha["COD. COLIGADA"] = coligada;
                novaLinha["COD. NATUREZA"] = idNatureza;
                novaLinha["DESCRIÇÃO NATUREZA"] = natureza;
                novaLinha["TIPO CONTABILIZAÇÃO"] = tipoContabilizacao;
                novaLinha["COD. CONTA"] = codConta;

                // adiciona a linha ao DataTable
                resultado.Rows.Add(novaLinha);
                



            }

            return resultado;
        }
    }
}
