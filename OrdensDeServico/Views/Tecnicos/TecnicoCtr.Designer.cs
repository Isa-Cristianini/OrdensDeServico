namespace OrdensDeServico.Views.Tecnicos
{
    partial class TecnicoCtr
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
            lblNome = new Label();
            lblEspecialidade = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Location = new Point(9, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(238, 23);
            lblNome.TabIndex = 0;
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.Location = new Point(9, 57);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(238, 23);
            lblEspecialidade.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(27, 101);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(147, 101);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(80, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // TecnicoCtr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(lblEspecialidade);
            Controls.Add(lblNome);
            Name = "TecnicoCtr";
            Size = new Size(250, 144);
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private Label lblEspecialidade;
        private Button btnEditar;
        private Button btnExcluir;
    }
}
