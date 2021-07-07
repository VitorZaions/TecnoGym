namespace Tecno_Gym.Contas
{
    partial class CadastrarContaReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarContaReceber));
            this.EmAberto_RB = new MetroFramework.Controls.MetroRadioButton();
            this.Pago_RB = new MetroFramework.Controls.MetroRadioButton();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.DataRecebimento_DT = new System.Windows.Forms.DateTimePicker();
            this.DataRecebimento_LBL = new System.Windows.Forms.Label();
            this.Valor_TB = new System.Windows.Forms.TextBox();
            this.Valor_LBL = new System.Windows.Forms.Label();
            this.Desc_LBL = new System.Windows.Forms.Label();
            this.Desc_TB = new System.Windows.Forms.TextBox();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmAberto_RB
            // 
            this.EmAberto_RB.AutoSize = true;
            this.EmAberto_RB.Checked = true;
            this.EmAberto_RB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmAberto_RB.Location = new System.Drawing.Point(36, 235);
            this.EmAberto_RB.Name = "EmAberto_RB";
            this.EmAberto_RB.Size = new System.Drawing.Size(77, 15);
            this.EmAberto_RB.TabIndex = 51;
            this.EmAberto_RB.TabStop = true;
            this.EmAberto_RB.Text = "Em aberto";
            this.EmAberto_RB.UseSelectable = true;
            // 
            // Pago_RB
            // 
            this.Pago_RB.AutoSize = true;
            this.Pago_RB.ForeColor = System.Drawing.Color.Green;
            this.Pago_RB.Location = new System.Drawing.Point(36, 259);
            this.Pago_RB.Name = "Pago_RB";
            this.Pago_RB.Size = new System.Drawing.Size(50, 15);
            this.Pago_RB.TabIndex = 50;
            this.Pago_RB.Text = "Pago";
            this.Pago_RB.UseSelectable = true;
            // 
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(350, 258);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 45);
            this.Salvar_Button.TabIndex = 56;
            this.Salvar_Button.Text = "Salvar";
            this.Salvar_Button.UseSelectable = true;
            this.Salvar_Button.Click += new System.EventHandler(this.Salvar_Button_Click);
            // 
            // DataRecebimento_DT
            // 
            this.DataRecebimento_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataRecebimento_DT.Location = new System.Drawing.Point(230, 182);
            this.DataRecebimento_DT.Name = "DataRecebimento_DT";
            this.DataRecebimento_DT.Size = new System.Drawing.Size(256, 24);
            this.DataRecebimento_DT.TabIndex = 55;
            // 
            // DataRecebimento_LBL
            // 
            this.DataRecebimento_LBL.AutoSize = true;
            this.DataRecebimento_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataRecebimento_LBL.Location = new System.Drawing.Point(227, 161);
            this.DataRecebimento_LBL.Name = "DataRecebimento_LBL";
            this.DataRecebimento_LBL.Size = new System.Drawing.Size(155, 18);
            this.DataRecebimento_LBL.TabIndex = 54;
            this.DataRecebimento_LBL.Text = "* Data de recebimento";
            // 
            // Valor_TB
            // 
            this.Valor_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_TB.Location = new System.Drawing.Point(36, 182);
            this.Valor_TB.Name = "Valor_TB";
            this.Valor_TB.Size = new System.Drawing.Size(161, 24);
            this.Valor_TB.TabIndex = 53;
            this.Valor_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Valor_TB_KeyPress);
            // 
            // Valor_LBL
            // 
            this.Valor_LBL.AutoSize = true;
            this.Valor_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_LBL.Location = new System.Drawing.Point(33, 159);
            this.Valor_LBL.Name = "Valor_LBL";
            this.Valor_LBL.Size = new System.Drawing.Size(52, 18);
            this.Valor_LBL.TabIndex = 52;
            this.Valor_LBL.Text = "* Valor";
            // 
            // Desc_LBL
            // 
            this.Desc_LBL.AutoSize = true;
            this.Desc_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_LBL.Location = new System.Drawing.Point(167, 88);
            this.Desc_LBL.Name = "Desc_LBL";
            this.Desc_LBL.Size = new System.Drawing.Size(86, 18);
            this.Desc_LBL.TabIndex = 49;
            this.Desc_LBL.Text = "* Descrição";
            // 
            // Desc_TB
            // 
            this.Desc_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_TB.Location = new System.Drawing.Point(170, 112);
            this.Desc_TB.MaxLength = 100;
            this.Desc_TB.Name = "Desc_TB";
            this.Desc_TB.Size = new System.Drawing.Size(319, 24);
            this.Desc_TB.TabIndex = 48;
            // 
            // Id_LBL
            // 
            this.Id_LBL.AutoSize = true;
            this.Id_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_LBL.Location = new System.Drawing.Point(33, 88);
            this.Id_LBL.Name = "Id_LBL";
            this.Id_LBL.Size = new System.Drawing.Size(56, 18);
            this.Id_LBL.TabIndex = 47;
            this.Id_LBL.Text = "Código";
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(36, 112);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(104, 24);
            this.Id_TB.TabIndex = 46;
            // 
            // CadastrarContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 318);
            this.Controls.Add(this.EmAberto_RB);
            this.Controls.Add(this.Pago_RB);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.DataRecebimento_DT);
            this.Controls.Add(this.DataRecebimento_LBL);
            this.Controls.Add(this.Valor_TB);
            this.Controls.Add(this.Valor_LBL);
            this.Controls.Add(this.Desc_LBL);
            this.Controls.Add(this.Desc_TB);
            this.Controls.Add(this.Id_LBL);
            this.Controls.Add(this.Id_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarContaReceber";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Cadastrar conta a receber";
            this.Load += new System.EventHandler(this.CadastrarContaReceber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton EmAberto_RB;
        private MetroFramework.Controls.MetroRadioButton Pago_RB;
        private MetroFramework.Controls.MetroButton Salvar_Button;
        private System.Windows.Forms.DateTimePicker DataRecebimento_DT;
        private System.Windows.Forms.Label DataRecebimento_LBL;
        private System.Windows.Forms.TextBox Valor_TB;
        private System.Windows.Forms.Label Valor_LBL;
        private System.Windows.Forms.Label Desc_LBL;
        private System.Windows.Forms.TextBox Desc_TB;
        private System.Windows.Forms.Label Id_LBL;
        private System.Windows.Forms.TextBox Id_TB;
    }
}