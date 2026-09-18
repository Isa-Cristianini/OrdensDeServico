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
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(3, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(238, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Qualquer Texto em negrito";
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.Location = new Point(21, 60);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(224, 23);
            lblEspecialidade.TabIndex = 1;
            lblEspecialidade.Text = "Qualquer Texto";
            lblEspecialidade.Click += lblEspecialidade_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(32, 101);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(133, 101);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(80, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "&Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 45);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 4;
            label1.Text = "Especialidade:";
            label1.Click += label1_Click;
            // 
            // TecnicoCtr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(lblEspecialidade);
            Controls.Add(lblNome);
            Name = "TecnicoCtr";
            Size = new Size(254, 144);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblEspecialidade;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label1;
    }
}
