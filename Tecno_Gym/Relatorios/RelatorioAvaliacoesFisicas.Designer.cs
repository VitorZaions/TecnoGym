namespace Tecno_Gym.Relatorios
{
    partial class RelatorioAvaliacoesFisicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioAvaliacoesFisicas));
            this.GerarRelatorio_Button = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataFinal_DT = new System.Windows.Forms.DateTimePicker();
            this.DataInicial_DT = new System.Windows.Forms.DateTimePicker();
            this.Cliente_Button = new MetroFramework.Controls.MetroButton();
            this.Cliente_TB = new System.Windows.Forms.TextBox();
            this.Cliente_LBL = new System.Windows.Forms.Label();
            this.Tempo_CB = new System.Windows.Forms.CheckBox();
            this.Grid_AvaliacoesFisicas = new System.Windows.Forms.DataGridView();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_AvaliacoesFisicas)).BeginInit();
            this.SuspendLayout();
            // 
            // GerarRelatorio_Button
            // 
            this.GerarRelatorio_Button.Location = new System.Drawing.Point(321, 245);
            this.GerarRelatorio_Button.Name = "GerarRelatorio_Button";
            this.GerarRelatorio_Button.Size = new System.Drawing.Size(136, 45);
            this.GerarRelatorio_Button.TabIndex = 24;
            this.GerarRelatorio_Button.Text = "Gerar";
            this.GerarRelatorio_Button.UseSelectable = true;
            this.GerarRelatorio_Button.Click += new System.EventHandler(this.GerarRelatorio_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Data Inicial";
            // 
            // DataFinal_DT
            // 
            this.DataFinal_DT.Enabled = false;
            this.DataFinal_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFinal_DT.Location = new System.Drawing.Point(257, 180);
            this.DataFinal_DT.Name = "DataFinal_DT";
            this.DataFinal_DT.Size = new System.Drawing.Size(200, 24);
            this.DataFinal_DT.TabIndex = 21;
            // 
            // DataInicial_DT
            // 
            this.DataInicial_DT.Enabled = false;
            this.DataInicial_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicial_DT.Location = new System.Drawing.Point(23, 180);
            this.DataInicial_DT.Name = "DataInicial_DT";
            this.DataInicial_DT.Size = new System.Drawing.Size(200, 24);
            this.DataInicial_DT.TabIndex = 20;
            // 
            // Cliente_Button
            // 
            this.Cliente_Button.Location = new System.Drawing.Point(429, 87);
            this.Cliente_Button.Name = "Cliente_Button";
            this.Cliente_Button.Size = new System.Drawing.Size(28, 23);
            this.Cliente_Button.TabIndex = 53;
            this.Cliente_Button.Text = "🧑";
            this.Cliente_Button.UseSelectable = true;
            this.Cliente_Button.Click += new System.EventHandler(this.Cliente_Button_Click);
            // 
            // Cliente_TB
            // 
            this.Cliente_TB.Enabled = false;
            this.Cliente_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_TB.Location = new System.Drawing.Point(23, 86);
            this.Cliente_TB.Name = "Cliente_TB";
            this.Cliente_TB.ReadOnly = true;
            this.Cliente_TB.Size = new System.Drawing.Size(366, 24);
            this.Cliente_TB.TabIndex = 52;
            // 
            // Cliente_LBL
            // 
            this.Cliente_LBL.AutoSize = true;
            this.Cliente_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_LBL.Location = new System.Drawing.Point(20, 62);
            this.Cliente_LBL.Name = "Cliente_LBL";
            this.Cliente_LBL.Size = new System.Drawing.Size(53, 18);
            this.Cliente_LBL.TabIndex = 51;
            this.Cliente_LBL.Text = "Cliente";
            // 
            // Tempo_CB
            // 
            this.Tempo_CB.AutoSize = true;
            this.Tempo_CB.Location = new System.Drawing.Point(23, 129);
            this.Tempo_CB.Name = "Tempo_CB";
            this.Tempo_CB.Size = new System.Drawing.Size(129, 17);
            this.Tempo_CB.TabIndex = 111;
            this.Tempo_CB.Text = "Utilizar filtro por tempo";
            this.Tempo_CB.UseVisualStyleBackColor = true;
            this.Tempo_CB.CheckedChanged += new System.EventHandler(this.Tempo_CB_CheckedChanged);
            // 
            // Grid_AvaliacoesFisicas
            // 
            this.Grid_AvaliacoesFisicas.AllowUserToAddRows = false;
            this.Grid_AvaliacoesFisicas.AllowUserToDeleteRows = false;
            this.Grid_AvaliacoesFisicas.AllowUserToResizeColumns = false;
            this.Grid_AvaliacoesFisicas.AllowUserToResizeRows = false;
            this.Grid_AvaliacoesFisicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_AvaliacoesFisicas.BackgroundColor = System.Drawing.Color.White;
            this.Grid_AvaliacoesFisicas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_AvaliacoesFisicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_AvaliacoesFisicas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_AvaliacoesFisicas.Location = new System.Drawing.Point(23, 337);
            this.Grid_AvaliacoesFisicas.Name = "Grid_AvaliacoesFisicas";
            this.Grid_AvaliacoesFisicas.ReadOnly = true;
            this.Grid_AvaliacoesFisicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_AvaliacoesFisicas.Size = new System.Drawing.Size(434, 224);
            this.Grid_AvaliacoesFisicas.TabIndex = 112;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(395, 87);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(28, 23);
            this.metroButton3.TabIndex = 114;
            this.metroButton3.Text = "X";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // RelatorioAvaliacoesFisicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 312);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.Grid_AvaliacoesFisicas);
            this.Controls.Add(this.Tempo_CB);
            this.Controls.Add(this.Cliente_Button);
            this.Controls.Add(this.Cliente_TB);
            this.Controls.Add(this.Cliente_LBL);
            this.Controls.Add(this.GerarRelatorio_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataFinal_DT);
            this.Controls.Add(this.DataInicial_DT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RelatorioAvaliacoesFisicas";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Relatório avaliações físicas";
            this.Load += new System.EventHandler(this.RelatorioAvaliacoesFisicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_AvaliacoesFisicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton GerarRelatorio_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DataFinal_DT;
        private System.Windows.Forms.DateTimePicker DataInicial_DT;
        private MetroFramework.Controls.MetroButton Cliente_Button;
        private System.Windows.Forms.TextBox Cliente_TB;
        private System.Windows.Forms.Label Cliente_LBL;
        private System.Windows.Forms.CheckBox Tempo_CB;
        private System.Windows.Forms.DataGridView Grid_AvaliacoesFisicas;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}