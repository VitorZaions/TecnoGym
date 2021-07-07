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
    public partial class RelatorioCliente : MetroForm
    {
        int id_cliente;
        string nome_cliente;
        public RelatorioCliente()
        {
            InitializeComponent();
        }

        private void RelatorioAlunos_Load(object sender, EventArgs e)
        {

        }

        private void Cliente_Button_Click(object sender, EventArgs e)
        {
            SelecionarCliente SelecionarCli = new SelecionarCliente();
            SelecionarCli.ShowDialog();

            id_cliente = SelecionarCli.selected_id;
            nome_cliente = SelecionarCli.selected_nome;
            Cliente_TB.Text = nome_cliente;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void PdfExportMedidas()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(Grid_Medidas.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 70;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in Grid_Medidas.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                // cell.BackgroundColor = new iTextSharp.text.color(240, 240, 240);
                //cell.BackgroundColor = new iT
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in Grid_Medidas.Rows)
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
                using (FileStream stream = new FileStream(folderPath + "RelatorioMedidas.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    System.Diagnostics.Process.Start("C:\\PDFs\\RelatorioMedidas.pdf");
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "\n\nNão foi possível gerar o relatório, pois o arquivo de caminho está sendo usado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PdfExportFinanceiro()
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(Grid_Financeiro.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 40;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in Grid_Financeiro.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                // cell.BackgroundColor = new iTextSharp.text.color(240, 240, 240);
                //cell.BackgroundColor = new iT
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in Grid_Financeiro.Rows)
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
                using (FileStream stream = new FileStream(folderPath + "RelatorioFinanceiro.pdf", FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                    System.Diagnostics.Process.Start("C:\\PDFs\\RelatorioFinanceiro.pdf");
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "\n\nNão foi possível gerar o relatório, pois o arquivo de caminho está sendo usado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if(Cliente_TB.Text != "")
            {
                if (Tempo_CB.Checked == true) // gerar financeiro COM CLIENTE E TEMPO 
                {
                    CarregarDataGridFinanceiroGeralTimeCliente();
                }
                else // gerar financeiro COM CLIENTE E SEM TEMPO
                {
                    CarregarDataGridFinanceiroGeralCliente();
                }
                PdfExportFinanceiro();
            }
            else
            {
                if (Tempo_CB.Checked == true) // gerar financeiro sem cliente com tempo
                {
                    CarregarDataGridFinanceiroGeralTime();
                }
                else // gerar financeiro sem cliente sem tempo
                {
                    CarregarDataGridFinanceiroGeral();
                }
                PdfExportFinanceiro();
            }
        }

        void CarregarDataGridFinanceiroGeral()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Financeiro.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Financeiro.Columns[0].HeaderText = "Id";
            Grid_Financeiro.Columns[1].HeaderText = "Cliente";
            Grid_Financeiro.Columns[2].HeaderText = "Valor mensalidade";
            Grid_Financeiro.Columns[3].HeaderText = "Data pagamento";
            Grid_Financeiro.Columns[4].HeaderText = "Status";
            Grid_Financeiro.Columns[5].HeaderText = "Id Cliente";
            Grid_Financeiro.Columns[0].Visible = false;
            Grid_Financeiro.Columns[4].Visible = false;
            Grid_Financeiro.Columns[5].Visible = false;
        }

        void CarregarDataGridFinanceiroGeralTime()
        {
            string DataInicial = DataInicial_DT.Value.ToShortDateString();
            string DataFinal = DataFinal_DT.Value.ToShortDateString();

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente WHERE m.data_pagamento >= '"+DataInicial+ "' and m.data_pagamento <= '"+DataFinal+"' ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Financeiro.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Financeiro.Columns[0].HeaderText = "Id";
            Grid_Financeiro.Columns[1].HeaderText = "Cliente";
            Grid_Financeiro.Columns[2].HeaderText = "Valor mensalidade";
            Grid_Financeiro.Columns[3].HeaderText = "Data pagamento";
            Grid_Financeiro.Columns[4].HeaderText = "Status";
            Grid_Financeiro.Columns[5].HeaderText = "Id Cliente";
            Grid_Financeiro.Columns[0].Visible = false;
            Grid_Financeiro.Columns[4].Visible = false;
            Grid_Financeiro.Columns[5].Visible = false;
        }

        // SEM TEMPO E COM CLIENTE

        void CarregarDataGridFinanceiroGeralCliente()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente WHERE m.id_cliente = "+id_cliente+" ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Financeiro.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Financeiro.Columns[0].HeaderText = "Id";
            Grid_Financeiro.Columns[1].HeaderText = "Cliente";
            Grid_Financeiro.Columns[2].HeaderText = "Valor mensalidade";
            Grid_Financeiro.Columns[3].HeaderText = "Data pagamento";
            Grid_Financeiro.Columns[4].HeaderText = "Status";
            Grid_Financeiro.Columns[5].HeaderText = "Id Cliente";
            Grid_Financeiro.Columns[0].Visible = false;
            Grid_Financeiro.Columns[4].Visible = false;
            Grid_Financeiro.Columns[5].Visible = false;
        }

        void CarregarDataGridFinanceiroGeralTimeCliente()
        {
            string DataInicial = DataInicial_DT.Value.ToShortDateString();
            string DataFinal = DataFinal_DT.Value.ToShortDateString();

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT m.id_mensalidade,c.nome,m.valor_mensalidade,m.data_pagamento,m.status,m.id_cliente from mensalidade m INNER JOIN cliente c ON m.id_cliente = c.id_cliente WHERE m.data_pagamento >= '" + DataInicial + "' and m.data_pagamento <= '" + DataFinal + "' and m.id_cliente = "+id_cliente+" ORDER BY c.nome", Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Financeiro.DataSource = myTable.DefaultView;
                con.Close();
            }

            Grid_Financeiro.Columns[0].HeaderText = "Id";
            Grid_Financeiro.Columns[1].HeaderText = "Cliente";
            Grid_Financeiro.Columns[2].HeaderText = "Valor mensalidade";
            Grid_Financeiro.Columns[3].HeaderText = "Data pagamento";
            Grid_Financeiro.Columns[4].HeaderText = "Status";
            Grid_Financeiro.Columns[5].HeaderText = "Id Cliente";
            Grid_Financeiro.Columns[0].Visible = false;
            Grid_Financeiro.Columns[4].Visible = false;
            Grid_Financeiro.Columns[5].Visible = false;
        }

        void CarregarDataGridMedidaGeralTime()
        {
            string DataInicial = DataInicial_DT.Value.ToShortDateString();
            string DataFinal = DataFinal_DT.Value.ToShortDateString();

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT med.id_medida,c.nome,med.altura,med.peitoral,med.brc_esquerdo,med.brc_direito,med.pnt_direita,med.pnt_esquerda,med.quadril,med.coxa_direita,med.coxa_esquerda,med.data_medida,med.id_cliente from medida med INNER JOIN cliente c ON med.id_cliente = c.id_cliente WHERE data_medida >= '"+DataInicial+ "' data_medida <= '"+DataFinal+"' and  ORDER BY c.nome", Database.Database.GetConnection());
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
        }

        void CarregarDataGridMedidaGeral()
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
        }

        void CarregarDataGridMedidaGeralCliente()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT med.id_medida,c.nome,med.altura,med.peitoral,med.brc_esquerdo,med.brc_direito,med.pnt_direita,med.pnt_esquerda,med.quadril,med.coxa_direita,med.coxa_esquerda,med.data_medida,med.id_cliente from medida med INNER JOIN cliente c ON med.id_cliente = c.id_cliente WHERE med.id_cliente = "+id_cliente+" ORDER BY c.nome", Database.Database.GetConnection());
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
        }

        void CarregarDataGridMedidaGeralClienteTime()
        {
            string DataInicial = DataInicial_DT.Value.ToShortDateString();
            string DataFinal = DataFinal_DT.Value.ToShortDateString();

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT med.id_medida,c.nome,med.altura,med.peitoral,med.brc_esquerdo,med.brc_direito,med.pnt_direita,med.pnt_esquerda,med.quadril,med.coxa_direita,med.coxa_esquerda,med.data_medida,med.id_cliente from medida med INNER JOIN cliente c ON med.id_cliente = c.id_cliente WHERE med.id_cliente = " + id_cliente + " and data_medida >= '"+DataInicial+ "' and data_medida <= '"+DataFinal+"' ORDER BY c.nome", Database.Database.GetConnection());
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
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (Cliente_TB.Text != "")
            {
                if (Tempo_CB.Checked == true) // gerar medidas COM CLIENTE E COM TEMPO
                {
                    CarregarDataGridMedidaGeralClienteTime();
                }
                else // gerar medidas COM CLIENTE E SEM TEMPO
                {
                    CarregarDataGridMedidaGeralCliente();
                }
                PdfExportMedidas();
            }
            else
            {
                if (Tempo_CB.Checked == true) // gerar medida sem cliente com tempo
                {
                    CarregarDataGridMedidaGeralTime();
                }
                else // gerar medida sem cliente sem tempo
                {
                    CarregarDataGridMedidaGeral();
                }
                PdfExportMedidas();
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
