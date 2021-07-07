using MetroFramework;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Pessoas
{
    public class Funcionario : Pessoa
    {
        protected string login, senha;
        protected bool admin;

        public bool DoLogin(string[] infos)
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT id_funcionario, nome, sexo, cep, cpf, uf, cidade, bairro, rua, email, telefone, senha, admin FROM funcionario WHERE login = '" + infos[0] + "'", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {                   
                    dr.Read();
                    string pass = dr["senha"].ToString();

                    if (infos[1] == pass)
                    {
                        id_pessoa = int.Parse(dr["id_funcionario"].ToString());
                        nome = dr["nome"].ToString();
                        sexo = dr["sexo"].ToString();
                        cep = dr["cep"].ToString();
                        cpf = dr["cpf"].ToString();
                        uf = dr["uf"].ToString();
                        cidade = dr["cidade"].ToString();
                        bairro = dr["bairro"].ToString();
                        rua = dr["rua"].ToString();
                        cidade = dr["email"].ToString();
                        telefone = dr["email"].ToString();
                        login = infos[0];
                        senha = infos[1];                       

                        admin = Convert.ToBoolean(dr["admin"]);
                        con.Close();
                        return true;
                        // pegar o resto das infos
                    }
                    else
                    {
                        con.Close();
                        return false;
                    }
                }
                else
                {
                    con.Close();
                    return false; // algum erro ocorreu
                }
            }            
        }

        public void novo()
        {
            // insert into funcionario (nome, sexo, cep, cpf, uf, cidade, bairro, rua, email, telefone, login, senha, admin) values('Vitor Zaions', 0, '99838000', '05478548527', 'RS', 'Centenário', 'Centro', 'Avenida', 'vitor@email.com', '54984381200', 'Vitor', 'senha', true)
            /*  if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connected");
                } */
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into funcionario (nome, sexo, cep, cpf, uf, cidade, bairro, rua, email, telefone, login, senha, admin) values(:nome, :sexo, :cep, :cpf, :uf, :cidade, :bairro, :rua, :email, :telefone, :login, :senha, :admin)", con);
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
                cmd.Parameters.Add(new NpgsqlParameter("login", login));
                cmd.Parameters.Add(new NpgsqlParameter("senha", senha));
                cmd.Parameters.Add(new NpgsqlParameter("admin", admin));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void atualizar()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update funcionario set nome = :nome, sexo = :sexo, cep = :cep, cpf = :cpf, uf = :uf, cidade = :cidade, bairro = :bairro, rua = :rua, email = :email, telefone = :telefone, login = :login, senha = :senha, admin = :admin where id_funcionario = :id_funcionario", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_funcionario", id_pessoa));
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
                cmd.Parameters.Add(new NpgsqlParameter("login", login));
                cmd.Parameters.Add(new NpgsqlParameter("senha", senha));
                cmd.Parameters.Add(new NpgsqlParameter("admin", admin));
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        public void excluir()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from funcionario where id_funcionario = :id_funcionario", con);
                cmd.Parameters.Add(new NpgsqlParameter("id_funcionario", id_pessoa));
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void SetLogin(string loginT)
        {
            login = loginT;
        }

        public string GetLogin()
        {
            return login;
        }

        public void SetSenha(string senhaT)
        {
            senha = senhaT;
        }

        public string GetSenha()
        {
            return senha;
        }

        public void SetAdmin(bool adminT)
        {
            admin = adminT;
        }

        public bool GetAdmin()
        {
            return admin;
        }


    }
}
