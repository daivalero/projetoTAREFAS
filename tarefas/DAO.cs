using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarefas
{
    public class DAO
    {
        public MySqlConnection conexao;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=projetotarefas;Uid=root;password=;Convert Zero Datetime=True");
            try
            {
                conexao.Open(); // Tentando conectar com o banco
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n\n" + erro);
            }
        }

        public string Inserir(string titulo, string descricao, string dataVencimento, string prioridade)
        {
            string inserir = $"INSERT INTO tarefas (titulo, descricao, dataVencimento, prioridade) " +
                             $"VALUES ('{titulo}', '{descricao}', '{dataVencimento}', '{prioridade}')";

            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " tarefa cadastrada com sucesso!";
            return resultado;
        }

        public class Tarefa
        {
            public int id;
            public string titulo;
            public string descricao;
            public string data;
            public string prioridade;
        }

        public List<Tarefa> ListarTarefas()
        {
            List<Tarefa> tarefas = new List<Tarefa>();

            string query = "SELECT id, titulo, descricao, dataVencimento, prioridade FROM tarefas";
            MySqlCommand cmd = new MySqlCommand(query, conexao);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Tarefa tarefa = new Tarefa();
                tarefa.id = Convert.ToInt32(reader["id"]);
                tarefa.titulo = reader["titulo"].ToString();
                tarefa.descricao = reader["descricao"].ToString();
                tarefa.data = reader["dataVencimento"].ToString();
                tarefa.prioridade = reader["prioridade"].ToString();

                tarefas.Add(tarefa);
            }

            reader.Close();
            return tarefas;
        }

        public void Excluir(int id)
        {
            string query = $"DELETE FROM tarefas WHERE id = {id}";
            MySqlCommand cmd = new MySqlCommand(query, conexao);
            cmd.ExecuteNonQuery();
        }

        public string AtualizarTarefa(Tarefa tarefa)
        {
            string atualizar = $"UPDATE tarefas SET titulo=@titulo, descricao=@descricao, dataVencimento=@dataVencimento, prioridade=@prioridade WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(atualizar, conexao);

            cmd.Parameters.AddWithValue("@titulo", tarefa.titulo);
            cmd.Parameters.AddWithValue("@descricao", tarefa.descricao);
            cmd.Parameters.AddWithValue("@dataVencimento", tarefa.data);
            cmd.Parameters.AddWithValue("@prioridade", tarefa.prioridade);
            cmd.Parameters.AddWithValue("@id", tarefa.id);

            string resultado = cmd.ExecuteNonQuery() + " tarefa atualizada com sucesso!";
            return resultado;
        }


    }

    }


