namespace Tecno_Gym.Turma
{
    partial class ListarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarTurma));
            this.Novo_Button = new MetroFramework.Controls.MetroButton();
            this.Excluir_Button = new MetroFramework.Controls.MetroButton();
            this.Editar_Button = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Responsavel_RB = new System.Windows.Forms.RadioButton();
            this.Descricao_RB = new System.Windows.Forms.RadioButton();
            this.Pesquisa_TB = new System.Windows.Forms.TextBox();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.Grid_Turmas = new System.Windows.Forms.DataGridView();
            this.Refresh_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // Novo_Button
            // 
            this.Novo_Button.Location = new System.Drawing.Point(756, 566);
            this.Novo_Button.Name = "Novo_Button";
            this.Novo_Button.Size = new System.Drawing.Size(136, 45);
            this.Novo_Button.TabIndex = 2;
            this.Novo_Button.Text = "Novo";
            this.Novo_Button.UseSelectable = true;
            this.Novo_Button.Click += new System.EventHandler(this.Novo_Button_Click);
            // 
            // Excluir_Button
            // 
            this.Excluir_Button.Location = new System.Drawing.Point(448, 566);
            this.Excluir_Button.Name = "Excluir_Button";
            this.Excluir_Button.Size = new System.Drawing.Size(136, 45);
            this.Excluir_Button.TabIndex = 4;
            this.Excluir_Button.Text = "Excluir";
            this.Excluir_Button.UseSelectable = true;
            this.Excluir_Button.Click += new System.EventHandler(this.Excluir_Button_Click);
            // 
            // Editar_Button
            // 
            this.Editar_Button.Location = new System.Drawing.Point(603, 566);
            this.Editar_Button.Name = "Editar_Button";
            this.Editar_Button.Size = new System.Drawing.Size(136, 45);
            this.Editar_Button.TabIndex = 5;
            this.Editar_Button.Text = "Editar";
            this.Editar_Button.UseSelectable = true;
            this.Editar_Button.Click += new System.EventHandler(this.Editar_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Responsavel_RB);
            this.groupBox1.Controls.Add(this.Descricao_RB);
            this.groupBox1.Controls.Add(this.Pesquisa_TB);
            this.groupBox1.Controls.Add(this.Pesquisa_Button);
            this.groupBox1.Location = new System.Drawing.Point(448, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 43);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // Responsavel_RB
            // 
            this.Responsavel_RB.AutoSize = true;
            this.Responsavel_RB.Location = new System.Drawing.Point(346, 17);
            this.Responsavel_RB.Name = "Responsavel_RB";
            this.Responsavel_RB.Size = new System.Drawing.Size(87, 17);
            this.Responsavel_RB.TabIndex = 29;
            this.Responsavel_RB.Text = "Responsável";
            this.Responsavel_RB.UseVisualStyleBackColor = true;
            this.Responsavel_RB.CheckedChanged += new System.EventHandler(this.Responsavel_RB_CheckedChanged);
            // 
            // Descricao_RB
            // 
            this.Descricao_RB.AutoSize = true;
            this.Descricao_RB.Checked = true;
            this.Descricao_RB.Location = new System.Drawing.Point(267, 17);
            this.Descricao_RB.Name = "Descricao_RB";
            this.Descricao_RB.Size = new System.Drawing.Size(73, 17);
            this.Descricao_RB.TabIndex = 28;
            this.Descricao_RB.TabStop = true;
            this.Descricao_RB.Text = "Descrição";
            this.Descricao_RB.UseVisualStyleBackColor = true;
            this.Descricao_RB.CheckedChanged += new System.EventHandler(this.Descricao_RB_CheckedChanged);
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
            // Grid_Turmas
            // 
            this.Grid_Turmas.AllowUserToAddRows = false;
            this.Grid_Turmas.AllowUserToDeleteRows = false;
            this.Grid_Turmas.AllowUserToResizeColumns = false;
            this.Grid_Turmas.AllowUserToResizeRows = false;
            this.Grid_Turmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Turmas.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Turmas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Turmas.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Turmas.Location = new System.Drawing.Point(23, 82);
            this.Grid_Turmas.Name = "Grid_Turmas";
            this.Grid_Turmas.ReadOnly = true;
            this.Grid_Turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Turmas.Size = new System.Drawing.Size(870, 469);
            this.Grid_Turmas.TabIndex = 31;
            // 
            // Refresh_Button
            // 
            this.Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.Location = new System.Drawing.Point(406, 43);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(36, 34);
            this.Refresh_Button.TabIndex = 38;
            this.Refresh_Button.Text = "🔃";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // ListarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 625);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.Grid_Turmas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Editar_Button);
            this.Controls.Add(this.Excluir_Button);
            this.Controls.Add(this.Novo_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListarTurma";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Turmas";
            this.Load += new System.EventHandler(this.ListaTurma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Turmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Novo_Button;
        private MetroFramework.Controls.MetroButton Excluir_Button;
        private MetroFramework.Controls.MetroButton Editar_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Pesquisa_TB;
        private System.Windows.Forms.Button Pesquisa_Button;
        private System.Windows.Forms.DataGridView Grid_Turmas;
        private System.Windows.Forms.RadioButton Responsavel_RB;
        private System.Windows.Forms.RadioButton Descricao_RB;
        private System.Windows.Forms.Button Refresh_Button;
    }
}