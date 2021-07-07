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
    public partial class ListarFornecedores : MetroForm
    {
        public ListarFornecedores()
        {
            InitializeComponent();
        }

        private void ListasFornecedores_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from fornecedor ORDER BY nome", Database.Database.GetConnection());
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

        private void Pesquisa_Button_Click(object sender, EventArgs e)
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

        private void Excluir_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDeseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (Grid_Fornecedores.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Fornecedores.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Fornecedores.Rows[selectedrowindex];

                    Fornecedor For = new Fornecedor();

                    try
                    {
                        For.SetIdFornecedor(Convert.ToInt32(selectedRow.Cells[0].Value));
                        For.excluir();
                    }
                    catch
                    {                       
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir o fornecedor, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione um fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            CadastrarFornecedor CadastrarF = new CadastrarFornecedor(0);
            CadastrarF.ShowDialog();
            CarregarDataGrid();
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {

            if (Grid_Fornecedores.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Fornecedores.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Fornecedores.Rows[selectedrowindex];

                Fornecedor For = new Fornecedor();

                For.SetIdFornecedor(Convert.ToInt32(selectedRow.Cells[0].Value));
                For.SetNome(Convert.ToString(selectedRow.Cells[1].Value));
                For.SetCNPJ(Convert.ToString(selectedRow.Cells[2].Value));
                For.SetCep(Convert.ToString(selectedRow.Cells[3].Value));
                For.setUF(Convert.ToString(selectedRow.Cells[4].Value));
                For.SetCidade(Convert.ToString(selectedRow.Cells[5].Value));
                For.SetBairro(Convert.ToString(selectedRow.Cells[6].Value));
                For.SetRua(Convert.ToString(selectedRow.Cells[7].Value));
                For.SetEmail(Convert.ToString(selectedRow.Cells[8].Value));
                For.SetTelefone(Convert.ToString(selectedRow.Cells[9].Value));

                CadastrarFornecedor CadastrarF = new CadastrarFornecedor(1,For);                
                CadastrarF.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
