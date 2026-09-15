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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.Location = new Point(9, 13);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(238, 23);
            lblNome.TabIndex = 0;
            lblNome.Click += label1_Click;
            // 
            // lblEspecialidade
            // 
            lblEspecialidade.Location = new Point(9, 57);
            lblEspecialidade.Name = "lblEspecialidade";
            lblEspecialidade.Size = new Size(238, 23);
            lblEspecialidade.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(26, 113);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(151, 113);
            button2.Name = "button2";
            button2.Size = new Size(80, 23);
            button2.TabIndex = 3;
            button2.Text = "Remover";
            button2.UseVisualStyleBackColor = true;
            // 
            // TecnicoCtr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblEspecialidade);
            Controls.Add(lblNome);
            Name = "TecnicoCtr";
            Size = new Size(250, 158);
            ResumeLayout(false);
        }

        #endregion

        private Label lblNome;
        private Label lblEspecialidade;
        private Button button1;
        private Button button2;
    }
}
