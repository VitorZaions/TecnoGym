namespace Tecno_Gym.Relatorios
{
    partial class RelatorioAulas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioAulas));
            this.DataInicial_DT = new System.Windows.Forms.DateTimePicker();
            this.DataFinal_DT = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GerarRelatorio_Button = new MetroFramework.Controls.MetroButton();
            this.FiltroTempo_CB = new System.Windows.Forms.CheckBox();
            this.Grid_Aulas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Aulas)).BeginInit();
            this.SuspendLayout();
            // 
            // DataInicial_DT
            // 
            this.DataInicial_DT.Enabled = false;
            this.DataInicial_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicial_DT.Location = new System.Drawing.Point(23, 97);
            this.DataInicial_DT.Name = "DataInicial_DT";
            this.DataInicial_DT.Size = new System.Drawing.Size(200, 24);
            this.DataInicial_DT.TabIndex = 0;
            // 
            // DataFinal_DT
            // 
            this.DataFinal_DT.Enabled = false;
            this.DataFinal_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFinal_DT.Location = new System.Drawing.Point(257, 97);
            this.DataFinal_DT.Name = "DataFinal_DT";
            this.DataFinal_DT.Size = new System.Drawing.Size(200, 24);
            this.DataFinal_DT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Final";
            // 
            // GerarRelatorio_Button
            // 
            this.GerarRelatorio_Button.Location = new System.Drawing.Point(321, 174);
            this.GerarRelatorio_Button.Name = "GerarRelatorio_Button";
            this.GerarRelatorio_Button.Size = new System.Drawing.Size(136, 45);
            this.GerarRelatorio_Button.TabIndex = 19;
            this.GerarRelatorio_Button.Text = "Gerar";
            this.GerarRelatorio_Button.UseSelectable = true;
            this.GerarRelatorio_Button.Click += new System.EventHandler(this.GerarRelatorio_Button_Click);
            // 
            // FiltroTempo_CB
            // 
            this.FiltroTempo_CB.AutoSize = true;
            this.FiltroTempo_CB.Location = new System.Drawing.Point(26, 139);
            this.FiltroTempo_CB.Name = "FiltroTempo_CB";
            this.FiltroTempo_CB.Size = new System.Drawing.Size(126, 17);
            this.FiltroTempo_CB.TabIndex = 20;
            this.FiltroTempo_CB.Text = "Utilizar filtro de tempo";
            this.FiltroTempo_CB.UseVisualStyleBackColor = true;
            this.FiltroTempo_CB.CheckedChanged += new System.EventHandler(this.FiltroTempo_CB_CheckedChanged);
            // 
            // Grid_Aulas
            // 
            this.Grid_Aulas.AllowUserToAddRows = false;
            this.Grid_Aulas.AllowUserToDeleteRows = false;
            this.Grid_Aulas.AllowUserToResizeColumns = false;
            this.Grid_Aulas.AllowUserToResizeRows = false;
            this.Grid_Aulas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Aulas.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Aulas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Aulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Aulas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Aulas.Location = new System.Drawing.Point(23, 255);
            this.Grid_Aulas.Name = "Grid_Aulas";
            this.Grid_Aulas.ReadOnly = true;
            this.Grid_Aulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Aulas.Size = new System.Drawing.Size(434, 224);
            this.Grid_Aulas.TabIndex = 34;
            // 
            // RelatorioAulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 244);
            this.Controls.Add(this.Grid_Aulas);
            this.Controls.Add(this.FiltroTempo_CB);
            this.Controls.Add(this.GerarRelatorio_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataFinal_DT);
            this.Controls.Add(this.DataInicial_DT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RelatorioAulas";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Relatório aulas";
            this.Load += new System.EventHandler(this.RelatorioAulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Aulas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DataInicial_DT;
        private System.Windows.Forms.DateTimePicker DataFinal_DT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton GerarRelatorio_Button;
        private System.Windows.Forms.CheckBox FiltroTempo_CB;
        private System.Windows.Forms.DataGridView Grid_Aulas;
    }
}