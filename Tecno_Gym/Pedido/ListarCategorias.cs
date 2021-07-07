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

namespace Tecno_Gym.Pedido
{
    public partial class ListarCategorias : MetroForm
    {
        public ListarCategorias()
        {
            InitializeComponent();
        }

        private void ListarCategorias_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from categoria ORDER BY nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Categorias.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Categorias.Columns[0].HeaderText = "Id";
            Grid_Categorias.Columns[1].HeaderText = "Nome";
            Grid_Categorias.Columns[0].Visible = false;

        }

        private void Grid_Categorias_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn Coluna in Grid_Categorias.Columns)
            {
                Coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
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

        private void Excluir_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDeseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (Grid_Categorias.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Categorias.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Categorias.Rows[selectedrowindex];

                    Categoria Cat = new Categoria();

                    try
                    {
                        Cat.SetIdCategoria(Convert.ToInt32(selectedRow.Cells[0].Value));
                        Cat.excluir();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir a categoria, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                    }

                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione uma categoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            CadastrarCategoria CadastrarC = new CadastrarCategoria(0);
            CadastrarC.ShowDialog();
            CarregarDataGrid();
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Categorias.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Categorias.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Categorias.Rows[selectedrowindex];

                Categoria Cat = new Categoria();

                Cat.SetIdCategoria(Convert.ToInt32(selectedRow.Cells[0].Value));
                Cat.SetNome(Convert.ToString(selectedRow.Cells[1].Value));

                CadastrarCategoria CadastrarC = new CadastrarCategoria(1,Cat);
                CadastrarC.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
