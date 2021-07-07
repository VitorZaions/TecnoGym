namespace Tecno_Gym.Pedido
{
    partial class CadastrarFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFornecedor));
            this.Novo_Button = new MetroFramework.Controls.MetroButton();
            this.Nome_TB = new System.Windows.Forms.TextBox();
            this.Nome_LBL = new System.Windows.Forms.Label();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.Geral_GP = new System.Windows.Forms.GroupBox();
            this.CNPJ_TB = new System.Windows.Forms.TextBox();
            this.CNPJ_LBL = new System.Windows.Forms.Label();
            this.GP_Endereco = new System.Windows.Forms.GroupBox();
            this.Bairro_TB = new System.Windows.Forms.TextBox();
            this.Rua_LBL = new System.Windows.Forms.Label();
            this.Rua_TB = new System.Windows.Forms.TextBox();
            this.Bairro_LBL = new System.Windows.Forms.Label();
            this.Cidade_TB = new System.Windows.Forms.TextBox();
            this.UF_CB = new System.Windows.Forms.ComboBox();
            this.CEP_TB = new System.Windows.Forms.TextBox();
            this.UF_LBL = new System.Windows.Forms.Label();
            this.CEP_LBL = new System.Windows.Forms.Label();
            this.Cidade_LBL = new System.Windows.Forms.Label();
            this.Contato_GP = new System.Windows.Forms.GroupBox();
            this.Telefone_TB = new System.Windows.Forms.TextBox();
            this.Telefone_LBL = new System.Windows.Forms.Label();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.Email_LBL = new System.Windows.Forms.Label();
            this.Geral_GP.SuspendLayout();
            this.GP_Endereco.SuspendLayout();
            this.Contato_GP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Novo_Button
            // 
            this.Novo_Button.Location = new System.Drawing.Point(714, 540);
            this.Novo_Button.Name = "Novo_Button";
            this.Novo_Button.Size = new System.Drawing.Size(136, 45);
            this.Novo_Button.TabIndex = 51;
            this.Novo_Button.Text = "Salvar";
            this.Novo_Button.UseSelectable = true;
            this.Novo_Button.Click += new System.EventHandler(this.Novo_Button_Click);
            // 
            // Nome_TB
            // 
            this.Nome_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_TB.Location = new System.Drawing.Point(471, 55);
            this.Nome_TB.MaxLength = 100;
            this.Nome_TB.Name = "Nome_TB";
            this.Nome_TB.Size = new System.Drawing.Size(331, 24);
            this.Nome_TB.TabIndex = 49;
            // 
            // Nome_LBL
            // 
            this.Nome_LBL.AutoSize = true;
            this.Nome_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_LBL.Location = new System.Drawing.Point(468, 34);
            this.Nome_LBL.Name = "Nome_LBL";
            this.Nome_LBL.Size = new System.Drawing.Size(59, 18);
            this.Nome_LBL.TabIndex = 48;
            this.Nome_LBL.Text = "* Nome";
            this.Nome_LBL.Click += new System.EventHandler(this.Cliente_LBL_Click);
            // 
            // Id_LBL
            // 
            this.Id_LBL.AutoSize = true;
            this.Id_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_LBL.Location = new System.Drawing.Point(15, 31);
            this.Id_LBL.Name = "Id_LBL";
            this.Id_LBL.Size = new System.Drawing.Size(56, 18);
            this.Id_LBL.TabIndex = 47;
            this.Id_LBL.Text = "Código";
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(18, 55);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(161, 24);
            this.Id_TB.TabIndex = 46;
            // 
            // Geral_GP
            // 
            this.Geral_GP.BackColor = System.Drawing.Color.White;
            this.Geral_GP.Controls.Add(this.CNPJ_TB);
            this.Geral_GP.Controls.Add(this.Id_TB);
            this.Geral_GP.Controls.Add(this.CNPJ_LBL);
            this.Geral_GP.Controls.Add(this.Id_LBL);
            this.Geral_GP.Controls.Add(this.Nome_LBL);
            this.Geral_GP.Controls.Add(this.Nome_TB);
            this.Geral_GP.Location = new System.Drawing.Point(26, 72);
            this.Geral_GP.Name = "Geral_GP";
            this.Geral_GP.Size = new System.Drawing.Size(824, 108);
            this.Geral_GP.TabIndex = 55;
            this.Geral_GP.TabStop = false;
            this.Geral_GP.Text = "Geral";
            // 
            // CNPJ_TB
            // 
            this.CNPJ_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPJ_TB.Location = new System.Drawing.Point(218, 55);
            this.CNPJ_TB.MaxLength = 14;
            this.CNPJ_TB.Name = "CNPJ_TB";
            this.CNPJ_TB.Size = new System.Drawing.Size(221, 24);
            this.CNPJ_TB.TabIndex = 57;
            this.CNPJ_TB.TextChanged += new System.EventHandler(this.CNPJ_TB_TextChanged);
            // 
            // CNPJ_LBL
            // 
            this.CNPJ_LBL.AutoSize = true;
            this.CNPJ_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNPJ_LBL.Location = new System.Drawing.Point(215, 34);
            this.CNPJ_LBL.Name = "CNPJ_LBL";
            this.CNPJ_LBL.Size = new System.Drawing.Size(58, 18);
            this.CNPJ_LBL.TabIndex = 58;
            this.CNPJ_LBL.Text = "* CNPJ";
            // 
            // GP_Endereco
            // 
            this.GP_Endereco.BackColor = System.Drawing.Color.White;
            this.GP_Endereco.Controls.Add(this.Bairro_TB);
            this.GP_Endereco.Controls.Add(this.Rua_LBL);
            this.GP_Endereco.Controls.Add(this.Rua_TB);
            this.GP_Endereco.Controls.Add(this.Bairro_LBL);
            this.GP_Endereco.Controls.Add(this.Cidade_TB);
            this.GP_Endereco.Controls.Add(this.UF_CB);
            this.GP_Endereco.Controls.Add(this.CEP_TB);
            this.GP_Endereco.Controls.Add(this.UF_LBL);
            this.GP_Endereco.Controls.Add(this.CEP_LBL);
            this.GP_Endereco.Controls.Add(this.Cidade_LBL);
            this.GP_Endereco.Location = new System.Drawing.Point(26, 202);
            this.GP_Endereco.Name = "GP_Endereco";
            this.GP_Endereco.Size = new System.Drawing.Size(824, 162);
            this.GP_Endereco.TabIndex = 59;
            this.GP_Endereco.TabStop = false;
            this.GP_Endereco.Text = "Endereço";
            // 
            // Bairro_TB
            // 
            this.Bairro_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro_TB.Location = new System.Drawing.Point(654, 51);
            this.Bairro_TB.MaxLength = 100;
            this.Bairro_TB.Name = "Bairro_TB";
            this.Bairro_TB.Size = new System.Drawing.Size(148, 24);
            this.Bairro_TB.TabIndex = 67;
            // 
            // Rua_LBL
            // 
            this.Rua_LBL.AutoSize = true;
            this.Rua_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rua_LBL.Location = new System.Drawing.Point(21, 90);
            this.Rua_LBL.Name = "Rua_LBL";
            this.Rua_LBL.Size = new System.Drawing.Size(45, 18);
            this.Rua_LBL.TabIndex = 66;
            this.Rua_LBL.Text = "* Rua";
            // 
            // Rua_TB
            // 
            this.Rua_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rua_TB.Location = new System.Drawing.Point(24, 111);
            this.Rua_TB.MaxLength = 100;
            this.Rua_TB.Name = "Rua_TB";
            this.Rua_TB.Size = new System.Drawing.Size(161, 24);
            this.Rua_TB.TabIndex = 65;
            // 
            // Bairro_LBL
            // 
            this.Bairro_LBL.AutoSize = true;
            this.Bairro_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro_LBL.Location = new System.Drawing.Point(651, 27);
            this.Bairro_LBL.Name = "Bairro_LBL";
            this.Bairro_LBL.Size = new System.Drawing.Size(58, 18);
            this.Bairro_LBL.TabIndex = 64;
            this.Bairro_LBL.Text = "* Bairro";
            // 
            // Cidade_TB
            // 
            this.Cidade_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade_TB.Location = new System.Drawing.Point(471, 51);
            this.Cidade_TB.MaxLength = 100;
            this.Cidade_TB.Name = "Cidade_TB";
            this.Cidade_TB.Size = new System.Drawing.Size(148, 24);
            this.Cidade_TB.TabIndex = 62;
            // 
            // UF_CB
            // 
            this.UF_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UF_CB.FormattingEnabled = true;
            this.UF_CB.Location = new System.Drawing.Point(24, 53);
            this.UF_CB.Name = "UF_CB";
            this.UF_CB.Size = new System.Drawing.Size(161, 24);
            this.UF_CB.TabIndex = 53;
            // 
            // CEP_TB
            // 
            this.CEP_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEP_TB.Location = new System.Drawing.Point(218, 51);
            this.CEP_TB.MaxLength = 8;
            this.CEP_TB.Name = "CEP_TB";
            this.CEP_TB.Size = new System.Drawing.Size(221, 24);
            this.CEP_TB.TabIndex = 60;
            this.CEP_TB.TextChanged += new System.EventHandler(this.CEP_TB_TextChanged);
            // 
            // UF_LBL
            // 
            this.UF_LBL.AutoSize = true;
            this.UF_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UF_LBL.Location = new System.Drawing.Point(21, 27);
            this.UF_LBL.Name = "UF_LBL";
            this.UF_LBL.Size = new System.Drawing.Size(38, 18);
            this.UF_LBL.TabIndex = 58;
            this.UF_LBL.Text = "* UF";
            // 
            // CEP_LBL
            // 
            this.CEP_LBL.AutoSize = true;
            this.CEP_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEP_LBL.Location = new System.Drawing.Point(215, 27);
            this.CEP_LBL.Name = "CEP_LBL";
            this.CEP_LBL.Size = new System.Drawing.Size(49, 18);
            this.CEP_LBL.TabIndex = 59;
            this.CEP_LBL.Text = "* CEP";
            // 
            // Cidade_LBL
            // 
            this.Cidade_LBL.AutoSize = true;
            this.Cidade_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade_LBL.Location = new System.Drawing.Point(468, 27);
            this.Cidade_LBL.Name = "Cidade_LBL";
            this.Cidade_LBL.Size = new System.Drawing.Size(64, 18);
            this.Cidade_LBL.TabIndex = 61;
            this.Cidade_LBL.Text = "* Cidade";
            // 
            // Contato_GP
            // 
            this.Contato_GP.BackColor = System.Drawing.Color.White;
            this.Contato_GP.Controls.Add(this.Telefone_TB);
            this.Contato_GP.Controls.Add(this.Telefone_LBL);
            this.Contato_GP.Controls.Add(this.Email_TB);
            this.Contato_GP.Controls.Add(this.Email_LBL);
            this.Contato_GP.Location = new System.Drawing.Point(26, 387);
            this.Contato_GP.Name = "Contato_GP";
            this.Contato_GP.Size = new System.Drawing.Size(824, 108);
            this.Contato_GP.TabIndex = 60;
            this.Contato_GP.TabStop = false;
            this.Contato_GP.Text = "Contato";
            // 
            // Telefone_TB
            // 
            this.Telefone_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone_TB.Location = new System.Drawing.Point(471, 46);
            this.Telefone_TB.MaxLength = 11;
            this.Telefone_TB.Name = "Telefone_TB";
            this.Telefone_TB.Size = new System.Drawing.Size(331, 24);
            this.Telefone_TB.TabIndex = 67;
            this.Telefone_TB.TextChanged += new System.EventHandler(this.Telefone_TB_TextChanged);
            // 
            // Telefone_LBL
            // 
            this.Telefone_LBL.AutoSize = true;
            this.Telefone_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone_LBL.Location = new System.Drawing.Point(468, 25);
            this.Telefone_LBL.Name = "Telefone_LBL";
            this.Telefone_LBL.Size = new System.Drawing.Size(75, 18);
            this.Telefone_LBL.TabIndex = 56;
            this.Telefone_LBL.Text = "* Telefone";
            // 
            // Email_TB
            // 
            this.Email_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_TB.Location = new System.Drawing.Point(24, 46);
            this.Email_TB.MaxLength = 100;
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(415, 24);
            this.Email_TB.TabIndex = 38;
            // 
            // Email_LBL
            // 
            this.Email_LBL.AutoSize = true;
            this.Email_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_LBL.Location = new System.Drawing.Point(21, 22);
            this.Email_LBL.Name = "Email_LBL";
            this.Email_LBL.Size = new System.Drawing.Size(60, 18);
            this.Email_LBL.TabIndex = 39;
            this.Email_LBL.Text = "* E-mail";
            // 
            // CadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 606);
            this.Controls.Add(this.Contato_GP);
            this.Controls.Add(this.GP_Endereco);
            this.Controls.Add(this.Geral_GP);
            this.Controls.Add(this.Novo_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarFornecedor";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Cadastrar fornecedor";
            this.Load += new System.EventHandler(this.CadastrarFornecedor_Load);
            this.Geral_GP.ResumeLayout(false);
            this.Geral_GP.PerformLayout();
            this.GP_Endereco.ResumeLayout(false);
            this.GP_Endereco.PerformLayout();
            this.Contato_GP.ResumeLayout(false);
            this.Contato_GP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Novo_Button;
        private System.Windows.Forms.TextBox Nome_TB;
        private System.Windows.Forms.Label Nome_LBL;
        private System.Windows.Forms.Label Id_LBL;
        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.GroupBox Geral_GP;
        private System.Windows.Forms.TextBox CNPJ_TB;
        private System.Windows.Forms.Label CNPJ_LBL;
        private System.Windows.Forms.GroupBox GP_Endereco;
        private System.Windows.Forms.Label Rua_LBL;
        private System.Windows.Forms.TextBox Rua_TB;
        private System.Windows.Forms.Label Bairro_LBL;
        private System.Windows.Forms.TextBox Cidade_TB;
        private System.Windows.Forms.ComboBox UF_CB;
        private System.Windows.Forms.TextBox CEP_TB;
        private System.Windows.Forms.Label UF_LBL;
        private System.Windows.Forms.Label CEP_LBL;
        private System.Windows.Forms.Label Cidade_LBL;
        private System.Windows.Forms.GroupBox Contato_GP;
        private System.Windows.Forms.TextBox Telefone_TB;
        private System.Windows.Forms.Label Telefone_LBL;
        private System.Windows.Forms.TextBox Email_TB;
        private System.Windows.Forms.Label Email_LBL;
        private System.Windows.Forms.TextBox Bairro_TB;
    }
}