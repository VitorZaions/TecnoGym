using MetroFramework;
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

namespace Tecno_Gym.Pessoas
{
    public partial class CadastrarFuncionario : MetroForm
    {
        int tipo_op = 0;
        Funcionario FuncioCame;
        public CadastrarFuncionario(int tipo)
        {
            InitializeComponent();
            LoadUfs();
            tipo_op = tipo;
        }

        public CadastrarFuncionario(int tipo, Funcionario Funcio)
        {
            InitializeComponent();
            LoadUfs();
            tipo_op = tipo;
            FuncioCame = Funcio;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(FuncioCame.GetId_pessoa());
            Nome_TB.Text = FuncioCame.GetNome();
            Sexo_CB.Text = FuncioCame.GetSexo();
            CEP_TB.Text = FuncioCame.GetCep();
            CPF_TB.Text = FuncioCame.GetCPF();
            UF_CB.Text = FuncioCame.GetUF();
            Cidade_TB.Text = FuncioCame.GetCidade();
            Bairro_TB.Text = FuncioCame.GetBairro();
            Rua_TB.Text = FuncioCame.GetRua();
            Email_TB.Text = FuncioCame.GetEmail();
            Telefone_TB.Text = FuncioCame.GetTelefone();
            Login_TB.Text = FuncioCame.GetLogin();
            Senha_TB.Text = FuncioCame.GetSenha();
            IsAdmin_CB.Checked = FuncioCame.GetAdmin();
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
            Sexo_CB.DropDownStyle = ComboBoxStyle.DropDownList;
            UF_CB.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {

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

        private void metroTabPage6_Click(object sender, EventArgs e)
        {

        }



        private void Novo_Button_Click(object sender, EventArgs e)
        {

            if (Nome_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o nome do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (CPF_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o cpf do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Sexo_CB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o sexo do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (UF_CB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o estado do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (CEP_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o CEP do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Cidade_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira a cidade do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Bairro_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o bairro do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Rua_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira a rua do do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Email_TB.Text == "" || IsValidEmail(Email_TB.Text) == false)
                MetroMessageBox.Show(this, "\n\nInsira um email válido para o funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Telefone_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o telefone do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Login_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o login do funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Senha_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira a senha do funcionário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Funcionario Func = new Funcionario();

                Func.SetNome(Nome_TB.Text);
                Func.SetCpf(CPF_TB.Text);
                Func.SetSexo(Sexo_CB.Text);
                Func.setUF(UF_CB.Text);
                Func.SetCep(CEP_TB.Text);
                Func.SetCidade(Cidade_TB.Text);
                Func.SetBairro(Bairro_TB.Text);
                Func.SetRua(Rua_TB.Text);
                Func.SetEmail(Email_TB.Text);
                Func.SetTelefone(Telefone_TB.Text);
                Func.SetLogin(Login_TB.Text);
                Func.SetSenha(Senha_TB.Text);
                              
                if(IsAdmin_CB.Checked == true)
                    Func.SetAdmin(true);                
                else               
                    Func.SetAdmin(false);
 
                if (tipo_op == 0) // novo
                {
                    Func.novo();
                    this.Close();
                }
                else // salvar
                {
                    Func.SetIdPessoa(Convert.ToInt32(Id_TB.Text));
                    Func.atualizar();
                    this.Close();
                }
            }

        }

        private void GP_Endereco_Enter(object sender, EventArgs e)
        {

        }

        private void CPF_TB_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.CPF_TB.Text)
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

                this.CPF_TB.Text = sb.ToString();
                this.CPF_TB.SelectionStart = this.CPF_TB.Text.Length;
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
