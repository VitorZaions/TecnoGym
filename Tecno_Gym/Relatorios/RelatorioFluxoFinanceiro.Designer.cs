namespace Tecno_Gym.Relatorios
{
    partial class RelatorioFluxoFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioFluxoFinanceiro));
            this.GerarRelatorio_Button = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataFinal_DT = new System.Windows.Forms.DateTimePicker();
            this.DataInicial_DT = new System.Windows.Forms.DateTimePicker();
            this.ContaPagar_CB = new System.Windows.Forms.CheckBox();
            this.ContasReceber_CB = new System.Windows.Forms.CheckBox();
            this.Mesalidades_CB = new System.Windows.Forms.CheckBox();
            this.EmAberto_RB = new System.Windows.Forms.RadioButton();
            this.Pago_RB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tempo_CB = new System.Windows.Forms.CheckBox();
            this.Grid_ContasReceber = new System.Windows.Forms.DataGridView();
            this.Grid_Mensalidades = new System.Windows.Forms.DataGridView();
            this.Grid_ContasPagar = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ContasReceber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Mensalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ContasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // GerarRelatorio_Button
            // 
            this.GerarRelatorio_Button.Location = new System.Drawing.Point(326, 317);
            this.GerarRelatorio_Button.Name = "GerarRelatorio_Button";
            this.GerarRelatorio_Button.Size = new System.Drawing.Size(136, 45);
            this.GerarRelatorio_Button.TabIndex = 29;
            this.GerarRelatorio_Button.Text = "Salvar";
            this.GerarRelatorio_Button.UseSelectable = true;
            this.GerarRelatorio_Button.Click += new System.EventHandler(this.GerarRelatorio_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Data Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Data Inicial";
            // 
            // DataFinal_DT
            // 
            this.DataFinal_DT.Enabled = false;
            this.DataFinal_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFinal_DT.Location = new System.Drawing.Point(262, 97);
            this.DataFinal_DT.Name = "DataFinal_DT";
            this.DataFinal_DT.Size = new System.Drawing.Size(200, 24);
            this.DataFinal_DT.TabIndex = 26;
            // 
            // DataInicial_DT
            // 
            this.DataInicial_DT.Enabled = false;
            this.DataInicial_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicial_DT.Location = new System.Drawing.Point(28, 97);
            this.DataInicial_DT.Name = "DataInicial_DT";
            this.DataInicial_DT.Size = new System.Drawing.Size(200, 24);
            this.DataInicial_DT.TabIndex = 25;
            // 
            // ContaPagar_CB
            // 
            this.ContaPagar_CB.AutoSize = true;
            this.ContaPagar_CB.Location = new System.Drawing.Point(14, 85);
            this.ContaPagar_CB.Name = "ContaPagar_CB";
            this.ContaPagar_CB.Size = new System.Drawing.Size(98, 17);
            this.ContaPagar_CB.TabIndex = 30;
            this.ContaPagar_CB.Text = "Contas a pagar";
            this.ContaPagar_CB.UseVisualStyleBackColor = true;
            // 
            // ContasReceber_CB
            // 
            this.ContasReceber_CB.AutoSize = true;
            this.ContasReceber_CB.Location = new System.Drawing.Point(14, 29);
            this.ContasReceber_CB.Name = "ContasReceber_CB";
            this.ContasReceber_CB.Size = new System.Drawing.Size(107, 17);
            this.ContasReceber_CB.TabIndex = 31;
            this.ContasReceber_CB.Text = "Contas a receber";
            this.ContasReceber_CB.UseVisualStyleBackColor = true;
            // 
            // Mesalidades_CB
            // 
            this.Mesalidades_CB.AutoSize = true;
            this.Mesalidades_CB.Location = new System.Drawing.Point(14, 57);
            this.Mesalidades_CB.Name = "Mesalidades_CB";
            this.Mesalidades_CB.Size = new System.Drawing.Size(91, 17);
            this.Mesalidades_CB.TabIndex = 32;
            this.Mesalidades_CB.Text = "Mensalidades";
            this.Mesalidades_CB.UseVisualStyleBackColor = true;
            // 
            // EmAberto_RB
            // 
            this.EmAberto_RB.AutoSize = true;
            this.EmAberto_RB.Checked = true;
            this.EmAberto_RB.Location = new System.Drawing.Point(162, 29);
            this.EmAberto_RB.Name = "EmAberto_RB";
            this.EmAberto_RB.Size = new System.Drawing.Size(73, 17);
            this.EmAberto_RB.TabIndex = 33;
            this.EmAberto_RB.TabStop = true;
            this.EmAberto_RB.Text = "Em aberto";
            this.EmAberto_RB.UseVisualStyleBackColor = true;
            this.EmAberto_RB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Pago_RB
            // 
            this.Pago_RB.AutoSize = true;
            this.Pago_RB.Location = new System.Drawing.Point(162, 56);
            this.Pago_RB.Name = "Pago_RB";
            this.Pago_RB.Size = new System.Drawing.Size(50, 17);
            this.Pago_RB.TabIndex = 34;
            this.Pago_RB.Text = "Pago";
            this.Pago_RB.UseVisualStyleBackColor = true;
            this.Pago_RB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ContasReceber_CB);
            this.groupBox1.Controls.Add(this.Pago_RB);
            this.groupBox1.Controls.Add(this.ContaPagar_CB);
            this.groupBox1.Controls.Add(this.EmAberto_RB);
            this.groupBox1.Controls.Add(this.Mesalidades_CB);
            this.groupBox1.Location = new System.Drawing.Point(28, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 115);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geral";
            // 
            // Tempo_CB
            // 
            this.Tempo_CB.AutoSize = true;
            this.Tempo_CB.Location = new System.Drawing.Point(31, 143);
            this.Tempo_CB.Name = "Tempo_CB";
            this.Tempo_CB.Size = new System.Drawing.Size(129, 17);
            this.Tempo_CB.TabIndex = 111;
            this.Tempo_CB.Text = "Utilizar filtro por tempo";
            this.Tempo_CB.UseVisualStyleBackColor = true;
            this.Tempo_CB.CheckedChanged += new System.EventHandler(this.Tempo_CB_CheckedChanged);
            // 
            // Grid_ContasReceber
            // 
            this.Grid_ContasReceber.AllowUserToAddRows = false;
            this.Grid_ContasReceber.AllowUserToDeleteRows = false;
            this.Grid_ContasReceber.AllowUserToResizeColumns = false;
            this.Grid_ContasReceber.AllowUserToResizeRows = false;
            this.Grid_ContasReceber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_ContasReceber.BackgroundColor = System.Drawing.Color.White;
            this.Grid_ContasReceber.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_ContasReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ContasReceber.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_ContasReceber.Location = new System.Drawing.Point(28, 402);
            this.Grid_ContasReceber.Name = "Grid_ContasReceber";
            this.Grid_ContasReceber.ReadOnly = true;
            this.Grid_ContasReceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_ContasReceber.Size = new System.Drawing.Size(225, 100);
            this.Grid_ContasReceber.TabIndex = 114;
            // 
            // Grid_Mensalidades
            // 
            this.Grid_Mensalidades.AllowUserToAddRows = false;
            this.Grid_Mensalidades.AllowUserToDeleteRows = false;
            this.Grid_Mensalidades.AllowUserToResizeColumns = false;
            this.Grid_Mensalidades.AllowUserToResizeRows = false;
            this.Grid_Mensalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Mensalidades.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Mensalidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Mensalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Mensalidades.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Mensalidades.Location = new System.Drawing.Point(271, 402);
            this.Grid_Mensalidades.Name = "Grid_Mensalidades";
            this.Grid_Mensalidades.ReadOnly = true;
            this.Grid_Mensalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Mensalidades.Size = new System.Drawing.Size(214, 100);
            this.Grid_Mensalidades.TabIndex = 115;
            // 
            // Grid_ContasPagar
            // 
            this.Grid_ContasPagar.AllowUserToAddRows = false;
            this.Grid_ContasPagar.AllowUserToDeleteRows = false;
            this.Grid_ContasPagar.AllowUserToResizeColumns = false;
            this.Grid_ContasPagar.AllowUserToResizeRows = false;
            this.Grid_ContasPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_ContasPagar.BackgroundColor = System.Drawing.Color.White;
            this.Grid_ContasPagar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_ContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ContasPagar.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_ContasPagar.Location = new System.Drawing.Point(23, 528);
            this.Grid_ContasPagar.Name = "Grid_ContasPagar";
            this.Grid_ContasPagar.ReadOnly = true;
            this.Grid_ContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_ContasPagar.Size = new System.Drawing.Size(225, 92);
            this.Grid_ContasPagar.TabIndex = 116;
            // 
            // RelatorioFluxoFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 388);
            this.Controls.Add(this.Grid_ContasPagar);
            this.Controls.Add(this.Grid_Mensalidades);
            this.Controls.Add(this.Grid_ContasReceber);
            this.Controls.Add(this.Tempo_CB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GerarRelatorio_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataFinal_DT);
            this.Controls.Add(this.DataInicial_DT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RelatorioFluxoFinanceiro";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Relatório fluxo de caixa";
            this.Load += new System.EventHandler(this.RelatorioFluxoFinanceiro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ContasReceber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Mensalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ContasPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton GerarRelatorio_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DataFinal_DT;
        private System.Windows.Forms.DateTimePicker DataInicial_DT;
        private System.Windows.Forms.CheckBox ContaPagar_CB;
        private System.Windows.Forms.CheckBox ContasReceber_CB;
        private System.Windows.Forms.CheckBox Mesalidades_CB;
        private System.Windows.Forms.RadioButton EmAberto_RB;
        private System.Windows.Forms.RadioButton Pago_RB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Tempo_CB;
        private System.Windows.Forms.DataGridView Grid_ContasReceber;
        private System.Windows.Forms.DataGridView Grid_Mensalidades;
        private System.Windows.Forms.DataGridView Grid_ContasPagar;
    }
}