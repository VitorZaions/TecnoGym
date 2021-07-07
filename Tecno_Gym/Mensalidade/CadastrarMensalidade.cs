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

namespace Tecno_Gym.Mensalidade
{
    public partial class CadastrarMensalidade : MetroForm
    {
        int tipo_op = 0;
        int id_cliente = 0;
        string nome_cliente;
        Mensalidade MensaCame;

        public CadastrarMensalidade(int tipo)
        {
            InitializeComponent();
            tipo_op = tipo;
        }

        public CadastrarMensalidade(int tipo, Mensalidade mensalidade)
        {
            InitializeComponent();
            tipo_op = tipo;
            MensaCame = mensalidade;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(MensaCame.GetIdMensalidade());
            ValorMensalidade_TB.Text = Convert.ToString(MensaCame.GetValorMensalidade());
            DataPagamento_DT.Value = MensaCame.GetDataPagamento();
            id_cliente = Convert.ToInt32(MensaCame.GetIdCliente());
            nome_cliente = Convert.ToString(MensaCame.GetNomeCliente());            
            Cliente_TB.Text = Convert.ToString(nome_cliente);

            int status = MensaCame.GetStatus();

            if (status == 0)
                EmAberto_RB.Checked = true;
            else
                Pago_RB.Checked = true;
        }

        private void CadastrarMensalidade_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if (Cliente_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o cliente responsável pela mensalidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (ValorMensalidade_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o valor da mensalidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DataPagamento_DT.Value == null)
                MetroMessageBox.Show(this, "\n\nInsira o cnpj do fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Mensalidade Mens = new Mensalidade();
                Mens.SetDataPagamento(DataPagamento_DT.Value);
                Mens.SetIdCliente(id_cliente);

                if (EmAberto_RB.Checked == true)
                    Mens.SetStatus(0);
                else
                    Mens.SetStatus(1);

                Mens.SetValorMensalidade(Convert.ToDouble(ValorMensalidade_TB.Text));
                
                if (tipo_op == 0)
                {
                    Mens.novo();
                    this.Close();
                }
                else
                {
                    Mens.SetIdMensalidade(Convert.ToInt32(Id_TB.Text));
                    Mens.atualizar();
                    this.Close();
                }
            }


        }

        private void Cliente_TB_TextChanged(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SelecionarCliente SelecionarCli = new SelecionarCliente();
            SelecionarCli.ShowDialog();

            id_cliente = SelecionarCli.selected_id;
            nome_cliente = SelecionarCli.selected_nome;
            Cliente_TB.Text = nome_cliente;
        }

        private void ValorMensalidade_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
