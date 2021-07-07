using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Pedido
{
    public class Produto
    {
        private int id_produto;
        private string descricao;
        private int estoque;
        private double valor;
        private int id_categoria;
        private int id_fornecedor;

        //extra
        private string nome_categoria;
        private string nome_fornecedor;
               
        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into produto (descrição, estoque, valor, id_categoria, id_fornecedor) values(:descrição, :estoque, :valor, :id_categoria, :id_fornecedor)", con);
                cmd.Parameters.Add(new NpgsqlParameter("descrição", descricao));
                cmd.Parameters.Add(new NpgsqlParameter("estoque", estoque));
                cmd.Parameters.Add(new NpgsqlParameter("valor", valor));
                cmd.Parameters.Add(new NpgsqlParameter("id_categoria", id_categoria));
                cmd.Parameters.Add(new NpgsqlParameter("id_fornecedor", id_fornecedor));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update produto set descrição = :descrição, estoque = :estoque, valor = :valor, id_categoria = :id_categoria, id_fornecedor = :id_fornecedor where id_produto = :id_produto", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_produto", id_produto));
                cmd.Parameters.Add(new NpgsqlParameter("descrição", descricao));
                cmd.Parameters.Add(new NpgsqlParameter("estoque", estoque));
                cmd.Parameters.Add(new NpgsqlParameter("valor", valor));
                cmd.Parameters.Add(new NpgsqlParameter("id_categoria", id_categoria));
                cmd.Parameters.Add(new NpgsqlParameter("id_fornecedor", id_fornecedor));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from produto where id_produto = :id_produto", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_produto", id_produto));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetIdProduto(int idT)
        {
            id_produto = idT;
        }

        public int GetIdProduto()
        {
            return id_produto;
        }

        public void SetDescricao(string nomeT)
        {
            descricao = nomeT;
        }

        public string GetDescricao()
        {
            return descricao;
        }

        public void SetEstoque(int estoqueT)
        {
            estoque = estoqueT;
        }
        public int GetEstoque()
        {
            return estoque;
        }

        public void SetValor(double valorT)
        {
            valor = valorT;
        }

        public double GetValor()
        {
            return valor;
        }

        public void SetCategoria(int idT)
        {
            id_categoria = idT;
        }

        public int GetIdCategoria()
        {
            return id_categoria;
        }

        public void SetFornecedor(int idT)
        {
            id_fornecedor = idT;
        }

        public int GetIdFornecedor()
        {
            return id_fornecedor;
        }

        public void SetNomeCategoria(string nomeT)
        {
            nome_categoria = nomeT;
        }

        public string GetNomeCategoria()
        {
            return nome_categoria;
        }

        public void SetNomeFornecedor(string nomeT)
        {
            nome_fornecedor = nomeT;
        }

        public string GetNomeFornecedor()
        {
            return nome_fornecedor;
        }

    }
}
