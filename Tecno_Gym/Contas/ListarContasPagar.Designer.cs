namespace Tecno_Gym.Contas
{
    partial class ListarContasPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarContasPagar));
            this.Editar_Button = new MetroFramework.Controls.MetroButton();
            this.Excluir_Button = new MetroFramework.Controls.MetroButton();
            this.Novo_Button = new MetroFramework.Controls.MetroButton();
            this.Grid_ContaPagar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Vencido_RB = new System.Windows.Forms.RadioButton();
            this.EmAberto_RB = new System.Windows.Forms.RadioButton();
            this.Pago_RB = new System.Windows.Forms.RadioButton();
            this.Data_DT = new System.Windows.Forms.DateTimePicker();
            this.Data_RB = new System.Windows.Forms.RadioButton();
            this.Descricao_RB = new System.Windows.Forms.RadioButton();
            this.Pesquisa_TB = new System.Windows.Forms.TextBox();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ContaPagar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Editar_Button
            // 
            this.Editar_Button.Location = new System.Drawing.Point(604, 565);
            this.Editar_Button.Name = "Editar_Button";
            this.Editar_Button.Size = new System.Drawing.Size(136, 45);
            this.Editar_Button.TabIndex = 13;
            this.Editar_Button.Text = "Editar";
            this.Editar_Button.UseSelectable = true;
            this.Editar_Button.Click += new System.EventHandler(this.Editar_Button_Click);
            // 
            // Excluir_Button
            // 
            this.Excluir_Button.Location = new System.Drawing.Point(448, 565);
            this.Excluir_Button.Name = "Excluir_Button";
            this.Excluir_Button.Size = new System.Drawing.Size(136, 45);
            this.Excluir_Button.TabIndex = 12;
            this.Excluir_Button.Text = "Excluir";
            this.Excluir_Button.UseSelectable = true;
            this.Excluir_Button.Click += new System.EventHandler(this.Excluir_Button_Click);
            // 
            // Novo_Button
            // 
            this.Novo_Button.Location = new System.Drawing.Point(756, 565);
            this.Novo_Button.Name = "Novo_Button";
            this.Novo_Button.Size = new System.Drawing.Size(136, 45);
            this.Novo_Button.TabIndex = 10;
            this.Novo_Button.Text = "Novo";
            this.Novo_Button.UseSelectable = true;
            this.Novo_Button.Click += new System.EventHandler(this.Novo_Button_Click);
            // 
            // Grid_ContaPagar
            // 
            this.Grid_ContaPagar.AllowUserToAddRows = false;
            this.Grid_ContaPagar.AllowUserToDeleteRows = false;
            this.Grid_ContaPagar.AllowUserToResizeColumns = false;
            this.Grid_ContaPagar.AllowUserToResizeRows = false;
            this.Grid_ContaPagar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_ContaPagar.BackgroundColor = System.Drawing.Color.White;
            this.Grid_ContaPagar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_ContaPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ContaPagar.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_ContaPagar.Location = new System.Drawing.Point(23, 82);
            this.Grid_ContaPagar.Name = "Grid_ContaPagar";
            this.Grid_ContaPagar.ReadOnly = true;
            this.Grid_ContaPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_ContaPagar.Size = new System.Drawing.Size(870, 469);
            this.Grid_ContaPagar.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Vencido_RB);
            this.groupBox1.Controls.Add(this.EmAberto_RB);
            this.groupBox1.Controls.Add(this.Pago_RB);
            this.groupBox1.Controls.Add(this.Data_DT);
            this.groupBox1.Controls.Add(this.Data_RB);
            this.groupBox1.Controls.Add(this.Descricao_RB);
            this.groupBox1.Controls.Add(this.Pesquisa_TB);
            this.groupBox1.Controls.Add(this.Pesquisa_Button);
            this.groupBox1.Location = new System.Drawing.Point(282, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 43);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Vencido_RB
            // 
            this.Vencido_RB.AutoSize = true;
            this.Vencido_RB.Location = new System.Drawing.Point(402, 17);
            this.Vencido_RB.Name = "Vencido_RB";
            this.Vencido_RB.Size = new System.Drawing.Size(64, 17);
            this.Vencido_RB.TabIndex = 39;
            this.Vencido_RB.Text = "Vencido";
            this.Vencido_RB.UseVisualStyleBackColor = true;
            this.Vencido_RB.CheckedChanged += new System.EventHandler(this.Vencido_RB_CheckedChanged);
            // 
            // EmAberto_RB
            // 
            this.EmAberto_RB.AutoSize = true;
            this.EmAberto_RB.Location = new System.Drawing.Point(528, 17);
            this.EmAberto_RB.Name = "EmAberto_RB";
            this.EmAberto_RB.Size = new System.Drawing.Size(73, 17);
            this.EmAberto_RB.TabIndex = 38;
            this.EmAberto_RB.Text = "Em aberto";
            this.EmAberto_RB.UseVisualStyleBackColor = true;
            this.EmAberto_RB.CheckedChanged += new System.EventHandler(this.EmAberto_RB_CheckedChanged_1);
            // 
            // Pago_RB
            // 
            this.Pago_RB.AutoSize = true;
            this.Pago_RB.Location = new System.Drawing.Point(472, 17);
            this.Pago_RB.Name = "Pago_RB";
            this.Pago_RB.Size = new System.Drawing.Size(50, 17);
            this.Pago_RB.TabIndex = 37;
            this.Pago_RB.Text = "Pago";
            this.Pago_RB.UseVisualStyleBackColor = true;
            this.Pago_RB.CheckedChanged += new System.EventHandler(this.Pago_RB_CheckedChanged_1);
            // 
            // Data_DT
            // 
            this.Data_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Data_DT.Location = new System.Drawing.Point(6, 12);
            this.Data_DT.Name = "Data_DT";
            this.Data_DT.Size = new System.Drawing.Size(200, 24);
            this.Data_DT.TabIndex = 36;
            this.Data_DT.Visible = false;
            // 
            // Data_RB
            // 
            this.Data_RB.AutoSize = true;
            this.Data_RB.Location = new System.Drawing.Point(348, 17);
            this.Data_RB.Name = "Data_RB";
            this.Data_RB.Size = new System.Drawing.Size(48, 17);
            this.Data_RB.TabIndex = 29;
            this.Data_RB.Text = "Data";
            this.Data_RB.UseVisualStyleBackColor = true;
            this.Data_RB.CheckedChanged += new System.EventHandler(this.Data_RB_CheckedChanged_1);
            // 
            // Descricao_RB
            // 
            this.Descricao_RB.AutoSize = true;
            this.Descricao_RB.Checked = true;
            this.Descricao_RB.Location = new System.Drawing.Point(269, 17);
            this.Descricao_RB.Name = "Descricao_RB";
            this.Descricao_RB.Size = new System.Drawing.Size(73, 17);
            this.Descricao_RB.TabIndex = 28;
            this.Descricao_RB.TabStop = true;
            this.Descricao_RB.Text = "Descrição";
            this.Descricao_RB.UseVisualStyleBackColor = true;
            this.Descricao_RB.CheckedChanged += new System.EventHandler(this.Descricao_RB_CheckedChanged_1);
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
            this.Pesquisa_Button.Click += new System.EventHandler(this.Pesquisa_Button_Click_2);
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.Location = new System.Drawing.Point(240, 43);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(36, 34);
            this.Refresh_Button.TabIndex = 44;
            this.Refresh_Button.Text = "🔃";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click_1);
            // 
            // ListarContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grid_ContaPagar);
            this.Controls.Add(this.Editar_Button);
            this.Controls.Add(this.Excluir_Button);
            this.Controls.Add(this.Novo_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListarContasPagar";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Contas a pagar";
            this.Load += new System.EventHandler(this.ListarContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ContaPagar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Editar_Button;
        private MetroFramework.Controls.MetroButton Excluir_Button;
        private MetroFramework.Controls.MetroButton Novo_Button;
        private System.Windows.Forms.DataGridView Grid_ContaPagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Vencido_RB;
        private System.Windows.Forms.RadioButton EmAberto_RB;
        private System.Windows.Forms.RadioButton Pago_RB;
        private System.Windows.Forms.DateTimePicker Data_DT;
        private System.Windows.Forms.RadioButton Data_RB;
        private System.Windows.Forms.RadioButton Descricao_RB;
        private System.Windows.Forms.TextBox Pesquisa_TB;
        private System.Windows.Forms.Button Pesquisa_Button;
        private System.Windows.Forms.Button Refresh_Button;
    }
}