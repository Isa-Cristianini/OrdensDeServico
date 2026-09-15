namespace OrdensDeServico.Views.Tecnicos
{
    partial class FrmCadastrar
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
            lblNome = new Label();
            label1 = new Label();
            txtNome = new TextBox();
            txtEspecialidade = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 92);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 1;
            label1.Text = "Especialidade:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(47, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(306, 23);
            txtNome.TabIndex = 2;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Location = new Point(47, 129);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.Size = new Size(306, 23);
            txtEspecialidade.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(265, 200);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 33);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // FrmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 260);
            Controls.Add(btnSalvar);
            Controls.Add(txtEspecialidade);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Name = "FrmCadastrar";
            Text = "FrmCadastrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtEspecialidade;
        private Button btnSalvar;
    }
}