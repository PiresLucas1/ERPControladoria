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

    public interface IAjusteComboBoxUi
    {
        Dictionary<string, string> DicionarioColigada { get; set; }
        DataTable DatatableNatureza { get; set; }
    }

    public class CarregaCFOPController : UIController
    {


        public class AjusteComboBoxUi : IAjusteComboBoxUi
        {
            public Dictionary<string, string> DicionarioColigada { get; set; }
            public DataTable DatatableNatureza { get; set; }

            public AjusteComboBoxUi()
            {
                DicionarioColigada = new Dictionary<string, string>();
                DatatableNatureza = new DataTable();
            }
        }
        public async Task<DataTable> CarregaTodos()
        {

            cfopRepositories cfops = new cfopRepositories();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.EncontrarTodos();
            });

            var resultado = AjusteComboBox(dataTable);
            return resultado.DatatableNatureza ;
        }

        public IAjusteComboBoxUi AjusteComboBox(DataTable dataTable)
        {

            var resultado = new AjusteComboBoxUi();
            resultado.DatatableNatureza.Columns.Add("CODCOLIGADA", typeof(int));
            resultado.DatatableNatureza.Columns.Add("IDNATUREZA", typeof(string));
            resultado.DatatableNatureza.Columns.Add("DESCRICAO_NATUREZA", typeof(string));
            resultado.DatatableNatureza.Columns.Add("TIPO_CONTABILIZAÇÃO", typeof(string));
            resultado.DatatableNatureza.Columns.Add("CODCONTA", typeof(string)); 
            foreach (DataRow row in dataTable.Rows)
            {

                var keyColigada = row["CODCOLIGADA"].ToString();
                var valorColigada = row["NOME COLIGADA"].ToString();

                if (!resultado.DicionarioColigada.ContainsKey(keyColigada))
                {
                    resultado.DicionarioColigada.Add(keyColigada, valorColigada);
                }

               

                var coligada = row["CODCOLIGADA"];
                var idNatureza = row["IDNATUREZA"].ToString();
                var natureza = row["DESCRIÇÃO NATUREZA"].ToString();
                var tipoContabilizacao = row["TIPO CONTABILIZAÇÃO"].ToString();
                var codConta = row["CODCONTA"].ToString();

                // cria uma nova linha no DataTable destino
                DataRow novaLinha = resultado.DatatableNatureza.NewRow();
                novaLinha["CODCOLIGADA"] = coligada;
                novaLinha["IDNATUREZA"] = idNatureza;
                novaLinha["DESCRICAO_NATUREZA"] = natureza;
                novaLinha["TIPO_CONTABILIZAÇÃO"] = tipoContabilizacao;
                novaLinha["CODCONTA"] = codConta;

                // adiciona a linha ao DataTable
                resultado.DatatableNatureza.Rows.Add(novaLinha);



            }

            return resultado;
        }

        public async Task<DataTable> CarregaComOcorrencia(string valor)
        {
            cfopRepositories cfops = new cfopRepositories();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.EncontrarComOcorrencia(valor);
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
            cfopRepositories cfops = new cfopRepositories();
            DataTable dataTable = await Task.Run(() =>
            {
                return cfops.PegaValorPeloCodigo(valor);
            });
            return dataTable;
        }
    }
}
