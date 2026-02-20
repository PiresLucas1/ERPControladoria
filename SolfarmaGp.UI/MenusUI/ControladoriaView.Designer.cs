namespace SolfarmaGp.UI.MenusUI
{
    partial class Portal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
            menuBarTop = new MenuStrip();
            FiscalMenu = new ToolStripMenuItem();
            importarToolStripMenuItem = new ToolStripMenuItem();
            importarNotasParaOBigToolStripMenuItem = new ToolStripMenuItem();
            alteraçõesFiscaisToolStripMenuItem1 = new ToolStripMenuItem();
            alterarTipoDeMovimentoToolStripMenuItem = new ToolStripMenuItem();
            alteraçãoUnicaToolStripMenuItem = new ToolStripMenuItem();
            alteraçãoEmListaToolStripMenuItem = new ToolStripMenuItem();
            exportarXMLToolStripMenuItem = new ToolStripMenuItem();
            xMLPostoDoLagoToolStripMenuItem = new ToolStripMenuItem();
            contabilToolStripMenuItem = new ToolStripMenuItem();
            importarRecebimentoToolStripMenuItem = new ToolStripMenuItem();
            atualizarGestãoPatrimonialToolStripMenuItem = new ToolStripMenuItem();
            ZanupMenu = new ToolStripMenuItem();
            devoluçaoDeNotasToolStripMenuItem = new ToolStripMenuItem();
            criarNotaZanupToolStripMenuItem = new ToolStripMenuItem();
            gerencialToolStripMenuItem = new ToolStripMenuItem();
            metaComissãoToolStripMenuItem = new ToolStripMenuItem();
            farmaToolStripMenuItem = new ToolStripMenuItem();
            gestãoProcessosToolStripMenuItem = new ToolStripMenuItem();
            campanhasTelevendasToolStripMenuItem = new ToolStripMenuItem();
            criarCampanhaToolStripMenuItem = new ToolStripMenuItem();
            menuBarBottom = new MenuStrip();
            txtVersao = new ToolStripMenuItem();
            Opções = new ToolStripMenuItem();
            alterarCorToolStripMenuItem = new ToolStripMenuItem();
            cadastrarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            alterarTamanhoDaFonteToolStripMenuItem = new ToolStripMenuItem();
            pequenoToolStripMenuItem = new ToolStripMenuItem();
            médioToolStripMenuItem = new ToolStripMenuItem();
            grandeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            txtNomeUsuario = new ToolStripMenuItem();
            menuBarTop.SuspendLayout();
            menuBarBottom.SuspendLayout();
            SuspendLayout();
            // 
            // menuBarTop
            // 
            menuBarTop.BackColor = Color.DarkOrange;
            menuBarTop.ImageScalingSize = new Size(24, 24);
            menuBarTop.Items.AddRange(new ToolStripItem[] { FiscalMenu, contabilToolStripMenuItem, ZanupMenu, gerencialToolStripMenuItem, gestãoProcessosToolStripMenuItem });
            menuBarTop.Location = new Point(0, 0);
            menuBarTop.Name = "menuBarTop";
            menuBarTop.Padding = new Padding(5, 2, 0, 2);
            menuBarTop.Size = new Size(1636, 28);
            menuBarTop.TabIndex = 0;
            menuBarTop.Text = "menuStrip1";
            // 
            // FiscalMenu
            // 
            FiscalMenu.DropDownItems.AddRange(new ToolStripItem[] { importarToolStripMenuItem, importarNotasParaOBigToolStripMenuItem, alteraçõesFiscaisToolStripMenuItem1, exportarXMLToolStripMenuItem });
            FiscalMenu.Name = "FiscalMenu";
            FiscalMenu.ShowShortcutKeys = false;
            FiscalMenu.Size = new Size(59, 24);
            FiscalMenu.Text = "Fiscal";
            // 
            // importarToolStripMenuItem
            // 
            importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            importarToolStripMenuItem.Size = new Size(239, 26);
            importarToolStripMenuItem.Text = "Importar XML Serviço";
            importarToolStripMenuItem.Click += importarToolStripMenuItem_Click;
            // 
            // importarNotasParaOBigToolStripMenuItem
            // 
            importarNotasParaOBigToolStripMenuItem.Name = "importarNotasParaOBigToolStripMenuItem";
            importarNotasParaOBigToolStripMenuItem.Size = new Size(239, 26);
            importarNotasParaOBigToolStripMenuItem.Text = "Exportar Notas do Big";
            importarNotasParaOBigToolStripMenuItem.Click += importarNotasParaOBigToolStripMenuItem_Click;
            // 
            // alteraçõesFiscaisToolStripMenuItem1
            // 
            alteraçõesFiscaisToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { alterarTipoDeMovimentoToolStripMenuItem });
            alteraçõesFiscaisToolStripMenuItem1.Name = "alteraçõesFiscaisToolStripMenuItem1";
            alteraçõesFiscaisToolStripMenuItem1.Size = new Size(239, 26);
            alteraçõesFiscaisToolStripMenuItem1.Text = "Alterações Fiscais";
            // 
            // alterarTipoDeMovimentoToolStripMenuItem
            // 
            alterarTipoDeMovimentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alteraçãoUnicaToolStripMenuItem, alteraçãoEmListaToolStripMenuItem });
            alterarTipoDeMovimentoToolStripMenuItem.Name = "alterarTipoDeMovimentoToolStripMenuItem";
            alterarTipoDeMovimentoToolStripMenuItem.Size = new Size(224, 26);
            alterarTipoDeMovimentoToolStripMenuItem.Text = "Alterações Fiscais";
            // 
            // alteraçãoUnicaToolStripMenuItem
            // 
            alteraçãoUnicaToolStripMenuItem.Name = "alteraçãoUnicaToolStripMenuItem";
            alteraçãoUnicaToolStripMenuItem.Size = new Size(224, 26);
            alteraçãoUnicaToolStripMenuItem.Text = "Alteração unica";
            alteraçãoUnicaToolStripMenuItem.Click += alteraçãoUnicaToolStripMenuItem_Click;
            // 
            // alteraçãoEmListaToolStripMenuItem
            // 
            alteraçãoEmListaToolStripMenuItem.Name = "alteraçãoEmListaToolStripMenuItem";
            alteraçãoEmListaToolStripMenuItem.Size = new Size(224, 26);
            alteraçãoEmListaToolStripMenuItem.Text = "Alteração em lista";
            alteraçãoEmListaToolStripMenuItem.Click += alteraçãoEmListaToolStripMenuItem_Click;
            // 
            // exportarXMLToolStripMenuItem
            // 
            exportarXMLToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xMLPostoDoLagoToolStripMenuItem });
            exportarXMLToolStripMenuItem.Name = "exportarXMLToolStripMenuItem";
            exportarXMLToolStripMenuItem.Size = new Size(239, 26);
            exportarXMLToolStripMenuItem.Text = "Exportar XML ";
            // 
            // xMLPostoDoLagoToolStripMenuItem
            // 
            xMLPostoDoLagoToolStripMenuItem.Name = "xMLPostoDoLagoToolStripMenuItem";
            xMLPostoDoLagoToolStripMenuItem.Size = new Size(224, 26);
            xMLPostoDoLagoToolStripMenuItem.Text = "XML Posto do Lago";
            xMLPostoDoLagoToolStripMenuItem.Click += xMLPostoDoLagoToolStripMenuItem_Click;
            // 
            // contabilToolStripMenuItem
            // 
            contabilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importarRecebimentoToolStripMenuItem, atualizarGestãoPatrimonialToolStripMenuItem });
            contabilToolStripMenuItem.Name = "contabilToolStripMenuItem";
            contabilToolStripMenuItem.Size = new Size(79, 24);
            contabilToolStripMenuItem.Text = "Contabil";
            // 
            // importarRecebimentoToolStripMenuItem
            // 
            importarRecebimentoToolStripMenuItem.Name = "importarRecebimentoToolStripMenuItem";
            importarRecebimentoToolStripMenuItem.Size = new Size(280, 26);
            importarRecebimentoToolStripMenuItem.Text = "Importar Recebimento";
            // 
            // atualizarGestãoPatrimonialToolStripMenuItem
            // 
            atualizarGestãoPatrimonialToolStripMenuItem.Name = "atualizarGestãoPatrimonialToolStripMenuItem";
            atualizarGestãoPatrimonialToolStripMenuItem.Size = new Size(280, 26);
            atualizarGestãoPatrimonialToolStripMenuItem.Text = "Atualizar Gestão Patrimonial";
            // 
            // ZanupMenu
            // 
            ZanupMenu.DropDownItems.AddRange(new ToolStripItem[] { devoluçaoDeNotasToolStripMenuItem, criarNotaZanupToolStripMenuItem });
            ZanupMenu.Enabled = false;
            ZanupMenu.Name = "ZanupMenu";
            ZanupMenu.Size = new Size(65, 24);
            ZanupMenu.Text = "Zanup";
            // 
            // devoluçaoDeNotasToolStripMenuItem
            // 
            devoluçaoDeNotasToolStripMenuItem.Name = "devoluçaoDeNotasToolStripMenuItem";
            devoluçaoDeNotasToolStripMenuItem.Size = new Size(224, 26);
            devoluçaoDeNotasToolStripMenuItem.Text = "Devoluçao de notas";
            // 
            // criarNotaZanupToolStripMenuItem
            // 
            criarNotaZanupToolStripMenuItem.Name = "criarNotaZanupToolStripMenuItem";
            criarNotaZanupToolStripMenuItem.Size = new Size(224, 26);
            criarNotaZanupToolStripMenuItem.Text = "Criar Nota Zanup";
            // 
            // gerencialToolStripMenuItem
            // 
            gerencialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { metaComissãoToolStripMenuItem });
            gerencialToolStripMenuItem.Name = "gerencialToolStripMenuItem";
            gerencialToolStripMenuItem.Size = new Size(85, 24);
            gerencialToolStripMenuItem.Text = "Gerencial";
            // 
            // metaComissãoToolStripMenuItem
            // 
            metaComissãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { farmaToolStripMenuItem });
            metaComissãoToolStripMenuItem.Name = "metaComissãoToolStripMenuItem";
            metaComissãoToolStripMenuItem.Size = new Size(194, 26);
            metaComissãoToolStripMenuItem.Text = "Meta Comissão";
            // 
            // farmaToolStripMenuItem
            // 
            farmaToolStripMenuItem.Name = "farmaToolStripMenuItem";
            farmaToolStripMenuItem.Size = new Size(132, 26);
            farmaToolStripMenuItem.Text = "Farma";
            // 
            // gestãoProcessosToolStripMenuItem
            // 
            gestãoProcessosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { campanhasTelevendasToolStripMenuItem });
            gestãoProcessosToolStripMenuItem.Name = "gestãoProcessosToolStripMenuItem";
            gestãoProcessosToolStripMenuItem.Size = new Size(137, 24);
            gestãoProcessosToolStripMenuItem.Text = "Gestão Processos";
            // 
            // campanhasTelevendasToolStripMenuItem
            // 
            campanhasTelevendasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarCampanhaToolStripMenuItem });
            campanhasTelevendasToolStripMenuItem.Name = "campanhasTelevendasToolStripMenuItem";
            campanhasTelevendasToolStripMenuItem.Size = new Size(246, 26);
            campanhasTelevendasToolStripMenuItem.Text = "Campanhas Televendas";
            // 
            // criarCampanhaToolStripMenuItem
            // 
            criarCampanhaToolStripMenuItem.Name = "criarCampanhaToolStripMenuItem";
            criarCampanhaToolStripMenuItem.Size = new Size(198, 26);
            criarCampanhaToolStripMenuItem.Text = "Criar Campanha";
            // 
            // menuBarBottom
            // 
            menuBarBottom.BackColor = Color.DarkOrange;
            menuBarBottom.Dock = DockStyle.Bottom;
            menuBarBottom.ImageScalingSize = new Size(24, 24);
            menuBarBottom.Items.AddRange(new ToolStripItem[] { txtVersao, Opções, toolStripMenuItem4, txtNomeUsuario });
            menuBarBottom.Location = new Point(0, 847);
            menuBarBottom.Name = "menuBarBottom";
            menuBarBottom.Padding = new Padding(5, 2, 0, 2);
            menuBarBottom.Size = new Size(1636, 28);
            menuBarBottom.TabIndex = 1;
            menuBarBottom.Text = "menuStrip2";
            // 
            // txtVersao
            // 
            txtVersao.Name = "txtVersao";
            txtVersao.Size = new Size(67, 24);
            txtVersao.Text = "Versão";
            txtVersao.Click += txtVersao_Click;
            // 
            // Opções
            // 
            Opções.DropDownItems.AddRange(new ToolStripItem[] { alterarCorToolStripMenuItem, cadastrarUsuarioToolStripMenuItem, alterarTamanhoDaFonteToolStripMenuItem });
            Opções.Name = "Opções";
            Opções.Size = new Size(73, 24);
            Opções.Text = "Opções";
            // 
            // alterarCorToolStripMenuItem
            // 
            alterarCorToolStripMenuItem.Name = "alterarCorToolStripMenuItem";
            alterarCorToolStripMenuItem.Size = new Size(263, 26);
            alterarCorToolStripMenuItem.Text = "Alterar Cor";
            alterarCorToolStripMenuItem.Click += alterarCorToolStripMenuItem_Click;
            // 
            // cadastrarUsuarioToolStripMenuItem
            // 
            cadastrarUsuarioToolStripMenuItem.Name = "cadastrarUsuarioToolStripMenuItem";
            cadastrarUsuarioToolStripMenuItem.Size = new Size(263, 26);
            cadastrarUsuarioToolStripMenuItem.Text = "Cadastrar usuario";
            // 
            // alterarTamanhoDaFonteToolStripMenuItem
            // 
            alterarTamanhoDaFonteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pequenoToolStripMenuItem, médioToolStripMenuItem, grandeToolStripMenuItem });
            alterarTamanhoDaFonteToolStripMenuItem.Name = "alterarTamanhoDaFonteToolStripMenuItem";
            alterarTamanhoDaFonteToolStripMenuItem.Size = new Size(263, 26);
            alterarTamanhoDaFonteToolStripMenuItem.Text = "Alterar Tamanho da Fonte";
            // 
            // pequenoToolStripMenuItem
            // 
            pequenoToolStripMenuItem.Name = "pequenoToolStripMenuItem";
            pequenoToolStripMenuItem.Size = new Size(149, 26);
            pequenoToolStripMenuItem.Text = "Pequeno";
            pequenoToolStripMenuItem.Click += pequenoToolStripMenuItem_Click;
            // 
            // médioToolStripMenuItem
            // 
            médioToolStripMenuItem.Name = "médioToolStripMenuItem";
            médioToolStripMenuItem.Size = new Size(149, 26);
            médioToolStripMenuItem.Text = "Médio";
            médioToolStripMenuItem.Click += médioToolStripMenuItem_Click;
            // 
            // grandeToolStripMenuItem
            // 
            grandeToolStripMenuItem.Name = "grandeToolStripMenuItem";
            grandeToolStripMenuItem.Size = new Size(149, 26);
            grandeToolStripMenuItem.Text = "Grande";
            grandeToolStripMenuItem.Click += grandeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem5 });
            toolStripMenuItem4.Enabled = false;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(79, 24);
            toolStripMenuItem4.Text = "Contabil";
            toolStripMenuItem4.Visible = false;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(213, 26);
            toolStripMenuItem5.Text = "Alterar conta frete";
            // 
            // txtNomeUsuario
            // 
            txtNomeUsuario.Name = "txtNomeUsuario";
            txtNomeUsuario.Size = new Size(116, 24);
            txtNomeUsuario.Text = "Nome usuario";
            // 
            // Portal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1636, 875);
            Controls.Add(menuBarBottom);
            Controls.Add(menuBarTop);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuBarTop;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Portal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controladoria";
            WindowState = FormWindowState.Maximized;
            Shown += Portal_Shown;
            menuBarTop.ResumeLayout(false);
            menuBarTop.PerformLayout();
            menuBarBottom.ResumeLayout(false);
            menuBarBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBarTop;
        private System.Windows.Forms.ToolStripMenuItem FiscalMenu;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarNotasParaOBigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contabilToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuBarBottom;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem Opções;
        private System.Windows.Forms.ToolStripMenuItem alterarCorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtVersao;
        private System.Windows.Forms.ToolStripMenuItem alteraçõesFiscaisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alterarTipoDeMovimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZanupMenu;
        private System.Windows.Forms.ToolStripMenuItem devoluçaoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarRecebimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarGestãoPatrimonialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraçãoUnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraçãoEmListaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLPostoDoLagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarTamanhoDaFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pequenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtNomeUsuario;
        private System.Windows.Forms.ToolStripMenuItem gerencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metaComissãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarNotaZanupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoProcessosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campanhasTelevendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarCampanhaToolStripMenuItem;
    }
}