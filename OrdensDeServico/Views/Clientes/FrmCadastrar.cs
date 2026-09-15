using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using System;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Tecnicos
{
    public partial class FrmCadastrar : Form
    {
        private readonly TecnicoPresenter presenter;

        public FrmCadastrar(TecnicoPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var tecnico = new Tecnico
            {
                Nome = txtNome.Text,
                Especialidade = txtEspecialidade.Text
            };

            if (presenter.Cadastrar(tecnico))
            {
                MessageBox.Show("Técnico cadastrado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar técnico.");
            }
        }
    }
}
