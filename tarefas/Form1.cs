using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tarefas; // Certifique-se de que o namespace está correto
               // OU ajuste para `using Tarefas;` se for esse o namespace da DAO

namespace tarefas
{
    public partial class Form1 : Form
    {
        DAO dao;

        public Form1()
        {
            InitializeComponent();
            dao = new DAO(); // Inicializa a conexão
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Pode deixar vazio ou colocar alguma inicialização, se quiser.
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = textBox1.Text;
            string descricao = textBox2.Text;
            string data = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string prioridade = comboBox1.Text;

            MessageBox.Show(dao.Inserir(titulo, descricao, data, prioridade));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
