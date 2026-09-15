using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OrdensDeServico.Models;
using OrdensDeServico.Presenters;

namespace OrdensDeServico.Views.Tecnicos
{
    public partial class FrmCadastrar : Form
    {
        private TecnicoPresenter presenter;

        public FrmCadastrar()
        {
            InitializeComponent();
            this.presenter = new TecnicoPresenter();
        }

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
