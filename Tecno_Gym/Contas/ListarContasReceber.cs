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

namespace Tecno_Gym.Contas
{
    public partial class ListarContasReceber : MetroForm
    {
        public ListarContasReceber()
        {
            InitializeComponent();
        }

        private void ListarContasReceber_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }


        void ColorizeDataGrid()
        {
            foreach (DataGridViewRow dgvr in Grid_ContaReceber.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[3].Value) == 0 && Convert.ToDateTime(dgvr.Cells[4].Value) < DateTime.Today)
                {
                    dgvr.DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (Convert.ToInt32(dgvr.Cells[3].Value) == 1)
                {
                    dgvr.DefaultCellStyle.ForeColor = Color.ForestGreen;
                }
            }
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_receber ORDER BY descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_ContaReceber.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_ContaReceber.Columns[0].HeaderText = "Id";
            Grid_ContaReceber.Columns[1].HeaderText = "Descricao";
            Grid_ContaReceber.Columns[2].HeaderText = "Valor";
            Grid_ContaReceber.Columns[3].HeaderText = "Status";
            Grid_ContaReceber.Columns[4].HeaderText = "Data recebimento";

            Grid_ContaReceber.Columns[0].Visible = false;
            Grid_ContaReceber.Columns[3].Visible = false;

            ColorizeDataGrid();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Data_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "📅";
                Pesquisa_TB.Text = "";
                Data_DT.Visible = true;
                Data_DT.Enabled = true;
                CarregarDataGrid();
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
                Data_DT.Visible = false;
                Data_DT.Enabled = false;
                CarregarDataGrid();
            }
        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            var dateTimeNow = Data_DT.Value; // Return 00/00/0000 00:00:00
            var dateOnlyString = dateTimeNow.ToShortDateString(); //Return 00/00/0000

            if (Data_RB.Checked == true)
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_receber WHERE data_recebimento = '" + dateOnlyString + "'", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_ContaReceber.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_ContaReceber.Columns[0].HeaderText = "Id";
                Grid_ContaReceber.Columns[1].HeaderText = "Descricao";
                Grid_ContaReceber.Columns[2].HeaderText = "Valor";
                Grid_ContaReceber.Columns[3].HeaderText = "Status";
                Grid_ContaReceber.Columns[4].HeaderText = "Data recebimento";

                Grid_ContaReceber.Columns[0].Visible = false;
                Grid_ContaReceber.Columns[3].Visible = false;

                ColorizeDataGrid();
            }
            else if (Pago_RB.Checked == true)
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_receber WHERE status = 1", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_ContaReceber.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_ContaReceber.Columns[0].HeaderText = "Id";
                Grid_ContaReceber.Columns[1].HeaderText = "Descricao";
                Grid_ContaReceber.Columns[2].HeaderText = "Valor";
                Grid_ContaReceber.Columns[3].HeaderText = "Status";
                Grid_ContaReceber.Columns[4].HeaderText = "data_recebimento";

                Grid_ContaReceber.Columns[0].Visible = false;
                Grid_ContaReceber.Columns[3].Visible = false;

                ColorizeDataGrid();
            }
            else if (Vencido_RB.Checked == true)
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_receber WHERE status = 0 AND data_recebimento < '" + dateOnlyString + "'", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_ContaReceber.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_ContaReceber.Columns[0].HeaderText = "Id";
                Grid_ContaReceber.Columns[1].HeaderText = "Descricao";
                Grid_ContaReceber.Columns[2].HeaderText = "Valor";
                Grid_ContaReceber.Columns[3].HeaderText = "Status";
                Grid_ContaReceber.Columns[4].HeaderText = "Data recebimento";

                Grid_ContaReceber.Columns[0].Visible = false;
                Grid_ContaReceber.Columns[3].Visible = false;

                ColorizeDataGrid();
            }
            else if (EmAberto_RB.Checked == true)
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_receber WHERE status = 0 AND data_recebimento > '" + dateOnlyString + "'", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_ContaReceber.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_ContaReceber.Columns[0].HeaderText = "Id";
                Grid_ContaReceber.Columns[1].HeaderText = "Descricao";
                Grid_ContaReceber.Columns[2].HeaderText = "Valor";
                Grid_ContaReceber.Columns[3].HeaderText = "Status";
                Grid_ContaReceber.Columns[4].HeaderText = "Data recebimento";

                Grid_ContaReceber.Columns[0].Visible = false;
                Grid_ContaReceber.Columns[3].Visible = false;

                ColorizeDataGrid();
            }
            else // descrição
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_receber WHERE lower(descricao) LIKE '%" + Pesquisa_TB.Text.ToLower() + "%'", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_ContaReceber.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_ContaReceber.Columns[0].HeaderText = "Id";
                Grid_ContaReceber.Columns[1].HeaderText = "Descricao";
                Grid_ContaReceber.Columns[2].HeaderText = "Valor";
                Grid_ContaReceber.Columns[3].HeaderText = "Status";
                Grid_ContaReceber.Columns[4].HeaderText = "Data recebimento";

                Grid_ContaReceber.Columns[0].Visible = false;
                Grid_ContaReceber.Columns[3].Visible = false;

                ColorizeDataGrid();
            }
        }

        private void Refresh_Button_Click_1(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Pago_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "🔎";
                Pesquisa_TB.Text = "";
                Data_DT.Visible = false;
                Data_DT.Enabled = false;
                CarregarDataGrid();
            }
        }

        private void EmAberto_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (EmAberto_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "🔎";
                Pesquisa_TB.Text = "";
                Data_DT.Visible = false;
                Data_DT.Enabled = false;
                CarregarDataGrid();
            }
        }

        private void Vencido_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Vencido_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "🔎";
                Pesquisa_TB.Text = "";
                Data_DT.Visible = false;
                Data_DT.Enabled = false;
                CarregarDataGrid();
            }
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_ContaReceber.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_ContaReceber.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_ContaReceber.Rows[selectedrowindex];

                Contas.ContaReceber ContaRec = new Contas.ContaReceber();

                ContaRec.SetIdConta(Convert.ToInt32(selectedRow.Cells[0].Value));
                ContaRec.SetDescricao(Convert.ToString(selectedRow.Cells[1].Value));
                ContaRec.SetValor(Convert.ToDouble(selectedRow.Cells[2].Value));
                ContaRec.SetStatus(Convert.ToInt32(selectedRow.Cells[3].Value));
                ContaRec.SetDataRecebimento(Convert.ToDateTime(selectedRow.Cells[4].Value));

                Contas.CadastrarContaReceber CadastrarCP = new Contas.CadastrarContaReceber(1, ContaRec);
                CadastrarCP.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Excluir_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDeseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (Grid_ContaReceber.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_ContaReceber.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_ContaReceber.Rows[selectedrowindex];

                    try
                    {
                        Contas.ContaReceber ContaRec = new Contas.ContaReceber();
                        ContaRec.SetIdConta(Convert.ToInt32(selectedRow.Cells[0].Value));
                        ContaRec.excluir();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir a conta, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione uma conta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            Contas.CadastrarContaReceber CadastrarCR = new Contas.CadastrarContaReceber(0);
            CadastrarCR.ShowDialog();
            CarregarDataGrid();
        }
    }
    }
