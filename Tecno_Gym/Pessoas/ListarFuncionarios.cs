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
    public partial class ListarFuncionarios : MetroForm
    {
        public ListarFuncionarios()
        {
            InitializeComponent();
        }

        private void ListarFuncionarios_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }


        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from funcionario ORDER BY nome", Database.Database.GetConnection());
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
            Grid_Funcionarios.Columns[11].HeaderText = "Login";
            Grid_Funcionarios.Columns[12].HeaderText = "Senha";
            Grid_Funcionarios.Columns[13].HeaderText = "Admin";
            Grid_Funcionarios.Columns[0].Visible = false;
            Grid_Funcionarios.Columns[10].Visible = false;
            Grid_Funcionarios.Columns[12].Visible = false;
        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from funcionario where lower(nome) LIKE '%" + Pesquisa_TB.Text.ToLower()+"%'", Database.Database.GetConnection());
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
            Grid_Funcionarios.Columns[11].HeaderText = "Login";
            Grid_Funcionarios.Columns[12].HeaderText = "Senha";
            Grid_Funcionarios.Columns[13].HeaderText = "Admin";
            Grid_Funcionarios.Columns[0].Visible = false;
            Grid_Funcionarios.Columns[10].Visible = false;
            Grid_Funcionarios.Columns[12].Visible = false;
        }

        private void Excluir_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDeseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (Grid_Funcionarios.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Funcionarios.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Funcionarios.Rows[selectedrowindex];

                    Funcionario Fun = new Funcionario();

                    try
                    {
                        Fun.SetIdPessoa(Convert.ToInt32(selectedRow.Cells[0].Value));
                        Fun.excluir();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir o funcionário, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione um funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            CadastrarFuncionario CadastrarF = new CadastrarFuncionario(0);
            CadastrarF.ShowDialog();
            CarregarDataGrid();
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Funcionarios.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Funcionarios.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Funcionarios.Rows[selectedrowindex];

                Funcionario Funcio = new Funcionario();

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
                Grid_Funcionarios.Columns[11].HeaderText = "Login";
                Grid_Funcionarios.Columns[12].HeaderText = "Senha";
                Grid_Funcionarios.Columns[13].HeaderText = "Admin";

                Funcio.SetIdPessoa(Convert.ToInt32(selectedRow.Cells[0].Value));
                Funcio.SetNome(Convert.ToString(selectedRow.Cells[1].Value));
                Funcio.SetSexo(Convert.ToString(selectedRow.Cells[2].Value));
                Funcio.SetCep(Convert.ToString(selectedRow.Cells[3].Value));
                Funcio.SetCpf(Convert.ToString(selectedRow.Cells[4].Value));
                Funcio.setUF(Convert.ToString(selectedRow.Cells[5].Value));
                Funcio.SetCidade(Convert.ToString(selectedRow.Cells[6].Value));
                Funcio.SetBairro(Convert.ToString(selectedRow.Cells[7].Value));
                Funcio.SetRua(Convert.ToString(selectedRow.Cells[8].Value));
                Funcio.SetEmail(Convert.ToString(selectedRow.Cells[9].Value));
                Funcio.SetTelefone(Convert.ToString(selectedRow.Cells[10].Value));
                Funcio.SetLogin(Convert.ToString(selectedRow.Cells[11].Value));
                Funcio.SetSenha(Convert.ToString(selectedRow.Cells[12].Value));
                Funcio.SetAdmin(Convert.ToBoolean(selectedRow.Cells[13].Value));

                CadastrarFuncionario CadastrarF = new CadastrarFuncionario(1, Funcio);
                CadastrarF.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma mensalidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
