namespace Tecno_Gym
{
    partial class SelecionarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionarTurma));
            this.Selecionar_Button = new MetroFramework.Controls.MetroButton();
            this.Grid_Turmas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Responsavel_RB = new System.Windows.Forms.RadioButton();
            this.Descricao_RB = new System.Windows.Forms.RadioButton();
            this.Pesquisa_TB = new System.Windows.Forms.TextBox();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.Refresh_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Turmas)).BeginInit();
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
            this.Grid_Turmas.Location = new System.Drawing.Point(23, 90);
            this.Grid_Turmas.Name = "Grid_Turmas";
            this.Grid_Turmas.ReadOnly = true;
            this.Grid_Turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Turmas.Size = new System.Drawing.Size(708, 308);
            this.Grid_Turmas.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Responsavel_RB);
            this.groupBox1.Controls.Add(this.Descricao_RB);
            this.groupBox1.Controls.Add(this.Pesquisa_TB);
            this.groupBox1.Controls.Add(this.Pesquisa_Button);
            this.groupBox1.Location = new System.Drawing.Point(286, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 43);
            this.groupBox1.TabIndex = 35;
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
            // Refresh_Button
            // 
            this.Refresh_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_Button.Location = new System.Drawing.Point(244, 51);
            this.Refresh_Button.Name = "Refresh_Button";
            this.Refresh_Button.Size = new System.Drawing.Size(36, 34);
            this.Refresh_Button.TabIndex = 37;
            this.Refresh_Button.Text = "🔃";
            this.Refresh_Button.UseVisualStyleBackColor = true;
            this.Refresh_Button.Click += new System.EventHandler(this.Refresh_Button_Click);
            // 
            // SelecionarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 473);
            this.Controls.Add(this.Refresh_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Grid_Turmas);
            this.Controls.Add(this.Selecionar_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelecionarTurma";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Selecionar turma";
            this.Load += new System.EventHandler(this.SelecionarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Turmas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton Selecionar_Button;
        private System.Windows.Forms.DataGridView Grid_Turmas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Responsavel_RB;
        private System.Windows.Forms.RadioButton Descricao_RB;
        private System.Windows.Forms.TextBox Pesquisa_TB;
        private System.Windows.Forms.Button Pesquisa_Button;
        private System.Windows.Forms.Button Refresh_Button;
    }
}