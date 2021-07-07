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
    public partial class ListarProdutos : MetroForm
    {
        public ListarProdutos()
        {
            InitializeComponent();
        }

        private void ListarProdutos_Load(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
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
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT p.id_produto,p.descrição,p.estoque,p.valor,p.id_categoria,p.id_fornecedor,cat.nome,forne.nome from produto p INNER JOIN categoria cat ON p.id_categoria = cat.id_categoria INNER JOIN fornecedor forne ON p.id_fornecedor = forne.id_fornecedor WHERE p.id_fornecedor = " + id+"", Database.Database.GetConnection());
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

        private void Excluir_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDeseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (Grid_Produtos.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Produtos.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Produtos.Rows[selectedrowindex];

                    try
                    {
                        Produto Prod = new Produto();
                        Prod.SetIdProduto(Convert.ToInt32(selectedRow.Cells[0].Value));
                        Prod.excluir();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nErro ao excluir o produto, pois o mesmo possuí pendências no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione um produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            CadastrarProduto CadastrarP = new CadastrarProduto(0);
            CadastrarP.ShowDialog();
            CarregarDataGrid();
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Produtos.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Produtos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Produtos.Rows[selectedrowindex];

                Produto Prod = new Produto();

                Prod.SetIdProduto(Convert.ToInt32(selectedRow.Cells[0].Value));
                Prod.SetDescricao(Convert.ToString(selectedRow.Cells[1].Value));
                Prod.SetEstoque(Convert.ToInt32(selectedRow.Cells[2].Value));
                Prod.SetValor(Convert.ToDouble(selectedRow.Cells[3].Value));
                Prod.SetCategoria(Convert.ToInt32(selectedRow.Cells[4].Value));
                Prod.SetFornecedor(Convert.ToInt32(selectedRow.Cells[5].Value));
                Prod.SetNomeCategoria(Convert.ToString(selectedRow.Cells[6].Value));
                Prod.SetNomeFornecedor(Convert.ToString(selectedRow.Cells[7].Value));

                CadastrarProduto CadastrarP = new CadastrarProduto(1, Prod);
                CadastrarP.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
