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

namespace Tecno_Gym.AvaliacaoFisica
{
    public partial class ListarAvaliacoesFisicas : MetroForm
    {
        public ListarAvaliacoesFisicas()
        {
            InitializeComponent();
        }

        private void ListarAvaliacoesFisicas_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT af.id_avaliacao_fisica,c.nome,af.dia,af.hora,af.id_cliente from avaliacaofisica af INNER JOIN cliente c ON af.id_cliente = c.id_cliente ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Avaliacoes.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Avaliacoes.Columns[0].HeaderText = "Id";
            Grid_Avaliacoes.Columns[1].HeaderText = "Cliente";
            Grid_Avaliacoes.Columns[2].HeaderText = "Dia";
            Grid_Avaliacoes.Columns[3].HeaderText = "Hora";
            Grid_Avaliacoes.Columns[4].HeaderText = "Id Cliente";
            Grid_Avaliacoes.Columns[0].Visible = false;
            Grid_Avaliacoes.Columns[4].Visible = false;

        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            SelecionarCliente SelecionarCli = new SelecionarCliente();
            SelecionarCli.ShowDialog();

            int id = SelecionarCli.selected_id;
            string nome = SelecionarCli.selected_nome;


            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT af.id_avaliacao_fisica,c.nome,af.dia,af.hora,af.id_cliente from avaliacaofisica af INNER JOIN cliente c ON af.id_cliente = c.id_cliente WHERE af.id_cliente = "+id+"", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Avaliacoes.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Avaliacoes.Columns[0].HeaderText = "Id";
            Grid_Avaliacoes.Columns[1].HeaderText = "Cliente";
            Grid_Avaliacoes.Columns[2].HeaderText = "Dia";
            Grid_Avaliacoes.Columns[3].HeaderText = "Hora";
            Grid_Avaliacoes.Columns[4].HeaderText = "Id Cliente";
            Grid_Avaliacoes.Columns[0].Visible = false;
            Grid_Avaliacoes.Columns[4].Visible = false;
        }

        private void Excluir_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDeseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (Grid_Avaliacoes.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Avaliacoes.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Avaliacoes.Rows[selectedrowindex];

                    try
                    {
                        AvaliacaoFisica AvaliacaoF = new AvaliacaoFisica();
                        AvaliacaoF.SetIdAvaliacao(Convert.ToInt32(selectedRow.Cells[0].Value));
                        AvaliacaoF.excluir();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir a avaliação física, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione uma avaliação física.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            Turma.CadastroAvaliacao CadastroA = new Turma.CadastroAvaliacao(0);
            CadastroA.ShowDialog();
            CarregarDataGrid();
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Avaliacoes.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Avaliacoes.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Avaliacoes.Rows[selectedrowindex];

                AvaliacaoFisica AvalF = new AvaliacaoFisica();

                AvalF.SetIdAvaliacao(Convert.ToInt32(selectedRow.Cells[0].Value));
                AvalF.SetNomeCliente(Convert.ToString(selectedRow.Cells[1].Value));
                AvalF.SetDia(Convert.ToDateTime(selectedRow.Cells[2].Value));
                AvalF.SetHora(TimeSpan.Parse(selectedRow.Cells[3].Value.ToString()));
                AvalF.SetIdCliente(Convert.ToInt32(selectedRow.Cells[4].Value));

                Turma.CadastroAvaliacao CadastrarA = new Turma.CadastroAvaliacao(1,AvalF);
                CadastrarA.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Refresh_Button_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }
    }
}
