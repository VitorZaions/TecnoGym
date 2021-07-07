using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Pedido
{
    public class Pedido
    {
        private int id_pedido;
        private DateTime data;
        private double valortotal;
        private int id_cliente;
        private string tipo_pagamento,descricao;

        //extra

        string nome_cliente;

        public int novo()
        {
            Object res;
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into pedido (descricao, data, valor_total, tipo_pagamento, id_cliente) values(:descrição, :data, :valor_total, :tipo_pagamento, :id_cliente) RETURNING id_pedido", con);
                cmd.Parameters.Add(new NpgsqlParameter("descrição", descricao));
                cmd.Parameters.Add(new NpgsqlParameter("data", data));
                cmd.Parameters.Add(new NpgsqlParameter("valor_total", valortotal));
                cmd.Parameters.Add(new NpgsqlParameter("tipo_pagamento", tipo_pagamento));
                cmd.Parameters.Add(new NpgsqlParameter("id_cliente", id_cliente));
               // cmd.ExecuteNonQuery();
                res = cmd.ExecuteScalar();
                con.Close();
            }
            return Convert.ToInt32(res);
        }

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update pedido set descricao = :descrição, data = :data, valor_total = :valor_total, tipo_pagamento = :tipo_pagamento, id_cliente = :id_cliente where id_pedido = :id_pedido", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_pedido", id_pedido));
                cmd.Parameters.Add(new NpgsqlParameter("descrição", descricao));
                cmd.Parameters.Add(new NpgsqlParameter("data", data));
                cmd.Parameters.Add(new NpgsqlParameter("valor_total", valortotal));
                cmd.Parameters.Add(new NpgsqlParameter("tipo_pagamento", tipo_pagamento));
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

                NpgsqlCommand cmd2 = new NpgsqlCommand("delete from item_pedido where id_pedido = :id_pedido", con);
                cmd2.Parameters.Add(new NpgsqlParameter("id_pedido", id_pedido));
                cmd2.ExecuteNonQuery();

                NpgsqlCommand cmd = new NpgsqlCommand("delete from pedido where id_pedido = :id_pedido", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_pedido", id_pedido));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetIdPedido(int idT)
        {
            id_pedido = idT;
        }

        public int GetIdPedido()
        {
            return id_pedido;
        }

        public void SetData(DateTime dataT)
        {
            data = dataT;
        }

        public DateTime GetData()
        {
            return data;
        }

        public void SetValorTotal(double valortotalT)
        {
            valortotal = valortotalT;
        }

        public double GetValorTotal()
        {
            return valortotal;
        }

        public void SetIdCliente(int idT)
        {
            id_cliente = idT;
        }

        public int GetIdCliente()
        {
            return id_cliente;
        }

        public void SetTipoPagamento(string tipo_pagamentoT)
        {
            tipo_pagamento = tipo_pagamentoT;
        }

        public string GetTipoPagamento()
        {
            return tipo_pagamento;
        }

        public void SetDescricao(string descricaoT)
        {
            descricao = descricaoT;
        }

        public string GetDescricao()
        {
            return descricao;
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
