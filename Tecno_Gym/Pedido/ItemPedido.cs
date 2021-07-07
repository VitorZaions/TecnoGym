using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Pedido
{
    class ItemPedido
    {
        private int id_pedido;
        private int id_produto;
        private int quantidade;
        private double valortotaladd;

        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into item_pedido (id_pedido,id_produto,quantidade) values(:id_pedido,:id_produto,:quantidade)", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_pedido", id_pedido));
                cmd.Parameters.Add(new NpgsqlParameter("id_produto", id_produto));
                cmd.Parameters.Add(new NpgsqlParameter("quantidade", quantidade));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void BaixaNoEstoque()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update produto set estoque = estoque - :estoque where id_produto = :id_produto", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_pedido", id_pedido));
                cmd.Parameters.Add(new NpgsqlParameter("id_produto", id_produto));
                cmd.Parameters.Add(new NpgsqlParameter("estoque", quantidade));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public double GetValorValorProduto()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select valor from produto where id_produto = :id_produto", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_produto", id_produto));
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                //return dr
                double valor = Convert.ToDouble(dr["valor"]);
                return valor;
            }
        }


        public void AtualizarValorTotal(double valor)
        {
            Object res;
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update pedido set valor_total = :valor_total WHERE id_pedido = :id_pedido", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_pedido", id_pedido));
                cmd.Parameters.Add(new NpgsqlParameter("valor_total", valor));
                res = cmd.ExecuteScalar();
                con.Close();
            }
        }

        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from item_pedido where id_pedido = :id_pedido and id_produto = :id_produto", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_pedido", id_pedido));
                cmd.Parameters.Add(new NpgsqlParameter("id_produto", id_produto));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public bool CheckProdutoTemEstoque()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT estoque from produto WHERE id_produto = " + id_produto, con);
                NpgsqlDataReader dr = cmd.ExecuteReader();


                dr.Read();
                int estoque = Convert.ToInt32(dr["estoque"]);
                if(estoque > 0)
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

        public bool CheckProdutoEstaNoPedido()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * from item_pedido WHERE id_pedido = "+id_pedido+" and id_produto = "+id_produto, con);
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

        public int CheckQuantidadeEstoque()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT estoque from produto WHERE id_produto = " + id_produto, con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                
                dr.Read();
                int estoque = Convert.ToInt32(dr["estoque"]);
                return estoque;              
            }
        }

        public bool CheckProdutoExiste()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT descrição from produto WHERE id_produto = " + id_produto, con);
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

        public void SetIdPedido(int idT)
        {
            id_pedido = idT;
        }

        public int GetIdPedido()
        {
            return id_pedido;
        }

        public void SetIdProduto(int idT)
        {
            id_produto = idT;
        }

        public int GetIdProduto()
        {
            return id_produto;
        }

        public void SetQuantidade(int quantidadeT)
        {
            quantidade = quantidadeT;
        }

        public int GetQuantidade()
        {
            return quantidade;
        }

        public void SetValorTotalAdd(double valorT)
        {
            valortotaladd = valorT;
        }

        public double GetValorValorTotalAdd()
        {
            return valortotaladd;
        }


    }
}
