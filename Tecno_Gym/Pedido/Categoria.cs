using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Pedido
{
    public class Categoria
    {
        private int id_categoria;
        private string nome;


        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into categoria (nome) values(:nome)", con);
                cmd.Parameters.Add(new NpgsqlParameter("nome", nome));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update categoria set nome = :nome where id_categoria = :id_categoria", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_categoria", id_categoria));
                cmd.Parameters.Add(new NpgsqlParameter("nome", nome));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from categoria where id_categoria = :id_categoria", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_categoria", id_categoria));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetIdCategoria(int idT)
        {
            id_categoria = idT;
        }

        public int GetIdCategoria()
        {
            return id_categoria;
        }

        public void SetNome(string nomeT)
        {
            nome = nomeT;
        }

        public string GetNome()
        {
            return nome;
        }

    }
}
