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

namespace Tecno_Gym
{
    public partial class SelecionarFuncionario : MetroForm
    {

        public int selected_id {get; private set;} = 0;
        public string selected_nome { get; private set; } = "";

        public SelecionarFuncionario()
        {
            InitializeComponent();
        }

        private void SelecionarFuncionario_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from funcionario", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Funcionarios.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Funcionarios.Columns[0].HeaderText = "Id";
            Grid_Funcionarios.Columns[1].HeaderText = "Nome";
            Grid_Funcionarios.Columns[2].HeaderText = "Sexo";
            Grid_Funcionarios.Columns[3].HeaderText = "CEP";
            Grid_Funcionarios.Columns[4].HeaderText = "CPF";
            Grid_Funcionarios.Columns[5].HeaderText = "UF";
            Grid_Funcionarios.Columns[6].HeaderText = "Cidade";
            Grid_Funcionarios.Columns[7].HeaderText = "Bairro";
            Grid_Funcionarios.Columns[8].HeaderText = "Rua";
            Grid_Funcionarios.Columns[9].HeaderText = "E-mail";
            Grid_Funcionarios.Columns[10].HeaderText = "Telefone";
            Grid_Funcionarios.Columns[10].HeaderText = "Login";
            Grid_Funcionarios.Columns[10].HeaderText = "Senha";
            Grid_Funcionarios.Columns[11].HeaderText = "Admin";
            Grid_Funcionarios.Columns[0].Visible = false;
            Grid_Funcionarios.Columns[10].Visible = false;
            Grid_Funcionarios.Columns[11].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from funcionario where lower(nome) LIKE '%" + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Funcionarios.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Funcionarios.Columns[0].HeaderText = "Id";
            Grid_Funcionarios.Columns[1].HeaderText = "Nome";
            Grid_Funcionarios.Columns[2].HeaderText = "Sexo";
            Grid_Funcionarios.Columns[3].HeaderText = "CEP";
            Grid_Funcionarios.Columns[4].HeaderText = "CPF";
            Grid_Funcionarios.Columns[5].HeaderText = "UF";
            Grid_Funcionarios.Columns[6].HeaderText = "Cidade";
            Grid_Funcionarios.Columns[7].HeaderText = "Bairro";
            Grid_Funcionarios.Columns[8].HeaderText = "Rua";
            Grid_Funcionarios.Columns[9].HeaderText = "E-mail";
            Grid_Funcionarios.Columns[10].HeaderText = "Telefone";
            Grid_Funcionarios.Columns[10].HeaderText = "Login";
            Grid_Funcionarios.Columns[10].HeaderText = "Senha";
            Grid_Funcionarios.Columns[11].HeaderText = "Admin";
            Grid_Funcionarios.Columns[0].Visible = false;
            Grid_Funcionarios.Columns[10].Visible = false;
            Grid_Funcionarios.Columns[11].Visible = false;
        }

        private void Selecionar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Funcionarios.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Funcionarios.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Funcionarios.Rows[selectedrowindex];
                selected_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                selected_nome = Convert.ToString(selectedRow.Cells[1].Value);
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }
    }
}
