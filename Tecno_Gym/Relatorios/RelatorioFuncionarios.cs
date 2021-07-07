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
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Tecno_Gym.Relatorios
{
    public partial class RelatorioFuncionarios : MetroForm
    {
        int id_funcionario;
        public RelatorioFuncionarios()
        {
            InitializeComponent();
        }

        private void RelatorioFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void PdfExport()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(Grid_Funcionarios.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in Grid_Funcionarios.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                // cell.BackgroundColor = new iTextSharp.text.color(240, 240, 240);
                //cell.BackgroundColor = new iT
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in Grid_Funcionarios.Rows)
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
                using (FileStream stream = new FileStream(folderPath + "RelatorioFuncionario.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    System.Diagnostics.Process.Start("C:\\PDFs\\RelatorioFuncionario.pdf");
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "\n\nNão foi possível gerar o relatório, pois o arquivo de caminho está sendo usado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CarregarDataGrid()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT f.nome,t.descricao,t.id_funcionario from turma t INNER JOIN funcionario f ON t.id_funcionario = f.id_funcionario", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Funcionarios.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Funcionarios.Columns[0].HeaderText = "Funcionário";
            Grid_Funcionarios.Columns[1].HeaderText = "Descrição";
            Grid_Funcionarios.Columns[2].HeaderText = "Id funcionário";
            Grid_Funcionarios.Columns[2].Visible = false;
            // Grid_Categorias.AutoResizeColumns();
            //Grid_Categorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        void CarregarDataGridComFuncionario()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT f.nome,t.descricao,t.id_funcionario FROM turma t INNER JOIN funcionario f ON t.id_funcionario = f.id_funcionario WHERE t.id_funcionario = " + id_funcionario, Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Funcionarios.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Funcionarios.Columns[0].HeaderText = "Funcionário";
            Grid_Funcionarios.Columns[1].HeaderText = "Descrição";
            Grid_Funcionarios.Columns[2].HeaderText = "Id funcionário";
            Grid_Funcionarios.Columns[2].Visible = false;
        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            SelecionarFuncionario SelecionarFun = new SelecionarFuncionario();
            SelecionarFun.ShowDialog();

            id_funcionario = SelecionarFun.selected_id;
            Responsavel_TB.Text = SelecionarFun.selected_nome;
        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if(Responsavel_TB.Text == "")
            {
                CarregarDataGrid();
                PdfExport();
            }
            else
            {
                CarregarDataGridComFuncionario();
                PdfExport();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            id_funcionario = 0;
            Responsavel_TB.Text = "";
        }
    }
}
