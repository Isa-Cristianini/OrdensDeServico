using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using System;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Tecnicos
{
    public partial class TecnicoCtr : UserControl
    {
        private readonly FrmListar frmListar;
        private readonly TecnicoPresenter presenter;
        private readonly Tecnico tecnico;

        public TecnicoCtr(FrmListar frmListar, TecnicoPresenter presenter, Tecnico tecnico)
        {
            InitializeComponent();
            this.frmListar = frmListar;
            this.presenter = presenter;
            this.tecnico = tecnico;

            // Atribuir dados aos Labels na interface
            lblNome.Text = tecnico.Nome;
            lblEspecialidade.Text = tecnico.Especialidade;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            FrmEditar frm = new FrmEditar(presenter, tecnico);
            frm.ShowDialog();
            frmListar.CarregarTecnicos();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja excluir o técnico {tecnico.Nome}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (presenter.Remover(tecnico))
                {
                    MessageBox.Show("Técnico removido com sucesso!");
                    frmListar.CarregarTecnicos();
                }
                else
                {
                    MessageBox.Show("Não foi possível remover o técnico.");
                }
            }
        }

        private void lblEspecialidade_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
