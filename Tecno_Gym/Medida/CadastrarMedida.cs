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

namespace Tecno_Gym.Medida
{
    public partial class CadastrarMedida : MetroForm
    {
        int tipo_op = 0;
        int id_cliente = 0;
        string nome_cliente;
        Medida MedCame;
        public CadastrarMedida(int tipo)
        {
            InitializeComponent();
            tipo_op = tipo;
        }

        public CadastrarMedida(int tipo,Medida Med)
        {
            InitializeComponent();
            tipo_op = tipo;
            MedCame = Med;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(MedCame.GetIdMedida());
            Cliente_TB.Text = MedCame.GetNomeCliente();
            nome_cliente = MedCame.GetNomeCliente();
            id_cliente = MedCame.GetIdCliente();
            Altura_TB.Text = Convert.ToString(MedCame.GetAltura());
            Peitoral_TB.Text = Convert.ToString(MedCame.GetPeitoral());
            BracoDir_TB.Text = Convert.ToString(MedCame.GetBrc_direito());
            BracoEsq_TB.Text = Convert.ToString(MedCame.GetBrc_esquerdo());
            PantDir_TB.Text = Convert.ToString(MedCame.GetPnt_direita());
            PantEsq_TB.Text = Convert.ToString(MedCame.GetPnt_esquerda());
            Quadril_TB.Text = Convert.ToString(MedCame.GetQuadril());
            CoxaDir_TB.Text = Convert.ToString(MedCame.GetCoxa_direita());
            CoxaEsq_TB.Text = Convert.ToString(MedCame.GetCoxa_esquerda());
            Data_DT.Value = MedCame.GetDataMedida();
        }

        private void CadastrarMedida_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if(Cliente_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira um cliente para a medida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Altura_TB.Text == "" || Altura_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira a medida altura do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Peitoral_TB.Text == "" || Peitoral_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira a medida do peitoral do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (BracoDir_TB.Text == "" || BracoDir_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira a medida do braço direito do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (BracoEsq_TB.Text == "" || BracoEsq_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira a medida do braço esquerdo do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (PantDir_TB.Text == "" || PantDir_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira a medida da panturilha direita do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (PantEsq_TB.Text == "" || PantEsq_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira a medida da panturilha esquerda do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Quadril_TB.Text == "" || Quadril_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira a medida do quadril do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (CoxaDir_TB.Text == "" || CoxaDir_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira a medida da coxa direita do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (CoxaEsq_TB.Text == "" || CoxaEsq_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira a medida da coxa esquerda do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Data_DT.Value == null)
                MetroMessageBox.Show(this, "\n\nInsira a data em que foi realizada as medidas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Medida Medi = new Medida();
            Medi.SetIdCliente(id_cliente);
            Medi.SetAltura(Convert.ToInt32(Altura_TB.Text));
            Medi.SetPeitoral(Convert.ToInt32(Peitoral_TB.Text));
            Medi.SetBrc_direito(Convert.ToInt32(BracoDir_TB.Text));
            Medi.SetBrc_esquerdo(Convert.ToInt32(BracoEsq_TB.Text));
            Medi.SetPnt_esquerda(Convert.ToInt32(PantEsq_TB.Text));
            Medi.SetPnt_direita(Convert.ToInt32(PantDir_TB.Text));
            Medi.SetQuadril(Convert.ToInt32(Quadril_TB.Text));
            Medi.SetCoxa_direita(Convert.ToInt32(CoxaDir_TB.Text));
            Medi.SetCoxa_esquerda(Convert.ToInt32(CoxaEsq_TB.Text));
            Medi.SetDataMedida(Data_DT.Value);

            if (tipo_op == 0) //novo
            {
                Medi.novo();
                this.Close();
            }
            else //att
            {
                Medi.SetIdMedida(Convert.ToInt32(Id_TB.Text));
                Medi.atualizar();
                this.Close();
            }

        }

        private void Altura_TB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Peitoral_TB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BracoDir_TB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BracoEsq_TB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PantDir_TB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PantEsq_TB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Quadril_TB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CoxaDir_TB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CoxaEsq_TB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SelecionarCliente SelecionarCli = new SelecionarCliente();
            SelecionarCli.ShowDialog();

            id_cliente = SelecionarCli.selected_id;
            nome_cliente = SelecionarCli.selected_nome;
            Cliente_TB.Text = nome_cliente;
        }
    }
}
