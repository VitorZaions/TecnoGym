using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Pessoas
{
    public class Pessoa
    {
        protected int id_pessoa { get; set; }
        protected string nome;
        protected string sexo;
        protected string cep, cpf, uf, cidade, bairro, rua, email, telefone;

        public void SetIdPessoa(int idT)
        {
            id_pessoa = idT;
        }

        public int GetId_pessoa()
        {
            return id_pessoa;
        }

        public void SetNome(string nomeT)
        {
            nome = nomeT;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetSexo(string sexoT)
        {
            sexo = sexoT;
        }
        public string GetSexo()
        {
            return sexo;
        }

        public void SetCep(string cepT)
        {
            cep = cepT;
        }

        public string GetCep()
        {
            return cep;
        }

        public void SetCpf(string cpfT)
        {
            cpf = cpfT;
        }

        public string GetCPF()
        {
            return cpf;
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
