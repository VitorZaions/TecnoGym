using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Contas
{
    public class ContaReceber : Conta
    {
        DateTime data_recebimento;

        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into conta_receber (descricao, valor, status, data_recebimento) values(:descricao, :valor, :status, :data_recebimento)", con);
                cmd.Parameters.Add(new NpgsqlParameter("descricao", descricao));
                cmd.Parameters.Add(new NpgsqlParameter("valor", valor));
                cmd.Parameters.Add(new NpgsqlParameter("status", status));
                cmd.Parameters.Add(new NpgsqlParameter("data_recebimento", data_recebimento));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update conta_receber set descricao = :descricao, valor = :valor, status = :status, data_recebimento = :data_recebimento where id_conta_receber = :id_conta", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_conta", id_conta));
                cmd.Parameters.Add(new NpgsqlParameter("descricao", descricao));
                cmd.Parameters.Add(new NpgsqlParameter("valor", valor));
                cmd.Parameters.Add(new NpgsqlParameter("status", status));
                cmd.Parameters.Add(new NpgsqlParameter("data_recebimento", data_recebimento));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from conta_receber where id_conta_receber = :id_conta", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_conta", id_conta));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetDataRecebimento(DateTime dataT)
        {
            data_recebimento = dataT;
        }

        public DateTime GetDataRecebimento()
        {
            return data_recebimento;
        }

    }
}
