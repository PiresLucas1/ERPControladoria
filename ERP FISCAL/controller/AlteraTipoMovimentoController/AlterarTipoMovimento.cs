using ERP_FISCAL.Repositories.AlteraTipoMovimentoRepositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_FISCAL.Controller.AlteraTipoMovimentoController
{
    internal class AlterarTipoMovimentoController
    {
        public async Task<DataTable> ConsultaMovimentoTotvs(int codMovimento, int coligada)
        {
            AlteraTipoMovimentoRepositories alteraTipoMovimentoRepositories = new AlteraTipoMovimentoRepositories();
            DataTable dataRetorno = await alteraTipoMovimentoRepositories.ConsultaMovimentoTotvs(codMovimento, coligada);

            return dataRetorno;
        }
        public async Task<string> AlterarTipoMovimento(int codMovimento, int coligada, string codTmovimento)
        {
            AlteraTipoMovimentoRepositories alteraTipoMovimentoRepositories = new AlteraTipoMovimentoRepositories();
            DataTable retorno = await alteraTipoMovimentoRepositories.AlteraTipoMovimento(codMovimento, coligada, codTmovimento);

            string mensagem = retorno.Rows.Count > 0
                ? retorno.Rows[0]["Resultado"].ToString()
                : "Sem resultado";
            return mensagem;

        }
    }
}
