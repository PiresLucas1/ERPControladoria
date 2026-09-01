namespace SolfarmaGp.UI.ComponentesTelaUI
{
    partial class ResultadosEmTela
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
            pnlContainer = new Panel();
            btnOk = new Button();
            SuspendLayout();
            //
            // pnlContainer
            //
            pnlContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContainer.AutoScroll = true;
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Location = new Point(12, 12);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(486, 460);
            pnlContainer.TabIndex = 0;
            //
            // btnOk
            //
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(398, 484);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(102, 36);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            //
            // ResultadosEmTela
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 532);
            Controls.Add(btnOk);
            Controls.Add(pnlContainer);
            Name = "ResultadosEmTela";
            Text = "Resultados";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private Button btnOk;
    }
}
