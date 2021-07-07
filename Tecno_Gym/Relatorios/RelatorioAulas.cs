using MetroFramework.Forms;
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
using Npgsql;
using MetroFramework;

namespace Tecno_Gym.Relatorios
{
    public partial class RelatorioAulas : MetroForm
    {
        public RelatorioAulas()
        {
            InitializeComponent();
        }

        private void RelatorioAulas_Load(object sender, EventArgs e)
        { 
        }

        public void CarregarDataGridTime()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT a.id_aula,t.descricao,a.dia,a.horario,a.id_turma from aula a INNER JOIN turma t ON a.id_turma = t.id_turma WHERE dia >= '"+DataInicial_DT.Value.ToShortDateString()+"' and dia <= '"+DataFinal_DT.Value.ToShortDateString() + "' ORDER BY t.descricao", Database.Database.GetConnection());
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

        public void CarregarDataGrid()
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

        private void PdfExport()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(Grid_Aulas.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in Grid_Aulas.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
               // cell.BackgroundColor = new iTextSharp.text.color(240, 240, 240);
                //cell.BackgroundColor = new iT
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in Grid_Aulas.Rows)
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

                using (FileStream stream = new FileStream(folderPath + "RelatorioAula.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    System.Diagnostics.Process.Start("C:\\PDFs\\RelatorioAula.pdf");
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "\n\nNão foi possível gerar o relatório, pois o arquivo de caminho está sendo usado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GerarRelatorio_Button_Click(object sender, EventArgs e)
        {
            if(FiltroTempo_CB.Checked == true)
            {
                CarregarDataGridTime();
                PdfExport();
            }
            else // gerar relatório geral sem tempo
            {
                CarregarDataGrid();
                PdfExport();
            }
        }

        private void FiltroTempo_CB_CheckedChanged(object sender, EventArgs e)
        {
            if(FiltroTempo_CB.Checked == true)
            {
                DataFinal_DT.Enabled = true;
                DataInicial_DT.Enabled = true;
            }
            else
            {
                DataFinal_DT.Enabled = false;
                DataInicial_DT.Enabled = false;
            }
        }
    }
}
