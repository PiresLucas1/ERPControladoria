using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ERP_FISCAL.Controller;
using ERP_FISCAL.repositories;

namespace ERP_FISCAL.controller
{

    public interface IDataTableGridCFOPUi
    {
        Dictionary<string, string> DicionarioColigada { get; set; }
        DataTable DatatableNatureza { get; set; }
    }

    public class CfopController : UIController
    {


        public class AjusteDataGridView : IDataTableGridCFOPUi
        {
            public Dictionary<string, string> DicionarioColigada { get; set; }
            public DataTable DatatableNatureza { get; set; }

            public AjusteDataGridView()
            {
                DicionarioColigada = new Dictionary<string, string>();
                DatatableNatureza = new DataTable();
            }
        }
        public async Task<DataTable> CarregaTodos(int codColigada)
        {

            CfopRepositories cfops = new CfopRepositories();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.EncontrarTodos(codColigada);
            });

            var resultado = AjusteDataGrid(dataTable);
            return resultado.DatatableNatureza ;
        }

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

        public async Task<DataTable> CarregaComOcorrencia(string valor, int codColigada)
        {
            CfopRepositories cfops = new CfopRepositories();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.EncontrarComOcorrencia(valor, codColigada);
            });

            return dataTable;
        }

        public static bool VerificaValorParaPesquisa(string valor)
        {
            Regex regex = new Regex(@"^[0-9\.]+$");
            return regex.IsMatch(valor);
        }

        public async Task<DataTable> PegaValorUnicoPeloCodigo(string valor)
        {
            CfopRepositories cfops = new CfopRepositories();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.PegaValorPeloCodigo(valor);
            });
            return dataTable;
        }
    }
}
