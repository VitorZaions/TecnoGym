using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Pedido
{
    public class Fornecedor
    {
        private int id_fornecedor;
        private string nome,cnpj,cep,uf,cidade,bairro,rua,email,telefone;


        public void novo()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into fornecedor (nome,cnpj,cep,uf,cidade,bairro,rua,email,telefone) values(:nome,:cnpj,:cep,:uf,:cidade,:bairro,:rua,:email,:telefone)", con);
                cmd.Parameters.Add(new NpgsqlParameter("nome", nome));
                cmd.Parameters.Add(new NpgsqlParameter("cnpj", cnpj));
                cmd.Parameters.Add(new NpgsqlParameter("cep", cep));
                cmd.Parameters.Add(new NpgsqlParameter("uf", uf));
                cmd.Parameters.Add(new NpgsqlParameter("cidade", cidade));
                cmd.Parameters.Add(new NpgsqlParameter("bairro", bairro));
                cmd.Parameters.Add(new NpgsqlParameter("rua", rua));
                cmd.Parameters.Add(new NpgsqlParameter("email", email));
                cmd.Parameters.Add(new NpgsqlParameter("telefone", telefone));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update fornecedor set nome = :nome,cnpj = :cnpj,cep = :cep,uf = :uf,cidade = :cidade,bairro = :bairro,rua = :rua,email = :email,telefone = :telefone where id_fornecedor = :id_fornecedor ", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_fornecedor", id_fornecedor));
                cmd.Parameters.Add(new NpgsqlParameter("nome", nome));
                cmd.Parameters.Add(new NpgsqlParameter("cnpj", cnpj));
                cmd.Parameters.Add(new NpgsqlParameter("cep", cep));
                cmd.Parameters.Add(new NpgsqlParameter("uf", uf));
                cmd.Parameters.Add(new NpgsqlParameter("cidade", cidade));
                cmd.Parameters.Add(new NpgsqlParameter("bairro", bairro));
                cmd.Parameters.Add(new NpgsqlParameter("rua", rua));
                cmd.Parameters.Add(new NpgsqlParameter("email", email));
                cmd.Parameters.Add(new NpgsqlParameter("telefone", telefone));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from fornecedor where id_fornecedor = :id_fornecedor ", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_fornecedor", id_fornecedor));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void SetIdFornecedor(int idT)
        {
            id_fornecedor = idT;
        }

        public int GetIdFornecedor()
        {
            return id_fornecedor;
        }

        public void SetNome(string nomeT)
        {
            nome = nomeT;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetCNPJ(string cnpjT)
        {
            cnpj = cnpjT;
        }

        public string GetCNPJ()
        {
            return cnpj;
        }

        public void SetCep(string cepT)
        {
            cep = cepT;
        }

        public string GetCep()
        {
            return cep;
        }

        public void setUF(string ufT)
        {
            uf = ufT;
        }

        public string GetUF()
        {
            return uf;
        }

        public void SetCidade(string cidadeT)
        {
            cidade = cidadeT;
        }

        public string GetCidade()
        {
            return cidade;
        }


        public void SetBairro(string bairroT)
        {
            bairro = bairroT;
        }

        public string GetBairro()
        {
            return bairro;
        }

        public void SetRua(string ruaT)
        {
            rua = ruaT;
        }

        public string GetRua()
        {
            return rua;
        }

        public void SetEmail(string emailT)
        {
            email = emailT;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetTelefone(string telefoneT)
        {
            telefone = telefoneT;
        }

        public string GetTelefone()
        {
            return telefone;
        }
    }
}
