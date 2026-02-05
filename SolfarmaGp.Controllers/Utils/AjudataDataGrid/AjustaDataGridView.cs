using ERP_FISCAL.controller;
using System.Data;
using static ERP_FISCAL.controller.CfopController;

namespace SolfarmaGp.Controllers.Utils.AjudataDataGrid
{
    public class AjustaDataGridView
    {
        public IDataTableGridCFOPUi AjusteDataGrid(DataTable dataTable)
        {

            var resultado = new AjusteDataGridView();
            resultado.DatatableNatureza.Columns.Add("COD. COLIGADA", typeof(int));
            resultado.DatatableNatureza.Columns.Add("COD. NATUREZA", typeof(string));
            resultado.DatatableNatureza.Columns.Add("DESCRIÇÃO NATUREZA", typeof(string));
            resultado.DatatableNatureza.Columns.Add("TIPO CONTABILIZAÇÃO", typeof(string));
            resultado.DatatableNatureza.Columns.Add("COD. CONTA", typeof(string));
            foreach (DataRow row in dataTable.Rows)
            {

                var keyColigada = row["COD. COLIGADA"].ToString();
                var valorColigada = row["NOME COLIGADA"].ToString();

                if (!resultado.DicionarioColigada.ContainsKey(keyColigada))
                {
                    resultado.DicionarioColigada.Add(keyColigada, valorColigada);
                }



                var coligada = row["COD. COLIGADA"];
                var idNatureza = row["COD. NATUREZA"].ToString();
                var natureza = row["DESCRIÇÃO NATUREZA"].ToString();
                var tipoContabilizacao = row["TIPO CONTABILIZAÇÃO"].ToString();
                var codConta = row["COD. CONTA"].ToString();

                // cria uma nova linha no DataTable destino
                DataRow novaLinha = resultado.DatatableNatureza.NewRow();
                novaLinha["COD. COLIGADA"] = coligada;
                novaLinha["COD. NATUREZA"] = idNatureza;
                novaLinha["DESCRIÇÃO NATUREZA"] = natureza;
                novaLinha["TIPO CONTABILIZAÇÃO"] = tipoContabilizacao;
                novaLinha["COD. CONTA"] = codConta;

                // adiciona a linha ao DataTable
                resultado.DatatableNatureza.Rows.Add(novaLinha);



            }

            return resultado;
        }
    }
}
