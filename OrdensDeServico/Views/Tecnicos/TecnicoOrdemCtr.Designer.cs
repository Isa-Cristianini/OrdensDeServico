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
            btnConfirmarStatus = new Button();
            SuspendLayout();
            // 
            // lblDescricao
            // 
            lblDescricao.Location = new Point(17, 32);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(437, 63);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Descrição da ordem:";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(53, 98);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(183, 23);
            cmbStatus.TabIndex = 1;
            // 
            // btnConfirmarStatus
            // 
            btnConfirmarStatus.Location = new Point(279, 98);
            btnConfirmarStatus.Name = "btnConfirmarStatus";
            btnConfirmarStatus.Size = new Size(111, 24);
            btnConfirmarStatus.TabIndex = 2;
            btnConfirmarStatus.Text = "Confirmar";
            btnConfirmarStatus.UseVisualStyleBackColor = true;
            btnConfirmarStatus.Click += btnConfirmar_Click;
            // 
            // TecnicoOrdemCtr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(btnConfirmarStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblDescricao);
            Name = "TecnicoOrdemCtr";
            Size = new Size(480, 150);
            ResumeLayout(false);
        }

        #endregion

        private Label lblDescricao;
        private ComboBox cmbStatus;
        private Button btnConfirmarStatus;
    }
}
