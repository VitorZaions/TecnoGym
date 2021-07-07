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

namespace Tecno_Gym.Pedido
{
    public partial class CadastrarFornecedor : MetroForm
    {
        int tipo_op = 0;
        Fornecedor ForCame;
        public CadastrarFornecedor(int tipo)
        {
            InitializeComponent();
            tipo_op = tipo;
            LoadUfs();
        }

        public CadastrarFornecedor(int tipo, Fornecedor For)
        {
            InitializeComponent();
            tipo_op = tipo;
            ForCame = For;
            LoadUfs();
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(ForCame.GetIdFornecedor());
            Nome_TB.Text = ForCame.GetNome();
            CNPJ_TB.Text = ForCame.GetCNPJ();
            CEP_TB.Text = ForCame.GetCep();
            UF_CB.Text = ForCame.GetUF();
            UF_CB.Text = ForCame.GetUF();
            Cidade_TB.Text = ForCame.GetCidade();
            Bairro_TB.Text = ForCame.GetBairro();
            Rua_TB.Text = ForCame.GetRua();
            Email_TB.Text = ForCame.GetEmail();
            Telefone_TB.Text = ForCame.GetTelefone();
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void CadastrarFornecedor_Load(object sender, EventArgs e)
        {          
        }

        void LoadUfs()
        {
            UF_CB.Items.Add("AC");
            UF_CB.Items.Add("AL");
            UF_CB.Items.Add("AP");
            UF_CB.Items.Add("AM");
            UF_CB.Items.Add("BA");
            UF_CB.Items.Add("CE");
            UF_CB.Items.Add("DF");
            UF_CB.Items.Add("ES");
            UF_CB.Items.Add("GO");
            UF_CB.Items.Add("MA");
            UF_CB.Items.Add("MT");
            UF_CB.Items.Add("MS");
            UF_CB.Items.Add("MG");
            UF_CB.Items.Add("PA");
            UF_CB.Items.Add("PB");
            UF_CB.Items.Add("PR");
            UF_CB.Items.Add("PE");
            UF_CB.Items.Add("PI");
            UF_CB.Items.Add("RJ");
            UF_CB.Items.Add("RN");
            UF_CB.Items.Add("RS");
            UF_CB.Items.Add("RO");
            UF_CB.Items.Add("RR");
            UF_CB.Items.Add("SC");
            UF_CB.Items.Add("SP");
            UF_CB.Items.Add("SE");
            UF_CB.Items.Add("TO");
            UF_CB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Cliente_LBL_Click(object sender, EventArgs e)
        {

        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            if(CNPJ_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o cnpj do fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (Nome_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o nome do fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (UF_CB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o estado do fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (CEP_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o CEP do fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Cidade_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira a cidade do fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Bairro_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o bairro do fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Rua_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira a rua do cfornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Email_TB.Text == "" || IsValidEmail(Email_TB.Text) == false)
                MetroMessageBox.Show(this, "\n\nInsira um email válido para o fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Telefone_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o telefone do fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Fornecedor Forn = new Fornecedor();
                Forn.SetCNPJ(CNPJ_TB.Text);
                Forn.SetNome(Nome_TB.Text);
                Forn.setUF(UF_CB.Text);
                Forn.SetCep(CEP_TB.Text);
                Forn.SetCidade(Cidade_TB.Text);
                Forn.SetBairro(Bairro_TB.Text);
                Forn.SetRua(Rua_TB.Text);
                Forn.SetEmail(Email_TB.Text);
                Forn.SetTelefone(Telefone_TB.Text);


                if(tipo_op == 0)
                {
                    Forn.novo();
                    this.Close();
                }
                else
                {
                    Forn.SetIdFornecedor(Convert.ToInt32(Id_TB.Text));
                    Forn.atualizar();
                    this.Close();
                }
            }


        }

        private void CNPJ_TB_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.CNPJ_TB.Text)
            {
                if (char.IsDigit(ch))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.CNPJ_TB.Text = sb.ToString();
                this.CNPJ_TB.SelectionStart = this.CNPJ_TB.Text.Length;
            }
        }

        private void CEP_TB_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.CEP_TB.Text)
            {
                if (char.IsDigit(ch))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.CEP_TB.Text = sb.ToString();
                this.CEP_TB.SelectionStart = this.CEP_TB.Text.Length;
            }
        }

        private void Telefone_TB_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.Telefone_TB.Text)
            {
                if (char.IsDigit(ch))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.Telefone_TB.Text = sb.ToString();
                this.Telefone_TB.SelectionStart = this.Telefone_TB.Text.Length;
            }
        }
    }
}
