using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecno_Gym.Contas
{
    public class Conta
    {
        protected int id_conta;
        protected string descricao;
        protected double valor;
        protected int status;


        public void SetIdConta(int idT)
        {
            id_conta = idT;
        }

        public int GetIdConta()
        {
            return id_conta;
        }

        public void SetDescricao(string descricaoT)
        {
            descricao = descricaoT;
        }

        public string GetDescricao()
        {
            return descricao;
        }

        public void SetValor(double valorT)
        {
            valor = valorT;
        }

        public double GetValor()
        {
            return valor;
        }

        public void SetStatus(int statusT)
        {
            status = statusT;
        }

        public int GetStatus()
        {
            return status;
        }

    }
}
