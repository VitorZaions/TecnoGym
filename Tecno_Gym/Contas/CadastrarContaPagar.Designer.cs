namespace Tecno_Gym.Contas
{
    partial class CadastrarContaPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarContaPagar));
            this.Desc_LBL = new System.Windows.Forms.Label();
            this.Desc_TB = new System.Windows.Forms.TextBox();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.EmAberto_RB = new MetroFramework.Controls.MetroRadioButton();
            this.Pago_RB = new MetroFramework.Controls.MetroRadioButton();
            this.DataVencimento_DT = new System.Windows.Forms.DateTimePicker();
            this.DataVencimento_LBL = new System.Windows.Forms.Label();
            this.Valor_TB = new System.Windows.Forms.TextBox();
            this.Valor_LBL = new System.Windows.Forms.Label();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Desc_LBL
            // 
            this.Desc_LBL.AutoSize = true;
            this.Desc_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_LBL.Location = new System.Drawing.Point(167, 88);
            this.Desc_LBL.Name = "Desc_LBL";
            this.Desc_LBL.Size = new System.Drawing.Size(86, 18);
            this.Desc_LBL.TabIndex = 15;
            this.Desc_LBL.Text = "* Descrição";
            // 
            // Desc_TB
            // 
            this.Desc_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_TB.Location = new System.Drawing.Point(170, 112);
            this.Desc_TB.MaxLength = 100;
            this.Desc_TB.Name = "Desc_TB";
            this.Desc_TB.Size = new System.Drawing.Size(319, 24);
            this.Desc_TB.TabIndex = 14;
            // 
            // Id_LBL
            // 
            this.Id_LBL.AutoSize = true;
            this.Id_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_LBL.Location = new System.Drawing.Point(33, 88);
            this.Id_LBL.Name = "Id_LBL";
            this.Id_LBL.Size = new System.Drawing.Size(56, 18);
            this.Id_LBL.TabIndex = 13;
            this.Id_LBL.Text = "Código";
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(36, 112);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(104, 24);
            this.Id_TB.TabIndex = 12;
            // 
            // EmAberto_RB
            // 
            this.EmAberto_RB.AutoSize = true;
            this.EmAberto_RB.Checked = true;
            this.EmAberto_RB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmAberto_RB.Location = new System.Drawing.Point(36, 235);
            this.EmAberto_RB.Name = "EmAberto_RB";
            this.EmAberto_RB.Size = new System.Drawing.Size(77, 15);
            this.EmAberto_RB.TabIndex = 39;
            this.EmAberto_RB.TabStop = true;
            this.EmAberto_RB.Text = "Em aberto";
            this.EmAberto_RB.UseSelectable = true;
            this.EmAberto_RB.CheckedChanged += new System.EventHandler(this.metroRadioButton2_CheckedChanged);
            // 
            // Pago_RB
            // 
            this.Pago_RB.AutoSize = true;
            this.Pago_RB.ForeColor = System.Drawing.Color.Green;
            this.Pago_RB.Location = new System.Drawing.Point(36, 259);
            this.Pago_RB.Name = "Pago_RB";
            this.Pago_RB.Size = new System.Drawing.Size(50, 15);
            this.Pago_RB.TabIndex = 38;
            this.Pago_RB.Text = "Pago";
            this.Pago_RB.UseSelectable = true;
            this.Pago_RB.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // DataVencimento_DT
            // 
            this.DataVencimento_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataVencimento_DT.Location = new System.Drawing.Point(230, 182);
            this.DataVencimento_DT.Name = "DataVencimento_DT";
            this.DataVencimento_DT.Size = new System.Drawing.Size(256, 24);
            this.DataVencimento_DT.TabIndex = 43;
            // 
            // DataVencimento_LBL
            // 
            this.DataVencimento_LBL.AutoSize = true;
            this.DataVencimento_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataVencimento_LBL.Location = new System.Drawing.Point(227, 161);
            this.DataVencimento_LBL.Name = "DataVencimento_LBL";
            this.DataVencimento_LBL.Size = new System.Drawing.Size(149, 18);
            this.DataVencimento_LBL.TabIndex = 42;
            this.DataVencimento_LBL.Text = "* Data de vencimento";
            // 
            // Valor_TB
            // 
            this.Valor_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_TB.Location = new System.Drawing.Point(36, 182);
            this.Valor_TB.Name = "Valor_TB";
            this.Valor_TB.Size = new System.Drawing.Size(161, 24);
            this.Valor_TB.TabIndex = 41;
            this.Valor_TB.TextChanged += new System.EventHandler(this.Valor_TB_TextChanged);
            this.Valor_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_TB_KeyPress);
            // 
            // Valor_LBL
            // 
            this.Valor_LBL.AutoSize = true;
            this.Valor_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_LBL.Location = new System.Drawing.Point(33, 159);
            this.Valor_LBL.Name = "Valor_LBL";
            this.Valor_LBL.Size = new System.Drawing.Size(52, 18);
            this.Valor_LBL.TabIndex = 40;
            this.Valor_LBL.Text = "* Valor";
            // 
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(350, 258);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 45);
            this.Salvar_Button.TabIndex = 45;
            this.Salvar_Button.Text = "Salvar";
            this.Salvar_Button.UseSelectable = true;
            this.Salvar_Button.Click += new System.EventHandler(this.Salvar_Button_Click);
            // 
            // CadastrarContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 318);
            this.Controls.Add(this.EmAberto_RB);
            this.Controls.Add(this.Pago_RB);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.DataVencimento_DT);
            this.Controls.Add(this.DataVencimento_LBL);
            this.Controls.Add(this.Valor_TB);
            this.Controls.Add(this.Valor_LBL);
            this.Controls.Add(this.Desc_LBL);
            this.Controls.Add(this.Desc_TB);
            this.Controls.Add(this.Id_LBL);
            this.Controls.Add(this.Id_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarContaPagar";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Cadastrar conta a pagar";
            this.Load += new System.EventHandler(this.CadastrarContaPagar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Desc_LBL;
        private System.Windows.Forms.TextBox Desc_TB;
        private System.Windows.Forms.Label Id_LBL;
        private System.Windows.Forms.TextBox Id_TB;
        private MetroFramework.Controls.MetroRadioButton EmAberto_RB;
        private MetroFramework.Controls.MetroRadioButton Pago_RB;
        private System.Windows.Forms.DateTimePicker DataVencimento_DT;
        private System.Windows.Forms.Label DataVencimento_LBL;
        private System.Windows.Forms.TextBox Valor_TB;
        private System.Windows.Forms.Label Valor_LBL;
        private MetroFramework.Controls.MetroButton Salvar_Button;
    }
}