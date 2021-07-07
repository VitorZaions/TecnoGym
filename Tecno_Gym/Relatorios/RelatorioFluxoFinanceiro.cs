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
    public partial class RelatorioFluxoFinanceiro : MetroForm
    {
        public RelatorioFluxoFinanceiro()
        {
            InitializeComponent();
        }

        private void RelatorioFluxoFinanceiro_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PdfExportContasReceber()
        {

            if (Grid_ContasReceber.ColumnCount > 0)
            {

                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(Grid_ContasReceber.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 30;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                PdfPTable pdfTable2 = new PdfPTable(1);
                pdfTable2.DefaultCell.Padding = 3;
                pdfTable2.WidthPercentage = 30;
                pdfTable2.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable2.DefaultCell.BorderWidth = 1;

                double sum = 0;
                for (int i = 0; i < Grid_ContasReceber.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(Grid_ContasReceber.Rows[i].Cells[2].Value);
                }

                PdfPCell cell2 = new PdfPCell(new Phrase("Total:"));
                pdfTable2.AddCell(cell2);
                pdfTable2.AddCell(sum.ToString());

                //Adding Header row
                foreach (DataGridViewColumn column in Grid_ContasReceber.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    // cell.BackgroundColor = new iTextSharp.text.color(240, 240, 240);
                    //cell.BackgroundColor = new iT
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in Grid_ContasReceber.Rows)
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
                    using (FileStream stream = new FileStream(folderPath + "RelatorioFluxoContasReceber.pdf", FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Add(pdfTable2);
                        pdfDoc.Close();
                        stream.Close();
                        System.Diagnostics.Process.Start("C:\\PDFs\\RelatorioFluxoContasReceber.pdf");
                    }
                }
                catch
                {
                    MetroMessageBox.Show(this, "\n\nNão foi possível gerar o relatório, pois o arquivo de caminho está sendo usado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nNão há contas a receber.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void PdfExportMensalidades()
        {

            if (Grid_Mensalidades.ColumnCount > 0)
            {

                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(Grid_Mensalidades.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 30;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                PdfPTable pdfTable2 = new PdfPTable(1);
                pdfTable2.DefaultCell.Padding = 3;
                pdfTable2.WidthPercentage = 30;
                pdfTable2.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable2.DefaultCell.BorderWidth = 1;

                double sum = 0;
                for (int i = 0; i < Grid_Mensalidades.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(Grid_Mensalidades.Rows[i].Cells[2].Value);
                }

                PdfPCell cell2 = new PdfPCell(new Phrase("Total:"));
                pdfTable2.AddCell(cell2);
                pdfTable2.AddCell(sum.ToString());

                //Adding Header row
                foreach (DataGridViewColumn column in Grid_Mensalidades.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    // cell.BackgroundColor = new iTextSharp.text.color(240, 240, 240);
                    //cell.BackgroundColor = new iT
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in Grid_Mensalidades.Rows)
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
                    using (FileStream stream = new FileStream(folderPath + "RelatorioFluxoMensalidades.pdf", FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Add(pdfTable2);
                        pdfDoc.Close();
                        stream.Close();
                        System.Diagnostics.Process.Start("C:\\PDFs\\RelatorioFluxoMensalidades.pdf");
                    }
                }
                catch
                {
                    MetroMessageBox.Show(this, "\n\nNão foi possível gerar o relatório, pois o arquivo de caminho está sendo usado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nNão há mensalidades.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void PdfExportContasPagar()
        {
            if (Grid_ContasPagar.ColumnCount > 0)
            {

                //Creating iTextSharp Table from the DataTable data
                PdfPTable pdfTable = new PdfPTable(Grid_ContasPagar.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 30;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                PdfPTable pdfTable2 = new PdfPTable(1);
                pdfTable2.DefaultCell.Padding = 3;
                pdfTable2.WidthPercentage = 30;
                pdfTable2.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfTable2.DefaultCell.BorderWidth = 1;

                double sum = 0;
                for (int i = 0; i < Grid_ContasPagar.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(Grid_ContasPagar.Rows[i].Cells[2].Value);
                }

                PdfPCell cell2 = new PdfPCell(new Phrase("Total:"));
                pdfTable2.AddCell(cell2);
                pdfTable2.AddCell(sum.ToString());

                //Adding Header row
                foreach (DataGridViewColumn column in Grid_ContasPagar.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    // cell.BackgroundColor = new iTextSharp.text.color(240, 240, 240);
                    //cell.BackgroundColor = new iT
                    pdfTable.AddCell(cell);
                }

                //Adding DataRow
                foreach (DataGridViewRow row in Grid_ContasPagar.Rows)
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
                    using (FileStream stream = new FileStream(folderPath + "RelatorioFluxoContasPagar.pdf", FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Add(pdfTable2);
                        pdfDoc.Close();
                        stream.Close();
                        System.Diagnostics.Process.Start("C:\\PDFs\\RelatorioFluxoContasPagar.pdf");
                    }
                }
                catch
                {
                    MetroMessageBox.Show(this, "\n\nNão foi possível gerar o relatório, pois o arquivo de caminho está sendo usado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nNão há contas a pagar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
               


        void CarregarGrid_ContasReceberEmAberto()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_receber WHERE status = 0 ORDER BY descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_ContasReceber.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_ContasReceber.Columns[0].HeaderText = "Id";
            Grid_ContasReceber.Columns[1].HeaderText = "Descricao";
            Grid_ContasReceber.Columns[2].HeaderText = "Valor";
            Grid_ContasReceber.Columns[3].HeaderText = "Status";
            Grid_ContasReceber.Columns[4].HeaderText = "data_recebimento";
            Grid_ContasReceber.Columns[0].Visible = false;
            Grid_ContasReceber.Columns[3].Visible = false;
        }

        void CarregarGrid_ContasReceberPago()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_receber WHERE status = 1 ORDER BY descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_ContasReceber.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_ContasReceber.Columns[0].HeaderText = "Id";
            Grid_ContasReceber.Columns[1].HeaderText = "Descricao";
            Grid_ContasReceber.Columns[2].HeaderText = "Valor";
            Grid_ContasReceber.Columns[3].HeaderText = "Status";
            Grid_ContasReceber.Columns[4].HeaderText = "data_recebimento";
            Grid_ContasReceber.Columns[0].Visible = false;
            Grid_ContasReceber.Columns[3].Visible = false;
        }

        void CarregarGrid_ContasPagarEmAberto()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_pagar WHERE status = 0 ORDER BY descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_ContasPagar.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_ContasPagar.Columns[0].HeaderText = "Id";
            Grid_ContasPagar.Columns[1].HeaderText = "Descricao";
            Grid_ContasPagar.Columns[2].HeaderText = "Valor";
            Grid_ContasPagar.Columns[3].HeaderText = "Status";
            Grid_ContasPagar.Columns[4].HeaderText = "Data vencimento";

            Grid_ContasPagar.Columns[0].Visible = false;
            Grid_ContasPagar.Columns[3].Visible = false;

        }

        void CarregarGrid_ContasPagarPago()
        {

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_pagar WHERE status = 1 ORDER BY descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_ContasPagar.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_ContasPagar.Columns[0].HeaderText = "Id";
            Grid_ContasPagar.Columns[1].HeaderText = "Descricao";
            Grid_ContasPagar.Columns[2].HeaderText = "Valor";
            Grid_ContasPagar.Columns[3].HeaderText = "Status";
            Grid_ContasPagar.Columns[4].HeaderText = "Data vencimento";

            Grid_ContasPagar.Columns[0].Visible = false;
            Grid_ContasPagar.Columns[3].Visible = false;
        }

        void CarregarGrid_MensalidadesEmAberto()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente WHERE m.status = 0 ORDER BY c.nome", Database.Database.GetConnection());
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
        }

        void CarregarGrid_MensalidadesPago()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente WHERE m.status = 1 ORDER BY c.nome", Database.Database.GetConnection());
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
        }


        /// Com Filtro de tempo ativo



        void CarregarGrid_ContasReceberEmAbertoTime()
        {
            string DataInicial = DataInicial_DT.Value.ToShortDateString();
            string DataFinal = DataFinal_DT.Value.ToShortDateString();

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_receber WHERE status = 0 and data_recebimento >= '" + DataInicial +"' and data_recebimento <= '"+DataFinal+"' ORDER BY descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_ContasReceber.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_ContasReceber.Columns[0].HeaderText = "Id";
            Grid_ContasReceber.Columns[1].HeaderText = "Descricao";
            Grid_ContasReceber.Columns[2].HeaderText = "Valor";
            Grid_ContasReceber.Columns[3].HeaderText = "Status";
            Grid_ContasReceber.Columns[4].HeaderText = "data_recebimento";
            Grid_ContasReceber.Columns[0].Visible = false;
            Grid_ContasReceber.Columns[3].Visible = false;
        }

        void CarregarGrid_ContasReceberPagoTime()
        {
            string DataInicial = DataInicial_DT.Value.ToShortDateString();
            string DataFinal = DataFinal_DT.Value.ToShortDateString();

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_receber WHERE status = 1 and data_recebimento >= '" + DataInicial + "' and data_recebimento <= '" + DataFinal + "' ORDER BY descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_ContasReceber.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_ContasReceber.Columns[0].HeaderText = "Id";
            Grid_ContasReceber.Columns[1].HeaderText = "Descricao";
            Grid_ContasReceber.Columns[2].HeaderText = "Valor";
            Grid_ContasReceber.Columns[3].HeaderText = "Status";
            Grid_ContasReceber.Columns[4].HeaderText = "data_recebimento";
            Grid_ContasReceber.Columns[0].Visible = false;
            Grid_ContasReceber.Columns[3].Visible = false;
        }

        void CarregarGrid_ContasPagarEmAbertoTime()
        {
            string DataInicial = DataInicial_DT.Value.ToShortDateString();
            string DataFinal = DataFinal_DT.Value.ToShortDateString();

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_pagar WHERE status = 0 and data_vencimento >= '" + DataInicial + "' and data_vencimento <= '" + DataFinal + "' ORDER BY descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_ContasPagar.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_ContasPagar.Columns[0].HeaderText = "Id";
            Grid_ContasPagar.Columns[1].HeaderText = "Descricao";
            Grid_ContasPagar.Columns[2].HeaderText = "Valor";
            Grid_ContasPagar.Columns[3].HeaderText = "Status";
            Grid_ContasPagar.Columns[4].HeaderText = "Data vencimento";

            Grid_ContasPagar.Columns[0].Visible = false;
            Grid_ContasPagar.Columns[3].Visible = false;

        }

        void CarregarGrid_ContasPagarPagoTime()
        {
            string DataInicial = DataInicial_DT.Value.ToShortDateString();
            string DataFinal = DataFinal_DT.Value.ToShortDateString();

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from conta_pagar WHERE status = 1 and data_vencimento >= '" + DataInicial + "' and data_vencimento <= '" + DataFinal + "' ORDER BY descricao", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_ContasPagar.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_ContasPagar.Columns[0].HeaderText = "Id";
            Grid_ContasPagar.Columns[1].HeaderText = "Descricao";
            Grid_ContasPagar.Columns[2].HeaderText = "Valor";
            Grid_ContasPagar.Columns[3].HeaderText = "Status";
            Grid_ContasPagar.Columns[4].HeaderText = "Data vencimento";

            Grid_ContasPagar.Columns[0].Visible = false;
            Grid_ContasPagar.Columns[3].Visible = false;
        }

        void CarregarGrid_MensalidadesEmAbertoTime()
        {
            string DataInicial = DataInicial_DT.Value.ToShortDateString();
            string DataFinal = DataFinal_DT.Value.ToShortDateString();

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente WHERE m.status = 0 and data_pagamento >= '" + DataInicial + "' and data_pagamento <= '" + DataFinal + "' ORDER BY c.nome", Database.Database.GetConnection());
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
        }

        void CarregarGrid_MensalidadesPagoTime()
        {
            string DataInicial = DataInicial_DT.Value.ToShortDateString();
            string DataFinal = DataFinal_DT.Value.ToShortDateString();

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente WHERE m.status = 1 and data_pagamento >= '" + DataInicial + "' and data_pagamento <= '" + DataFinal + "' ORDER BY c.nome", Database.Database.GetConnection());
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
        }


        private void GerarRelatorio_Button_Click(object sender, EventArgs e)
        {

            if(ContasReceber_CB.Checked == false && ContaPagar_CB.Checked == false && Mesalidades_CB.Checked == false)
            {
                MetroMessageBox.Show(this, "\n\nVocê deve específicar pelo menos um tipo de financeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {  // GERAR

                if(Tempo_CB.Checked == true) //gerar com tempo
                {

                    // Contas receber
                    if (ContasReceber_CB.Checked == true && EmAberto_RB.Checked == true)
                    {
                        CarregarGrid_ContasReceberEmAbertoTime(); //gerar com tempo;
                        PdfExportContasReceber();
                    }
                    else if (ContasReceber_CB.Checked == true && Pago_RB.Checked == true)
                    {
                        CarregarGrid_ContasReceberPagoTime();
                        PdfExportContasReceber();
                    }

                    // Contas pagar

                    if (ContaPagar_CB.Checked == true && EmAberto_RB.Checked == true)
                    {
                        CarregarGrid_ContasPagarEmAbertoTime(); //gerar com tempo;
                        PdfExportContasPagar();
                    }
                    else if (ContaPagar_CB.Checked == true && Pago_RB.Checked == true)
                    {
                        CarregarGrid_ContasPagarPagoTime();
                        PdfExportContasPagar();
                    }

                    //Mensalidades

                    if (Mesalidades_CB.Checked == true && EmAberto_RB.Checked == true)
                    {
                        CarregarGrid_MensalidadesEmAbertoTime(); //gerar com tempo;
                    }
                    else if (Mesalidades_CB.Checked == true && Pago_RB.Checked == true)
                    {
                        CarregarGrid_MensalidadesPagoTime();
                    }

                }
                else //gerar sem tempo
                {
                    // Contas receber
                    if(ContasReceber_CB.Checked == true && EmAberto_RB.Checked == true)
                    {
                        CarregarGrid_ContasReceberEmAberto(); //gerar com tempo;
                        PdfExportContasReceber();
                    }
                    else if(ContasReceber_CB.Checked == true && Pago_RB.Checked == true)
                    {
                        CarregarGrid_ContasReceberPago();
                        PdfExportContasReceber();
                    }

                    // Contas pagar

                    if (ContaPagar_CB.Checked == true && EmAberto_RB.Checked == true)
                    {
                        CarregarGrid_ContasPagarEmAberto(); //gerar com tempo;
                        PdfExportContasPagar();
                    }
                    else if (ContaPagar_CB.Checked == true && Pago_RB.Checked == true)
                    {
                        CarregarGrid_ContasPagarPago();
                        PdfExportContasPagar();
                    }

                    //Mensalidades

                    if (Mesalidades_CB.Checked == true && EmAberto_RB.Checked == true)
                    {
                        CarregarGrid_MensalidadesEmAberto(); //gerar com tempo;
                        PdfExportMensalidades();
                    }
                    else if (Mesalidades_CB.Checked == true && Pago_RB.Checked == true)
                    {
                        CarregarGrid_MensalidadesPago();
                        PdfExportMensalidades();
                    }                    
                }
            }

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Tempo_CB_CheckedChanged(object sender, EventArgs e)
        {
            if(Tempo_CB.Checked == true)
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
    }
}
