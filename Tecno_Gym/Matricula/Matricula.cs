using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Matricula
{
    public class Matricula
    {
        int id_matricula;
        DateTime datainicial;
        DateTime datafinal;
        int id_cliente;

        //extra
        string nome_cliente;

        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into matricula (data_inicial,data_final,id_cliente) values(:data_inicial,:data_final,:id_cliente)", con);
                cmd.Parameters.Add(new NpgsqlParameter("data_inicial", datainicial));
                cmd.Parameters.Add(new NpgsqlParameter("data_final", datafinal));
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
                NpgsqlCommand cmd = new NpgsqlCommand("update matricula set data_inicial = :data_inicial, data_final = :data_final, id_cliente = :id_cliente where id_matricula = :id_matricula", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_matricula", id_matricula));
                cmd.Parameters.Add(new NpgsqlParameter("data_inicial", datainicial));
                cmd.Parameters.Add(new NpgsqlParameter("data_final", datafinal));
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
                NpgsqlCommand cmd = new NpgsqlCommand("delete from matricula where id_matricula = :id_matricula", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_matricula", id_matricula));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetIdMatricula(int idT)
        {
            id_matricula = idT;
        }

        public int GetIdMatricula()
        {
            return id_matricula;
        }

        public void SetDataInicial(DateTime datainicialT)
        {
            datainicial = datainicialT;
        }

        public DateTime GetDataInicial()
        {
            return datainicial;
        }

        public void SetDataFinal(DateTime datafinalT)
        {
            datafinal = datafinalT;
        }

        public DateTime GetDataFinal()
        {
            return datafinal;
        }

        public void SetIdCliente(int idT)
        {
            id_cliente = idT;
        }

        public int GetIdCliente()
        {
            return id_cliente;
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
