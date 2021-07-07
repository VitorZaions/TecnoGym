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
    public partial class CadastrarCliente : MetroForm
    {
        int tipo_op = 0;
        Cliente CliCame;
        DateTime DataCadastro;

        int id_turma;
        string nome_turma;
        public CadastrarCliente(int tipo)
        {
            InitializeComponent();
            LoadUfs();
            tipo_op = tipo;
        }


        void carregarturmas()
        {      
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT ct.id_cliente, ct.id_turma, tur.descricao from cliente_turma ct INNER JOIN turma tur ON ct.id_turma = tur.id_turma WHERE ct.id_cliente = " + CliCame.GetId_pessoa(), Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    GD_Turmas.DataSource = myTable.DefaultView;
                    con.Close();
                }

            GD_Turmas.Columns[0].HeaderText = "Id";
            GD_Turmas.Columns[1].HeaderText = "Id Turma";
            GD_Turmas.Columns[2].HeaderText = "Descricao";
            GD_Turmas.Columns[0].Visible = false;
            GD_Turmas.Columns[1].Visible = false;
        }

        public CadastrarCliente(int tipo, Cliente Cli)
        {
            InitializeComponent();
            LoadUfs();
            tipo_op = tipo;
            CliCame = Cli;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(CliCame.GetId_pessoa());
            Nome_TB.Text = CliCame.GetNome();
            Sexo_CB.Text = CliCame.GetSexo();
            CEP_TB.Text = CliCame.GetCep();
            CPF_TB.Text = CliCame.GetCPF();
            UF_CB.Text = CliCame.GetUF();
            Cidade_TB.Text = CliCame.GetCidade();
            Bairro_TB.Text = CliCame.GetBairro();
            Rua_TB.Text = CliCame.GetRua();
            Email_TB.Text = CliCame.GetEmail();
            Telefone_TB.Text = CliCame.GetTelefone();
            DataCadastro = CliCame.GetDataCadastro();
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

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            if (tipo_op == 0)
                Salvar_Button.Text = "Cadastrar";
            else
                Salvar_Button.Text = "Salvar";
        }

        private void Dados_Tab_Click(object sender, EventArgs e)
        {

        }

        private void GP_Endereco_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
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

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if(Nome_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o nome do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(CPF_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o cpf do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(Sexo_CB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o sexo do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(UF_CB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o estado do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (CEP_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o CEP do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Cidade_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira a cidade do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Bairro_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o bairro do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Rua_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira a rua do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Email_TB.Text == "" || IsValidEmail(Email_TB.Text) == false)
                MetroMessageBox.Show(this, "\n\nInsira um email válido para o cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Telefone_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o telefone do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Cliente Client = new Cliente();
                Client.SetNome(Nome_TB.Text);
                Client.SetCpf(CPF_TB.Text);
                Client.SetSexo(Sexo_CB.Text); 
                Client.setUF(UF_CB.Text);
                Client.SetCep(CEP_TB.Text);
                Client.SetCidade(Cidade_TB.Text);
                Client.SetBairro(Bairro_TB.Text);
                Client.SetRua(Rua_TB.Text);
                Client.SetEmail(Email_TB.Text);
                Client.SetTelefone(Telefone_TB.Text);
                Client.SetDataCadastro(DataCadastro);

                if (tipo_op == 0) // novo
                {
                    int id = Client.novo();
                    MetroMessageBox.Show(this, "\n\nCadastro realizado com sucesso, agora você pode adicionar turmas ao cliente.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Client.SetIdPessoa(id);
                    CliCame = Client;
                    CompletarCampos();
                    tipo_op = 1;
                    Salvar_Button.Text = "Salvar";
                }
                else // salvar
                {
                    Client.SetIdPessoa(Convert.ToInt32(Id_TB.Text));
                    Client.atualizar();
                    this.Close();
                }

            }
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

        private void metroTabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Geral_TAB_Enter(object sender, EventArgs e)
        {
            Salvar_Button.Enabled = true;
            Salvar_Button.Visible = true;
        }

        private void Turmas_TAB_Enter(object sender, EventArgs e)
        {
            Salvar_Button.Enabled = false;
            Salvar_Button.Visible = false;

            if(CliCame == null || CliCame.GetId_pessoa() == 0)
            {
                TurmaAdd_Button.Enabled = false;
                TurmaRemover_Button.Enabled = false;
                Pesquisa_Button.Enabled = false;
                //vai ser aqui                
            }
            else
            {
                TurmaAdd_Button.Enabled = true;
                TurmaRemover_Button.Enabled = true;
                Pesquisa_Button.Enabled = true;
                carregarturmas();
            }

        }

        private void Turmas_TAB_Click(object sender, EventArgs e)
        {

        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            SelecionarTurma SelecionarTur = new SelecionarTurma();
            SelecionarTur.ShowDialog();

            id_turma = SelecionarTur.selected_id;
            nome_turma = SelecionarTur.selected_nome;
            Turma_TB.Text = nome_turma;
        }

        private void TurmaAdd_Button_Click(object sender, EventArgs e)
        {
            if(Turma_TB.Text != "")
            {
                Turma.Turma Tur = new Turma.Turma();
                Tur.SetIdTurma(id_turma);

                if(Tur.CheckClienteEstaNaTurma(CliCame.GetId_pessoa()) == false)
                {
                    ClienteTurma CliT = new ClienteTurma();
                    CliT.SetIdCliente(CliCame.GetId_pessoa());
                    CliT.SetTurmaId(id_turma);
                    CliT.novo();
                    carregarturmas();                    
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nEste cliente já está nesta turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MetroMessageBox.Show(this, "\n\nInsira uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TurmaRemover_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDeseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (GD_Turmas.SelectedCells.Count > 0)
                {
                    int selectedrowindex = GD_Turmas.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = GD_Turmas.Rows[selectedrowindex];

                    ClienteTurma CliT = new ClienteTurma();                      
                    try
                    {
                        CliT.SetIdCliente(CliCame.GetId_pessoa());
                        CliT.SetTurmaId(Convert.ToInt32(selectedRow.Cells[1].Value));
                        CliT.excluir();
                        carregarturmas();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir o cliente da turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
