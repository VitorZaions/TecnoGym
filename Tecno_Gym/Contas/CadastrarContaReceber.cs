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

namespace Tecno_Gym.Contas
{
    public partial class CadastrarContaReceber : MetroForm
    {
        int tipo_op = 0;
        Contas.ContaReceber ContaCame;
        public CadastrarContaReceber(int tipo)
        {
            InitializeComponent();
            tipo_op = tipo;
        }

        public CadastrarContaReceber(int tipo, Contas.ContaReceber Conta)
        {
            InitializeComponent();
            tipo_op = tipo;
            ContaCame = Conta;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(ContaCame.GetIdConta());
            Desc_TB.Text = ContaCame.GetDescricao();
            Valor_TB.Text = Convert.ToString(ContaCame.GetValor());
            DataRecebimento_DT.Value = ContaCame.GetDataRecebimento();
            int status = ContaCame.GetStatus();

            if (status == 0)
                EmAberto_RB.Checked = true;
            else
                Pago_RB.Checked = true;
        }

        private void CadastrarContaReceber_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if (Desc_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira uma descrição para a conta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Valor_TB.Text == "" || Valor_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira o valor da conta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DataRecebimento_DT.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira a data de recebimento da conta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ContaReceber Cont = new ContaReceber();
                Cont.SetDescricao(Desc_TB.Text);
                Cont.SetValor(Convert.ToDouble(Valor_TB.Text));
                Cont.SetDataRecebimento(DataRecebimento_DT.Value);

                if (EmAberto_RB.Checked == true)
                    Cont.SetStatus(0);
                else
                    Cont.SetStatus(1);

                if (tipo_op == 0)
                {
                    Cont.novo();
                    this.Close();
                }
                else
                {
                    Cont.SetIdConta(Convert.ToInt32(Id_TB.Text));
                    Cont.atualizar();
                    this.Close();
                }
            }
        }

        private void Valor_TB_KeyPress(object sender, KeyPressEventArgs e)
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
