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

namespace Tecno_Gym.Turma
{
    public partial class ListarTurma : MetroForm
    {
        public ListarTurma()
        {
            InitializeComponent();
        }

        private void ListaTurma_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT t.id_turma,t.descricao,f.nome,t.id_funcionario from turma t INNER JOIN funcionario f ON t.id_funcionario = f.id_funcionario", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Turmas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Turmas.Columns[0].HeaderText = "Id";
            Grid_Turmas.Columns[1].HeaderText = "Descrição";
            Grid_Turmas.Columns[2].HeaderText = "Funcionario Responsável";
            Grid_Turmas.Columns[3].HeaderText = "Id Funcionario";
            Grid_Turmas.Columns[0].Visible = false;
            Grid_Turmas.Columns[3].Visible = false;
            // Grid_Categorias.AutoResizeColumns();
            //Grid_Categorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            if(Descricao_RB.Checked == true)
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("select t.id_turma,t.descricao,f.nome,t.id_funcionario from turma t INNER JOIN funcionario f ON t.id_funcionario = f.id_funcionario where lower(descricao) LIKE '%" + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Turmas.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Turmas.Columns[0].HeaderText = "Id";
                Grid_Turmas.Columns[1].HeaderText = "Descrição";
                Grid_Turmas.Columns[2].HeaderText = "Funcionario Responsável";
                Grid_Turmas.Columns[3].HeaderText = "Id Funcionario";
                Grid_Turmas.Columns[0].Visible = false;
                Grid_Turmas.Columns[3].Visible = false;
            }
            else // responsável
            {

                SelecionarFuncionario SelecionarFun = new SelecionarFuncionario();
                SelecionarFun.ShowDialog();

                int id = SelecionarFun.selected_id;
                string nome = SelecionarFun.selected_nome;

                
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("select t.id_turma,t.descricao,f.nome,t.id_funcionario from turma t INNER JOIN funcionario f ON t.id_funcionario = f.id_funcionario WHERE t.id_funcionario = " + id + "", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Turmas.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Turmas.Columns[0].HeaderText = "Id";
                Grid_Turmas.Columns[1].HeaderText = "Descrição";
                Grid_Turmas.Columns[2].HeaderText = "Funcionario Responsável";
                Grid_Turmas.Columns[3].HeaderText = "Id Funcionario";
                Grid_Turmas.Columns[0].Visible = false;
                Grid_Turmas.Columns[3].Visible = false;

                Pesquisa_TB.Text = nome;
            }
        }

        private void Descricao_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Descricao_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = false;
                Pesquisa_Button.Text = "🔎";
                Pesquisa_TB.Text = "";

                CarregarDataGrid();
            }
        }

        private void Responsavel_RB_CheckedChanged(object sender, EventArgs e)
        {
            if(Responsavel_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "🧑";
                Pesquisa_TB.Text = "";

                CarregarDataGrid();
            }
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
                if (Grid_Turmas.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Turmas.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Turmas.Rows[selectedrowindex];

                    Turma Tur = new Turma();
                    try
                    {
                        Tur.SetIdTurma(Convert.ToInt32(selectedRow.Cells[0].Value));
                        Tur.excluir();                        
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir a turma, pois o mesmo possuí pendências no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            CadastroTurma CadastrarT = new CadastroTurma(0);
            CadastrarT.ShowDialog();
            CarregarDataGrid();
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Turmas.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Turmas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Turmas.Rows[selectedrowindex];
                             
                Turma Tur = new Turma();

                Grid_Turmas.Columns[0].HeaderText = "Id";
                Grid_Turmas.Columns[1].HeaderText = "Descrição";
                Grid_Turmas.Columns[2].HeaderText = "Funcionario Responsável";
                Grid_Turmas.Columns[3].HeaderText = "Id Funcionario";

                Tur.SetIdTurma(Convert.ToInt32(selectedRow.Cells[0].Value));
                Tur.SetDescricao(Convert.ToString(selectedRow.Cells[1].Value));
                Tur.SetNomeFuncionario(Convert.ToString(selectedRow.Cells[2].Value));
                Tur.SetIdFuncionario(Convert.ToInt32(selectedRow.Cells[3].Value));

                CadastroTurma CadastrarT = new CadastroTurma(1,Tur);
                CadastrarT.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
