using System;
using System.Windows.Forms;

namespace tarefas
{
    public partial class VisualizarTarefa : Form
    {
        public VisualizarTarefa(DAO.Tarefa tarefa)
        {
            InitializeComponent();

            lblTitulo.Text = tarefa.titulo;
            lblDescricao.Text = tarefa.descricao;
            lblData.Text = tarefa.data;
            lblPrioridade.Text = tarefa.prioridade;
        }
    }
}
