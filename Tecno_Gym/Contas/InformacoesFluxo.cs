using MetroFramework.Forms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecno_Gym.Contas
{
    public partial class InformacoesFluxo : MetroForm
    {
        double totalrecebido = 0;
        double totalpendentereceber = 0;
        double totalpagarpago = 0;
        double totalpendentepagar = 0;

        public InformacoesFluxo()
        {
            InitializeComponent();
        }

        private void InformacoesFluxo_Load(object sender, EventArgs e)
        {
            Dia_LBL.Text = DateTime.Now.ToShortDateString();
            LoadContasPagarPago();
            LoadContasPagarAberto();
            LoadContasReceberAberto();
            LoadContasReceberPago();
            LoadMensalidadesEmAberto();
            LoadMensalidadesPago();
            CompletarTotais();
        }

        void CompletarTotais()
        {
            ValorRecebidoTotal_LBL.Text = "R$" + totalrecebido;
            PendenteReceber_LBL.Text = "R$" + totalpendentereceber;
            TotalPago_LBL.Text = "R$" + totalpagarpago;
            PendentePagar_LBL.Text = "R$" + totalpendentepagar;
        }

        public void LoadMensalidadesEmAberto()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                string hoje = DateTime.Now.ToShortDateString();
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT sum(valor_mensalidade) from mensalidade WHERE status = 0 and data_pagamento = '" + hoje + "'", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                double valor;
                try
                {
                    valor = Convert.ToDouble(dr[0]);
                }
                catch
                {
                    valor = 0;
                }

                if (dr.HasRows && valor > 0)
                {
                    MensalidadesPendentes_LBL.Text = "R$" + valor;
                    totalpendentereceber += valor;
                }
                else
                {
                    MensalidadesPendentes_LBL.Text = "R$0";
                }
            }
        }

        public void LoadMensalidadesPago()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                string hoje = DateTime.Now.ToShortDateString();
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT sum(valor_mensalidade) from mensalidade WHERE status = 1 and data_pagamento = '" + hoje + "'", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                double valor;
                try
                {
                    valor = Convert.ToDouble(dr[0]);
                }
                catch
                {
                    valor = 0;
                }

                if (dr.HasRows && valor > 0)
                {
                    MensalidadesReceber_LBL.Text = "R$" + valor;
                    totalrecebido += valor;
                }
                else
                {
                    MensalidadesReceber_LBL.Text = "R$0";
                }
            }
        }

        public void LoadContasReceberPago()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                string hoje = DateTime.Now.ToShortDateString();
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT sum(valor) from conta_receber WHERE status = 1 and data_recebimento = '" + hoje + "'", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                double valor;
                try
                {
                    valor = Convert.ToDouble(dr[0]);
                }
                catch
                {
                    valor = 0;
                }

                if (dr.HasRows && valor > 0)
                {
                    ContaReceber_LBL.Text = "R$" + valor;
                    totalrecebido += valor;
                }
                else
                {
                    ContaReceber_LBL.Text = "R$0";
                }
            }
        }

        public void LoadContasReceberAberto()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                string hoje = DateTime.Now.ToShortDateString();
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT sum(valor) from conta_receber WHERE status = 0 and data_recebimento = '" + hoje + "'", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                double valor;
                try
                {
                    valor = Convert.ToDouble(dr[0]);
                }
                catch
                {
                    valor = 0;
                }

                if (dr.HasRows && valor > 0)
                {
                    ContasReceberPendente_LBL.Text = "R$" + valor;
                    totalpendentereceber += valor;
                }
                else
                {
                    ContasReceberPendente_LBL.Text = "R$0";
                }
            }
        }


        public void LoadContasPagarAberto()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                string hoje = DateTime.Now.ToShortDateString();
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT sum(valor) from conta_pagar WHERE status = 0 and data_vencimento = '" + hoje + "'", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                double valor;
                try
                {
                    valor = Convert.ToDouble(dr[0]);
                }
                catch
                {
                    valor = 0;
                }

                if (dr.HasRows && valor > 0)
                {
                    ContasPagarPendente_LBL.Text = "R$" + valor;
                    totalpendentepagar += valor;
                }
                else
                {
                    ContasPagarPendente_LBL.Text = "R$0";
                }
            }
        }

        public void LoadContasPagarPago()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                string hoje = DateTime.Now.ToShortDateString();
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT sum(valor) from conta_pagar WHERE status = 1 and data_vencimento = '"+hoje+"'", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                double valor;
                try
                {
                    valor = Convert.ToDouble(dr[0]);
                }
                catch
                {
                    valor = 0;
                }

                if (dr.HasRows && valor > 0)
                {
                    ContasPagar_LBL.Text = "R$" + valor;
                    totalpagarpago += valor;
                }
                else
                {
                    ContasPagar_LBL.Text = "R$0";
                }
            }
        }


    }    
}
