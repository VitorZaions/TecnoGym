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

namespace Tecno_Gym.Matricula
{
    public partial class ListarMatriculas : MetroForm
    {
        public ListarMatriculas()
        {
            InitializeComponent();
        }

        private void ListarMatriculas_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_matricula,c.nome,m.data_inicial,m.data_final,m.id_cliente from matricula m INNER JOIN cliente c ON m.id_cliente = c.id_cliente ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Matriculas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Matriculas.Columns[0].HeaderText = "Id";
            Grid_Matriculas.Columns[1].HeaderText = "Cliente";
            Grid_Matriculas.Columns[2].HeaderText = "Data inicial";
            Grid_Matriculas.Columns[3].HeaderText = "Data final";
            Grid_Matriculas.Columns[4].HeaderText = "Id Cliente";
            Grid_Matriculas.Columns[0].Visible = false;
            Grid_Matriculas.Columns[4].Visible = false;
        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            SelecionarCliente SelecionarCli = new SelecionarCliente();
            SelecionarCli.ShowDialog();

            int id = SelecionarCli.selected_id;
            string nome = SelecionarCli.selected_nome;


            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_matricula,c.nome,m.data_inicial,m.data_final,m.id_cliente from matricula m INNER JOIN cliente c ON m.id_cliente = c.id_cliente WHERE m.id_cliente = "+id+"", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Matriculas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Matriculas.Columns[0].HeaderText = "Id";
            Grid_Matriculas.Columns[1].HeaderText = "Cliente";
            Grid_Matriculas.Columns[2].HeaderText = "Data inicial";
            Grid_Matriculas.Columns[3].HeaderText = "Data final";
            Grid_Matriculas.Columns[4].HeaderText = "Id Cliente";
            Grid_Matriculas.Columns[0].Visible = false;
            Grid_Matriculas.Columns[4].Visible = false;

            Pesquisa_TB.Text = nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void Excluir_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDeseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (Grid_Matriculas.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Matriculas.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Matriculas.Rows[selectedrowindex];

                    try
                    {
                        Matricula Matricul = new Matricula();
                        Matricul.SetIdMatricula(Convert.ToInt32(selectedRow.Cells[0].Value));
                        Matricul.excluir();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir a matrícula, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione uma matrícula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            RealizarMatricula RMatricula = new RealizarMatricula(0);
            RMatricula.ShowDialog();
            CarregarDataGrid();
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
           /* if (Grid_Matriculas.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Matriculas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Matriculas.Rows[selectedrowindex];

               // AvaliacaoFisica AvalF = new AvaliacaoFisica();
                Matricula Mat = new Matricula();

                Grid_Matriculas.Columns[0].HeaderText = "Id";
                Grid_Matriculas.Columns[1].HeaderText = "Cliente";
                Grid_Matriculas.Columns[2].HeaderText = "Data inicial";
                Grid_Matriculas.Columns[3].HeaderText = "Data final";
                Grid_Matriculas.Columns[4].HeaderText = "Id Cliente";

                Mat.SetIdMatricula(Convert.ToInt32(selectedRow.Cells[0].Value));
                Mat.SetNomeCliente(Convert.ToString(selectedRow.Cells[1].Value));
                Mat.SetDataInicial(Convert.ToDateTime(selectedRow.Cells[2].Value));
                Mat.SetDataFinal(Convert.ToDateTime(selectedRow.Cells[3].Value));
                Mat.SetIdCliente(Convert.ToInt32(selectedRow.Cells[4].Value));


                RealizarMatricula RealizarMat = new RealizarMatricula(1, Mat);
                RealizarMat.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }
    }
}
