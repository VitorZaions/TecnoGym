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
    public partial class SelecionarCliente : MetroForm
    {
        public int selected_id { get; private set; } = 0;
        public string selected_nome { get; private set; } = "";
        public SelecionarCliente()
        {
            InitializeComponent();
        }

        private void SelecionarCliente_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from cliente", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Clientes.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Clientes.Columns[0].HeaderText = "Id";
            Grid_Clientes.Columns[1].HeaderText = "Nome";
            Grid_Clientes.Columns[2].HeaderText = "Sexo";
            Grid_Clientes.Columns[3].HeaderText = "CEP";
            Grid_Clientes.Columns[4].HeaderText = "CPF";
            Grid_Clientes.Columns[5].HeaderText = "UF";
            Grid_Clientes.Columns[6].HeaderText = "Cidade";
            Grid_Clientes.Columns[7].HeaderText = "Bairro";
            Grid_Clientes.Columns[8].HeaderText = "Rua";
            Grid_Clientes.Columns[9].HeaderText = "E-mail";
            Grid_Clientes.Columns[10].HeaderText = "Telefone";
            Grid_Clientes.Columns[11].HeaderText = "Data de cadastro";
            Grid_Clientes.Columns[0].Visible = false;
        }

        private void Selecionar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Clientes.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Clientes.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Clientes.Rows[selectedrowindex];
                selected_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                selected_nome = Convert.ToString(selectedRow.Cells[1].Value);
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                //NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from cliente where nome LIKE '% " + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from cliente where lower(nome) LIKE '%" + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Clientes.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Clientes.Columns[0].HeaderText = "Id";
            Grid_Clientes.Columns[1].HeaderText = "Nome";
            Grid_Clientes.Columns[2].HeaderText = "Sexo";
            Grid_Clientes.Columns[3].HeaderText = "CEP";
            Grid_Clientes.Columns[4].HeaderText = "CPF";
            Grid_Clientes.Columns[5].HeaderText = "UF";
            Grid_Clientes.Columns[6].HeaderText = "Cidade";
            Grid_Clientes.Columns[7].HeaderText = "Bairro";
            Grid_Clientes.Columns[8].HeaderText = "Rua";
            Grid_Clientes.Columns[9].HeaderText = "E-mail";
            Grid_Clientes.Columns[10].HeaderText = "Telefone";
            Grid_Clientes.Columns[11].HeaderText = "Data de cadastro";
            Grid_Clientes.Columns[0].Visible = false;
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }
    }
}
