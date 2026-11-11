namespace SolfarmaGp.UI.MenusUI.Fiscal.BaseCheia
{
    partial class ArrumaBaseCheia
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
            components = new System.ComponentModel.Container();
            dataInicio = new DateTimePicker();
            dataFim = new DateTimePicker();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            btnExecutar = new Button();
            btnCancelar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            rtbInformacao = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataInicio
            // 
            dataInicio.Format = DateTimePickerFormat.Short;
            dataInicio.Location = new Point(10, 55);
            dataInicio.Name = "dataInicio";
            dataInicio.Size = new Size(162, 31);
            dataInicio.TabIndex = 0;
            // 
            // dataFim
            // 
            dataFim.Format = DateTimePickerFormat.Short;
            dataFim.Location = new Point(210, 55);
            dataFim.Name = "dataFim";
            dataFim.Size = new Size(162, 31);
            dataFim.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataInicio);
            groupBox1.Controls.Add(dataFim);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 99);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Período para Atualização";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 27);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 3;
            label2.Text = "Data Final";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 27);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 2;
            label1.Text = "Data Inicial";
            label1.Click += label1_Click;
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(72, 276);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(112, 34);
            btnExecutar.TabIndex = 3;
            btnExecutar.Text = "Executar";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(222, 276);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // rtbInformacao
            // 
            rtbInformacao.BackColor = SystemColors.HighlightText;
            rtbInformacao.Location = new Point(12, 133);
            rtbInformacao.Name = "rtbInformacao";
            rtbInformacao.Size = new Size(392, 79);
            rtbInformacao.TabIndex = 6;
            rtbInformacao.Text = "Processo para recalcular as planilhas 11 e 19 dentro da TOTVS RM";
            rtbInformacao.TextChanged += richTextBox1_TextChanged;
            // 
            // ArrumaBaseCheia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 328);
            Controls.Add(rtbInformacao);
            Controls.Add(btnCancelar);
            Controls.Add(btnExecutar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ArrumaBaseCheia";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Recalcular Base Cheia";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dataInicio;
        private DateTimePicker dataFim;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button btnExecutar;
        private Button btnCancelar;
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox rtbInformacao;
    }
}