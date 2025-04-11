using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static tarefas.DAO;

namespace tarefas
{
    public partial class Home : Form
    {
        DAO dao;

        public Home()
        {
            InitializeComponent();
            dao = new DAO();
        }

        private void CarregarTarefas()
        {
            DAO dao = new DAO();
            List<Tarefa> lista = dao.ListarTarefas();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        private void home_Load(object sender, EventArgs e)
        {
            CarregarTarefas();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                Tarefa tarefaSelecionada = (Tarefa)dataGridView1.Rows[index].DataBoundItem;

                // Agora edite os dados dessa tarefa, por exemplo:
                tarefaSelecionada.titulo = "Novo título";
                tarefaSelecionada.descricao = "Nova descrição";
                tarefaSelecionada.data = "2025-04-11";
                tarefaSelecionada.prioridade = "Alta";

                DAO dao = new DAO();
                dao.AtualizarTarefa(tarefaSelecionada);

                MessageBox.Show("Tarefa atualizada com sucesso!");
                CarregarTarefas(); // Atualiza o DataGridView
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para editar.");
            }
        }



        private void Home_Load(object sender, EventArgs e)
        {
            var tarefas = dao.ListarTarefas();
            flowLayoutPanel1.Controls.Clear();

            Panel header = new Panel
            {
                Size = new Size(1450, 100),
                BackColor = Color.FromArgb(42, 63, 102),
                Location = new Point(0, 0)
            };

            PictureBox pictureBoxLogo = new PictureBox
            {
                Size = new Size(80, 80),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(20, 10)
            };

            header.Controls.Add(pictureBoxLogo);
            this.Controls.Add(header);

            flowLayoutPanel1.Location = new Point(0, header.Bottom + 10);
            flowLayoutPanel1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - header.Height - 10);
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Padding = new Padding(70, 10, 10, 10);
            flowLayoutPanel1.BackColor = Color.White;

            Label lblTitulo = new Label
            {
                Text = "Tarefas Pendentes",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.FromArgb(42, 63, 102),
                Margin = new Padding(0, 10, 0, 20),
                AutoSize = true
            };
            flowLayoutPanel1.Controls.Add(lblTitulo);

            foreach (var tarefa in tarefas)
            {
                Panel painel = new Panel
                {
                    Size = new Size(1450, 50),
                    BackColor = Color.FromArgb(42, 63, 102),
                    Margin = new Padding(0, 10, 0, 0)
                };

                Label lblTituloTarefa = new Label
                {
                    Text = tarefa.titulo,
                    Font = new Font("Segoe UI", 18, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location = new Point(70, 7),
                    AutoSize = true
                };

                Label lblDescricao = new Label
                {
                    Text = tarefa.descricao.Length > 20 ? tarefa.descricao.Substring(0, 20) + "..." : tarefa.descricao,
                    ForeColor = Color.White,
                    Location = new Point(360, 18),
                    AutoSize = true
                };

                Button btnVisualizar = new Button
                {
                    Text = "Visualizar",
                    BackColor = Color.White,
                    Location = new Point(1100, 9)
                };
                btnVisualizar.Click += (s, ev) => { new VisualizarTarefa(tarefa).ShowDialog(); };

                Button btnExcluir = new Button
                {
                    Text = "Excluir",
                    BackColor = Color.White,
                    Location = new Point(1250, 9)
                };
                btnExcluir.Click += (s, ev) =>
                {
                    dao.Excluir(tarefa.id);
                    MessageBox.Show("Tarefa excluída.");
                    Home_Load(null, null);
                };

                painel.Controls.Add(lblTituloTarefa);
                painel.Controls.Add(lblDescricao);
                painel.Controls.Add(btnVisualizar);
                painel.Controls.Add(btnExcluir);

                flowLayoutPanel1.Controls.Add(painel);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
