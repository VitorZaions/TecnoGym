namespace Tecno_Gym.Mensalidade
{
    partial class ListarMensalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarMensalidades));
            this.Editar_Button = new MetroFramework.Controls.MetroButton();
            this.Excluir_Button = new MetroFramework.Controls.MetroButton();
            this.Novo_Button = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmAberto_RB = new System.Windows.Forms.RadioButton();
            this.Pagas_RB = new System.Windows.Forms.RadioButton();
            this.Vencidas_RB = new System.Windows.Forms.RadioButton();
            this.Cliente_RB = new System.Windows.Forms.RadioButton();
            this.Pesquisa_TB = new System.Windows.Forms.TextBox();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.Grid_Mensalidades = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Mensalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // Editar_Button
            // 
            this.Editar_Button.Location = new System.Drawing.Point(603, 565);
            this.Editar_Button.Name = "Editar_Button";
            this.Editar_Button.Size = new System.Drawing.Size(136, 45);
            this.Editar_Button.TabIndex = 17;
            this.Editar_Button.Text = "Editar";
            this.Editar_Button.UseSelectable = true;
            this.Editar_Button.Click += new System.EventHandler(this.Editar_Button_Click);
            // 
            // Excluir_Button
            // 
            this.Excluir_Button.Location = new System.Drawing.Point(448, 565);
            this.Excluir_Button.Name = "Excluir_Button";
            this.Excluir_Button.Size = new System.Drawing.Size(136, 45);
            this.Excluir_Button.TabIndex = 16;
            this.Excluir_Button.Text = "Excluir";
            this.Excluir_Button.UseSelectable = true;
            this.Excluir_Button.Click += new System.EventHandler(this.Excluir_Button_Click);
            // 
            // Novo_Button
            // 
            this.Novo_Button.Location = new System.Drawing.Point(756, 565);
            this.Novo_Button.Name = "Novo_Button";
            this.Novo_Button.Size = new System.Drawing.Size(136, 45);
            this.Novo_Button.TabIndex = 14;
            this.Novo_Button.Text = "Novo";
            this.Novo_Button.UseSelectable = true;
            this.Novo_Button.Click += new System.EventHandler(this.Novo_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EmAberto_RB);
            this.groupBox1.Controls.Add(this.Pagas_RB);
            this.groupBox1.Controls.Add(this.Vencidas_RB);
            this.groupBox1.Controls.Add(this.Cliente_RB);
            this.groupBox1.Controls.Add(this.Pesquisa_TB);
            this.groupBox1.Controls.Add(this.Pesquisa_Button);
            this.groupBox1.Location = new System.Drawing.Point(349, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 43);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // EmAberto_RB
            // 
            this.EmAberto_RB.AutoSize = true;
            this.EmAberto_RB.Location = new System.Drawing.Point(460, 17);
            this.EmAberto_RB.Name = "EmAberto_RB";
            this.EmAberto_RB.Size = new System.Drawing.Size(73, 17);
            this.EmAberto_RB.TabIndex = 31;
            this.EmAberto_RB.Text = "Em aberto";
            this.EmAberto_RB.UseVisualStyleBackColor = true;
            this.EmAberto_RB.CheckedChanged += new System.EventHandler(this.EmAberto_RB_CheckedChanged);
            // 
            // Pagas_RB
            // 
            this.Pagas_RB.AutoSize = true;
            this.Pagas_RB.Location = new System.Drawing.Point(404, 17);
            this.Pagas_RB.Name = "Pagas_RB";
            this.Pagas_RB.Size = new System.Drawing.Size(50, 17);
            this.Pagas_RB.TabIndex = 30;
            this.Pagas_RB.Text = "Pago";
            this.Pagas_RB.UseVisualStyleBackColor = true;
            this.Pagas_RB.CheckedChanged += new System.EventHandler(this.Pagas_RB_CheckedChanged);
            // 
            // Vencidas_RB
            // 
            this.Vencidas_RB.AutoSize = true;
            this.Vencidas_RB.Location = new System.Drawing.Point(334, 17);
            this.Vencidas_RB.Name = "Vencidas_RB";
            this.Vencidas_RB.Size = new System.Drawing.Size(64, 17);
            this.Vencidas_RB.TabIndex = 29;
            this.Vencidas_RB.Text = "Vencido";
            this.Vencidas_RB.UseVisualStyleBackColor = true;
            this.Vencidas_RB.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Cliente_RB
            // 
            this.Cliente_RB.AutoSize = true;
            this.Cliente_RB.Checked = true;
            this.Cliente_RB.Location = new System.Drawing.Point(271, 17);
            this.Cliente_RB.Name = "Cliente_RB";
            this.Cliente_RB.Size = new System.Drawing.Size(57, 17);
            this.Cliente_RB.TabIndex = 28;
            this.Cliente_RB.TabStop = true;
            this.Cliente_RB.Text = "Cliente";
            this.Cliente_RB.UseVisualStyleBackColor = true;
            this.Cliente_RB.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.Grid_Mensalidades.Location = new System.Drawing.Point(23, 82);
            this.Grid_Mensalidades.Name = "Grid_Mensalidades";
            this.Grid_Mensalidades.ReadOnly = true;
            this.Grid_Mensalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Mensalidades.Size = new System.Drawing.Size(870, 469);
            this.Grid_Mensalidades.TabIndex = 33;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.Location = new System.Drawing.Point(307, 43);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(36, 34);
            this.Refresh_Button.TabIndex = 38;
            this.Refresh_Button.Text = "🔃";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // ListarMensalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Grid_Mensalidades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Editar_Button);
            this.Controls.Add(this.Excluir_Button);
            this.Controls.Add(this.Novo_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListarMensalidades";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Mensalidades";
            this.Load += new System.EventHandler(this.ListarMensalidades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Mensalidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Editar_Button;
        private MetroFramework.Controls.MetroButton Excluir_Button;
        private MetroFramework.Controls.MetroButton Novo_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pesquisa_TB;
        private System.Windows.Forms.Button Pesquisa_Button;
        private System.Windows.Forms.DataGridView Grid_Mensalidades;
        private System.Windows.Forms.RadioButton Vencidas_RB;
        private System.Windows.Forms.RadioButton Cliente_RB;
        private System.Windows.Forms.RadioButton EmAberto_RB;
        private System.Windows.Forms.RadioButton Pagas_RB;
        private System.Windows.Forms.Button Refresh_Button;
    }
}