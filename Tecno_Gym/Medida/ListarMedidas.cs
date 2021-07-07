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

namespace Tecno_Gym.Medida
{
    public partial class ListarMedidas : MetroForm
    {
        public ListarMedidas()
        {
            InitializeComponent();
        }

        private void ListaMedidas_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT med.id_medida,c.nome,med.altura,med.peitoral,med.brc_esquerdo,med.brc_direito,med.pnt_direita,med.pnt_esquerda,med.quadril,med.coxa_direita,med.coxa_esquerda,med.data_medida,med.id_cliente from medida med INNER JOIN cliente c ON med.id_cliente = c.id_cliente ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Medidas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Medidas.Columns[0].HeaderText = "Id";
            Grid_Medidas.Columns[1].HeaderText = "Cliente";
            Grid_Medidas.Columns[2].HeaderText = "Altura";
            Grid_Medidas.Columns[3].HeaderText = "Peitoral";
            Grid_Medidas.Columns[4].HeaderText = "Braço esquerdo";
            Grid_Medidas.Columns[5].HeaderText = "Braço direito";
            Grid_Medidas.Columns[6].HeaderText = "Panturilha direita";
            Grid_Medidas.Columns[7].HeaderText = "Panturilha esquerda";
            Grid_Medidas.Columns[8].HeaderText = "Quadril";
            Grid_Medidas.Columns[9].HeaderText = "Coxa direita";
            Grid_Medidas.Columns[10].HeaderText = "Coxa esquerda";
            Grid_Medidas.Columns[11].HeaderText = "Data da medida";
            Grid_Medidas.Columns[12].HeaderText = "Id Cliente";

            Grid_Medidas.Columns[0].Visible = false;
            Grid_Medidas.Columns[12].Visible = false;
            //Grid_Medidas.Columns[].Visible = false;
            // Grid_Categorias.AutoResizeColumns();
            //Grid_Categorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            SelecionarCliente SelecionarCli = new SelecionarCliente();
            SelecionarCli.ShowDialog();

            int id = SelecionarCli.selected_id;
            string nome = SelecionarCli.selected_nome;

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT med.id_medida,c.nome,med.altura,med.peitoral,med.brc_esquerdo,med.brc_direito,med.pnt_direita,med.pnt_esquerda,med.quadril,med.coxa_direita,med.coxa_esquerda,med.data_medida,med.id_cliente from medida med INNER JOIN cliente c ON med.id_cliente = c.id_cliente WHERE med.id_cliente = "+id+"", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Medidas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Medidas.Columns[0].HeaderText = "Id";
            Grid_Medidas.Columns[1].HeaderText = "Cliente";
            Grid_Medidas.Columns[2].HeaderText = "Altura";
            Grid_Medidas.Columns[3].HeaderText = "Peitoral";
            Grid_Medidas.Columns[4].HeaderText = "Braço esquerdo";
            Grid_Medidas.Columns[5].HeaderText = "Braço direito";
            Grid_Medidas.Columns[6].HeaderText = "Panturilha direita";
            Grid_Medidas.Columns[7].HeaderText = "Panturilha esquerda";
            Grid_Medidas.Columns[8].HeaderText = "Quadril";
            Grid_Medidas.Columns[9].HeaderText = "Coxa direita";
            Grid_Medidas.Columns[10].HeaderText = "Coxa esquerda";
            Grid_Medidas.Columns[11].HeaderText = "Data da medida";
            Grid_Medidas.Columns[12].HeaderText = "Id Cliente";

            Grid_Medidas.Columns[0].Visible = false;
            Grid_Medidas.Columns[12].Visible = false;

            Pesquisa_TB.Text = nome;

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
                if (Grid_Medidas.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Medidas.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Medidas.Rows[selectedrowindex];
                    
                    try
                    {
                        Medida Med = new Medida();
                        Med.SetIdMedida(Convert.ToInt32(selectedRow.Cells[0].Value));
                        Med.excluir();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "\n\nNão foi possível excluir a medida, pois há pendências do mesmo no sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    CarregarDataGrid();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione uma medida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Novo_Button_Click(object sender, EventArgs e)
        {
            CadastrarMedida CadastrarM = new CadastrarMedida(0);
            CadastrarM.ShowDialog();
            CarregarDataGrid();
        }

        private void Comparar_Button_Click(object sender, EventArgs e)
        {            

            var selectedRows = Grid_Medidas.SelectedRows
          .OfType<DataGridViewRow>()
          .Where(row => !row.IsNewRow)
          .ToArray();

            Medida Med1 = new Medida();
            Medida Med2 = new Medida();

            if (Grid_Medidas.SelectedCells.Count == 26)
            {
                Med1.SetIdMedida(Convert.ToInt32(selectedRows[0].Cells[0].Value));
                Med1.SetNomeCliente(Convert.ToString(selectedRows[0].Cells[1].Value));
                Med1.SetAltura(Convert.ToDouble(selectedRows[0].Cells[2].Value));
                Med1.SetPeitoral(Convert.ToDouble(selectedRows[0].Cells[3].Value));
                Med1.SetBrc_esquerdo(Convert.ToDouble(selectedRows[0].Cells[4].Value));
                Med1.SetBrc_direito(Convert.ToDouble(selectedRows[0].Cells[5].Value));
                Med1.SetPnt_direita(Convert.ToDouble(selectedRows[0].Cells[6].Value));
                Med1.SetPnt_esquerda(Convert.ToDouble(selectedRows[0].Cells[7].Value));
                Med1.SetQuadril(Convert.ToDouble(selectedRows[0].Cells[8].Value));
                Med1.SetCoxa_direita(Convert.ToDouble(selectedRows[0].Cells[9].Value));
                Med1.SetCoxa_esquerda(Convert.ToDouble(selectedRows[0].Cells[10].Value));
                Med1.SetDataMedida(Convert.ToDateTime(selectedRows[0].Cells[11].Value));
                Med1.SetIdCliente(Convert.ToInt32(selectedRows[0].Cells[12].Value));


                Med2.SetIdMedida(Convert.ToInt32(selectedRows[1].Cells[0].Value));
                Med2.SetNomeCliente(Convert.ToString(selectedRows[1].Cells[1].Value));
                Med2.SetAltura(Convert.ToDouble(selectedRows[1].Cells[2].Value));
                Med2.SetPeitoral(Convert.ToDouble(selectedRows[1].Cells[3].Value));
                Med2.SetBrc_esquerdo(Convert.ToDouble(selectedRows[1].Cells[4].Value));
                Med2.SetBrc_direito(Convert.ToDouble(selectedRows[1].Cells[5].Value));
                Med2.SetPnt_direita(Convert.ToDouble(selectedRows[1].Cells[6].Value));
                Med2.SetPnt_esquerda(Convert.ToDouble(selectedRows[1].Cells[7].Value));
                Med2.SetQuadril(Convert.ToDouble(selectedRows[1].Cells[8].Value));
                Med2.SetCoxa_direita(Convert.ToDouble(selectedRows[1].Cells[9].Value));
                Med2.SetCoxa_esquerda(Convert.ToDouble(selectedRows[1].Cells[10].Value));
                Med2.SetDataMedida(Convert.ToDateTime(selectedRows[1].Cells[11].Value));
                Med2.SetIdCliente(Convert.ToInt32(selectedRows[1].Cells[12].Value));

                Avaliacao_Fisica.CompararMedidas CompararA = new Avaliacao_Fisica.CompararMedidas(Med1, Med2);
                CompararA.Show();    
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione 2 medidas por vez.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Editar_Button_Click(object sender, EventArgs e)
        {
            if (Grid_Medidas.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Medidas.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Medidas.Rows[selectedrowindex];

                Medida Med = new Medida();

                Med.SetIdMedida(Convert.ToInt32(selectedRow.Cells[0].Value));
                Med.SetNomeCliente(Convert.ToString(selectedRow.Cells[1].Value));
                Med.SetAltura(Convert.ToDouble(selectedRow.Cells[2].Value));
                Med.SetPeitoral(Convert.ToDouble(selectedRow.Cells[3].Value));
                Med.SetBrc_esquerdo(Convert.ToDouble(selectedRow.Cells[4].Value));
                Med.SetBrc_direito(Convert.ToDouble(selectedRow.Cells[5].Value));
                Med.SetPnt_direita(Convert.ToDouble(selectedRow.Cells[6].Value));
                Med.SetPnt_esquerda(Convert.ToDouble(selectedRow.Cells[7].Value));
                Med.SetQuadril(Convert.ToDouble(selectedRow.Cells[8].Value));
                Med.SetCoxa_direita(Convert.ToDouble(selectedRow.Cells[9].Value));
                Med.SetCoxa_esquerda(Convert.ToDouble(selectedRow.Cells[10].Value));
                Med.SetDataMedida(Convert.ToDateTime(selectedRow.Cells[11].Value));
                Med.SetIdCliente(Convert.ToInt32(selectedRow.Cells[12].Value));

                CadastrarMedida CadastrarMed = new CadastrarMedida(1,Med);
                CadastrarMed.ShowDialog();
                CarregarDataGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione uma turma.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
