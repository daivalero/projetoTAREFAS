using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

        private void Home_Load(object sender, EventArgs e)
        {
            var tarefas = dao.ListarTarefas();
            flowLayoutPanel1.Controls.Clear();

            // Painel do cabeçalho
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

            string caminhoImagem = Path.Combine(Application.StartupPath, "logo.png");
            if (File.Exists(caminhoImagem))
            {
                pictureBoxLogo.Image = Image.FromFile(caminhoImagem);
            }
            else
            {
                MessageBox.Show("Imagem não encontrada: " + caminhoImagem);
            }

            Label lblNomeApp = new Label
            {
                Text = "✓ MyTasker",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(120, 30),
                AutoSize = true
            };

            header.Controls.Add(pictureBoxLogo);
            header.Controls.Add(lblNomeApp);
            this.Controls.Add(header);

            // Ajustar posição do flowLayoutPanel abaixo do header
            flowLayoutPanel1.Location = new Point(0, header.Bottom + 10);
            flowLayoutPanel1.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - header.Height - 10);
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.Padding = new Padding(70, 10, 10, 10);
            flowLayoutPanel1.BackColor = Color.White;

            // Título "Todas as Tarefas"
            Label lblTitulo = new Label
            {
                Text = "Todas as Tarefas",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                ForeColor = Color.FromArgb(42, 63, 102),
                Margin = new Padding(0, 10, 0, 20),
                AutoSize = true
            };
            flowLayoutPanel1.Controls.Add(lblTitulo);

            // Lista das tarefas
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
    }
}
