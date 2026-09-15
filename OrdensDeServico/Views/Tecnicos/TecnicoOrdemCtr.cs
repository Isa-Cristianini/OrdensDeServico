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
            // Exibe a descrição da ordem (ou detalhe da OS)
            lblDescricao.Text = ordemServico.Descricao; // Ajuste conforme a propriedade do seu Model

            // Configurar itens do ComboBox conforme especificação da imagem
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Em andamento");
            cmbStatus.Items.Add("Pendente");
            cmbStatus.Items.Add("Concluído");
            cmbStatus.Items.Add("Cancelado");

            // Define o item selecionado atual
            if (cmbStatus.Items.Contains(ordemServico.Status))
            {
                cmbStatus.SelectedItem = ordemServico.Status;
            }
            else
            {
                cmbStatus.Text = ordemServico.Status;
            }

            // Adiciona o evento de alteração após preencher os dados iniciais
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string novoStatus = cmbStatus.SelectedItem as string;

            if (!string.IsNullOrEmpty(novoStatus))
            {
                // Atualiza o objeto e salva a alteração no banco
                if (presenter.AtualizarStatusOrdem(ordemServico.Id, novoStatus))
                {
                    // Se o status for alterado para Concluído ou Cancelado, atualiza a lista no FrmEditar
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
}
