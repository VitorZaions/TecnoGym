using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.AvaliacaoFisica
{
    public class AvaliacaoFisica
    {
        int id_avaliacao_fisica;
        DateTime dia;
        TimeSpan hora;
        int id_cliente;

        //extra
        string nome_cliente;

        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into avaliacaofisica (dia, hora, id_cliente) values(:dia , :horario , :id_cliente)", con);
                cmd.Parameters.Add(new NpgsqlParameter("dia", dia));
                cmd.Parameters.Add(new NpgsqlParameter("horario", hora));
                cmd.Parameters.Add(new NpgsqlParameter("id_cliente", id_cliente));                
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update avaliacaofisica set dia = :dia, hora = :horario, id_cliente = :id_cliente where id_avaliacao_fisica = :id_avaliacao_fisica", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_avaliacao_fisica", id_avaliacao_fisica));
                cmd.Parameters.Add(new NpgsqlParameter("dia", dia));
                cmd.Parameters.Add(new NpgsqlParameter("horario", hora));
                cmd.Parameters.Add(new NpgsqlParameter("id_cliente", id_cliente));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from avaliacaofisica where id_avaliacao_fisica = :id_avaliacao_fisica", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_avaliacao_fisica", id_avaliacao_fisica));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetIdAvaliacao(int idT)
        {
            id_avaliacao_fisica = idT;
        }

        public int GetIdAvaliacao()
        {
            return id_avaliacao_fisica;
        }

        public void SetDia(DateTime diaT)
        {
            dia = diaT;
        }

        public DateTime GetDia()
        {
            return dia;
        }

        public void SetIdCliente(int idT)
        {
            id_cliente = idT;
        }

        public int GetIdCliente()
        {
            return id_cliente;
        }

        public void SetHora(TimeSpan horaT)
        {
            hora = horaT;
        }

        public TimeSpan GetHora()
        {
            return hora;
        }


        public void SetNomeCliente(string nomeT)
        {
            nome_cliente = nomeT;
        }

        public string GetNomeCliente()
        {
            return nome_cliente;
        }

    }
}
