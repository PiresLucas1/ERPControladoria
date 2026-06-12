using SolfarmaGp.Controllers.UseCase.Contabil.BuscaDadosCalculoCustoProduto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolfarmaGp.UI.MenusUI.Contabil.BuscaDadosCalculoCustoProduto
{
    public partial class BuscaDadosCalculoCustoProduto : Form
    {
        private int flag_execucao = 0;
        public BuscaDadosCalculoCustoProduto()
        {
            InitializeComponent();
        }

        private async void btnExecutar_click(object sender, EventArgs e)
        {
            var dataInicio = dtInicio.Value;
            var dataFim = dtFim.Value;
            
            if(flag_execucao == 1)
            {
                rtbResultado.Clear();
                flag_execucao = 0;
            }

            flag_execucao = 1;
            if (dataInicio > dataFim)
            {
                MessageBox.Show("A data de início deve ser menor que a data de fim.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!chkAqsValorTransferencia.Checked && !chkBoxIcmsRetidoSubstituido.Checked && !chkBoxIcmsSt.Checked && !chkBoxReembolsoSaida.Checked && !chkBoxReembolsoEntrada.Checked && !chkBoxValorFrete.Checked)
            {
                MessageBox.Show("Selecione pelo menos uma opção para buscar os dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                prbar.Style = ProgressBarStyle.Marquee; // fica animando em loop
                prbar.Visible = true;
                //checkbox de aquisição valor transferência
                var ResultadoAquisicaoValorTransferencia = chkAqsValorTransferencia.Checked ? await BuscaAqsValorTransferencia(dataInicio, dataFim) : string.Empty;
                
                //checkbox de icms retido e substituído
                var ResultadoIcmsRetidoSubstituido = chkBoxIcmsRetidoSubstituido.Checked ? await BuscaIcmsRetidoSubstituido(dataInicio, dataFim) : string.Empty;

                //checkbox de icms st
                var ResultadoIcmsSt = chkBoxIcmsSt.Checked ? await BuscaIcmsSt(dataInicio, dataFim) : string.Empty;

                //checkbox de reembolso saída    
                var ResultadoReembolsoSaida = chkBoxReembolsoSaida.Checked ? await BuscaReembolsoSaida(dataInicio, dataFim) : string.Empty;

                //checkbox de reembolso entrada
                var ResultadoReembolsoEntrada = chkBoxReembolsoEntrada.Checked ? await BuscaReembolsoEntrada(dataInicio, dataFim) : string.Empty;

                //checkbox de valor frete
                var ResultadoValorFrete = chkBoxValorFrete.Checked ? await BuscaValorFrete(dataInicio, dataFim) : string.Empty;
                prbar.Visible = false;
            }

        }

        private async Task<string> BuscaAqsValorTransferencia(DateTime dataInicio, DateTime datafim)
        {
            BuscaAqsValorTransferenciaUsecase usecase = new BuscaAqsValorTransferenciaUsecase();
            var resultado = await usecase.ExecuteAsync(dataInicio, datafim);
            PreencheBlocoDeRetorno("Busca Aquisição Valor Transferência",resultado);
            return resultado;
        }
        private async Task<string> BuscaIcmsRetidoSubstituido(DateTime dataInicio, DateTime datafim)
        {
            BuscaIcmsRetidoSubstituidoUseCase usecase = new BuscaIcmsRetidoSubstituidoUseCase();
            var resultado = await usecase.ExecuteAsync(dataInicio, datafim);
            PreencheBlocoDeRetorno("Busca ICMS  Retido e Substituído", resultado);
            return resultado;
        }
        private async Task<string> BuscaIcmsSt(DateTime dataInicio, DateTime datafim)
        {
            BuscaIcmsStUseCase usecase = new BuscaIcmsStUseCase();
            var resultado = await usecase.ExecuteAsync(dataInicio, datafim);
            PreencheBlocoDeRetorno("Busca ICMS ST", resultado);
            return resultado;
        }
        private async Task<string> BuscaReembolsoSaida(DateTime dataInicio, DateTime datafim)
        {
            BuscaReembolsoSaidaUseCase usecase = new BuscaReembolsoSaidaUseCase();
            var resultado = await usecase.ExecuteAsync(dataInicio, datafim);
            PreencheBlocoDeRetorno("Busca Reembolso da Saída", resultado);
            return resultado;
        }
        private async Task<string> BuscaReembolsoEntrada(DateTime dataInicio, DateTime datafim)
        {
            BuscaReembolsoEntradaUseCase usecase = new BuscaReembolsoEntradaUseCase();
            var resultado = await usecase.ExecuteAsync(dataInicio, datafim);
            PreencheBlocoDeRetorno("Busca Reembolso Entrada", resultado);
            return resultado;   
        }
        private async Task<string> BuscaValorFrete(DateTime dataInicio, DateTime datafim)
        {
            BuscaValorFreteUseCase usecase = new BuscaValorFreteUseCase();
            var resultado = await usecase.ExecuteAsync(dataInicio, datafim);
            PreencheBlocoDeRetorno("Busca Aquisição Valor Transferência", resultado);
            return resultado;
        }

        private void PreencheBlocoDeRetorno(string tipoExecucao, string resultado)
        {
            rtbResultado.Text = rtbResultado.Text +
                $"========================================{Environment.NewLine}" +
                $" PROCESSAMENTO CONCLUÍDO{Environment.NewLine}" +
                $"========================================{Environment.NewLine}" +
                $"Tipo de execução: {tipoExecucao}{Environment.NewLine}" +
                $"Retorno: {resultado}{Environment.NewLine}" +
                $"Data/Hora: {DateTime.Now:dd/MM/yyyy HH:mm:ss}{Environment.NewLine}" +
                $"Status: Sucesso{Environment.NewLine}" +
                $"========================================";
            }

    }
}
