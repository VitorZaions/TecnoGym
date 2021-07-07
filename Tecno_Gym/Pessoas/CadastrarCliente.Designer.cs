namespace Tecno_Gym.Pessoas
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            this.Nome_TB = new System.Windows.Forms.TextBox();
            this.Nome_LBL = new System.Windows.Forms.Label();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.CPF_LBL = new System.Windows.Forms.Label();
            this.CPF_TB = new System.Windows.Forms.TextBox();
            this.UF_CB = new System.Windows.Forms.ComboBox();
            this.GP_Gerla = new System.Windows.Forms.GroupBox();
            this.Sexo_LBL = new System.Windows.Forms.Label();
            this.Sexo_CB = new System.Windows.Forms.ComboBox();
            this.GP_Endereco = new System.Windows.Forms.GroupBox();
            this.Bairro_TB = new System.Windows.Forms.TextBox();
            this.Rua_LBL = new System.Windows.Forms.Label();
            this.Rua_TB = new System.Windows.Forms.TextBox();
            this.Bairro_LBL = new System.Windows.Forms.Label();
            this.Cidade_TB = new System.Windows.Forms.TextBox();
            this.CEP_TB = new System.Windows.Forms.TextBox();
            this.UF_LBL = new System.Windows.Forms.Label();
            this.CEP_LBL = new System.Windows.Forms.Label();
            this.Cidade_LBL = new System.Windows.Forms.Label();
            this.GP_Contato = new System.Windows.Forms.GroupBox();
            this.Telefone_TB = new System.Windows.Forms.TextBox();
            this.Telefone_LBL = new System.Windows.Forms.Label();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.Email_LBL = new System.Windows.Forms.Label();
            this.TabControl_Cliente = new MetroFramework.Controls.MetroTabControl();
            this.Geral_TAB = new MetroFramework.Controls.MetroTabPage();
            this.Turmas_TAB = new MetroFramework.Controls.MetroTabPage();
            this.Turma_TB = new System.Windows.Forms.TextBox();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.TurmaRemover_Button = new MetroFramework.Controls.MetroButton();
            this.TurmaAdd_Button = new MetroFramework.Controls.MetroButton();
            this.GD_Turmas = new System.Windows.Forms.DataGridView();
            this.GP_Gerla.SuspendLayout();
            this.GP_Endereco.SuspendLayout();
            this.GP_Contato.SuspendLayout();
            this.TabControl_Cliente.SuspendLayout();
            this.Geral_TAB.SuspendLayout();
            this.Turmas_TAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GD_Turmas)).BeginInit();
            this.SuspendLayout();
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
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(718, 588);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 43);
            this.Salvar_Button.TabIndex = 40;
            this.Salvar_Button.UseSelectable = true;
            this.Salvar_Button.Click += new System.EventHandler(this.Salvar_Button_Click);
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
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(24, 46);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(161, 24);
            this.Id_TB.TabIndex = 38;
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
            // UF_CB
            // 
            this.UF_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UF_CB.FormattingEnabled = true;
            this.UF_CB.Location = new System.Drawing.Point(24, 53);
            this.UF_CB.Name = "UF_CB";
            this.UF_CB.Size = new System.Drawing.Size(161, 24);
            this.UF_CB.TabIndex = 53;
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
            this.GP_Gerla.TabIndex = 54;
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
            this.GP_Endereco.TabIndex = 55;
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
            this.GP_Contato.TabIndex = 57;
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
            // TabControl_Cliente
            // 
            this.TabControl_Cliente.Controls.Add(this.Geral_TAB);
            this.TabControl_Cliente.Controls.Add(this.Turmas_TAB);
            this.TabControl_Cliente.Location = new System.Drawing.Point(23, 73);
            this.TabControl_Cliente.Name = "TabControl_Cliente";
            this.TabControl_Cliente.SelectedIndex = 0;
            this.TabControl_Cliente.Size = new System.Drawing.Size(837, 513);
            this.TabControl_Cliente.Style = MetroFramework.MetroColorStyle.Black;
            this.TabControl_Cliente.TabIndex = 101;
            this.TabControl_Cliente.UseSelectable = true;
            // 
            // Geral_TAB
            // 
            this.Geral_TAB.Controls.Add(this.GP_Contato);
            this.Geral_TAB.Controls.Add(this.GP_Endereco);
            this.Geral_TAB.Controls.Add(this.GP_Gerla);
            this.Geral_TAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geral_TAB.HorizontalScrollbarBarColor = true;
            this.Geral_TAB.HorizontalScrollbarHighlightOnWheel = false;
            this.Geral_TAB.HorizontalScrollbarSize = 10;
            this.Geral_TAB.Location = new System.Drawing.Point(4, 38);
            this.Geral_TAB.Name = "Geral_TAB";
            this.Geral_TAB.Size = new System.Drawing.Size(829, 471);
            this.Geral_TAB.TabIndex = 0;
            this.Geral_TAB.Text = "Geral";
            this.Geral_TAB.VerticalScrollbarBarColor = true;
            this.Geral_TAB.VerticalScrollbarHighlightOnWheel = false;
            this.Geral_TAB.VerticalScrollbarSize = 10;
            this.Geral_TAB.Click += new System.EventHandler(this.metroTabPage5_Click);
            this.Geral_TAB.Enter += new System.EventHandler(this.Geral_TAB_Enter);
            // 
            // Turmas_TAB
            // 
            this.Turmas_TAB.Controls.Add(this.Turma_TB);
            this.Turmas_TAB.Controls.Add(this.Pesquisa_Button);
            this.Turmas_TAB.Controls.Add(this.TurmaRemover_Button);
            this.Turmas_TAB.Controls.Add(this.TurmaAdd_Button);
            this.Turmas_TAB.Controls.Add(this.GD_Turmas);
            this.Turmas_TAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turmas_TAB.HorizontalScrollbarBarColor = true;
            this.Turmas_TAB.HorizontalScrollbarHighlightOnWheel = false;
            this.Turmas_TAB.HorizontalScrollbarSize = 10;
            this.Turmas_TAB.Location = new System.Drawing.Point(4, 38);
            this.Turmas_TAB.Name = "Turmas_TAB";
            this.Turmas_TAB.Size = new System.Drawing.Size(829, 471);
            this.Turmas_TAB.TabIndex = 1;
            this.Turmas_TAB.Text = "Turmas";
            this.Turmas_TAB.VerticalScrollbarBarColor = true;
            this.Turmas_TAB.VerticalScrollbarHighlightOnWheel = false;
            this.Turmas_TAB.VerticalScrollbarSize = 10;
            this.Turmas_TAB.Click += new System.EventHandler(this.Turmas_TAB_Click);
            this.Turmas_TAB.Enter += new System.EventHandler(this.Turmas_TAB_Enter);
            // 
            // Turma_TB
            // 
            this.Turma_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turma_TB.Location = new System.Drawing.Point(383, 11);
            this.Turma_TB.Name = "Turma_TB";
            this.Turma_TB.ReadOnly = true;
            this.Turma_TB.Size = new System.Drawing.Size(170, 24);
            this.Turma_TB.TabIndex = 134;
            // 
            // Pesquisa_Button
            // 
            this.Pesquisa_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa_Button.Location = new System.Drawing.Point(559, 8);
            this.Pesquisa_Button.Name = "Pesquisa_Button";
            this.Pesquisa_Button.Size = new System.Drawing.Size(54, 28);
            this.Pesquisa_Button.TabIndex = 133;
            this.Pesquisa_Button.Text = "🔎";
            this.Pesquisa_Button.UseVisualStyleBackColor = true;
            this.Pesquisa_Button.Click += new System.EventHandler(this.Pesquisa_Button_Click);
            // 
            // TurmaRemover_Button
            // 
            this.TurmaRemover_Button.Location = new System.Drawing.Point(725, 8);
            this.TurmaRemover_Button.Name = "TurmaRemover_Button";
            this.TurmaRemover_Button.Size = new System.Drawing.Size(102, 28);
            this.TurmaRemover_Button.Style = MetroFramework.MetroColorStyle.White;
            this.TurmaRemover_Button.TabIndex = 100;
            this.TurmaRemover_Button.TabStop = false;
            this.TurmaRemover_Button.Text = "REMOVER";
            this.TurmaRemover_Button.UseSelectable = true;
            this.TurmaRemover_Button.Click += new System.EventHandler(this.TurmaRemover_Button_Click);
            // 
            // TurmaAdd_Button
            // 
            this.TurmaAdd_Button.Location = new System.Drawing.Point(619, 8);
            this.TurmaAdd_Button.Name = "TurmaAdd_Button";
            this.TurmaAdd_Button.Size = new System.Drawing.Size(100, 28);
            this.TurmaAdd_Button.Style = MetroFramework.MetroColorStyle.White;
            this.TurmaAdd_Button.TabIndex = 98;
            this.TurmaAdd_Button.TabStop = false;
            this.TurmaAdd_Button.Text = "ADICIONAR";
            this.TurmaAdd_Button.UseSelectable = true;
            this.TurmaAdd_Button.Click += new System.EventHandler(this.TurmaAdd_Button_Click);
            // 
            // GD_Turmas
            // 
            this.GD_Turmas.AllowUserToAddRows = false;
            this.GD_Turmas.AllowUserToDeleteRows = false;
            this.GD_Turmas.AllowUserToResizeColumns = false;
            this.GD_Turmas.AllowUserToResizeRows = false;
            this.GD_Turmas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GD_Turmas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GD_Turmas.BackgroundColor = System.Drawing.Color.White;
            this.GD_Turmas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GD_Turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GD_Turmas.ColumnHeadersHeight = 25;
            this.GD_Turmas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GD_Turmas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GD_Turmas.Location = new System.Drawing.Point(3, 47);
            this.GD_Turmas.Margin = new System.Windows.Forms.Padding(2);
            this.GD_Turmas.MultiSelect = false;
            this.GD_Turmas.Name = "GD_Turmas";
            this.GD_Turmas.ReadOnly = true;
            this.GD_Turmas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.GD_Turmas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.GD_Turmas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GD_Turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GD_Turmas.ShowCellErrors = false;
            this.GD_Turmas.ShowEditingIcon = false;
            this.GD_Turmas.ShowRowErrors = false;
            this.GD_Turmas.Size = new System.Drawing.Size(824, 422);
            this.GD_Turmas.TabIndex = 122;
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 654);
            this.Controls.Add(this.TabControl_Cliente);
            this.Controls.Add(this.Salvar_Button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarCliente";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.CadastrarCliente_Load);
            this.GP_Gerla.ResumeLayout(false);
            this.GP_Gerla.PerformLayout();
            this.GP_Endereco.ResumeLayout(false);
            this.GP_Endereco.PerformLayout();
            this.GP_Contato.ResumeLayout(false);
            this.GP_Contato.PerformLayout();
            this.TabControl_Cliente.ResumeLayout(false);
            this.Geral_TAB.ResumeLayout(false);
            this.Turmas_TAB.ResumeLayout(false);
            this.Turmas_TAB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GD_Turmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Nome_TB;
        private System.Windows.Forms.Label Nome_LBL;
        private MetroFramework.Controls.MetroButton Salvar_Button;
        private System.Windows.Forms.Label Id_LBL;
        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.Label CPF_LBL;
        private System.Windows.Forms.TextBox CPF_TB;
        private System.Windows.Forms.ComboBox UF_CB;
        private System.Windows.Forms.GroupBox GP_Gerla;
        private System.Windows.Forms.Label Sexo_LBL;
        private System.Windows.Forms.ComboBox Sexo_CB;
        private System.Windows.Forms.GroupBox GP_Endereco;
        private System.Windows.Forms.Label Bairro_LBL;
        private System.Windows.Forms.TextBox Cidade_TB;
        private System.Windows.Forms.TextBox CEP_TB;
        private System.Windows.Forms.Label UF_LBL;
        private System.Windows.Forms.Label CEP_LBL;
        private System.Windows.Forms.Label Cidade_LBL;
        private System.Windows.Forms.TextBox Rua_TB;
        private System.Windows.Forms.Label Rua_LBL;
        private System.Windows.Forms.GroupBox GP_Contato;
        private System.Windows.Forms.Label Telefone_LBL;
        private System.Windows.Forms.TextBox Email_TB;
        private System.Windows.Forms.Label Email_LBL;
        private MetroFramework.Controls.MetroTabControl TabControl_Cliente;
        private MetroFramework.Controls.MetroTabPage Geral_TAB;
        private MetroFramework.Controls.MetroTabPage Turmas_TAB;
        private System.Windows.Forms.DataGridView GD_Turmas;
        private MetroFramework.Controls.MetroButton TurmaRemover_Button;
        private MetroFramework.Controls.MetroButton TurmaAdd_Button;
        private System.Windows.Forms.TextBox Telefone_TB;
        private System.Windows.Forms.TextBox Bairro_TB;
        private System.Windows.Forms.Button Pesquisa_Button;
        private System.Windows.Forms.TextBox Turma_TB;
    }
}