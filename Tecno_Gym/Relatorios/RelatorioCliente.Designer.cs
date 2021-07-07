namespace Tecno_Gym.Relatorios
{
    partial class RelatorioCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioCliente));
            this.Cliente_Button = new MetroFramework.Controls.MetroButton();
            this.Cliente_TB = new System.Windows.Forms.TextBox();
            this.Cliente_LBL = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Tempo_GP = new System.Windows.Forms.GroupBox();
            this.DataFinal_DT = new System.Windows.Forms.DateTimePicker();
            this.DataFinal_LBL = new System.Windows.Forms.Label();
            this.DataInicial_DT = new System.Windows.Forms.DateTimePicker();
            this.DataInicial_LBL = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.Tempo_CB = new System.Windows.Forms.CheckBox();
            this.Grid_Financeiro = new System.Windows.Forms.DataGridView();
            this.Grid_Medidas = new System.Windows.Forms.DataGridView();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.Tempo_GP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Financeiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Medidas)).BeginInit();
            this.SuspendLayout();
            // 
            // Cliente_Button
            // 
            this.Cliente_Button.Location = new System.Drawing.Point(463, 104);
            this.Cliente_Button.Name = "Cliente_Button";
            this.Cliente_Button.Size = new System.Drawing.Size(28, 23);
            this.Cliente_Button.TabIndex = 50;
            this.Cliente_Button.Text = "🧑";
            this.Cliente_Button.UseSelectable = true;
            this.Cliente_Button.Click += new System.EventHandler(this.Cliente_Button_Click);
            // 
            // Cliente_TB
            // 
            this.Cliente_TB.Enabled = false;
            this.Cliente_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_TB.Location = new System.Drawing.Point(27, 103);
            this.Cliente_TB.Name = "Cliente_TB";
            this.Cliente_TB.ReadOnly = true;
            this.Cliente_TB.Size = new System.Drawing.Size(396, 24);
            this.Cliente_TB.TabIndex = 49;
            // 
            // Cliente_LBL
            // 
            this.Cliente_LBL.AutoSize = true;
            this.Cliente_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_LBL.Location = new System.Drawing.Point(24, 79);
            this.Cliente_LBL.Name = "Cliente_LBL";
            this.Cliente_LBL.Size = new System.Drawing.Size(53, 18);
            this.Cliente_LBL.TabIndex = 48;
            this.Cliente_LBL.Text = "Cliente";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(387, 269);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(104, 43);
            this.metroButton1.TabIndex = 107;
            this.metroButton1.Text = "Gerar medidas";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Tempo_GP
            // 
            this.Tempo_GP.Controls.Add(this.DataFinal_DT);
            this.Tempo_GP.Controls.Add(this.DataFinal_LBL);
            this.Tempo_GP.Controls.Add(this.DataInicial_DT);
            this.Tempo_GP.Controls.Add(this.DataInicial_LBL);
            this.Tempo_GP.Location = new System.Drawing.Point(27, 174);
            this.Tempo_GP.Name = "Tempo_GP";
            this.Tempo_GP.Size = new System.Drawing.Size(464, 71);
            this.Tempo_GP.TabIndex = 108;
            this.Tempo_GP.TabStop = false;
            this.Tempo_GP.Text = "Filtro por tempo";
            // 
            // DataFinal_DT
            // 
            this.DataFinal_DT.Enabled = false;
            this.DataFinal_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFinal_DT.Location = new System.Drawing.Point(255, 41);
            this.DataFinal_DT.Name = "DataFinal_DT";
            this.DataFinal_DT.Size = new System.Drawing.Size(204, 24);
            this.DataFinal_DT.TabIndex = 29;
            // 
            // DataFinal_LBL
            // 
            this.DataFinal_LBL.AutoSize = true;
            this.DataFinal_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFinal_LBL.Location = new System.Drawing.Point(252, 19);
            this.DataFinal_LBL.Name = "DataFinal_LBL";
            this.DataFinal_LBL.Size = new System.Drawing.Size(79, 18);
            this.DataFinal_LBL.TabIndex = 28;
            this.DataFinal_LBL.Text = "* Data final";
            // 
            // DataInicial_DT
            // 
            this.DataInicial_DT.Enabled = false;
            this.DataInicial_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicial_DT.Location = new System.Drawing.Point(6, 41);
            this.DataInicial_DT.Name = "DataInicial_DT";
            this.DataInicial_DT.Size = new System.Drawing.Size(204, 24);
            this.DataInicial_DT.TabIndex = 27;
            // 
            // DataInicial_LBL
            // 
            this.DataInicial_LBL.AutoSize = true;
            this.DataInicial_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicial_LBL.Location = new System.Drawing.Point(3, 19);
            this.DataInicial_LBL.Name = "DataInicial_LBL";
            this.DataInicial_LBL.Size = new System.Drawing.Size(89, 18);
            this.DataInicial_LBL.TabIndex = 26;
            this.DataInicial_LBL.Text = "* Data inicial";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(265, 269);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(104, 43);
            this.metroButton2.TabIndex = 109;
            this.metroButton2.Text = "Gerar financeiro";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Tempo_CB
            // 
            this.Tempo_CB.AutoSize = true;
            this.Tempo_CB.Location = new System.Drawing.Point(27, 144);
            this.Tempo_CB.Name = "Tempo_CB";
            this.Tempo_CB.Size = new System.Drawing.Size(129, 17);
            this.Tempo_CB.TabIndex = 110;
            this.Tempo_CB.Text = "Utilizar filtro por tempo";
            this.Tempo_CB.UseVisualStyleBackColor = true;
            this.Tempo_CB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Grid_Financeiro
            // 
            this.Grid_Financeiro.AllowUserToAddRows = false;
            this.Grid_Financeiro.AllowUserToDeleteRows = false;
            this.Grid_Financeiro.AllowUserToResizeColumns = false;
            this.Grid_Financeiro.AllowUserToResizeRows = false;
            this.Grid_Financeiro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Financeiro.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Financeiro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Financeiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Financeiro.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Financeiro.Location = new System.Drawing.Point(27, 380);
            this.Grid_Financeiro.Name = "Grid_Financeiro";
            this.Grid_Financeiro.ReadOnly = true;
            this.Grid_Financeiro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Financeiro.Size = new System.Drawing.Size(228, 255);
            this.Grid_Financeiro.TabIndex = 111;
            // 
            // Grid_Medidas
            // 
            this.Grid_Medidas.AllowUserToAddRows = false;
            this.Grid_Medidas.AllowUserToDeleteRows = false;
            this.Grid_Medidas.AllowUserToResizeColumns = false;
            this.Grid_Medidas.AllowUserToResizeRows = false;
            this.Grid_Medidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Medidas.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Medidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Medidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Medidas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Medidas.Location = new System.Drawing.Point(267, 380);
            this.Grid_Medidas.Name = "Grid_Medidas";
            this.Grid_Medidas.ReadOnly = true;
            this.Grid_Medidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Medidas.Size = new System.Drawing.Size(815, 255);
            this.Grid_Medidas.TabIndex = 112;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(429, 104);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(28, 23);
            this.metroButton3.TabIndex = 113;
            this.metroButton3.Text = "X";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // RelatorioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 335);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.Grid_Medidas);
            this.Controls.Add(this.Grid_Financeiro);
            this.Controls.Add(this.Tempo_CB);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.Tempo_GP);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Cliente_Button);
            this.Controls.Add(this.Cliente_TB);
            this.Controls.Add(this.Cliente_LBL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RelatorioCliente";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Relatório clientes";
            this.Load += new System.EventHandler(this.RelatorioAlunos_Load);
            this.Tempo_GP.ResumeLayout(false);
            this.Tempo_GP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Financeiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Medidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Cliente_Button;
        private System.Windows.Forms.TextBox Cliente_TB;
        private System.Windows.Forms.Label Cliente_LBL;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox Tempo_GP;
        private System.Windows.Forms.DateTimePicker DataFinal_DT;
        private System.Windows.Forms.Label DataFinal_LBL;
        private System.Windows.Forms.DateTimePicker DataInicial_DT;
        private System.Windows.Forms.Label DataInicial_LBL;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.CheckBox Tempo_CB;
        private System.Windows.Forms.DataGridView Grid_Financeiro;
        private System.Windows.Forms.DataGridView Grid_Medidas;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}