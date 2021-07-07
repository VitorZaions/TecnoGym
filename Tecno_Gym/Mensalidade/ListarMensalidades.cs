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

namespace Tecno_Gym.Mensalidade
{
    public partial class ListarMensalidades : MetroForm
    {
        public ListarMensalidades()
        {
            InitializeComponent();
        }

        private void ListarMensalidades_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void ColorizeDataGrid()
        {
            foreach (DataGridViewRow dgvr in Grid_Mensalidades.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[4].Value) == 0 && Convert.ToDateTime(dgvr.Cells[3].Value) < DateTime.Today)
                {
                    dgvr.DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (Convert.ToInt32(dgvr.Cells[4].Value) == 1)
                {
                    dgvr.DefaultCellStyle.ForeColor = Color.ForestGreen;
                }
            }
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Mensalidades.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Mensalidades.Columns[0].HeaderText = "Id";
            Grid_Mensalidades.Columns[1].HeaderText = "Cliente";
            Grid_Mensalidades.Columns[2].HeaderText = "Valor mensalidade";
            Grid_Mensalidades.Columns[3].HeaderText = "Data pagamento";
            Grid_Mensalidades.Columns[4].HeaderText = "Status";
            Grid_Mensalidades.Columns[5].HeaderText = "Id Cliente";
            Grid_Mensalidades.Columns[0].Visible = false;
            Grid_Mensalidades.Columns[4].Visible = false;
            Grid_Mensalidades.Columns[5].Visible = false;
            
            ColorizeDataGrid();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (Vencidas_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "🔎";
                Pesquisa_TB.Text = "";
                CarregarDataGrid();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Cliente_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "🧑";
                Pesquisa_TB.Text = "";
                CarregarDataGrid();
            }
        }

        private void Pagas_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Pagas_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "🔎";
                Pesquisa_TB.Text = "";
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
                CarregarDataGrid();
            }
        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            var dateTimeNow = DateTime.Now; // Return 00/00/0000 00:00:00
            var dateOnlyString = dateTimeNow.ToShortDateString(); //Return 00/00/0000

            if (Cliente_RB.Checked == true)
            {
                SelecionarCliente SelecionarCli = new SelecionarCliente();
                SelecionarCli.ShowDialog();

                int id = SelecionarCli.selected_id;
                string nome = SelecionarCli.selected_nome;


                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente where m.id_cliente = " + id + "", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Mensalidades.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Mensalidades.Columns[0].HeaderText = "Id";
                Grid_Mensalidades.Columns[1].HeaderText = "Cliente";
                Grid_Mensalidades.Columns[2].HeaderText = "Valor mensalidade";
                Grid_Mensalidades.Columns[3].HeaderText = "Data pagamento";
                Grid_Mensalidades.Columns[4].HeaderText = "Status";
                Grid_Mensalidades.Columns[5].HeaderText = "Id Cliente";
                Grid_Mensalidades.Columns[0].Visible = false;
                Grid_Mensalidades.Columns[4].Visible = false;
                Grid_Mensalidades.Columns[5].Visible = false;

                Pesquisa_TB.Text = nome;
                ColorizeDataGrid();

            }
            else if (Vencidas_RB.Checked == true)
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente where m.status = 0 and m.data_pagamento < '" + dateOnlyString + "'", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Mensalidades.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Mensalidades.Columns[0].HeaderText = "Id";
                Grid_Mensalidades.Columns[1].HeaderText = "Cliente";
                Grid_Mensalidades.Columns[2].HeaderText = "Valor mensalidade";
                Grid_Mensalidades.Columns[3].HeaderText = "Data pagamento";
                Grid_Mensalidades.Columns[4].HeaderText = "Status";
                Grid_Mensalidades.Columns[5].HeaderText = "Id Cliente";
                Grid_Mensalidades.Columns[0].Visible = false;
                Grid_Mensalidades.Columns[4].Visible = false;
                Grid_Mensalidades.Columns[5].Visible = false;

                ColorizeDataGrid();

            }
            else if (Pagas_RB.Checked == true)
            {                
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente where m.status = 1", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Mensalidades.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Mensalidades.Columns[0].HeaderText = "Id";
                Grid_Mensalidades.Columns[1].HeaderText = "Cliente";
                Grid_Mensalidades.Columns[2].HeaderText = "Valor mensalidade";
                Grid_Mensalidades.Columns[3].HeaderText = "Data pagamento";
                Grid_Mensalidades.Columns[4].HeaderText = "Status";
                Grid_Mensalidades.Columns[5].HeaderText = "Id Cliente";
                Grid_Mensalidades.Columns[0].Visible = false;
                Grid_Mensalidades.Columns[4].Visible = false;
                Grid_Mensalidades.Columns[5].Visible = false;

                ColorizeDataGrid();
            }
            else //EmAberto_RB
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente where m.status = 0 and m.data_pagamento > '"+dateOnlyString+"'", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Mensalidades.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Mensalidades.Columns[0].HeaderText = "Id";
                Grid_Mensalidades.Columns[1].HeaderText = "Cliente";
                Grid_Mensalidades.Columns[2].HeaderText = "Valor mensalidade";
                Grid_Mensalidades.Columns[3].HeaderText = "Data pagamento";
                Grid_Mensalidades.Columns[4].HeaderText = "Status";
                Grid_Mensalidades.Columns[5].HeaderText = "Id Cliente";
                Grid_Mensalidades.Columns[0].Visible = false;
                Grid_Mensalidades.Columns[4].Visible = false;
                Grid_Mensalidades.Columns[5].Visible = false;

                ColorizeDataGrid();
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
                if (Grid_Mensalidades.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Mensalidades.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Mensalidades.Rows[selectedrowindex];

                    try
                    {
                        Mensalidade Mensa = new Mensalidade();
                        Mensa.SetIdMensalidade(Convert.ToInt32(selectedRow.Cells[0].Value));
                        Mensa.excluir();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir a mensalidade, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);                      
                    }

                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione uma mensalidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Mensalidades.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Mensalidades.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Mensalidades.Rows[selectedrowindex];

                Mensalidade Mensa = new Mensalidade();

                Mensa.SetIdMensalidade(Convert.ToInt32(selectedRow.Cells[0].Value));
                Mensa.SetNomeCliente(Convert.ToString(selectedRow.Cells[1].Value));
                Mensa.SetValorMensalidade(Convert.ToDouble(selectedRow.Cells[2].Value));
                Mensa.SetDataPagamento(Convert.ToDateTime(selectedRow.Cells[3].Value));
                Mensa.SetStatus(Convert.ToInt32(selectedRow.Cells[4].Value));
                Mensa.SetIdCliente(Convert.ToInt32(selectedRow.Cells[5].Value));                  

                CadastrarMensalidade CadastrarMensa = new CadastrarMensalidade(1, Mensa);
                CadastrarMensa.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma mensalidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            CadastrarMensalidade CadastrarMen = new CadastrarMensalidade(0);
            CadastrarMen.ShowDialog();
            CarregarDataGrid();
        }
    }
}
