namespace OrdensDeServico.Views.Tecnicos
{
    partial class FrmListar
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
            txtBusca = new TextBox();
            btnNovo = new Button();
            btnBuscar = new Button();
            flpTecnicos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(12, 14);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(368, 23);
            txtBusca.TabIndex = 0;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNovo.Location = new Point(194, 400);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(121, 29);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "+Novo Técnico";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(386, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(116, 27);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // flpTecnicos
            // 
            flpTecnicos.AutoScroll = true;
            flpTecnicos.Location = new Point(0, 45);
            flpTecnicos.Name = "flpTecnicos";
            flpTecnicos.Size = new Size(534, 336);
            flpTecnicos.TabIndex = 3;
            // 
            // FrmListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(514, 441);
            Controls.Add(flpTecnicos);
            Controls.Add(btnBuscar);
            Controls.Add(btnNovo);
            Controls.Add(txtBusca);
            MaximizeBox = false;
            Name = "FrmListar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Técnicos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusca;
        private Button btnNovo;
        private Button btnBuscar;
        private FlowLayoutPanel flpTecnicos;
    }
}