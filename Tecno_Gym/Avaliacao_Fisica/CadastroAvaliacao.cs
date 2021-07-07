using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecno_Gym.Turma
{
    public partial class CadastroAvaliacao : MetroForm
    {
        int tipo_op = 0;
        int id_cliente;
        string nome_cliente;
        AvaliacaoFisica.AvaliacaoFisica AvaliacaoCame;
        public CadastroAvaliacao(int tipo)
        {
            InitializeComponent();
            tipo_op = tipo;
        }

        public CadastroAvaliacao(int tipo, AvaliacaoFisica.AvaliacaoFisica AvaliacaoF)
        {
            InitializeComponent();
            tipo_op = tipo;
            AvaliacaoCame = AvaliacaoF;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(AvaliacaoCame.GetIdAvaliacao());
            nome_cliente = AvaliacaoCame.GetNomeCliente();
            Cliente_TB.Text = nome_cliente;
            Data_DT.Value = AvaliacaoCame.GetDia();
            DateTime dt = new DateTime(2012, 01, 01);
            TimeSpan ts = new TimeSpan(1, 0, 0, 0, 0);
            dt = AvaliacaoCame.GetDia() + AvaliacaoCame.GetHora();
            Hora_DT.Value = dt;
            id_cliente = AvaliacaoCame.GetIdCliente();
        }

        private void CadastroAvaliacao_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if (Cliente_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira um cliente para a avaliação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Data_DT.Value == null)
                MetroMessageBox.Show(this, "\n\nInsira uma data para a avaliação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                AvaliacaoFisica.AvaliacaoFisica Aval = new AvaliacaoFisica.AvaliacaoFisica();
                Aval.SetIdCliente(id_cliente);
                Aval.SetDia(Data_DT.Value);
                TimeSpan CurrentTime = Hora_DT.Value.TimeOfDay;
                TimeSpan newTimeSpan = new TimeSpan(CurrentTime.Hours, CurrentTime.Minutes, 0);
                Aval.SetHora(newTimeSpan);
               
                if (tipo_op == 0)
                {
                    Aval.novo();
                    this.Close();
                }
                else
                {
                    Aval.SetIdAvaliacao(Convert.ToInt32(Id_TB.Text));
                    Aval.atualizar();
                    this.Close();
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SelecionarCliente SelecionarCli = new SelecionarCliente();
            SelecionarCli.ShowDialog();
            id_cliente= SelecionarCli.selected_id;
            nome_cliente = SelecionarCli.selected_nome;
            Cliente_TB.Text = nome_cliente;
        }
    }
}
