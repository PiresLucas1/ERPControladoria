namespace SolfarmaGp.UI.MenusUI.Fiscal.Gerenciar
{
    partial class AlteracaoDePeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlteracaoDePeriodo));
            dtpInicio = new DateTimePicker();
            dtpFim = new DateTimePicker();
            lbDtInicio = new Label();
            lbDataFim = new Label();
            btnConfirmar = new Button();
            richTextBox1 = new RichTextBox();
            lbStatus = new Label();
            cbStatus = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(26, 65);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(117, 27);
            dtpInicio.TabIndex = 0;
            // 
            // dtpFim
            // 
            dtpFim.Format = DateTimePickerFormat.Short;
            dtpFim.Location = new Point(26, 150);
            dtpFim.Name = "dtpFim";
            dtpFim.Size = new Size(117, 27);
            dtpFim.TabIndex = 1;
            // 
            // lbDtInicio
            // 
            lbDtInicio.AutoSize = true;
            lbDtInicio.Location = new Point(26, 27);
            lbDtInicio.Name = "lbDtInicio";
            lbDtInicio.Size = new Size(84, 20);
            lbDtInicio.TabIndex = 2;
            lbDtInicio.Text = "Data inicio:";
            // 
            // lbDataFim
            // 
            lbDataFim.AutoSize = true;
            lbDataFim.Location = new Point(26, 110);
            lbDataFim.Name = "lbDataFim";
            lbDataFim.Size = new Size(72, 20);
            lbDataFim.TabIndex = 3;
            lbDataFim.Text = "Data Fim:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(414, 364);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(101, 32);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            richTextBox1.Location = new Point(216, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(314, 231);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(26, 195);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(52, 20);
            lbStatus.TabIndex = 6;
            lbStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(26, 227);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(151, 28);
            cbStatus.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(14, 37);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(117, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Enabled = false;
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(181, 37);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(117, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(12, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 127);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Periodo Ativo:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(14, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 27);
            textBox1.TabIndex = 13;
            // 
            // AlteracaoDePeriodo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 419);
            Controls.Add(richTextBox1);
            Controls.Add(lbStatus);
            Controls.Add(cbStatus);
            Controls.Add(btnConfirmar);
            Controls.Add(lbDataFim);
            Controls.Add(lbDtInicio);
            Controls.Add(dtpFim);
            Controls.Add(dtpInicio);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "AlteracaoDePeriodo";
            Text = "AlteraçãoDePeriodo";
            Load += AlteracaoDePeriodo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFim;
        private Label lbDtInicio;
        private Label lbDataFim;
        private Button btnConfirmar;
        private RichTextBox richTextBox1;
        private Label lbStatus;
        private ComboBox cbStatus;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}