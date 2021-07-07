namespace Tecno_Gym.Turma
{
    partial class CadastroTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTurma));
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.Codigo_LBL = new System.Windows.Forms.Label();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.Nome_LBL = new System.Windows.Forms.Label();
            this.Descricao_TB = new System.Windows.Forms.TextBox();
            this.Responsavel_LBL = new System.Windows.Forms.Label();
            this.Responsavel_TB = new System.Windows.Forms.TextBox();
            this.Pesquisa_Button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(36, 112);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(104, 24);
            this.Id_TB.TabIndex = 5;
            // 
            // Codigo_LBL
            // 
            this.Codigo_LBL.AutoSize = true;
            this.Codigo_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_LBL.Location = new System.Drawing.Point(33, 88);
            this.Codigo_LBL.Name = "Codigo_LBL";
            this.Codigo_LBL.Size = new System.Drawing.Size(56, 18);
            this.Codigo_LBL.TabIndex = 6;
            this.Codigo_LBL.Text = "Código";
            // 
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(353, 253);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 45);
            this.Salvar_Button.TabIndex = 7;
            this.Salvar_Button.Text = "Salvar";
            this.Salvar_Button.UseSelectable = true;
            this.Salvar_Button.Click += new System.EventHandler(this.Salvar_Button_Click);
            // 
            // Nome_LBL
            // 
            this.Nome_LBL.AutoSize = true;
            this.Nome_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_LBL.Location = new System.Drawing.Point(167, 88);
            this.Nome_LBL.Name = "Nome_LBL";
            this.Nome_LBL.Size = new System.Drawing.Size(86, 18);
            this.Nome_LBL.TabIndex = 9;
            this.Nome_LBL.Text = "* Descricao";
            // 
            // Descricao_TB
            // 
            this.Descricao_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao_TB.Location = new System.Drawing.Point(170, 112);
            this.Descricao_TB.MaxLength = 100;
            this.Descricao_TB.Name = "Descricao_TB";
            this.Descricao_TB.Size = new System.Drawing.Size(319, 24);
            this.Descricao_TB.TabIndex = 8;
            // 
            // Responsavel_LBL
            // 
            this.Responsavel_LBL.AutoSize = true;
            this.Responsavel_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responsavel_LBL.Location = new System.Drawing.Point(33, 165);
            this.Responsavel_LBL.Name = "Responsavel_LBL";
            this.Responsavel_LBL.Size = new System.Drawing.Size(177, 18);
            this.Responsavel_LBL.TabIndex = 11;
            this.Responsavel_LBL.Text = "* Responsável pela turma";
            // 
            // Responsavel_TB
            // 
            this.Responsavel_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responsavel_TB.Location = new System.Drawing.Point(36, 186);
            this.Responsavel_TB.Name = "Responsavel_TB";
            this.Responsavel_TB.ReadOnly = true;
            this.Responsavel_TB.Size = new System.Drawing.Size(419, 24);
            this.Responsavel_TB.TabIndex = 10;
            // 
            // Pesquisa_Button
            // 
            this.Pesquisa_Button.Location = new System.Drawing.Point(461, 186);
            this.Pesquisa_Button.Name = "Pesquisa_Button";
            this.Pesquisa_Button.Size = new System.Drawing.Size(28, 23);
            this.Pesquisa_Button.TabIndex = 12;
            this.Pesquisa_Button.Text = "🧑";
            this.Pesquisa_Button.UseSelectable = true;
            this.Pesquisa_Button.Click += new System.EventHandler(this.Pesquisa_Button_Click);
            // 
            // CadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 322);
            this.Controls.Add(this.Pesquisa_Button);
            this.Controls.Add(this.Responsavel_LBL);
            this.Controls.Add(this.Responsavel_TB);
            this.Controls.Add(this.Nome_LBL);
            this.Controls.Add(this.Descricao_TB);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.Codigo_LBL);
            this.Controls.Add(this.Id_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroTurma";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Cadastrar turma";
            this.Load += new System.EventHandler(this.CadastroTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.Label Codigo_LBL;
        private MetroFramework.Controls.MetroButton Salvar_Button;
        private System.Windows.Forms.Label Nome_LBL;
        private System.Windows.Forms.TextBox Descricao_TB;
        private System.Windows.Forms.Label Responsavel_LBL;
        private System.Windows.Forms.TextBox Responsavel_TB;
        private MetroFramework.Controls.MetroButton Pesquisa_Button;
    }
}