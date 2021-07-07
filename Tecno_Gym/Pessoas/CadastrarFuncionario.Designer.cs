namespace Tecno_Gym.Pessoas
{
    partial class CadastrarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarFuncionario));
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.TAB_GERAL = new MetroFramework.Controls.MetroTabPage();
            this.GP_Contato = new System.Windows.Forms.GroupBox();
            this.Telefone_TB = new System.Windows.Forms.TextBox();
            this.Telefone_LBL = new System.Windows.Forms.Label();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.Email_LBL = new System.Windows.Forms.Label();
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
            this.GP_Gerla = new System.Windows.Forms.GroupBox();
            this.Sexo_LBL = new System.Windows.Forms.Label();
            this.Sexo_CB = new System.Windows.Forms.ComboBox();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.Nome_LBL = new System.Windows.Forms.Label();
            this.CPF_TB = new System.Windows.Forms.TextBox();
            this.CPF_LBL = new System.Windows.Forms.Label();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Nome_TB = new System.Windows.Forms.TextBox();
            this.TAB_LOGIN = new MetroFramework.Controls.MetroTabPage();
            this.Login_GP = new System.Windows.Forms.GroupBox();
            this.IsAdmin_CB = new System.Windows.Forms.CheckBox();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Senha_TB = new System.Windows.Forms.TextBox();
            this.Senha_LBL = new System.Windows.Forms.Label();
            this.LBL_Login = new System.Windows.Forms.Label();
            this.Novo_Button = new MetroFramework.Controls.MetroButton();
            this.metroTabControl2.SuspendLayout();
            this.TAB_GERAL.SuspendLayout();
            this.GP_Contato.SuspendLayout();
            this.GP_Endereco.SuspendLayout();
            this.GP_Gerla.SuspendLayout();
            this.TAB_LOGIN.SuspendLayout();
            this.Login_GP.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.TAB_GERAL);
            this.metroTabControl2.Controls.Add(this.TAB_LOGIN);
            this.metroTabControl2.Location = new System.Drawing.Point(23, 73);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(837, 513);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl2.TabIndex = 102;
            this.metroTabControl2.UseSelectable = true;
            // 
            // TAB_GERAL
            // 
            this.TAB_GERAL.Controls.Add(this.GP_Contato);
            this.TAB_GERAL.Controls.Add(this.GP_Endereco);
            this.TAB_GERAL.Controls.Add(this.GP_Gerla);
            this.TAB_GERAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB_GERAL.HorizontalScrollbarBarColor = true;
            this.TAB_GERAL.HorizontalScrollbarHighlightOnWheel = false;
            this.TAB_GERAL.HorizontalScrollbarSize = 10;
            this.TAB_GERAL.Location = new System.Drawing.Point(4, 38);
            this.TAB_GERAL.Name = "TAB_GERAL";
            this.TAB_GERAL.Size = new System.Drawing.Size(829, 471);
            this.TAB_GERAL.TabIndex = 0;
            this.TAB_GERAL.Text = "Geral";
            this.TAB_GERAL.VerticalScrollbarBarColor = true;
            this.TAB_GERAL.VerticalScrollbarHighlightOnWheel = false;
            this.TAB_GERAL.VerticalScrollbarSize = 10;
            // 
            // GP_Contato
            // 
            this.GP_Contato.BackColor = System.Drawing.Color.White;
            this.GP_Contato.Controls.Add(this.Telefone_TB);
            this.GP_Contato.Controls.Add(this.Telefone_LBL);
            this.GP_Contato.Controls.Add(this.Email_TB);
            this.GP_Contato.Controls.Add(this.Email_LBL);
            this.GP_Contato.Location = new System.Drawing.Point(3, 323);
            this.GP_Contato.Name = "GP_Contato";
            this.GP_Contato.Size = new System.Drawing.Size(824, 108);
            this.GP_Contato.TabIndex = 60;
            this.GP_Contato.TabStop = false;
            this.GP_Contato.Text = "Contato";
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
            this.GP_Endereco.Location = new System.Drawing.Point(3, 140);
            this.GP_Endereco.Name = "GP_Endereco";
            this.GP_Endereco.Size = new System.Drawing.Size(824, 162);
            this.GP_Endereco.TabIndex = 59;
            this.GP_Endereco.TabStop = false;
            this.GP_Endereco.Text = "Endereço";
            this.GP_Endereco.Enter += new System.EventHandler(this.GP_Endereco_Enter);
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
            this.UF_CB.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
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
            // GP_Gerla
            // 
            this.GP_Gerla.BackColor = System.Drawing.Color.White;
            this.GP_Gerla.Controls.Add(this.Sexo_LBL);
            this.GP_Gerla.Controls.Add(this.Sexo_CB);
            this.GP_Gerla.Controls.Add(this.Id_TB);
            this.GP_Gerla.Controls.Add(this.Nome_LBL);
            this.GP_Gerla.Controls.Add(this.CPF_TB);
            this.GP_Gerla.Controls.Add(this.CPF_LBL);
            this.GP_Gerla.Controls.Add(this.Id_LBL);
            this.GP_Gerla.Controls.Add(this.Nome_TB);
            this.GP_Gerla.Location = new System.Drawing.Point(3, 13);
            this.GP_Gerla.Name = "GP_Gerla";
            this.GP_Gerla.Size = new System.Drawing.Size(824, 108);
            this.GP_Gerla.TabIndex = 58;
            this.GP_Gerla.TabStop = false;
            this.GP_Gerla.Text = "Pessoa";
            // 
            // Sexo_LBL
            // 
            this.Sexo_LBL.AutoSize = true;
            this.Sexo_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo_LBL.Location = new System.Drawing.Point(651, 25);
            this.Sexo_LBL.Name = "Sexo_LBL";
            this.Sexo_LBL.Size = new System.Drawing.Size(52, 18);
            this.Sexo_LBL.TabIndex = 56;
            this.Sexo_LBL.Text = "* Sexo";
            // 
            // Sexo_CB
            // 
            this.Sexo_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexo_CB.FormattingEnabled = true;
            this.Sexo_CB.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.Sexo_CB.Location = new System.Drawing.Point(654, 46);
            this.Sexo_CB.Name = "Sexo_CB";
            this.Sexo_CB.Size = new System.Drawing.Size(148, 24);
            this.Sexo_CB.TabIndex = 55;
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(24, 46);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(161, 24);
            this.Id_TB.TabIndex = 38;
            // 
            // Nome_LBL
            // 
            this.Nome_LBL.AutoSize = true;
            this.Nome_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_LBL.Location = new System.Drawing.Point(215, 22);
            this.Nome_LBL.Name = "Nome_LBL";
            this.Nome_LBL.Size = new System.Drawing.Size(59, 18);
            this.Nome_LBL.TabIndex = 41;
            this.Nome_LBL.Text = "* Nome";
            // 
            // CPF_TB
            // 
            this.CPF_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF_TB.Location = new System.Drawing.Point(471, 46);
            this.CPF_TB.MaxLength = 11;
            this.CPF_TB.Name = "CPF_TB";
            this.CPF_TB.Size = new System.Drawing.Size(148, 24);
            this.CPF_TB.TabIndex = 52;
            this.CPF_TB.TextChanged += new System.EventHandler(this.CPF_TB_TextChanged);
            // 
            // CPF_LBL
            // 
            this.CPF_LBL.AutoSize = true;
            this.CPF_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF_LBL.Location = new System.Drawing.Point(468, 25);
            this.CPF_LBL.Name = "CPF_LBL";
            this.CPF_LBL.Size = new System.Drawing.Size(48, 18);
            this.CPF_LBL.TabIndex = 51;
            this.CPF_LBL.Text = "* CPF";
            // 
            // Id_LBL
            // 
            this.Id_LBL.AutoSize = true;
            this.Id_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_LBL.Location = new System.Drawing.Point(21, 22);
            this.Id_LBL.Name = "Id_LBL";
            this.Id_LBL.Size = new System.Drawing.Size(56, 18);
            this.Id_LBL.TabIndex = 39;
            this.Id_LBL.Text = "Código";
            // 
            // Nome_TB
            // 
            this.Nome_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_TB.Location = new System.Drawing.Point(218, 46);
            this.Nome_TB.MaxLength = 100;
            this.Nome_TB.Name = "Nome_TB";
            this.Nome_TB.Size = new System.Drawing.Size(221, 24);
            this.Nome_TB.TabIndex = 42;
            // 
            // TAB_LOGIN
            // 
            this.TAB_LOGIN.Controls.Add(this.Login_GP);
            this.TAB_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.TAB_LOGIN.HorizontalScrollbarBarColor = true;
            this.TAB_LOGIN.HorizontalScrollbarHighlightOnWheel = false;
            this.TAB_LOGIN.HorizontalScrollbarSize = 10;
            this.TAB_LOGIN.Location = new System.Drawing.Point(4, 38);
            this.TAB_LOGIN.Name = "TAB_LOGIN";
            this.TAB_LOGIN.Size = new System.Drawing.Size(829, 471);
            this.TAB_LOGIN.TabIndex = 2;
            this.TAB_LOGIN.Text = " Login";
            this.TAB_LOGIN.VerticalScrollbarBarColor = true;
            this.TAB_LOGIN.VerticalScrollbarHighlightOnWheel = false;
            this.TAB_LOGIN.VerticalScrollbarSize = 10;
            // 
            // Login_GP
            // 
            this.Login_GP.BackColor = System.Drawing.Color.White;
            this.Login_GP.Controls.Add(this.IsAdmin_CB);
            this.Login_GP.Controls.Add(this.Login_TB);
            this.Login_GP.Controls.Add(this.Senha_TB);
            this.Login_GP.Controls.Add(this.Senha_LBL);
            this.Login_GP.Controls.Add(this.LBL_Login);
            this.Login_GP.Location = new System.Drawing.Point(3, 13);
            this.Login_GP.Name = "Login_GP";
            this.Login_GP.Size = new System.Drawing.Size(824, 108);
            this.Login_GP.TabIndex = 55;
            this.Login_GP.TabStop = false;
            this.Login_GP.Text = "Informações de login";
            // 
            // IsAdmin_CB
            // 
            this.IsAdmin_CB.AutoSize = true;
            this.IsAdmin_CB.Location = new System.Drawing.Point(701, 53);
            this.IsAdmin_CB.Name = "IsAdmin_CB";
            this.IsAdmin_CB.Size = new System.Drawing.Size(65, 20);
            this.IsAdmin_CB.TabIndex = 53;
            this.IsAdmin_CB.Text = "Admin";
            this.IsAdmin_CB.UseVisualStyleBackColor = true;
            // 
            // Login_TB
            // 
            this.Login_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_TB.Location = new System.Drawing.Point(24, 51);
            this.Login_TB.MaxLength = 100;
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(315, 24);
            this.Login_TB.TabIndex = 38;
            // 
            // Senha_TB
            // 
            this.Senha_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha_TB.Location = new System.Drawing.Point(384, 51);
            this.Senha_TB.MaxLength = 100;
            this.Senha_TB.Name = "Senha_TB";
            this.Senha_TB.Size = new System.Drawing.Size(251, 24);
            this.Senha_TB.TabIndex = 52;
            // 
            // Senha_LBL
            // 
            this.Senha_LBL.AutoSize = true;
            this.Senha_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha_LBL.Location = new System.Drawing.Point(381, 30);
            this.Senha_LBL.Name = "Senha_LBL";
            this.Senha_LBL.Size = new System.Drawing.Size(60, 18);
            this.Senha_LBL.TabIndex = 51;
            this.Senha_LBL.Text = "* Senha";
            // 
            // LBL_Login
            // 
            this.LBL_Login.AutoSize = true;
            this.LBL_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Login.Location = new System.Drawing.Point(21, 27);
            this.LBL_Login.Name = "LBL_Login";
            this.LBL_Login.Size = new System.Drawing.Size(54, 18);
            this.LBL_Login.TabIndex = 39;
            this.LBL_Login.Text = "* Login";
            // 
            // Novo_Button
            // 
            this.Novo_Button.Location = new System.Drawing.Point(717, 597);
            this.Novo_Button.Name = "Novo_Button";
            this.Novo_Button.Size = new System.Drawing.Size(136, 43);
            this.Novo_Button.TabIndex = 103;
            this.Novo_Button.Text = "Salvar";
            this.Novo_Button.UseSelectable = true;
            this.Novo_Button.Click += new System.EventHandler(this.Novo_Button_Click);
            // 
            // CadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 654);
            this.Controls.Add(this.Novo_Button);
            this.Controls.Add(this.metroTabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarFuncionario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Cadastro de funcionário";
            this.Load += new System.EventHandler(this.CadastrarFuncionario_Load);
            this.metroTabControl2.ResumeLayout(false);
            this.TAB_GERAL.ResumeLayout(false);
            this.GP_Contato.ResumeLayout(false);
            this.GP_Contato.PerformLayout();
            this.GP_Endereco.ResumeLayout(false);
            this.GP_Endereco.PerformLayout();
            this.GP_Gerla.ResumeLayout(false);
            this.GP_Gerla.PerformLayout();
            this.TAB_LOGIN.ResumeLayout(false);
            this.Login_GP.ResumeLayout(false);
            this.Login_GP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage TAB_GERAL;
        private MetroFramework.Controls.MetroButton Novo_Button;
        private MetroFramework.Controls.MetroTabPage TAB_LOGIN;
        private System.Windows.Forms.GroupBox Login_GP;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.TextBox Senha_TB;
        private System.Windows.Forms.Label Senha_LBL;
        private System.Windows.Forms.Label LBL_Login;
        private System.Windows.Forms.CheckBox IsAdmin_CB;
        private System.Windows.Forms.GroupBox GP_Contato;
        private System.Windows.Forms.TextBox Telefone_TB;
        private System.Windows.Forms.Label Telefone_LBL;
        private System.Windows.Forms.TextBox Email_TB;
        private System.Windows.Forms.Label Email_LBL;
        private System.Windows.Forms.GroupBox GP_Endereco;
        private System.Windows.Forms.TextBox Bairro_TB;
        private System.Windows.Forms.Label Rua_LBL;
        private System.Windows.Forms.TextBox Rua_TB;
        private System.Windows.Forms.Label Bairro_LBL;
        private System.Windows.Forms.TextBox Cidade_TB;
        private System.Windows.Forms.ComboBox UF_CB;
        private System.Windows.Forms.TextBox CEP_TB;
        private System.Windows.Forms.Label UF_LBL;
        private System.Windows.Forms.Label CEP_LBL;
        private System.Windows.Forms.Label Cidade_LBL;
        private System.Windows.Forms.GroupBox GP_Gerla;
        private System.Windows.Forms.Label Sexo_LBL;
        private System.Windows.Forms.ComboBox Sexo_CB;
        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.Label Nome_LBL;
        private System.Windows.Forms.TextBox CPF_TB;
        private System.Windows.Forms.Label CPF_LBL;
        private System.Windows.Forms.Label Id_LBL;
        private System.Windows.Forms.TextBox Nome_TB;
    }
}