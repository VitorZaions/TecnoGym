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

namespace Tecno_Gym.Aula
{
    public partial class ListarAulas : MetroForm
    {
        public ListarAulas()
        {
            InitializeComponent();
        }

        private void ListarAulas_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT a.id_aula,t.descricao,a.dia,a.horario,a.id_turma from aula a INNER JOIN turma t ON a.id_turma = t.id_turma ORDER BY t.descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Aulas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Aulas.Columns[0].HeaderText = "Id";
            Grid_Aulas.Columns[1].HeaderText = "Turma";
            Grid_Aulas.Columns[2].HeaderText = "Dia";
            Grid_Aulas.Columns[3].HeaderText = "Hora";
            Grid_Aulas.Columns[4].HeaderText = "Id Turma";
            Grid_Aulas.Columns[0].Visible = false;
            Grid_Aulas.Columns[4].Visible = false;

        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            SelecionarTurma SelecionarTur = new SelecionarTurma();
            SelecionarTur.ShowDialog();

            int id = SelecionarTur.selected_id;
            string nome = SelecionarTur.selected_nome;

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT a.id_aula,t.descricao,a.dia,a.horario,a.id_turma from aula a INNER JOIN turma t ON a.id_turma = t.id_turma WHERE a.id_turma = "+id+"", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Aulas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Aulas.Columns[0].HeaderText = "Id";
            Grid_Aulas.Columns[1].HeaderText = "Turma";
            Grid_Aulas.Columns[2].HeaderText = "Dia";
            Grid_Aulas.Columns[3].HeaderText = "Hora";
            Grid_Aulas.Columns[4].HeaderText = "Id Turma";
            Grid_Aulas.Columns[0].Visible = false;
            Grid_Aulas.Columns[4].Visible = false;

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
                if (Grid_Aulas.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Aulas.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Aulas.Rows[selectedrowindex];

                    try
                    {
                        Aula Aul = new Aula();
                        Aul.SetIdAula(Convert.ToInt32(selectedRow.Cells[0].Value));
                        Aul.excluir();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir a aula, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione uma aula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            CadastrarAula CadastrarA = new CadastrarAula(0);
            CadastrarA.ShowDialog();
            CarregarDataGrid();
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Aulas.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Aulas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Aulas.Rows[selectedrowindex];

                Aula aula = new Aula();

                aula.SetIdAula(Convert.ToInt32(selectedRow.Cells[0].Value));
                aula.SetNomeTurma(Convert.ToString(selectedRow.Cells[1].Value));
                aula.SetDia(Convert.ToDateTime(selectedRow.Cells[2].Value));
                aula.SetHora(TimeSpan.Parse(selectedRow.Cells[3].Value.ToString()));
                aula.SetIdTurma(Convert.ToInt32(selectedRow.Cells[4].Value));

                CadastrarAula CadastrarA = new CadastrarAula(1, aula);
                CadastrarA.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
