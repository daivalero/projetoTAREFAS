using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

           

            //caixa

            ArredondarCaixa(caixa5, 22);
            ArredondarCaixa(caixa6, 22);
           


            //criar 
            
            ArredondarBotao(criar, 40);

            // não fez
         
            // Pode deixar vazio ou colocar alguma inicialização, se quiser.
        }


        private void ArredondarCaixa(TextBox caixa, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(caixa.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(caixa.Width - raio, caixa.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, caixa.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            caixa.Region = new Region(path);
        } // Fim

        private void ArredondarBotao(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            botao.Region = new Region(path);
        } // Fim

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = caixa5.Text;
            string descricao = caixa6.Text;
            string data = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string prioridade = prioridade1.Text;

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void volta_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar 
    }
}
