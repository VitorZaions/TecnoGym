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
    public partial class ListarClientes : MetroForm
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from cliente ORDER BY nome", Database.Database.GetConnection());
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

        private void Pesquisa_Button_Click(object sender, EventArgs e)
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

        private void Excluir_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDeseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (Grid_Clientes.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Clientes.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Clientes.Rows[selectedrowindex];

                    Cliente Cli = new Cliente();

                    try
                    {
                        Cli.SetIdPessoa(Convert.ToInt32(selectedRow.Cells[0].Value));
                        Cli.excluir();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir o cliente, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                     
                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione um cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            CadastrarCliente CadastrarC = new CadastrarCliente(0);
            CadastrarC.ShowDialog();
            CarregarDataGrid();
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Clientes.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Clientes.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Clientes.Rows[selectedrowindex];

                Cliente Cli = new Cliente();

                Cli.SetIdPessoa(Convert.ToInt32(selectedRow.Cells[0].Value));
                Cli.SetNome(Convert.ToString(selectedRow.Cells[1].Value));
                Cli.SetSexo(Convert.ToString(selectedRow.Cells[2].Value));
                Cli.SetCep(Convert.ToString(selectedRow.Cells[3].Value));
                Cli.SetCpf(Convert.ToString(selectedRow.Cells[4].Value));
                Cli.setUF(Convert.ToString(selectedRow.Cells[5].Value));
                Cli.SetCidade(Convert.ToString(selectedRow.Cells[6].Value));
                Cli.SetBairro(Convert.ToString(selectedRow.Cells[7].Value));
                Cli.SetRua(Convert.ToString(selectedRow.Cells[8].Value));
                Cli.SetEmail(Convert.ToString(selectedRow.Cells[9].Value));
                Cli.SetTelefone(Convert.ToString(selectedRow.Cells[10].Value));
                Cli.SetDataCadastro(Convert.ToDateTime(selectedRow.Cells[11].Value));

                CadastrarCliente CadastrarC = new CadastrarCliente(1,Cli);
                CadastrarC.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma mensalidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
