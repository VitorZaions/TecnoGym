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
    public partial class SelecionarProduto : MetroForm
    {
        public int selected_id { get; private set; } = 0;
        public string selected_nome { get; private set; } = "";

        public SelecionarProduto()
        {
            InitializeComponent();
        }

        private void SelecionarProduto_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

    void CarregarDataGrid()
    {
        using (NpgsqlConnection con = Database.Database.GetConnection())
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT p.id_produto,p.descrição,p.estoque,p.valor,p.id_categoria,p.id_fornecedor,cat.nome,forne.nome from produto p INNER JOIN categoria cat ON p.id_categoria = cat.id_categoria INNER JOIN fornecedor forne ON p.id_fornecedor = forne.id_fornecedor ORDER BY p.descrição", Database.Database.GetConnection());
            DataTable myTable = new System.Data.DataTable();
            da.Fill(myTable);
            Grid_Produtos.DataSource = myTable.DefaultView;
            con.Close();
        }

        Grid_Produtos.Columns[0].HeaderText = "Id";
        Grid_Produtos.Columns[1].HeaderText = "Nome";
        Grid_Produtos.Columns[2].HeaderText = "Estoque";
        Grid_Produtos.Columns[3].HeaderText = "Valor";
        Grid_Produtos.Columns[4].HeaderText = "Id Categoria";
        Grid_Produtos.Columns[5].HeaderText = "Id Fornecedor";
        Grid_Produtos.Columns[6].HeaderText = "Categoria";
        Grid_Produtos.Columns[7].HeaderText = "Fornecedor";
        Grid_Produtos.Columns[0].Visible = false;
        Grid_Produtos.Columns[4].Visible = false;
        Grid_Produtos.Columns[5].Visible = false;

    }

    private void Nome_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Nome_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = false;
                Pesquisa_Button.Text = "🔎";
                Pesquisa_TB.Text = "";

                CarregarDataGrid();
            }
        }

        private void Fornecedor_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Fornecedor_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "🚚";
                Pesquisa_TB.Text = "";

                CarregarDataGrid();
            }
        }

        private void Categoria_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Categoria_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "📑";
                Pesquisa_TB.Text = "";

                CarregarDataGrid();
            }
        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            if (Nome_RB.Checked == true)
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    //NpgsqlDataAdapter da = new NpgsqlDataAdapter("select t.id_turma,t.descricao,f.nome,t.id_funcionario from turma t INNER JOIN funcionario f ON t.id_funcionario = f.id_funcionario where lower(descricao) LIKE '%" + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT p.id_produto,p.descrição,p.estoque,p.valor,p.id_categoria,p.id_fornecedor,cat.nome,forne.nome from produto p INNER JOIN categoria cat ON p.id_categoria = cat.id_categoria INNER JOIN fornecedor forne ON p.id_fornecedor = forne.id_fornecedor WHERE lower(descrição) LIKE '%" + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Produtos.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Produtos.Columns[0].HeaderText = "Id";
                Grid_Produtos.Columns[1].HeaderText = "Nome";
                Grid_Produtos.Columns[2].HeaderText = "Estoque";
                Grid_Produtos.Columns[3].HeaderText = "Valor";
                Grid_Produtos.Columns[4].HeaderText = "Id Categoria";
                Grid_Produtos.Columns[5].HeaderText = "Id Fornecedor";
                Grid_Produtos.Columns[6].HeaderText = "Categoria";
                Grid_Produtos.Columns[7].HeaderText = "Fornecedor";

                Grid_Produtos.Columns[0].Visible = false;
                Grid_Produtos.Columns[4].Visible = false;
                Grid_Produtos.Columns[5].Visible = false;
            }
            else if (Fornecedor_RB.Checked == true)
            {

                SelecionarFornecedor SelecionarFor = new SelecionarFornecedor();
                SelecionarFor.ShowDialog();

                int id = SelecionarFor.selected_id;
                string nome = SelecionarFor.selected_nome;

                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    //NpgsqlDataAdapter da = new NpgsqlDataAdapter("select t.id_turma,t.descricao,f.nome,t.id_funcionario from turma t INNER JOIN funcionario f ON t.id_funcionario = f.id_funcionario where lower(descricao) LIKE '%" + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT p.id_produto,p.descrição,p.estoque,p.valor,p.id_categoria,p.id_fornecedor,cat.nome,forne.nome from produto p INNER JOIN categoria cat ON p.id_categoria = cat.id_categoria INNER JOIN fornecedor forne ON p.id_fornecedor = forne.id_fornecedor WHERE p.id_fornecedor = " + id + "", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Produtos.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Produtos.Columns[0].HeaderText = "Id";
                Grid_Produtos.Columns[1].HeaderText = "Nome";
                Grid_Produtos.Columns[2].HeaderText = "Estoque";
                Grid_Produtos.Columns[3].HeaderText = "Valor";
                Grid_Produtos.Columns[4].HeaderText = "Id Categoria";
                Grid_Produtos.Columns[5].HeaderText = "Id Fornecedor";
                Grid_Produtos.Columns[6].HeaderText = "Categoria";
                Grid_Produtos.Columns[7].HeaderText = "Fornecedor";

                Grid_Produtos.Columns[0].Visible = false;
                Grid_Produtos.Columns[4].Visible = false;
                Grid_Produtos.Columns[5].Visible = false;


            }
            else // categoria
            {
                SelecionarCategoria SelecionarCat = new SelecionarCategoria();
                SelecionarCat.ShowDialog();

                int id = SelecionarCat.selected_id;
                string nome = SelecionarCat.selected_nome;

                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    //NpgsqlDataAdapter da = new NpgsqlDataAdapter("select t.id_turma,t.descricao,f.nome,t.id_funcionario from turma t INNER JOIN funcionario f ON t.id_funcionario = f.id_funcionario where lower(descricao) LIKE '%" + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT p.id_produto,p.descrição,p.estoque,p.valor,p.id_categoria,p.id_fornecedor,cat.nome,forne.nome from produto p INNER JOIN categoria cat ON p.id_categoria = cat.id_categoria INNER JOIN fornecedor forne ON p.id_fornecedor = forne.id_fornecedor WHERE p.id_categoria = " + id + "", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Produtos.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Produtos.Columns[0].HeaderText = "Id";
                Grid_Produtos.Columns[1].HeaderText = "Nome";
                Grid_Produtos.Columns[2].HeaderText = "Estoque";
                Grid_Produtos.Columns[3].HeaderText = "Valor";
                Grid_Produtos.Columns[4].HeaderText = "Id Categoria";
                Grid_Produtos.Columns[5].HeaderText = "Id Fornecedor";
                Grid_Produtos.Columns[6].HeaderText = "Categoria";
                Grid_Produtos.Columns[7].HeaderText = "Fornecedor";
                Grid_Produtos.Columns[0].Visible = false;
                Grid_Produtos.Columns[4].Visible = false;
                Grid_Produtos.Columns[5].Visible = false;

            }
        }

        private void Selecionar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Produtos.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Produtos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Produtos.Rows[selectedrowindex];
                selected_id = Convert.ToInt32(selectedRow.Cells[0].Value);
                selected_nome = Convert.ToString(selectedRow.Cells[1].Value);
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione um produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }
    }
}
