namespace Tecno_Gym.Pedido
{
    partial class ListarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarProdutos));
            this.Editar_Button = new MetroFramework.Controls.MetroButton();
            this.Excluir_Button = new MetroFramework.Controls.MetroButton();
            this.Novo_Button = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Categoria_RB = new System.Windows.Forms.RadioButton();
            this.Fornecedor_RB = new System.Windows.Forms.RadioButton();
            this.Nome_RB = new System.Windows.Forms.RadioButton();
            this.Pesquisa_TB = new System.Windows.Forms.TextBox();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.Grid_Produtos = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // Editar_Button
            // 
            this.Editar_Button.Location = new System.Drawing.Point(603, 566);
            this.Editar_Button.Name = "Editar_Button";
            this.Editar_Button.Size = new System.Drawing.Size(136, 45);
            this.Editar_Button.TabIndex = 29;
            this.Editar_Button.Text = "Editar";
            this.Editar_Button.UseSelectable = true;
            this.Editar_Button.Click += new System.EventHandler(this.Editar_Button_Click);
            // 
            // Excluir_Button
            // 
            this.Excluir_Button.Location = new System.Drawing.Point(448, 566);
            this.Excluir_Button.Name = "Excluir_Button";
            this.Excluir_Button.Size = new System.Drawing.Size(136, 45);
            this.Excluir_Button.TabIndex = 28;
            this.Excluir_Button.Text = "Excluir";
            this.Excluir_Button.UseSelectable = true;
            this.Excluir_Button.Click += new System.EventHandler(this.Excluir_Button_Click);
            // 
            // Novo_Button
            // 
            this.Novo_Button.Location = new System.Drawing.Point(756, 566);
            this.Novo_Button.Name = "Novo_Button";
            this.Novo_Button.Size = new System.Drawing.Size(136, 45);
            this.Novo_Button.TabIndex = 26;
            this.Novo_Button.Text = "Novo";
            this.Novo_Button.UseSelectable = true;
            this.Novo_Button.Click += new System.EventHandler(this.Novo_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Categoria_RB);
            this.groupBox1.Controls.Add(this.Fornecedor_RB);
            this.groupBox1.Controls.Add(this.Nome_RB);
            this.groupBox1.Controls.Add(this.Pesquisa_TB);
            this.groupBox1.Controls.Add(this.Pesquisa_Button);
            this.groupBox1.Location = new System.Drawing.Point(402, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 43);
            this.groupBox1.TabIndex = 30;
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
            this.Nome_RB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.Grid_Produtos.Location = new System.Drawing.Point(23, 82);
            this.Grid_Produtos.Name = "Grid_Produtos";
            this.Grid_Produtos.ReadOnly = true;
            this.Grid_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Produtos.Size = new System.Drawing.Size(870, 469);
            this.Grid_Produtos.TabIndex = 35;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.Location = new System.Drawing.Point(360, 43);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(36, 34);
            this.Refresh_Button.TabIndex = 40;
            this.Refresh_Button.Text = "🔃";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // ListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Grid_Produtos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Editar_Button);
            this.Controls.Add(this.Excluir_Button);
            this.Controls.Add(this.Novo_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListarProdutos";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.ListarProdutos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Editar_Button;
        private MetroFramework.Controls.MetroButton Excluir_Button;
        private MetroFramework.Controls.MetroButton Novo_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pesquisa_TB;
        private System.Windows.Forms.Button Pesquisa_Button;
        private System.Windows.Forms.DataGridView Grid_Produtos;
        private System.Windows.Forms.RadioButton Categoria_RB;
        private System.Windows.Forms.RadioButton Fornecedor_RB;
        private System.Windows.Forms.RadioButton Nome_RB;
        private System.Windows.Forms.Button Refresh_Button;
    }
}