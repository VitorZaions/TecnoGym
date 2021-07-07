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
    public partial class SelecionarCategoria : MetroForm
    {
        public int selected_id { get; private set; } = 0;
        public string selected_nome { get; private set; } = "";
        public SelecionarCategoria()
        {
            InitializeComponent();
            CarregarDataGrid();
        }

        private void SelecionarCategoria_Load(object sender, EventArgs e)
        {
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from categoria", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Categorias.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Categorias.Columns[0].HeaderText = "Id";
            Grid_Categorias.Columns[1].HeaderText = "Nome";
            Grid_Categorias.Columns[0].Visible = false;

        }

        private void Selecionar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Categorias.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Categorias.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Categorias.Rows[selectedrowindex];
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
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from categoria where lower(nome) LIKE '%" + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Categorias.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Categorias.Columns[0].HeaderText = "Id";
            Grid_Categorias.Columns[1].HeaderText = "Nome";
            Grid_Categorias.Columns[0].Visible = false;
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }
    }
}
