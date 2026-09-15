using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Clientes
{
    public partial class FrmEditar : Form
    {
        private Label lblNome;
        private TextBox txtNome;
        private Label lblTelefone;
        private TextBox txtTelefone;
        private Button btSalvar;

        

        private void InitializeComponent()
        {
            this.lblNome = new Label();
            this.txtNome = new TextBox();
            this.lblTelefone = new Label();
            this.txtTelefone = new TextBox();
            this.btSalvar = new Button();

            this.SuspendLayout();

            this.Size = new Size(340, 230);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Label Nome
            this.lblNome.Text = "Nome:";
            this.lblNome.Location = new Point(20, 20);
            this.lblNome.AutoSize = true;

            // TextBox Nome
            this.txtNome.Location = new Point(20, 40);
            this.txtNome.Size = new Size(280, 23);

            // Label Telefone
            this.lblTelefone.Text = "Telefone:";
            this.lblTelefone.Location = new Point(20, 75);
            this.lblTelefone.AutoSize = true;

            // TextBox Telefone
            this.txtTelefone.Location = new Point(20, 95);
            this.txtTelefone.Size = new Size(280, 23);

            // Botão Salvar
            this.btSalvar.Text = "Salvar Alterações";
            this.btSalvar.Location = new Point(160, 140);
            this.btSalvar.Size = new Size(140, 32);
            this.btSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.btSalvar.Click += btSalvar_Click;

            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.btSalvar);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        
    }
}