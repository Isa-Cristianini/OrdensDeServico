using OrdensDeServico.Models;
using OrdensDeServico.Presenters;
using System;
using System.Windows.Forms;

namespace OrdensDeServico.Views.Tecnicos
{
    public partial class TecnicoOrdemCtr : UserControl
    {
        private readonly OrdemServico ordemServico;
        private readonly TecnicoPresenter presenter;
        private readonly FrmEditar frmEditar;

        public TecnicoOrdemCtr(FrmEditar frmEditar, TecnicoPresenter presenter, OrdemServico ordemServico)
        {
            InitializeComponent();
            this.frmEditar = frmEditar;
            this.presenter = presenter;
            this.ordemServico = ordemServico;

            CarregarDados();
        }

        private void CarregarDados()
        {
           
            lblDescricao.Text = ordemServico.DescricaoProblema;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Em andamento");
            cmbStatus.Items.Add("Pendente");
            cmbStatus.Items.Add("Concluído");
            cmbStatus.Items.Add("Cancelado");

            if (cmbStatus.Items.Contains(ordemServico.Status))
            {
                cmbStatus.SelectedItem = ordemServico.Status;
            }
            else
            {
                cmbStatus.Text = ordemServico.Status;
            }
        }

        // Evento do botão Confirmar (btnConfirmar) presente dentro do UserControl TecnicoOrdemCtr
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string novoStatus = cmbStatus.SelectedItem as string;

            if (string.IsNullOrEmpty(novoStatus))
            {
                MessageBox.Show("Selecione um status válido.");
                return;
            }

            // A alteração no banco de dados SÓ ocorre aqui, ao clicar no botão Confirmar
            if (presenter.AtualizarStatusOrdem(ordemServico.Id, novoStatus))
            {
                MessageBox.Show($"Status da Ordem #{ordemServico.Id} atualizado para '{novoStatus}'!");

                // Se mudou para Concluído ou Cancelado, recarrega a lista do FrmEditar para ocultar esta OS
                if (novoStatus == "Concluído" || novoStatus == "Cancelado")
                {
                    frmEditar.CarregarOrdensDoTecnico();
                }
            }
            else
            {
                MessageBox.Show("Erro ao atualizar o status da Ordem de Serviço.");
            }
        }
    }
}