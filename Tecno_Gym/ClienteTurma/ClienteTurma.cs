using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym
{
    class ClienteTurma
    {
        int id_cliente;
        int id_turma;



        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into cliente_turma (id_cliente,id_turma) values(:id_cliente,:id_turma)", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_cliente", id_cliente));
                cmd.Parameters.Add(new NpgsqlParameter("id_turma", id_turma));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                Console.WriteLine("ID CLIENTE : " + id_cliente + " ID TURMA :" + id_turma);
                NpgsqlCommand cmd = new NpgsqlCommand("delete from cliente_turma where id_cliente = :id_cliente and id_turma = :id_turma", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_cliente", id_cliente));
                cmd.Parameters.Add(new NpgsqlParameter("id_turma", id_turma));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetIdCliente(int idT)
        {
            id_cliente = idT;
        }

        public int GetClienteId()
        {
            return id_cliente;
        }

        public void SetTurmaId(int idT)
        {
            id_turma = idT;
        }

        public int GetTurmaId()
        {
            return id_turma;
        }

    }

}
