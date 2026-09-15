using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using System;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Tecnicos
{
    public partial class FrmEditar : Form
    {
        private readonly TecnicoPresenter presenter;
        private readonly Tecnico tecnico;

        public FrmEditar(TecnicoPresenter presenter, Tecnico tecnico)
        {
            InitializeComponent();
            this.presenter = presenter;
            this.tecnico = tecnico;

            PreencherCampos();
            CarregarOrdensDoTecnico();
        }

        private void PreencherCampos()
        {
            txtNome.Text = tecnico.Nome;
            txtEspecialidade.Text = tecnico.Especialidade;
        }

        public void CarregarOrdensDoTecnico()
        {
            flpOrdens.Controls.Clear();

            // Busca ordens com status diferente de "Concluído" e "Cancelado"
            var ordensAtivas = presenter.ObterOrdensAtivasDoTecnico(tecnico.Id);

            foreach (var ordem in ordensAtivas)
            {
                var ctr = new TecnicoOrdemCtr(this, presenter, ordem);
                flpOrdens.Controls.Add(ctr);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            tecnico.Nome = txtNome.Text;
            tecnico.Especialidade = txtEspecialidade.Text;

            if (presenter.Editar(tecnico))
            {
                MessageBox.Show("Técnico atualizado com sucesso!");
                Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar dados do técnico.");
            }
        }
    }
}