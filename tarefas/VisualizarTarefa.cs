using System;
using System.Drawing;
using System.Windows.Forms;
using static tarefas.DAO;

namespace tarefas
{
    public partial class VisualizarTarefa : Form
    {
        public VisualizarTarefa(Tarefa tarefa)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(420, 400);
            this.Text = "Visualizar / Editar Tarefa";
            this.BackColor = Color.WhiteSmoke;

            int margem = 30;
            int larguraCampo = 340;
            int alturaCampo = 30;
            Font fonteLabel = new Font("Segoe UI", 10, FontStyle.Bold);
            Font fonteCampo = new Font("Segoe UI", 10);

            // ===== TÍTULO =====
            Label lblTitulo = new Label
            {
                Text = "Título",
                Font = fonteLabel,
                Location = new Point(margem, 20),
                AutoSize = true
            };

            TextBox txtTitulo = new TextBox
            {
                Text = tarefa.titulo,
                Font = fonteCampo,
                Location = new Point(margem, 45),
                Size = new Size(larguraCampo, alturaCampo)
            };

            // ===== DESCRIÇÃO =====
            Label lblDescricao = new Label
            {
                Text = "Descrição",
                Font = fonteLabel,
                Location = new Point(margem, 85),
                AutoSize = true
            };

            TextBox txtDescricao = new TextBox
            {
                Text = tarefa.descricao,
                Font = fonteCampo,
                Location = new Point(margem, 110),
                Size = new Size(larguraCampo, 60),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };

            // ===== VENCIMENTO =====
            Label lblData = new Label
            {
                Text = "Vencimento",
                Font = fonteLabel,
                Location = new Point(margem, 180),
                AutoSize = true
            };

            TextBox txtData = new TextBox
            {
                Text = tarefa.data,
                Font = fonteCampo,
                Location = new Point(margem, 205),
                Size = new Size(160, alturaCampo)
            };

            // ===== PRIORIDADE =====
            Label lblPrioridade = new Label
            {
                Text = "Prioridade",
                Font = fonteLabel,
                Location = new Point(margem + 180, 180),
                AutoSize = true
            };

            TextBox txtPrioridade = new TextBox
            {
                Text = tarefa.prioridade,
                Font = fonteCampo,
                Location = new Point(margem + 180, 205),
                Size = new Size(160, alturaCampo)
            };

            // ===== BOTÃO SALVAR =====
            Button btnSalvar = new Button
            {
                Text = "Salvar",
                Font = fonteCampo,
                Location = new Point(margem, 270),
                Size = new Size(120, 35),
                BackColor = Color.FromArgb(102, 187, 106), // Verde suave
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnSalvar.FlatAppearance.BorderSize = 0;

            btnSalvar.Click += (s, e) =>
            {
                tarefa.titulo = txtTitulo.Text;
                tarefa.descricao = txtDescricao.Text;
                tarefa.data = txtData.Text;
                tarefa.prioridade = txtPrioridade.Text;

                DAO dao = new DAO();
                string resultado = dao.AtualizarTarefa(tarefa);
                MessageBox.Show(resultado, "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            };

            // ===== BOTÃO FECHAR =====
            Button btnFechar = new Button
            {
                Text = "Cancelar",
                Font = fonteCampo,
                Location = new Point(margem + 140, 270),
                Size = new Size(120, 35),
                BackColor = Color.FromArgb(239, 83, 80), // Vermelho suave
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnFechar.FlatAppearance.BorderSize = 0;

            btnFechar.Click += (s, e) => { this.Close(); };

            // ===== ADICIONANDO COMPONENTES =====
            this.Controls.Add(lblTitulo);
            this.Controls.Add(txtTitulo);
            this.Controls.Add(lblDescricao);
            this.Controls.Add(txtDescricao);
            this.Controls.Add(lblData);
            this.Controls.Add(txtData);
            this.Controls.Add(lblPrioridade);
            this.Controls.Add(txtPrioridade);
            this.Controls.Add(btnSalvar);
            this.Controls.Add(btnFechar);
        }

        private void VisualizarTarefa_Load(object sender, EventArgs e)
        {
            // Evento de carregamento, se quiser adicionar algo
        }
    }
}
