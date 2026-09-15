using OrdensDeServico.Presenters;
using System;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Tecnicos
{
    public partial class FrmListar : Form
    {
        private TecnicoPresenter presenter;

        public FrmListar()
        {
            InitializeComponent();
            presenter = new TecnicoPresenter();
            CarregarTecnicos();
        }

        public void CarregarTecnicos()
        {
            flpTecnicos.Controls.Clear();
            var lista = presenter.Buscar(txtBusca.Text);

            foreach (var tecnico in lista)
            {
                var ctr = new TecnicoCtr(this, presenter, tecnico);
                flpTecnicos.Controls.Add(ctr);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CarregarTecnicos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastrar c = new FrmCadastrar(presenter);
            c.ShowDialog();
            CarregarTecnicos();
        }
    }
}

