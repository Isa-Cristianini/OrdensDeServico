namespace OrdensDeServico.Views.Tecnicos
{
    partial class TecnicoOrdemCtr
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDescricao = new Label();
            cmbStatus = new ComboBox();
            SuspendLayout();
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(25, 44);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(115, 15);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Descrição da ordem:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(25, 87);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 1;
            // 
            // TecnicoOrdemCtr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbStatus);
            Controls.Add(lblDescricao);
            Name = "TecnicoOrdemCtr";
            Size = new Size(311, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDescricao;
        private ComboBox cmbStatus;
    }
}
