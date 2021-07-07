using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Contas
{
    public class ContaPagar : Conta
    {
        DateTime data_vencimento;
        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into conta_pagar (descricao, valor, status, data_vencimento) values(:descricao, :valor, :status, :data_vencimento)", con);
                cmd.Parameters.Add(new NpgsqlParameter("descricao", descricao));
                cmd.Parameters.Add(new NpgsqlParameter("valor", valor));
                cmd.Parameters.Add(new NpgsqlParameter("status", status));
                cmd.Parameters.Add(new NpgsqlParameter("data_vencimento", data_vencimento));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update conta_pagar set descricao = :descricao, valor = :valor, status = :status, data_vencimento = :data_vencimento where id_conta_pagar = :id_conta", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_conta", id_conta));
                cmd.Parameters.Add(new NpgsqlParameter("descricao", descricao));
                cmd.Parameters.Add(new NpgsqlParameter("valor", valor));
                cmd.Parameters.Add(new NpgsqlParameter("status", status));
                cmd.Parameters.Add(new NpgsqlParameter("data_vencimento", data_vencimento));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from conta_pagar where id_conta_pagar = :id_conta", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_conta", id_conta));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetDataVencimento(DateTime dataT)
        {
            data_vencimento = dataT;
        }

        public DateTime GetDataVencimento()
        {
            return data_vencimento;
        }

    }
}
