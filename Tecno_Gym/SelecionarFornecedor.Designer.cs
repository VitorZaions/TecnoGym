namespace Tecno_Gym
{
    partial class SelecionarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarFornecedor));
            this.Selecionar_Button = new MetroFramework.Controls.MetroButton();
            this.Grid_Fornecedores = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pesquisa_TB = new System.Windows.Forms.TextBox();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Fornecedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Selecionar_Button
            // 
            this.Selecionar_Button.Location = new System.Drawing.Point(595, 413);
            this.Selecionar_Button.Name = "Selecionar_Button";
            this.Selecionar_Button.Size = new System.Drawing.Size(136, 45);
            this.Selecionar_Button.TabIndex = 9;
            this.Selecionar_Button.Text = "Selecionar";
            this.Selecionar_Button.UseSelectable = true;
            this.Selecionar_Button.Click += new System.EventHandler(this.Selecionar_Button_Click);
            // 
            // Grid_Fornecedores
            // 
            this.Grid_Fornecedores.AllowUserToAddRows = false;
            this.Grid_Fornecedores.AllowUserToDeleteRows = false;
            this.Grid_Fornecedores.AllowUserToResizeColumns = false;
            this.Grid_Fornecedores.AllowUserToResizeRows = false;
            this.Grid_Fornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Fornecedores.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Fornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Fornecedores.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Fornecedores.Location = new System.Drawing.Point(23, 90);
            this.Grid_Fornecedores.Name = "Grid_Fornecedores";
            this.Grid_Fornecedores.ReadOnly = true;
            this.Grid_Fornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Fornecedores.Size = new System.Drawing.Size(708, 308);
            this.Grid_Fornecedores.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pesquisa_TB);
            this.groupBox1.Controls.Add(this.Pesquisa_Button);
            this.groupBox1.Location = new System.Drawing.Point(475, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 43);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por nome";
            // 
            // Pesquisa_TB
            // 
            this.Pesquisa_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa_TB.Location = new System.Drawing.Point(6, 12);
            this.Pesquisa_TB.Name = "Pesquisa_TB";
            this.Pesquisa_TB.Size = new System.Drawing.Size(200, 24);
            this.Pesquisa_TB.TabIndex = 26;
            // 
            // Pesquisa_Button
            // 
            this.Pesquisa_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa_Button.Location = new System.Drawing.Point(212, 13);
            this.Pesquisa_Button.Name = "Pesquisa_Button";
            this.Pesquisa_Button.Size = new System.Drawing.Size(39, 23);
            this.Pesquisa_Button.TabIndex = 27;
            this.Pesquisa_Button.Text = "🔎";
            this.Pesquisa_Button.UseVisualStyleBackColor = true;
            this.Pesquisa_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.Location = new System.Drawing.Point(433, 48);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(36, 34);
            this.Refresh_Button.TabIndex = 35;
            this.Refresh_Button.Text = "🔃";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // SelecionarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 473);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grid_Fornecedores);
            this.Controls.Add(this.Selecionar_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelecionarFornecedor";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Selecionar fornecedor";
            this.Load += new System.EventHandler(this.SelecionarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Fornecedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton Selecionar_Button;
        private System.Windows.Forms.DataGridView Grid_Fornecedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pesquisa_TB;
        private System.Windows.Forms.Button Pesquisa_Button;
        private System.Windows.Forms.Button Refresh_Button;
    }
}