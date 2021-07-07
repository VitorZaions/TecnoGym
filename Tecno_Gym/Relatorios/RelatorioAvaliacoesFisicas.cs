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
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MetroFramework;

namespace Tecno_Gym.Relatorios
{
    public partial class RelatorioAvaliacoesFisicas : MetroForm
    {
        int id_cliente;
        string nome_cliente;
        public RelatorioAvaliacoesFisicas()
        {
            InitializeComponent();
        }

        private void RelatorioAvaliacoesFisicas_Load(object sender, EventArgs e)
        {

        }

        void CarregarDataGridTime()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT af.id_avaliacao_fisica,c.nome,af.dia,af.hora,af.id_cliente from avaliacaofisica af INNER JOIN cliente c ON af.id_cliente = c.id_cliente WHERE dia >= '" +DataInicial_DT.Value.ToShortDateString()+"' and dia <= '"+DataFinal_DT.Value.ToShortDateString()+"' ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_AvaliacoesFisicas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_AvaliacoesFisicas.Columns[0].HeaderText = "Id";
            Grid_AvaliacoesFisicas.Columns[1].HeaderText = "Cliente";
            Grid_AvaliacoesFisicas.Columns[2].HeaderText = "Dia";
            Grid_AvaliacoesFisicas.Columns[3].HeaderText = "Hora";
            Grid_AvaliacoesFisicas.Columns[4].HeaderText = "Id Cliente";
            Grid_AvaliacoesFisicas.Columns[0].Visible = false;
            Grid_AvaliacoesFisicas.Columns[4].Visible = false;

        }

        void CarregarDataGridTimeComCliente()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT af.id_avaliacao_fisica,c.nome,af.dia,af.hora,af.id_cliente from avaliacaofisica af INNER JOIN cliente c ON af.id_cliente = c.id_cliente WHERE dia >= '" + DataInicial_DT.Value.ToShortDateString() + "' and dia <= '" + DataFinal_DT.Value.ToShortDateString() + "' AND af.id_cliente = "+id_cliente+" ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_AvaliacoesFisicas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_AvaliacoesFisicas.Columns[0].HeaderText = "Id";
            Grid_AvaliacoesFisicas.Columns[1].HeaderText = "Cliente";
            Grid_AvaliacoesFisicas.Columns[2].HeaderText = "Dia";
            Grid_AvaliacoesFisicas.Columns[3].HeaderText = "Hora";
            Grid_AvaliacoesFisicas.Columns[4].HeaderText = "Id Cliente";
            Grid_AvaliacoesFisicas.Columns[0].Visible = false;
            Grid_AvaliacoesFisicas.Columns[4].Visible = false;

        }

        void CarregarDataGridComCliente()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT af.id_avaliacao_fisica,c.nome,af.dia,af.hora,af.id_cliente from avaliacaofisica af INNER JOIN cliente c ON af.id_cliente = c.id_cliente WHERE af.id_cliente = " + id_cliente + " ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_AvaliacoesFisicas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_AvaliacoesFisicas.Columns[0].HeaderText = "Id";
            Grid_AvaliacoesFisicas.Columns[1].HeaderText = "Cliente";
            Grid_AvaliacoesFisicas.Columns[2].HeaderText = "Dia";
            Grid_AvaliacoesFisicas.Columns[3].HeaderText = "Hora";
            Grid_AvaliacoesFisicas.Columns[4].HeaderText = "Id Cliente";
            Grid_AvaliacoesFisicas.Columns[0].Visible = false;
            Grid_AvaliacoesFisicas.Columns[4].Visible = false;

        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT af.id_avaliacao_fisica,c.nome,af.dia,af.hora,af.id_cliente from avaliacaofisica af INNER JOIN cliente c ON af.id_cliente = c.id_cliente ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_AvaliacoesFisicas.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_AvaliacoesFisicas.Columns[0].HeaderText = "Id";
            Grid_AvaliacoesFisicas.Columns[1].HeaderText = "Cliente";
            Grid_AvaliacoesFisicas.Columns[2].HeaderText = "Dia";
            Grid_AvaliacoesFisicas.Columns[3].HeaderText = "Hora";
            Grid_AvaliacoesFisicas.Columns[4].HeaderText = "Id Cliente";
            Grid_AvaliacoesFisicas.Columns[0].Visible = false;
            Grid_AvaliacoesFisicas.Columns[4].Visible = false;

        }

        private void Cliente_Button_Click(object sender, EventArgs e)
        {
            SelecionarCliente SelecionarCli = new SelecionarCliente();
            SelecionarCli.ShowDialog();

            id_cliente = SelecionarCli.selected_id;
            nome_cliente = SelecionarCli.selected_nome;
            Cliente_TB.Text = nome_cliente;
        }

        private void PdfExport()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(Grid_AvaliacoesFisicas.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in Grid_AvaliacoesFisicas.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                // cell.BackgroundColor = new iTextSharp.text.color(240, 240, 240);
                //cell.BackgroundColor = new iT
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in Grid_AvaliacoesFisicas.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            try
            {
                using (FileStream stream = new FileStream(folderPath + "RelatorioAvaliacõesFísicas.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    System.Diagnostics.Process.Start("C:\\PDFs\\RelatorioAvaliacõesFísicas.pdf");
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "\n\nNão foi possível gerar o relatório, pois o arquivo de caminho está sendo usado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GerarRelatorio_Button_Click(object sender, EventArgs e)
        {
            if(Cliente_TB.Text == "")
            {
                if(Tempo_CB.Checked == true) // relatório sem cliente e com tempo
                {
                    CarregarDataGridTime();
                }
                else // relatório sem cliente e sem tempo
                {
                    CarregarDataGrid();
                }
                PdfExport();
            }
            else //relatório de todas
            {
                if (Tempo_CB.Checked == true) // relatório com cliente e com tempo
                {
                    CarregarDataGridTimeComCliente();
                }
                else // relatório com cliente e sem tempo - GERAL, DE SEMPRE
                {
                    CarregarDataGridComCliente();
                }
                PdfExport();
            }
        }

        private void Tempo_CB_CheckedChanged(object sender, EventArgs e)
        {
            if (Tempo_CB.Checked == true)
            {
                DataInicial_DT.Enabled = true;
                DataFinal_DT.Enabled = true;
            }
            else
            {
                DataInicial_DT.Enabled = false;
                DataFinal_DT.Enabled = false;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            id_cliente = 0;
            nome_cliente = "";
            Cliente_TB.Text = "";
        }
    }
}
