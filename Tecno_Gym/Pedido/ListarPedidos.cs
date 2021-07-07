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
    public partial class ListarPedidos : MetroForm
    {
        public ListarPedidos()
        {
            InitializeComponent();
        }

        private void ListarPedidos_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT p.id_pedido,p.descricao,p.data,p.valor_total,p.tipo_pagamento,c.nome, p.id_cliente from pedido p INNER JOIN cliente c ON p.id_cliente = c.id_cliente ORDER BY p.descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Pedidos.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Pedidos.Columns[0].HeaderText = "Id";
            Grid_Pedidos.Columns[1].HeaderText = "Descricao";
            Grid_Pedidos.Columns[2].HeaderText = "Data";
            Grid_Pedidos.Columns[3].HeaderText = "Valor total";
            Grid_Pedidos.Columns[4].HeaderText = "Tipo de pagamento";
            Grid_Pedidos.Columns[5].HeaderText = "Cliente";
            Grid_Pedidos.Columns[6].HeaderText = "Id do cliente";
            Grid_Pedidos.Columns[0].Visible = false;
            Grid_Pedidos.Columns[6].Visible = false;
        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            var dateTimeNow = Data_DT.Value; // Return 00/00/0000 00:00:00
            var dateOnlyString = dateTimeNow.ToShortDateString(); //Return 00/00/0000

            if (Data_RB.Checked == true)
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT p.id_pedido,p.descricao,p.data,p.valor_total,p.tipo_pagamento,c.nome, p.id_cliente from pedido p INNER JOIN cliente c ON p.id_cliente = c.id_cliente WHERE p.data = '"+dateOnlyString+"'", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Pedidos.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Pedidos.Columns[0].HeaderText = "Id";
                Grid_Pedidos.Columns[1].HeaderText = "Descricao";
                Grid_Pedidos.Columns[2].HeaderText = "Data";
                Grid_Pedidos.Columns[3].HeaderText = "Valor total";
                Grid_Pedidos.Columns[4].HeaderText = "Tipo de pagamento";
                Grid_Pedidos.Columns[5].HeaderText = "Cliente";
                Grid_Pedidos.Columns[6].HeaderText = "Id do cliente";
                Grid_Pedidos.Columns[0].Visible = false;
                Grid_Pedidos.Columns[6].Visible = false;

            }
            else if(Descricao_RB.Checked == true)
            {
                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT p.id_pedido,p.descricao,p.data,p.valor_total,p.tipo_pagamento,c.nome, p.id_cliente from pedido p INNER JOIN cliente c ON p.id_cliente = c.id_cliente WHERE lower(p.descricao) LIKE '%"+Pesquisa_TB.Text.ToLower()+"%'", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Pedidos.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Pedidos.Columns[0].HeaderText = "Id";
                Grid_Pedidos.Columns[1].HeaderText = "Descricao";
                Grid_Pedidos.Columns[2].HeaderText = "Data";
                Grid_Pedidos.Columns[3].HeaderText = "Valor total";
                Grid_Pedidos.Columns[4].HeaderText = "Tipo de pagamento";
                Grid_Pedidos.Columns[5].HeaderText = "Cliente";
                Grid_Pedidos.Columns[6].HeaderText = "Id do cliente";
                Grid_Pedidos.Columns[0].Visible = false;
                Grid_Pedidos.Columns[6].Visible = false;
            }
            else // cliente
            {
                SelecionarCliente SelecionarCli = new SelecionarCliente();
                SelecionarCli.ShowDialog();

                int id = SelecionarCli.selected_id;
                string nome = SelecionarCli.selected_nome;

                using (NpgsqlConnection con = Database.Database.GetConnection())
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT p.id_pedido,p.descricao,p.data,p.valor_total,p.tipo_pagamento,c.nome, p.id_cliente from pedido p INNER JOIN cliente c ON p.id_cliente = c.id_cliente WHERE p.id_cliente = "+id+"", Database.Database.GetConnection());
                    DataTable myTable = new System.Data.DataTable();
                    da.Fill(myTable);
                    Grid_Pedidos.DataSource = myTable.DefaultView;
                    con.Close();
                }

                Grid_Pedidos.Columns[0].HeaderText = "Id";
                Grid_Pedidos.Columns[1].HeaderText = "Descricao";
                Grid_Pedidos.Columns[2].HeaderText = "Data";
                Grid_Pedidos.Columns[3].HeaderText = "Valor total";
                Grid_Pedidos.Columns[4].HeaderText = "Tipo de pagamento";
                Grid_Pedidos.Columns[5].HeaderText = "Cliente";
                Grid_Pedidos.Columns[6].HeaderText = "Id do cliente";
                Grid_Pedidos.Columns[0].Visible = false;
                Grid_Pedidos.Columns[6].Visible = false;
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

        private void Data_RB_CheckedChanged(object sender, EventArgs e)
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

        private void Cliente_RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Cliente_RB.Checked == true)
            {
                Pesquisa_TB.Visible = true;
                Pesquisa_TB.ReadOnly = true;
                Pesquisa_Button.Text = "🧑";
                Pesquisa_TB.Text = "";
                Data_DT.Visible = false;
                Data_DT.Enabled = false;
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
                if (Grid_Pedidos.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Pedidos.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Pedidos.Rows[selectedrowindex];

                    try{
                        Pedido Ped = new Pedido();
                        Ped.SetIdPedido(Convert.ToInt32(selectedRow.Cells[0].Value));
                        Ped.excluir();
                    }catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir o pedido, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione um pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            RealizarPedido RealizarP = new RealizarPedido(0);
            RealizarP.ShowDialog();
            CarregarDataGrid();
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Pedidos.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Pedidos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Pedidos.Rows[selectedrowindex];

                Pedido Ped = new Pedido();

                Ped.SetIdPedido(Convert.ToInt32(selectedRow.Cells[0].Value));
                Ped.SetDescricao(Convert.ToString(selectedRow.Cells[1].Value));
                Ped.SetData(Convert.ToDateTime(selectedRow.Cells[2].Value));
                Ped.SetValorTotal(Convert.ToDouble(selectedRow.Cells[3].Value));
                Ped.SetTipoPagamento(Convert.ToString(selectedRow.Cells[4].Value));
                Ped.SetNomeCliente(Convert.ToString(selectedRow.Cells[5].Value));
                Ped.SetIdCliente(Convert.ToInt32(selectedRow.Cells[6].Value));

                RealizarPedido RealizarP = new RealizarPedido(1, Ped);
                RealizarP.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
