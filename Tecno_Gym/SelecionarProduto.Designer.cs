namespace Tecno_Gym
{
    partial class SelecionarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarProduto));
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Grid_Produtos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Categoria_RB = new System.Windows.Forms.RadioButton();
            this.Fornecedor_RB = new System.Windows.Forms.RadioButton();
            this.Nome_RB = new System.Windows.Forms.RadioButton();
            this.Pesquisa_TB = new System.Windows.Forms.TextBox();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.Selecionar_Button = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produtos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.Location = new System.Drawing.Point(198, 80);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(36, 34);
            this.Refresh_Button.TabIndex = 43;
            this.Refresh_Button.Text = "🔃";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Grid_Produtos
            // 
            this.Grid_Produtos.AllowUserToAddRows = false;
            this.Grid_Produtos.AllowUserToDeleteRows = false;
            this.Grid_Produtos.AllowUserToResizeColumns = false;
            this.Grid_Produtos.AllowUserToResizeRows = false;
            this.Grid_Produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Produtos.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Produtos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Produtos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Produtos.Location = new System.Drawing.Point(23, 122);
            this.Grid_Produtos.Name = "Grid_Produtos";
            this.Grid_Produtos.ReadOnly = true;
            this.Grid_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Produtos.Size = new System.Drawing.Size(708, 308);
            this.Grid_Produtos.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Categoria_RB);
            this.groupBox1.Controls.Add(this.Fornecedor_RB);
            this.groupBox1.Controls.Add(this.Nome_RB);
            this.groupBox1.Controls.Add(this.Pesquisa_TB);
            this.groupBox1.Controls.Add(this.Pesquisa_Button);
            this.groupBox1.Location = new System.Drawing.Point(240, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 43);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // Categoria_RB
            // 
            this.Categoria_RB.AutoSize = true;
            this.Categoria_RB.Location = new System.Drawing.Point(412, 17);
            this.Categoria_RB.Name = "Categoria_RB";
            this.Categoria_RB.Size = new System.Drawing.Size(70, 17);
            this.Categoria_RB.TabIndex = 30;
            this.Categoria_RB.Text = "Categoria";
            this.Categoria_RB.UseVisualStyleBackColor = true;
            this.Categoria_RB.CheckedChanged += new System.EventHandler(this.Categoria_RB_CheckedChanged);
            // 
            // Fornecedor_RB
            // 
            this.Fornecedor_RB.AutoSize = true;
            this.Fornecedor_RB.Location = new System.Drawing.Point(327, 17);
            this.Fornecedor_RB.Name = "Fornecedor_RB";
            this.Fornecedor_RB.Size = new System.Drawing.Size(79, 17);
            this.Fornecedor_RB.TabIndex = 29;
            this.Fornecedor_RB.Text = "Fornecedor";
            this.Fornecedor_RB.UseVisualStyleBackColor = true;
            this.Fornecedor_RB.CheckedChanged += new System.EventHandler(this.Fornecedor_RB_CheckedChanged);
            // 
            // Nome_RB
            // 
            this.Nome_RB.AutoSize = true;
            this.Nome_RB.Checked = true;
            this.Nome_RB.Location = new System.Drawing.Point(268, 17);
            this.Nome_RB.Name = "Nome_RB";
            this.Nome_RB.Size = new System.Drawing.Size(53, 17);
            this.Nome_RB.TabIndex = 28;
            this.Nome_RB.TabStop = true;
            this.Nome_RB.Text = "Nome";
            this.Nome_RB.UseVisualStyleBackColor = true;
            this.Nome_RB.CheckedChanged += new System.EventHandler(this.Nome_RB_CheckedChanged);
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
            this.Pesquisa_Button.Click += new System.EventHandler(this.Pesquisa_Button_Click);
            // 
            // Selecionar_Button
            // 
            this.Selecionar_Button.Location = new System.Drawing.Point(595, 446);
            this.Selecionar_Button.Name = "Selecionar_Button";
            this.Selecionar_Button.Size = new System.Drawing.Size(136, 45);
            this.Selecionar_Button.TabIndex = 44;
            this.Selecionar_Button.Text = "Selecionar";
            this.Selecionar_Button.UseSelectable = true;
            this.Selecionar_Button.Click += new System.EventHandler(this.Selecionar_Button_Click);
            // 
            // SelecionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 508);
            this.Controls.Add(this.Selecionar_Button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Grid_Produtos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelecionarProduto";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Selecionar produto";
            this.Load += new System.EventHandler(this.SelecionarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produtos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Refresh_Button;
        private System.Windows.Forms.DataGridView Grid_Produtos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Categoria_RB;
        private System.Windows.Forms.RadioButton Fornecedor_RB;
        private System.Windows.Forms.RadioButton Nome_RB;
        private System.Windows.Forms.TextBox Pesquisa_TB;
        private System.Windows.Forms.Button Pesquisa_Button;
        private MetroFramework.Controls.MetroButton Selecionar_Button;
    }
}