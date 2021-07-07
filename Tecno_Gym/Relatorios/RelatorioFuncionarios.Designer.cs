namespace Tecno_Gym.Relatorios
{
    partial class RelatorioFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioFuncionarios));
            this.Pesquisa_Button = new MetroFramework.Controls.MetroButton();
            this.Responsavel_LBL = new System.Windows.Forms.Label();
            this.Responsavel_TB = new System.Windows.Forms.TextBox();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.Grid_Funcionarios = new System.Windows.Forms.DataGridView();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Pesquisa_Button
            // 
            this.Pesquisa_Button.Location = new System.Drawing.Point(453, 102);
            this.Pesquisa_Button.Name = "Pesquisa_Button";
            this.Pesquisa_Button.Size = new System.Drawing.Size(28, 23);
            this.Pesquisa_Button.TabIndex = 15;
            this.Pesquisa_Button.Text = "🧑";
            this.Pesquisa_Button.UseSelectable = true;
            this.Pesquisa_Button.Click += new System.EventHandler(this.Pesquisa_Button_Click);
            // 
            // Responsavel_LBL
            // 
            this.Responsavel_LBL.AutoSize = true;
            this.Responsavel_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responsavel_LBL.Location = new System.Drawing.Point(25, 81);
            this.Responsavel_LBL.Name = "Responsavel_LBL";
            this.Responsavel_LBL.Size = new System.Drawing.Size(96, 18);
            this.Responsavel_LBL.TabIndex = 14;
            this.Responsavel_LBL.Text = "* Funcionário";
            // 
            // Responsavel_TB
            // 
            this.Responsavel_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responsavel_TB.Location = new System.Drawing.Point(28, 102);
            this.Responsavel_TB.Name = "Responsavel_TB";
            this.Responsavel_TB.ReadOnly = true;
            this.Responsavel_TB.Size = new System.Drawing.Size(384, 24);
            this.Responsavel_TB.TabIndex = 13;
            // 
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(345, 158);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 45);
            this.Salvar_Button.TabIndex = 16;
            this.Salvar_Button.Text = "Gerar";
            this.Salvar_Button.UseSelectable = true;
            this.Salvar_Button.Click += new System.EventHandler(this.Salvar_Button_Click);
            // 
            // Grid_Funcionarios
            // 
            this.Grid_Funcionarios.AllowUserToAddRows = false;
            this.Grid_Funcionarios.AllowUserToDeleteRows = false;
            this.Grid_Funcionarios.AllowUserToResizeColumns = false;
            this.Grid_Funcionarios.AllowUserToResizeRows = false;
            this.Grid_Funcionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Funcionarios.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Funcionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Funcionarios.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Funcionarios.Location = new System.Drawing.Point(28, 278);
            this.Grid_Funcionarios.Name = "Grid_Funcionarios";
            this.Grid_Funcionarios.ReadOnly = true;
            this.Grid_Funcionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Funcionarios.Size = new System.Drawing.Size(453, 236);
            this.Grid_Funcionarios.TabIndex = 113;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(418, 102);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(28, 23);
            this.metroButton3.TabIndex = 115;
            this.metroButton3.Text = "X";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // RelatorioFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 227);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.Grid_Funcionarios);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.Pesquisa_Button);
            this.Controls.Add(this.Responsavel_LBL);
            this.Controls.Add(this.Responsavel_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RelatorioFuncionarios";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Relatório funcionarios";
            this.Load += new System.EventHandler(this.RelatorioFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Funcionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Pesquisa_Button;
        private System.Windows.Forms.Label Responsavel_LBL;
        private System.Windows.Forms.TextBox Responsavel_TB;
        private MetroFramework.Controls.MetroButton Salvar_Button;
        private System.Windows.Forms.DataGridView Grid_Funcionarios;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}