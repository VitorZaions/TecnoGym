namespace Tecno_Gym.Mensalidade
{
    partial class CadastrarMensalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarMensalidade));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.ValorMensalidade_LBL = new System.Windows.Forms.Label();
            this.Cliente_TB = new System.Windows.Forms.TextBox();
            this.Cliente_LBL = new System.Windows.Forms.Label();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.ValorMensalidade_TB = new System.Windows.Forms.TextBox();
            this.DataPagamento_LBL = new System.Windows.Forms.Label();
            this.DataPagamento_DT = new System.Windows.Forms.DateTimePicker();
            this.Pago_RB = new MetroFramework.Controls.MetroRadioButton();
            this.EmAberto_RB = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(458, 111);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(28, 23);
            this.metroButton1.TabIndex = 31;
            this.metroButton1.Text = "🧑";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ValorMensalidade_LBL
            // 
            this.ValorMensalidade_LBL.AutoSize = true;
            this.ValorMensalidade_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorMensalidade_LBL.Location = new System.Drawing.Point(33, 153);
            this.ValorMensalidade_LBL.Name = "ValorMensalidade_LBL";
            this.ValorMensalidade_LBL.Size = new System.Drawing.Size(159, 18);
            this.ValorMensalidade_LBL.TabIndex = 30;
            this.ValorMensalidade_LBL.Text = "* Valor da mensalidade";
            // 
            // Cliente_TB
            // 
            this.Cliente_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_TB.Location = new System.Drawing.Point(230, 110);
            this.Cliente_TB.Name = "Cliente_TB";
            this.Cliente_TB.ReadOnly = true;
            this.Cliente_TB.Size = new System.Drawing.Size(222, 24);
            this.Cliente_TB.TabIndex = 29;
            this.Cliente_TB.TextChanged += new System.EventHandler(this.Cliente_TB_TextChanged);
            // 
            // Cliente_LBL
            // 
            this.Cliente_LBL.AutoSize = true;
            this.Cliente_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_LBL.Location = new System.Drawing.Point(227, 86);
            this.Cliente_LBL.Name = "Cliente_LBL";
            this.Cliente_LBL.Size = new System.Drawing.Size(63, 18);
            this.Cliente_LBL.TabIndex = 28;
            this.Cliente_LBL.Text = "* Cliente";
            // 
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(351, 251);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 45);
            this.Salvar_Button.TabIndex = 26;
            this.Salvar_Button.Text = "Salvar";
            this.Salvar_Button.UseSelectable = true;
            this.Salvar_Button.Click += new System.EventHandler(this.Salvar_Button_Click);
            // 
            // Id_LBL
            // 
            this.Id_LBL.AutoSize = true;
            this.Id_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_LBL.Location = new System.Drawing.Point(33, 86);
            this.Id_LBL.Name = "Id_LBL";
            this.Id_LBL.Size = new System.Drawing.Size(56, 18);
            this.Id_LBL.TabIndex = 25;
            this.Id_LBL.Text = "Código";
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(36, 110);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(161, 24);
            this.Id_TB.TabIndex = 24;
            // 
            // ValorMensalidade_TB
            // 
            this.ValorMensalidade_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorMensalidade_TB.Location = new System.Drawing.Point(36, 176);
            this.ValorMensalidade_TB.Name = "ValorMensalidade_TB";
            this.ValorMensalidade_TB.Size = new System.Drawing.Size(161, 24);
            this.ValorMensalidade_TB.TabIndex = 32;
            this.ValorMensalidade_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorMensalidade_TB_KeyPress);
            // 
            // DataPagamento_LBL
            // 
            this.DataPagamento_LBL.AutoSize = true;
            this.DataPagamento_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPagamento_LBL.Location = new System.Drawing.Point(227, 155);
            this.DataPagamento_LBL.Name = "DataPagamento_LBL";
            this.DataPagamento_LBL.Size = new System.Drawing.Size(147, 18);
            this.DataPagamento_LBL.TabIndex = 33;
            this.DataPagamento_LBL.Text = "* Data de pagamento";
            // 
            // DataPagamento_DT
            // 
            this.DataPagamento_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPagamento_DT.Location = new System.Drawing.Point(230, 176);
            this.DataPagamento_DT.Name = "DataPagamento_DT";
            this.DataPagamento_DT.Size = new System.Drawing.Size(256, 24);
            this.DataPagamento_DT.TabIndex = 35;
            // 
            // Pago_RB
            // 
            this.Pago_RB.AutoSize = true;
            this.Pago_RB.ForeColor = System.Drawing.Color.Green;
            this.Pago_RB.Location = new System.Drawing.Point(36, 251);
            this.Pago_RB.Name = "Pago_RB";
            this.Pago_RB.Size = new System.Drawing.Size(50, 15);
            this.Pago_RB.TabIndex = 36;
            this.Pago_RB.Text = "Pago";
            this.Pago_RB.UseSelectable = true;
            // 
            // EmAberto_RB
            // 
            this.EmAberto_RB.AutoSize = true;
            this.EmAberto_RB.Checked = true;
            this.EmAberto_RB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EmAberto_RB.Location = new System.Drawing.Point(36, 227);
            this.EmAberto_RB.Name = "EmAberto_RB";
            this.EmAberto_RB.Size = new System.Drawing.Size(77, 15);
            this.EmAberto_RB.TabIndex = 37;
            this.EmAberto_RB.TabStop = true;
            this.EmAberto_RB.Text = "Em aberto";
            this.EmAberto_RB.UseSelectable = true;
            // 
            // CadastrarMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 318);
            this.Controls.Add(this.EmAberto_RB);
            this.Controls.Add(this.Pago_RB);
            this.Controls.Add(this.DataPagamento_DT);
            this.Controls.Add(this.DataPagamento_LBL);
            this.Controls.Add(this.ValorMensalidade_TB);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.ValorMensalidade_LBL);
            this.Controls.Add(this.Cliente_TB);
            this.Controls.Add(this.Cliente_LBL);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.Id_LBL);
            this.Controls.Add(this.Id_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarMensalidade";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Cadastrar mensalidade";
            this.Load += new System.EventHandler(this.CadastrarMensalidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Label ValorMensalidade_LBL;
        private System.Windows.Forms.TextBox Cliente_TB;
        private System.Windows.Forms.Label Cliente_LBL;
        private MetroFramework.Controls.MetroButton Salvar_Button;
        private System.Windows.Forms.Label Id_LBL;
        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.TextBox ValorMensalidade_TB;
        private System.Windows.Forms.Label DataPagamento_LBL;
        private System.Windows.Forms.DateTimePicker DataPagamento_DT;
        private MetroFramework.Controls.MetroRadioButton Pago_RB;
        private MetroFramework.Controls.MetroRadioButton EmAberto_RB;
    }
}