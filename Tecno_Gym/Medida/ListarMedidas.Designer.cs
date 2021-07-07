namespace Tecno_Gym.Medida
{
    partial class ListarMedidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarMedidas));
            this.Editar_Button = new MetroFramework.Controls.MetroButton();
            this.Excluir_Button = new MetroFramework.Controls.MetroButton();
            this.Grid_Medida = new MetroFramework.Controls.MetroGrid();
            this.Novo_Button = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pesquisa_TB = new System.Windows.Forms.TextBox();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.Grid_Medidas = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.Comparar_Button = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Medida)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Medidas)).BeginInit();
            this.SuspendLayout();
            // 
            // Editar_Button
            // 
            this.Editar_Button.Location = new System.Drawing.Point(604, 565);
            this.Editar_Button.Name = "Editar_Button";
            this.Editar_Button.Size = new System.Drawing.Size(136, 45);
            this.Editar_Button.TabIndex = 9;
            this.Editar_Button.Text = "Editar";
            this.Editar_Button.UseSelectable = true;
            this.Editar_Button.Click += new System.EventHandler(this.Editar_Button_Click);
            // 
            // Excluir_Button
            // 
            this.Excluir_Button.Location = new System.Drawing.Point(448, 565);
            this.Excluir_Button.Name = "Excluir_Button";
            this.Excluir_Button.Size = new System.Drawing.Size(136, 45);
            this.Excluir_Button.TabIndex = 8;
            this.Excluir_Button.Text = "Excluir";
            this.Excluir_Button.UseSelectable = true;
            this.Excluir_Button.Click += new System.EventHandler(this.Excluir_Button_Click);
            // 
            // Grid_Medida
            // 
            this.Grid_Medida.AllowUserToResizeRows = false;
            this.Grid_Medida.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Medida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Medida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Medida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Medida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_Medida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Medida.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_Medida.EnableHeadersVisualStyles = false;
            this.Grid_Medida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid_Medida.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Grid_Medida.Location = new System.Drawing.Point(23, 81);
            this.Grid_Medida.Name = "Grid_Medida";
            this.Grid_Medida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Medida.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid_Medida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Medida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Medida.Size = new System.Drawing.Size(869, 469);
            this.Grid_Medida.TabIndex = 7;
            // 
            // Novo_Button
            // 
            this.Novo_Button.Location = new System.Drawing.Point(756, 565);
            this.Novo_Button.Name = "Novo_Button";
            this.Novo_Button.Size = new System.Drawing.Size(136, 45);
            this.Novo_Button.TabIndex = 6;
            this.Novo_Button.Text = "Novo";
            this.Novo_Button.UseSelectable = true;
            this.Novo_Button.Click += new System.EventHandler(this.Novo_Button_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(864, 44);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(28, 23);
            this.metroButton1.TabIndex = 14;
            this.metroButton1.Text = "...";
            this.metroButton1.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pesquisa_TB);
            this.groupBox1.Controls.Add(this.Pesquisa_Button);
            this.groupBox1.Location = new System.Drawing.Point(637, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 43);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // Pesquisa_TB
            // 
            this.Pesquisa_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa_TB.Location = new System.Drawing.Point(6, 12);
            this.Pesquisa_TB.Name = "Pesquisa_TB";
            this.Pesquisa_TB.ReadOnly = true;
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
            this.Pesquisa_Button.Text = "🧑";
            this.Pesquisa_Button.UseVisualStyleBackColor = true;
            this.Pesquisa_Button.Click += new System.EventHandler(this.Pesquisa_Button_Click);
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
            this.Grid_Medidas.Location = new System.Drawing.Point(23, 82);
            this.Grid_Medidas.Name = "Grid_Medidas";
            this.Grid_Medidas.ReadOnly = true;
            this.Grid_Medidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Medidas.Size = new System.Drawing.Size(870, 469);
            this.Grid_Medidas.TabIndex = 32;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.Location = new System.Drawing.Point(595, 43);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(36, 34);
            this.Refresh_Button.TabIndex = 39;
            this.Refresh_Button.Text = "🔃";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // Comparar_Button
            // 
            this.Comparar_Button.Location = new System.Drawing.Point(23, 565);
            this.Comparar_Button.Name = "Comparar_Button";
            this.Comparar_Button.Size = new System.Drawing.Size(136, 45);
            this.Comparar_Button.TabIndex = 42;
            this.Comparar_Button.Text = "Comparar";
            this.Comparar_Button.UseSelectable = true;
            this.Comparar_Button.Click += new System.EventHandler(this.Comparar_Button_Click);
            // 
            // ListarMedidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.Comparar_Button);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Grid_Medidas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Editar_Button);
            this.Controls.Add(this.Excluir_Button);
            this.Controls.Add(this.Grid_Medida);
            this.Controls.Add(this.Novo_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListarMedidas";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Medidas";
            this.Load += new System.EventHandler(this.ListaMedidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Medida)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Medidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Editar_Button;
        private MetroFramework.Controls.MetroButton Excluir_Button;
        private MetroFramework.Controls.MetroGrid Grid_Medida;
        private MetroFramework.Controls.MetroButton Novo_Button;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pesquisa_TB;
        private System.Windows.Forms.Button Pesquisa_Button;
        private System.Windows.Forms.DataGridView Grid_Medidas;
        private System.Windows.Forms.Button Refresh_Button;
        private MetroFramework.Controls.MetroButton Comparar_Button;
    }
}