using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Aula
{
    public class Aula
    {
        int id_aula;
        DateTime dia;
        TimeSpan horario;
        int id_turma;

        //extra
        string nome_turma;
       
        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into aula (dia, horario, id_turma) values(:dia , :horario , :id_turma)", con);
                cmd.Parameters.Add(new NpgsqlParameter("dia", dia));
                cmd.Parameters.Add(new NpgsqlParameter("horario", horario));
                cmd.Parameters.Add(new NpgsqlParameter("id_turma", id_turma));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update aula set dia = :dia, horario = :horario, id_turma = :id_turma where id_aula = :id_aula", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_aula", id_aula));
                cmd.Parameters.Add(new NpgsqlParameter("dia", dia));
                cmd.Parameters.Add(new NpgsqlParameter("horario", horario));
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
                NpgsqlCommand cmd = new NpgsqlCommand("delete from aula where id_aula = :id_aula", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_aula", id_aula));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void SetIdAula(int idT)
        {
            id_aula = idT;
        }

        public int GetIdAula()
        {
            return id_aula;
        }

        public void SetDia(DateTime diaT)
        {
            dia = diaT;
        }

        public DateTime GetDia()
        {
            return dia;
        }

        public void SetIdTurma(int idT)
        {
            id_turma = idT;
        }

        public int GetIdTurma()
        {
            return id_turma;
        }

        public void SetHora(TimeSpan horaT)
        {
            horario = horaT;
        }

        public TimeSpan GetHora()
        {
            return horario;
        }       


        public void SetNomeTurma(string nomeT)
        {
            nome_turma = nomeT;
        }

        public string GetNomeTurma()
        {
            return nome_turma;
        }

    }
}
