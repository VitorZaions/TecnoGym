using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Pessoas
{
    public class Cliente : Pessoa
    {
        protected DateTime datacadastro;

        public int novo()
        {
            Object res;
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into cliente (nome, sexo, cep, cpf, uf, cidade, bairro, rua, email, telefone, data_cadastro) values(:nome, :sexo, :cep, :cpf, :uf, :cidade, :bairro, :rua, :email, :telefone, :data_cadastro) RETURNING id_cliente", con);
                cmd.Parameters.Add(new NpgsqlParameter("nome", nome));
                cmd.Parameters.Add(new NpgsqlParameter("sexo", sexo));
                cmd.Parameters.Add(new NpgsqlParameter("cep", cep));
                cmd.Parameters.Add(new NpgsqlParameter("cpf", cpf));
                cmd.Parameters.Add(new NpgsqlParameter("uf", uf));
                cmd.Parameters.Add(new NpgsqlParameter("cidade", cidade));
                cmd.Parameters.Add(new NpgsqlParameter("bairro", bairro));
                cmd.Parameters.Add(new NpgsqlParameter("rua", rua));
                cmd.Parameters.Add(new NpgsqlParameter("email", email));
                cmd.Parameters.Add(new NpgsqlParameter("telefone", telefone));
                cmd.Parameters.Add(new NpgsqlParameter("data_cadastro", datacadastro));
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
                NpgsqlCommand cmd = new NpgsqlCommand("update cliente set nome = :nome, sexo = :sexo, cep = :cep, cpf = :cpf, uf = :uf, cidade = :cidade, bairro = :bairro, rua = :rua, email = :email, telefone = :telefone, data_cadastro = :data_cadastro where id_cliente = :id_cliente", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_cliente", id_pessoa));
                cmd.Parameters.Add(new NpgsqlParameter("nome", nome));
                cmd.Parameters.Add(new NpgsqlParameter("sexo", sexo));
                cmd.Parameters.Add(new NpgsqlParameter("cep", cep));
                cmd.Parameters.Add(new NpgsqlParameter("cpf", cpf));
                cmd.Parameters.Add(new NpgsqlParameter("uf", uf));
                cmd.Parameters.Add(new NpgsqlParameter("cidade", cidade));
                cmd.Parameters.Add(new NpgsqlParameter("bairro", bairro));
                cmd.Parameters.Add(new NpgsqlParameter("rua", rua));
                cmd.Parameters.Add(new NpgsqlParameter("email", email));
                cmd.Parameters.Add(new NpgsqlParameter("telefone", telefone));
                cmd.Parameters.Add(new NpgsqlParameter("data_cadastro", datacadastro));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from cliente where id_cliente = :id_cliente", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_cliente", id_pessoa));
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        public void SetDataCadastro(DateTime datacadastroT)
        {
            datacadastro = datacadastroT;
        }

        public DateTime GetDataCadastro()
        {
            return datacadastro;
        }

    }
}
