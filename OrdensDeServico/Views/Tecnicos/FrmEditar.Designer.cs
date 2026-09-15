namespace OrdensDeServico.Views.Tecnicos
{
    partial class FrmEditar
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
            txtNome = new TextBox();
            txtEspecialidade = new TextBox();
            flpOrdens = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(285, 23);
            txtNome.TabIndex = 0;
            // 
            // txtEspecialidade
            // 
            txtEspecialidade.Location = new Point(100, 50);
            txtEspecialidade.Name = "txtEspecialidade";
            txtEspecialidade.Size = new Size(285, 23);
            txtEspecialidade.TabIndex = 1;
            // 
            // flpOrdens
            // 
            flpOrdens.Location = new Point(-1, 104);
            flpOrdens.Name = "flpOrdens";
            flpOrdens.Size = new Size(429, 173);
            flpOrdens.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 53);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Especialidade:";
            // 
            // FrmEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 346);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flpOrdens);
            Controls.Add(txtEspecialidade);
            Controls.Add(txtNome);
            Name = "FrmEditar";
            Text = "FrmEditar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtEspecialidade;
        private FlowLayoutPanel flpOrdens;
        private Label label1;
        private Label label2;
    }
}