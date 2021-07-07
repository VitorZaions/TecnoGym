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
    public partial class SelecionarFornecedor : MetroForm
    {
        public int selected_id { get; private set; } = 0;
        public string selected_nome { get; private set; } = "";
        public SelecionarFornecedor()
        {
            InitializeComponent();
        }

        private void SelecionarFornecedor_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from fornecedor", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Fornecedores.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Fornecedores.Columns[0].HeaderText = "Id";
            Grid_Fornecedores.Columns[1].HeaderText = "Nome";
            Grid_Fornecedores.Columns[2].HeaderText = "CNPJ";
            Grid_Fornecedores.Columns[3].HeaderText = "CEP";
            Grid_Fornecedores.Columns[4].HeaderText = "UF";
            Grid_Fornecedores.Columns[5].HeaderText = "Cidade";
            Grid_Fornecedores.Columns[6].HeaderText = "Bairro";
            Grid_Fornecedores.Columns[7].HeaderText = "Rua";
            Grid_Fornecedores.Columns[8].HeaderText = "E-mail";
            Grid_Fornecedores.Columns[9].HeaderText = "Telefone";
            Grid_Fornecedores.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from fornecedor where lower(nome) LIKE '%" + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Fornecedores.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Fornecedores.Columns[0].HeaderText = "Id";
            Grid_Fornecedores.Columns[1].HeaderText = "Nome";
            Grid_Fornecedores.Columns[2].HeaderText = "CNPJ";
            Grid_Fornecedores.Columns[3].HeaderText = "CEP";
            Grid_Fornecedores.Columns[4].HeaderText = "UF";
            Grid_Fornecedores.Columns[5].HeaderText = "Cidade";
            Grid_Fornecedores.Columns[6].HeaderText = "Bairro";
            Grid_Fornecedores.Columns[7].HeaderText = "Rua";
            Grid_Fornecedores.Columns[8].HeaderText = "E-mail";
            Grid_Fornecedores.Columns[9].HeaderText = "Telefone";
            Grid_Fornecedores.Columns[0].Visible = false;
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void Selecionar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Fornecedores.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Fornecedores.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Fornecedores.Rows[selectedrowindex];
                selected_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                selected_nome = Convert.ToString(selectedRow.Cells[1].Value);
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
