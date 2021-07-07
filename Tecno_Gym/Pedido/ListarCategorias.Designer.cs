namespace Tecno_Gym.Pedido
{
    partial class ListarCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarCategorias));
            this.Editar_Button = new MetroFramework.Controls.MetroButton();
            this.Excluir_Button = new MetroFramework.Controls.MetroButton();
            this.Novo_Button = new MetroFramework.Controls.MetroButton();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.Pesquisa_TB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid_Categorias = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // Editar_Button
            // 
            this.Editar_Button.Location = new System.Drawing.Point(603, 565);
            this.Editar_Button.Name = "Editar_Button";
            this.Editar_Button.Size = new System.Drawing.Size(136, 45);
            this.Editar_Button.TabIndex = 25;
            this.Editar_Button.Text = "Editar";
            this.Editar_Button.UseSelectable = true;
            this.Editar_Button.Click += new System.EventHandler(this.Editar_Button_Click);
            // 
            // Excluir_Button
            // 
            this.Excluir_Button.Location = new System.Drawing.Point(448, 565);
            this.Excluir_Button.Name = "Excluir_Button";
            this.Excluir_Button.Size = new System.Drawing.Size(136, 45);
            this.Excluir_Button.TabIndex = 24;
            this.Excluir_Button.Text = "Excluir";
            this.Excluir_Button.UseSelectable = true;
            this.Excluir_Button.Click += new System.EventHandler(this.Excluir_Button_Click);
            // 
            // Novo_Button
            // 
            this.Novo_Button.Location = new System.Drawing.Point(756, 565);
            this.Novo_Button.Name = "Novo_Button";
            this.Novo_Button.Size = new System.Drawing.Size(136, 45);
            this.Novo_Button.TabIndex = 22;
            this.Novo_Button.Text = "Novo";
            this.Novo_Button.UseSelectable = true;
            this.Novo_Button.Click += new System.EventHandler(this.Novo_Button_Click);
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
            // Pesquisa_TB
            // 
            this.Pesquisa_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa_TB.Location = new System.Drawing.Point(6, 12);
            this.Pesquisa_TB.Name = "Pesquisa_TB";
            this.Pesquisa_TB.Size = new System.Drawing.Size(200, 24);
            this.Pesquisa_TB.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pesquisa_TB);
            this.groupBox1.Controls.Add(this.Pesquisa_Button);
            this.groupBox1.Location = new System.Drawing.Point(637, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 43);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por nome";
            // 
            // Grid_Categorias
            // 
            this.Grid_Categorias.AllowUserToAddRows = false;
            this.Grid_Categorias.AllowUserToDeleteRows = false;
            this.Grid_Categorias.AllowUserToResizeColumns = false;
            this.Grid_Categorias.AllowUserToResizeRows = false;
            this.Grid_Categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Categorias.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Categorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Categorias.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Categorias.Location = new System.Drawing.Point(23, 82);
            this.Grid_Categorias.Name = "Grid_Categorias";
            this.Grid_Categorias.ReadOnly = true;
            this.Grid_Categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Categorias.Size = new System.Drawing.Size(870, 469);
            this.Grid_Categorias.TabIndex = 29;
            this.Grid_Categorias.SelectionChanged += new System.EventHandler(this.Grid_Categorias_SelectionChanged);
            // 
            // ListarCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.Grid_Categorias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Editar_Button);
            this.Controls.Add(this.Excluir_Button);
            this.Controls.Add(this.Novo_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListarCategorias";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.ListarCategorias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Categorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Editar_Button;
        private MetroFramework.Controls.MetroButton Excluir_Button;
        private MetroFramework.Controls.MetroButton Novo_Button;
        private System.Windows.Forms.Button Pesquisa_Button;
        private System.Windows.Forms.TextBox Pesquisa_TB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Grid_Categorias;
    }
}