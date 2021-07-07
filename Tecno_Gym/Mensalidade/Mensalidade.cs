using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Mensalidade
{
    public class Mensalidade
    {
        int id_mensalidade;
        double valormensalidade;
        DateTime datapagamento;
        int status;
        int id_cliente;


        // extra
        string nome_cliente;

        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into mensalidade (valor_mensalidade,data_pagamento,status,id_cliente) values(:valor_mensalidade,:data_pagamento,:status,:id_cliente)", con);
                cmd.Parameters.Add(new NpgsqlParameter("valor_mensalidade", valormensalidade));
                cmd.Parameters.Add(new NpgsqlParameter("data_pagamento", datapagamento));
                cmd.Parameters.Add(new NpgsqlParameter("status", status));
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
                NpgsqlCommand cmd = new NpgsqlCommand("update mensalidade set valor_mensalidade = :valor_mensalidade ,data_pagamento = :data_pagamento,status = :status,id_cliente = :id_cliente where id_mensalidade = :id_mensalidade", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_mensalidade", id_mensalidade));
                cmd.Parameters.Add(new NpgsqlParameter("valor_mensalidade", valormensalidade));
                cmd.Parameters.Add(new NpgsqlParameter("data_pagamento", datapagamento));
                cmd.Parameters.Add(new NpgsqlParameter("status", status));
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
                NpgsqlCommand cmd = new NpgsqlCommand("delete from mensalidade where id_mensalidade = :id_mensalidade", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_mensalidade", id_mensalidade));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetIdMensalidade(int idT)
        {
            id_mensalidade = idT;
        }

        public int GetIdMensalidade()
        {
            return id_mensalidade;
        }

        public void SetValorMensalidade(double valormensalidadeT)
        {
            valormensalidade = valormensalidadeT;
        }

        public double GetValorMensalidade()
        {
            return valormensalidade;
        }

        public void SetDataPagamento(DateTime datapagamentoT)
        {
            datapagamento = datapagamentoT;
        }
        public DateTime GetDataPagamento()
        {
            return datapagamento;
        }

        public void SetStatus(int statusT)
        {
            status = statusT;
        }
        public int GetStatus()
        {
            return status;
        }

        public void SetIdCliente(int idT)
        {
            id_cliente = idT;
        }

        public int GetIdCliente()
        {
            return id_cliente;
        }

        public void SetNomeCliente(string nome)
        {
            nome_cliente = nome;
        }

        public string GetNomeCliente()
        {
            return nome_cliente;
        }

    }
}
