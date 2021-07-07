using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Turma
{
    public class Turma
    {
        private int id_turma;
        private string descricao;
        private string nome_funcionario;

        int id_funcionario; //Responsável pela turma

        public void SetIdTurma(int idT)
        {
            id_turma = idT;
        }

        public bool CheckClienteEstaNaTurma(int id_cliente)
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();

                Console.WriteLine("ID TURMA : " + id_turma + "ID CLIENTE : " + id_cliente);

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from cliente_turma WHERE id_cliente = " + id_cliente+" and id_turma =" + id_turma, con);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                }
            }
        }
        public int GetIdTurma()
        {
            return id_turma;
        }

        public void SetDescricao(string descricaoT)
        {
            descricao = descricaoT;
        }

        public string GetDescricao()
        {
            return descricao;
        }

        public void SetIdFuncionario(int idT)
        {
            id_funcionario = idT;
        }

        public int GetIdFuncionario()
        {
            return id_funcionario;
        }

        public void SetNomeFuncionario(string nomeT)
        {
            nome_funcionario = nomeT;
        }
               
        public string GetNomeFuncionario()
        {
            return nome_funcionario;
        }

        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("insert into turma (descricao, id_funcionario) values(:descricao, :id_funcionario)", con);
                    cmd.Parameters.Add(new NpgsqlParameter("descricao", descricao));
                    cmd.Parameters.Add(new NpgsqlParameter("id_funcionario", id_funcionario));
                    cmd.ExecuteNonQuery();
                    con.Close();
            }
        } 

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update turma set descricao = :descricao, id_funcionario = :id_funcionario where id_turma = :id_turma", con);
                cmd.Parameters.Add(new NpgsqlParameter("descricao", descricao));
                cmd.Parameters.Add(new NpgsqlParameter("id_funcionario", id_funcionario));
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
                NpgsqlCommand cmd = new NpgsqlCommand("delete from turma where id_turma = :id_turma", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_turma", id_turma));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

    }
}
