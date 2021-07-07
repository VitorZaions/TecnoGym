namespace Tecno_Gym.Pedido
{
    partial class CadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarProduto));
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.Nome_TB = new System.Windows.Forms.TextBox();
            this.Nome_LBL = new System.Windows.Forms.Label();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.Estoque_NUM = new System.Windows.Forms.NumericUpDown();
            this.Estoque_LBL = new System.Windows.Forms.Label();
            this.Categoria_Button = new MetroFramework.Controls.MetroButton();
            this.Valor_TB = new System.Windows.Forms.TextBox();
            this.Valor_LBL = new System.Windows.Forms.Label();
            this.Categoria_TB = new System.Windows.Forms.TextBox();
            this.Categoria_LBL = new System.Windows.Forms.Label();
            this.Fornecedor_TB = new System.Windows.Forms.TextBox();
            this.Fornecedor_Button = new MetroFramework.Controls.MetroButton();
            this.Fornecedor_LBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Estoque_NUM)).BeginInit();
            this.SuspendLayout();
            // 
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(626, 248);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 45);
            this.Salvar_Button.TabIndex = 51;
            this.Salvar_Button.Text = "Salvar";
            this.Salvar_Button.UseSelectable = true;
            this.Salvar_Button.Click += new System.EventHandler(this.Salvar_Button_Click);
            // 
            // Nome_TB
            // 
            this.Nome_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_TB.Location = new System.Drawing.Point(232, 110);
            this.Nome_TB.MaxLength = 100;
            this.Nome_TB.Name = "Nome_TB";
            this.Nome_TB.Size = new System.Drawing.Size(267, 24);
            this.Nome_TB.TabIndex = 49;
            // 
            // Nome_LBL
            // 
            this.Nome_LBL.AutoSize = true;
            this.Nome_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_LBL.Location = new System.Drawing.Point(229, 86);
            this.Nome_LBL.Name = "Nome_LBL";
            this.Nome_LBL.Size = new System.Drawing.Size(59, 18);
            this.Nome_LBL.TabIndex = 48;
            this.Nome_LBL.Text = "* Nome";
            // 
            // Id_LBL
            // 
            this.Id_LBL.AutoSize = true;
            this.Id_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_LBL.Location = new System.Drawing.Point(33, 86);
            this.Id_LBL.Name = "Id_LBL";
            this.Id_LBL.Size = new System.Drawing.Size(56, 18);
            this.Id_LBL.TabIndex = 47;
            this.Id_LBL.Text = "Código";
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(36, 110);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(161, 24);
            this.Id_TB.TabIndex = 46;
            // 
            // Estoque_NUM
            // 
            this.Estoque_NUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estoque_NUM.Location = new System.Drawing.Point(531, 110);
            this.Estoque_NUM.Name = "Estoque_NUM";
            this.Estoque_NUM.Size = new System.Drawing.Size(231, 24);
            this.Estoque_NUM.TabIndex = 52;
            // 
            // Estoque_LBL
            // 
            this.Estoque_LBL.AutoSize = true;
            this.Estoque_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estoque_LBL.Location = new System.Drawing.Point(528, 86);
            this.Estoque_LBL.Name = "Estoque_LBL";
            this.Estoque_LBL.Size = new System.Drawing.Size(73, 18);
            this.Estoque_LBL.TabIndex = 53;
            this.Estoque_LBL.Text = "* Estoque";
            // 
            // Categoria_Button
            // 
            this.Categoria_Button.Location = new System.Drawing.Point(471, 184);
            this.Categoria_Button.Name = "Categoria_Button";
            this.Categoria_Button.Size = new System.Drawing.Size(28, 23);
            this.Categoria_Button.TabIndex = 56;
            this.Categoria_Button.Text = "📑";
            this.Categoria_Button.UseSelectable = true;
            this.Categoria_Button.Click += new System.EventHandler(this.Categoria_Button_Click);
            // 
            // Valor_TB
            // 
            this.Valor_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_TB.Location = new System.Drawing.Point(36, 183);
            this.Valor_TB.Name = "Valor_TB";
            this.Valor_TB.Size = new System.Drawing.Size(161, 24);
            this.Valor_TB.TabIndex = 55;
            this.Valor_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_TB_KeyPress);
            // 
            // Valor_LBL
            // 
            this.Valor_LBL.AutoSize = true;
            this.Valor_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_LBL.Location = new System.Drawing.Point(33, 159);
            this.Valor_LBL.Name = "Valor_LBL";
            this.Valor_LBL.Size = new System.Drawing.Size(52, 18);
            this.Valor_LBL.TabIndex = 54;
            this.Valor_LBL.Text = "* Valor";
            // 
            // Categoria_TB
            // 
            this.Categoria_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria_TB.Location = new System.Drawing.Point(232, 184);
            this.Categoria_TB.Name = "Categoria_TB";
            this.Categoria_TB.ReadOnly = true;
            this.Categoria_TB.Size = new System.Drawing.Size(233, 24);
            this.Categoria_TB.TabIndex = 58;
            // 
            // Categoria_LBL
            // 
            this.Categoria_LBL.AutoSize = true;
            this.Categoria_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria_LBL.Location = new System.Drawing.Point(229, 160);
            this.Categoria_LBL.Name = "Categoria_LBL";
            this.Categoria_LBL.Size = new System.Drawing.Size(82, 18);
            this.Categoria_LBL.TabIndex = 57;
            this.Categoria_LBL.Text = "* Categoria";
            // 
            // Fornecedor_TB
            // 
            this.Fornecedor_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fornecedor_TB.Location = new System.Drawing.Point(531, 184);
            this.Fornecedor_TB.Name = "Fornecedor_TB";
            this.Fornecedor_TB.ReadOnly = true;
            this.Fornecedor_TB.Size = new System.Drawing.Size(195, 24);
            this.Fornecedor_TB.TabIndex = 60;
            // 
            // Fornecedor_Button
            // 
            this.Fornecedor_Button.Location = new System.Drawing.Point(734, 185);
            this.Fornecedor_Button.Name = "Fornecedor_Button";
            this.Fornecedor_Button.Size = new System.Drawing.Size(28, 23);
            this.Fornecedor_Button.TabIndex = 59;
            this.Fornecedor_Button.Text = "🚚";
            this.Fornecedor_Button.UseSelectable = true;
            this.Fornecedor_Button.Click += new System.EventHandler(this.Fornecedor_Button_Click);
            // 
            // Fornecedor_LBL
            // 
            this.Fornecedor_LBL.AutoSize = true;
            this.Fornecedor_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fornecedor_LBL.Location = new System.Drawing.Point(528, 160);
            this.Fornecedor_LBL.Name = "Fornecedor_LBL";
            this.Fornecedor_LBL.Size = new System.Drawing.Size(95, 18);
            this.Fornecedor_LBL.TabIndex = 61;
            this.Fornecedor_LBL.Text = "* Fornecedor";
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 319);
            this.Controls.Add(this.Fornecedor_LBL);
            this.Controls.Add(this.Fornecedor_TB);
            this.Controls.Add(this.Fornecedor_Button);
            this.Controls.Add(this.Categoria_TB);
            this.Controls.Add(this.Categoria_LBL);
            this.Controls.Add(this.Categoria_Button);
            this.Controls.Add(this.Valor_TB);
            this.Controls.Add(this.Valor_LBL);
            this.Controls.Add(this.Estoque_LBL);
            this.Controls.Add(this.Estoque_NUM);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.Nome_TB);
            this.Controls.Add(this.Nome_LBL);
            this.Controls.Add(this.Id_LBL);
            this.Controls.Add(this.Id_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarProduto";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Cadastrar produto";
            this.Load += new System.EventHandler(this.CadastrarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Estoque_NUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Salvar_Button;
        private System.Windows.Forms.TextBox Nome_TB;
        private System.Windows.Forms.Label Nome_LBL;
        private System.Windows.Forms.Label Id_LBL;
        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.NumericUpDown Estoque_NUM;
        private System.Windows.Forms.Label Estoque_LBL;
        private MetroFramework.Controls.MetroButton Categoria_Button;
        private System.Windows.Forms.TextBox Valor_TB;
        private System.Windows.Forms.Label Valor_LBL;
        private System.Windows.Forms.TextBox Categoria_TB;
        private System.Windows.Forms.Label Categoria_LBL;
        private System.Windows.Forms.TextBox Fornecedor_TB;
        private MetroFramework.Controls.MetroButton Fornecedor_Button;
        private System.Windows.Forms.Label Fornecedor_LBL;
    }
}