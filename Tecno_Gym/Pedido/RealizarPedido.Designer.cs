namespace Tecno_Gym.Pedido
{
    partial class RealizarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarPedido));
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.Geral_TAB = new MetroFramework.Controls.MetroTabPage();
            this.Pagamento_GP = new System.Windows.Forms.GroupBox();
            this.Cartao_RB = new MetroFramework.Controls.MetroRadioButton();
            this.Boleto_RB = new MetroFramework.Controls.MetroRadioButton();
            this.Avista_RB = new MetroFramework.Controls.MetroRadioButton();
            this.TipoPagamento_LBL = new System.Windows.Forms.Label();
            this.Geral_GP = new System.Windows.Forms.GroupBox();
            this.DataPedido_LBL = new System.Windows.Forms.Label();
            this.DataPedido_DT = new System.Windows.Forms.DateTimePicker();
            this.Desc_LBL = new System.Windows.Forms.Label();
            this.Desc_TB = new System.Windows.Forms.TextBox();
            this.Cliente_Button = new MetroFramework.Controls.MetroButton();
            this.Cliente_TB = new System.Windows.Forms.TextBox();
            this.Cliente_LBL = new System.Windows.Forms.Label();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Produtos_TAB = new MetroFramework.Controls.MetroTabPage();
            this.Grid_Produtos = new System.Windows.Forms.DataGridView();
            this.Produtos_GP = new System.Windows.Forms.GroupBox();
            this.Pesquisa_Button = new System.Windows.Forms.Button();
            this.ValorProduto_LBL = new System.Windows.Forms.Label();
            this.ValorProduto_TB = new System.Windows.Forms.TextBox();
            this.RemoverProduto_Button = new MetroFramework.Controls.MetroButton();
            this.NomeProduto_LBL = new System.Windows.Forms.Label();
            this.QuantidadeProduto_LBL = new System.Windows.Forms.Label();
            this.QuantidadeProduto_NUM = new System.Windows.Forms.NumericUpDown();
            this.NomeProduto_TB = new System.Windows.Forms.TextBox();
            this.IdProduto_TB = new System.Windows.Forms.TextBox();
            this.AdicionarProduto_Button = new MetroFramework.Controls.MetroButton();
            this.IdProduto_Label = new System.Windows.Forms.Label();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.ValorTotal_LBL = new System.Windows.Forms.Label();
            this.ValorTotalValor_LBL = new System.Windows.Forms.Label();
            this.metroTabControl2.SuspendLayout();
            this.Geral_TAB.SuspendLayout();
            this.Pagamento_GP.SuspendLayout();
            this.Geral_GP.SuspendLayout();
            this.Produtos_TAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produtos)).BeginInit();
            this.Produtos_GP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeProduto_NUM)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.Geral_TAB);
            this.metroTabControl2.Controls.Add(this.Produtos_TAB);
            this.metroTabControl2.Location = new System.Drawing.Point(23, 73);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(856, 513);
            this.metroTabControl2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroTabControl2.TabIndex = 102;
            this.metroTabControl2.UseSelectable = true;
            this.metroTabControl2.TabIndexChanged += new System.EventHandler(this.metroTabControl2_TabIndexChanged);
            // 
            // Geral_TAB
            // 
            this.Geral_TAB.Controls.Add(this.Pagamento_GP);
            this.Geral_TAB.Controls.Add(this.Geral_GP);
            this.Geral_TAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Geral_TAB.HorizontalScrollbarBarColor = true;
            this.Geral_TAB.HorizontalScrollbarHighlightOnWheel = false;
            this.Geral_TAB.HorizontalScrollbarSize = 10;
            this.Geral_TAB.Location = new System.Drawing.Point(4, 38);
            this.Geral_TAB.Name = "Geral_TAB";
            this.Geral_TAB.Size = new System.Drawing.Size(848, 471);
            this.Geral_TAB.TabIndex = 0;
            this.Geral_TAB.Text = "Geral";
            this.Geral_TAB.VerticalScrollbarBarColor = true;
            this.Geral_TAB.VerticalScrollbarHighlightOnWheel = false;
            this.Geral_TAB.VerticalScrollbarSize = 10;
            this.Geral_TAB.Click += new System.EventHandler(this.metroTabPage5_Click);
            this.Geral_TAB.Enter += new System.EventHandler(this.Geral_TAB_Enter);
            // 
            // Pagamento_GP
            // 
            this.Pagamento_GP.BackColor = System.Drawing.Color.White;
            this.Pagamento_GP.Controls.Add(this.Cartao_RB);
            this.Pagamento_GP.Controls.Add(this.Boleto_RB);
            this.Pagamento_GP.Controls.Add(this.Avista_RB);
            this.Pagamento_GP.Controls.Add(this.TipoPagamento_LBL);
            this.Pagamento_GP.Location = new System.Drawing.Point(0, 148);
            this.Pagamento_GP.Name = "Pagamento_GP";
            this.Pagamento_GP.Size = new System.Drawing.Size(824, 153);
            this.Pagamento_GP.TabIndex = 55;
            this.Pagamento_GP.TabStop = false;
            this.Pagamento_GP.Text = "Pagamento";
            // 
            // Cartao_RB
            // 
            this.Cartao_RB.AutoSize = true;
            this.Cartao_RB.Location = new System.Drawing.Point(30, 85);
            this.Cartao_RB.Name = "Cartao_RB";
            this.Cartao_RB.Size = new System.Drawing.Size(58, 15);
            this.Cartao_RB.TabIndex = 42;
            this.Cartao_RB.Text = "Cartão";
            this.Cartao_RB.UseSelectable = true;
            // 
            // Boleto_RB
            // 
            this.Boleto_RB.AutoSize = true;
            this.Boleto_RB.Location = new System.Drawing.Point(30, 59);
            this.Boleto_RB.Name = "Boleto_RB";
            this.Boleto_RB.Size = new System.Drawing.Size(57, 15);
            this.Boleto_RB.TabIndex = 41;
            this.Boleto_RB.Text = "Boleto";
            this.Boleto_RB.UseSelectable = true;
            // 
            // Avista_RB
            // 
            this.Avista_RB.AutoSize = true;
            this.Avista_RB.Checked = true;
            this.Avista_RB.Location = new System.Drawing.Point(30, 110);
            this.Avista_RB.Name = "Avista_RB";
            this.Avista_RB.Size = new System.Drawing.Size(59, 15);
            this.Avista_RB.TabIndex = 40;
            this.Avista_RB.TabStop = true;
            this.Avista_RB.Text = "Á Vista";
            this.Avista_RB.UseSelectable = true;
            // 
            // TipoPagamento_LBL
            // 
            this.TipoPagamento_LBL.AutoSize = true;
            this.TipoPagamento_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoPagamento_LBL.Location = new System.Drawing.Point(21, 22);
            this.TipoPagamento_LBL.Name = "TipoPagamento_LBL";
            this.TipoPagamento_LBL.Size = new System.Drawing.Size(135, 18);
            this.TipoPagamento_LBL.TabIndex = 39;
            this.TipoPagamento_LBL.Text = "Tipo de pagamento";
            // 
            // Geral_GP
            // 
            this.Geral_GP.BackColor = System.Drawing.Color.White;
            this.Geral_GP.Controls.Add(this.DataPedido_LBL);
            this.Geral_GP.Controls.Add(this.DataPedido_DT);
            this.Geral_GP.Controls.Add(this.Desc_LBL);
            this.Geral_GP.Controls.Add(this.Desc_TB);
            this.Geral_GP.Controls.Add(this.Cliente_Button);
            this.Geral_GP.Controls.Add(this.Cliente_TB);
            this.Geral_GP.Controls.Add(this.Cliente_LBL);
            this.Geral_GP.Controls.Add(this.Id_TB);
            this.Geral_GP.Controls.Add(this.Id_LBL);
            this.Geral_GP.Location = new System.Drawing.Point(3, 13);
            this.Geral_GP.Name = "Geral_GP";
            this.Geral_GP.Size = new System.Drawing.Size(824, 108);
            this.Geral_GP.TabIndex = 54;
            this.Geral_GP.TabStop = false;
            this.Geral_GP.Text = "Geral";
            // 
            // DataPedido_LBL
            // 
            this.DataPedido_LBL.AutoSize = true;
            this.DataPedido_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPedido_LBL.Location = new System.Drawing.Point(627, 25);
            this.DataPedido_LBL.Name = "DataPedido_LBL";
            this.DataPedido_LBL.Size = new System.Drawing.Size(39, 18);
            this.DataPedido_LBL.TabIndex = 51;
            this.DataPedido_LBL.Text = "Data";
            // 
            // DataPedido_DT
            // 
            this.DataPedido_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPedido_DT.Location = new System.Drawing.Point(630, 46);
            this.DataPedido_DT.Name = "DataPedido_DT";
            this.DataPedido_DT.Size = new System.Drawing.Size(173, 26);
            this.DataPedido_DT.TabIndex = 50;
            // 
            // Desc_LBL
            // 
            this.Desc_LBL.AutoSize = true;
            this.Desc_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_LBL.Location = new System.Drawing.Point(184, 22);
            this.Desc_LBL.Name = "Desc_LBL";
            this.Desc_LBL.Size = new System.Drawing.Size(49, 18);
            this.Desc_LBL.TabIndex = 48;
            this.Desc_LBL.Text = "Nome";
            // 
            // Desc_TB
            // 
            this.Desc_TB.Enabled = false;
            this.Desc_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_TB.Location = new System.Drawing.Point(187, 46);
            this.Desc_TB.MaxLength = 100;
            this.Desc_TB.Name = "Desc_TB";
            this.Desc_TB.Size = new System.Drawing.Size(167, 24);
            this.Desc_TB.TabIndex = 49;
            // 
            // Cliente_Button
            // 
            this.Cliente_Button.Location = new System.Drawing.Point(579, 47);
            this.Cliente_Button.Name = "Cliente_Button";
            this.Cliente_Button.Size = new System.Drawing.Size(28, 23);
            this.Cliente_Button.TabIndex = 47;
            this.Cliente_Button.Text = "🧑";
            this.Cliente_Button.UseSelectable = true;
            this.Cliente_Button.Click += new System.EventHandler(this.Cliente_Button_Click);
            // 
            // Cliente_TB
            // 
            this.Cliente_TB.Enabled = false;
            this.Cliente_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_TB.Location = new System.Drawing.Point(376, 46);
            this.Cliente_TB.Name = "Cliente_TB";
            this.Cliente_TB.ReadOnly = true;
            this.Cliente_TB.Size = new System.Drawing.Size(199, 24);
            this.Cliente_TB.TabIndex = 46;
            // 
            // Cliente_LBL
            // 
            this.Cliente_LBL.AutoSize = true;
            this.Cliente_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_LBL.Location = new System.Drawing.Point(373, 22);
            this.Cliente_LBL.Name = "Cliente_LBL";
            this.Cliente_LBL.Size = new System.Drawing.Size(53, 18);
            this.Cliente_LBL.TabIndex = 45;
            this.Cliente_LBL.Text = "Cliente";
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(24, 46);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(142, 24);
            this.Id_TB.TabIndex = 38;
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
            // Produtos_TAB
            // 
            this.Produtos_TAB.Controls.Add(this.Grid_Produtos);
            this.Produtos_TAB.Controls.Add(this.Produtos_GP);
            this.Produtos_TAB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produtos_TAB.HorizontalScrollbarBarColor = true;
            this.Produtos_TAB.HorizontalScrollbarHighlightOnWheel = false;
            this.Produtos_TAB.HorizontalScrollbarSize = 10;
            this.Produtos_TAB.Location = new System.Drawing.Point(4, 38);
            this.Produtos_TAB.Name = "Produtos_TAB";
            this.Produtos_TAB.Size = new System.Drawing.Size(848, 471);
            this.Produtos_TAB.TabIndex = 1;
            this.Produtos_TAB.Text = "Produtos";
            this.Produtos_TAB.VerticalScrollbarBarColor = true;
            this.Produtos_TAB.VerticalScrollbarHighlightOnWheel = false;
            this.Produtos_TAB.VerticalScrollbarSize = 10;
            this.Produtos_TAB.Click += new System.EventHandler(this.metroTabPage6_Click);
            this.Produtos_TAB.Enter += new System.EventHandler(this.Produtos_TAB_Enter);
            // 
            // Grid_Produtos
            // 
            this.Grid_Produtos.AllowUserToAddRows = false;
            this.Grid_Produtos.AllowUserToDeleteRows = false;
            this.Grid_Produtos.AllowUserToResizeColumns = false;
            this.Grid_Produtos.AllowUserToResizeRows = false;
            this.Grid_Produtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Produtos.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Produtos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Grid_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Produtos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_Produtos.Location = new System.Drawing.Point(0, 115);
            this.Grid_Produtos.Name = "Grid_Produtos";
            this.Grid_Produtos.ReadOnly = true;
            this.Grid_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Produtos.Size = new System.Drawing.Size(848, 341);
            this.Grid_Produtos.TabIndex = 127;
            // 
            // Produtos_GP
            // 
            this.Produtos_GP.BackColor = System.Drawing.Color.White;
            this.Produtos_GP.Controls.Add(this.Pesquisa_Button);
            this.Produtos_GP.Controls.Add(this.ValorProduto_LBL);
            this.Produtos_GP.Controls.Add(this.ValorProduto_TB);
            this.Produtos_GP.Controls.Add(this.RemoverProduto_Button);
            this.Produtos_GP.Controls.Add(this.NomeProduto_LBL);
            this.Produtos_GP.Controls.Add(this.QuantidadeProduto_LBL);
            this.Produtos_GP.Controls.Add(this.QuantidadeProduto_NUM);
            this.Produtos_GP.Controls.Add(this.NomeProduto_TB);
            this.Produtos_GP.Controls.Add(this.IdProduto_TB);
            this.Produtos_GP.Controls.Add(this.AdicionarProduto_Button);
            this.Produtos_GP.Controls.Add(this.IdProduto_Label);
            this.Produtos_GP.Location = new System.Drawing.Point(3, 8);
            this.Produtos_GP.Name = "Produtos_GP";
            this.Produtos_GP.Size = new System.Drawing.Size(845, 91);
            this.Produtos_GP.TabIndex = 125;
            this.Produtos_GP.TabStop = false;
            this.Produtos_GP.Text = "Informações do produto";
            // 
            // Pesquisa_Button
            // 
            this.Pesquisa_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pesquisa_Button.Location = new System.Drawing.Point(692, 19);
            this.Pesquisa_Button.Name = "Pesquisa_Button";
            this.Pesquisa_Button.Size = new System.Drawing.Size(39, 59);
            this.Pesquisa_Button.TabIndex = 132;
            this.Pesquisa_Button.Text = "🔎";
            this.Pesquisa_Button.UseVisualStyleBackColor = true;
            this.Pesquisa_Button.Click += new System.EventHandler(this.Pesquisa_Button_Click);
            // 
            // ValorProduto_LBL
            // 
            this.ValorProduto_LBL.AutoSize = true;
            this.ValorProduto_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorProduto_LBL.Location = new System.Drawing.Point(383, 30);
            this.ValorProduto_LBL.Name = "ValorProduto_LBL";
            this.ValorProduto_LBL.Size = new System.Drawing.Size(42, 18);
            this.ValorProduto_LBL.TabIndex = 130;
            this.ValorProduto_LBL.Text = "Valor";
            // 
            // ValorProduto_TB
            // 
            this.ValorProduto_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorProduto_TB.Location = new System.Drawing.Point(386, 51);
            this.ValorProduto_TB.Name = "ValorProduto_TB";
            this.ValorProduto_TB.ReadOnly = true;
            this.ValorProduto_TB.Size = new System.Drawing.Size(170, 24);
            this.ValorProduto_TB.TabIndex = 129;
            // 
            // RemoverProduto_Button
            // 
            this.RemoverProduto_Button.Location = new System.Drawing.Point(737, 50);
            this.RemoverProduto_Button.Name = "RemoverProduto_Button";
            this.RemoverProduto_Button.Size = new System.Drawing.Size(102, 28);
            this.RemoverProduto_Button.Style = MetroFramework.MetroColorStyle.White;
            this.RemoverProduto_Button.TabIndex = 100;
            this.RemoverProduto_Button.TabStop = false;
            this.RemoverProduto_Button.Text = "REMOVER";
            this.RemoverProduto_Button.UseSelectable = true;
            this.RemoverProduto_Button.Click += new System.EventHandler(this.RemoverProduto_Button_Click);
            // 
            // NomeProduto_LBL
            // 
            this.NomeProduto_LBL.AutoSize = true;
            this.NomeProduto_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeProduto_LBL.Location = new System.Drawing.Point(101, 30);
            this.NomeProduto_LBL.Name = "NomeProduto_LBL";
            this.NomeProduto_LBL.Size = new System.Drawing.Size(49, 18);
            this.NomeProduto_LBL.TabIndex = 128;
            this.NomeProduto_LBL.Text = "Nome";
            // 
            // QuantidadeProduto_LBL
            // 
            this.QuantidadeProduto_LBL.AutoSize = true;
            this.QuantidadeProduto_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantidadeProduto_LBL.Location = new System.Drawing.Point(570, 27);
            this.QuantidadeProduto_LBL.Name = "QuantidadeProduto_LBL";
            this.QuantidadeProduto_LBL.Size = new System.Drawing.Size(83, 18);
            this.QuantidadeProduto_LBL.TabIndex = 127;
            this.QuantidadeProduto_LBL.Text = "Quantidade";
            // 
            // QuantidadeProduto_NUM
            // 
            this.QuantidadeProduto_NUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantidadeProduto_NUM.Location = new System.Drawing.Point(573, 51);
            this.QuantidadeProduto_NUM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.QuantidadeProduto_NUM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantidadeProduto_NUM.Name = "QuantidadeProduto_NUM";
            this.QuantidadeProduto_NUM.Size = new System.Drawing.Size(101, 24);
            this.QuantidadeProduto_NUM.TabIndex = 126;
            this.QuantidadeProduto_NUM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NomeProduto_TB
            // 
            this.NomeProduto_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeProduto_TB.Location = new System.Drawing.Point(104, 51);
            this.NomeProduto_TB.Name = "NomeProduto_TB";
            this.NomeProduto_TB.ReadOnly = true;
            this.NomeProduto_TB.Size = new System.Drawing.Size(261, 24);
            this.NomeProduto_TB.TabIndex = 125;
            // 
            // IdProduto_TB
            // 
            this.IdProduto_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProduto_TB.Location = new System.Drawing.Point(16, 51);
            this.IdProduto_TB.Name = "IdProduto_TB";
            this.IdProduto_TB.Size = new System.Drawing.Size(67, 24);
            this.IdProduto_TB.TabIndex = 123;
            this.IdProduto_TB.TextChanged += new System.EventHandler(this.IdProduto_TB_TextChanged);
            // 
            // AdicionarProduto_Button
            // 
            this.AdicionarProduto_Button.Location = new System.Drawing.Point(737, 19);
            this.AdicionarProduto_Button.Name = "AdicionarProduto_Button";
            this.AdicionarProduto_Button.Size = new System.Drawing.Size(102, 28);
            this.AdicionarProduto_Button.Style = MetroFramework.MetroColorStyle.White;
            this.AdicionarProduto_Button.TabIndex = 98;
            this.AdicionarProduto_Button.TabStop = false;
            this.AdicionarProduto_Button.Text = "ADICIONAR";
            this.AdicionarProduto_Button.UseSelectable = true;
            this.AdicionarProduto_Button.Click += new System.EventHandler(this.AdicionarProduto_Button_Click);
            // 
            // IdProduto_Label
            // 
            this.IdProduto_Label.AutoSize = true;
            this.IdProduto_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProduto_Label.Location = new System.Drawing.Point(13, 30);
            this.IdProduto_Label.Name = "IdProduto_Label";
            this.IdProduto_Label.Size = new System.Drawing.Size(56, 18);
            this.IdProduto_Label.TabIndex = 124;
            this.IdProduto_Label.Text = "Código";
            // 
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(739, 581);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 43);
            this.Salvar_Button.TabIndex = 103;
            this.Salvar_Button.UseSelectable = true;
            this.Salvar_Button.Click += new System.EventHandler(this.Salvar_Button_Click);
            // 
            // ValorTotal_LBL
            // 
            this.ValorTotal_LBL.AutoSize = true;
            this.ValorTotal_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTotal_LBL.Location = new System.Drawing.Point(24, 603);
            this.ValorTotal_LBL.Name = "ValorTotal_LBL";
            this.ValorTotal_LBL.Size = new System.Drawing.Size(89, 20);
            this.ValorTotal_LBL.TabIndex = 104;
            this.ValorTotal_LBL.Text = "Valor Total:";
            // 
            // ValorTotalValor_LBL
            // 
            this.ValorTotalValor_LBL.AutoSize = true;
            this.ValorTotalValor_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTotalValor_LBL.ForeColor = System.Drawing.Color.ForestGreen;
            this.ValorTotalValor_LBL.Location = new System.Drawing.Point(109, 604);
            this.ValorTotalValor_LBL.Name = "ValorTotalValor_LBL";
            this.ValorTotalValor_LBL.Size = new System.Drawing.Size(19, 20);
            this.ValorTotalValor_LBL.TabIndex = 105;
            this.ValorTotalValor_LBL.Text = "0";
            // 
            // RealizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 641);
            this.Controls.Add(this.ValorTotalValor_LBL);
            this.Controls.Add(this.ValorTotal_LBL);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.metroTabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RealizarPedido";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Realizar pedido";
            this.Load += new System.EventHandler(this.RealizarPedido_Load);
            this.metroTabControl2.ResumeLayout(false);
            this.Geral_TAB.ResumeLayout(false);
            this.Pagamento_GP.ResumeLayout(false);
            this.Pagamento_GP.PerformLayout();
            this.Geral_GP.ResumeLayout(false);
            this.Geral_GP.PerformLayout();
            this.Produtos_TAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Produtos)).EndInit();
            this.Produtos_GP.ResumeLayout(false);
            this.Produtos_GP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantidadeProduto_NUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage Geral_TAB;
        private System.Windows.Forms.GroupBox Geral_GP;
        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.Label Id_LBL;
        private MetroFramework.Controls.MetroTabPage Produtos_TAB;
        private MetroFramework.Controls.MetroButton RemoverProduto_Button;
        private MetroFramework.Controls.MetroButton AdicionarProduto_Button;
        private System.Windows.Forms.GroupBox Pagamento_GP;
        private MetroFramework.Controls.MetroRadioButton Cartao_RB;
        private MetroFramework.Controls.MetroRadioButton Boleto_RB;
        private MetroFramework.Controls.MetroRadioButton Avista_RB;
        private System.Windows.Forms.Label TipoPagamento_LBL;
        private MetroFramework.Controls.MetroButton Cliente_Button;
        private System.Windows.Forms.TextBox Cliente_TB;
        private System.Windows.Forms.Label Cliente_LBL;
        private System.Windows.Forms.Label Desc_LBL;
        private System.Windows.Forms.TextBox Desc_TB;
        private System.Windows.Forms.TextBox IdProduto_TB;
        private System.Windows.Forms.Label IdProduto_Label;
        private System.Windows.Forms.GroupBox Produtos_GP;
        private MetroFramework.Controls.MetroButton Salvar_Button;
        private System.Windows.Forms.Label NomeProduto_LBL;
        private System.Windows.Forms.Label QuantidadeProduto_LBL;
        private System.Windows.Forms.NumericUpDown QuantidadeProduto_NUM;
        private System.Windows.Forms.TextBox NomeProduto_TB;
        private System.Windows.Forms.Label ValorProduto_LBL;
        private System.Windows.Forms.TextBox ValorProduto_TB;
        private System.Windows.Forms.Label ValorTotal_LBL;
        private System.Windows.Forms.Label ValorTotalValor_LBL;
        private System.Windows.Forms.Label DataPedido_LBL;
        private System.Windows.Forms.DateTimePicker DataPedido_DT;
        private System.Windows.Forms.Button Pesquisa_Button;
        private System.Windows.Forms.DataGridView Grid_Produtos;
    }
}