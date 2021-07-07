namespace Tecno_Gym.Conf
{
    partial class ConfiguracaoGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracaoGeral));
            this.Geral = new System.Windows.Forms.GroupBox();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.Valor_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Geral.SuspendLayout();
            this.SuspendLayout();
            // 
            // Geral
            // 
            this.Geral.Controls.Add(this.label1);
            this.Geral.Controls.Add(this.Valor_TB);
            this.Geral.Location = new System.Drawing.Point(23, 77);
            this.Geral.Name = "Geral";
            this.Geral.Size = new System.Drawing.Size(225, 102);
            this.Geral.TabIndex = 0;
            this.Geral.TabStop = false;
            this.Geral.Text = "Financeiro";
            // 
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(112, 203);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 45);
            this.Salvar_Button.TabIndex = 19;
            this.Salvar_Button.Text = "Salvar";
            this.Salvar_Button.UseSelectable = true;
            this.Salvar_Button.Click += new System.EventHandler(this.Salvar_Button_Click);
            // 
            // Valor_TB
            // 
            this.Valor_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_TB.Location = new System.Drawing.Point(15, 60);
            this.Valor_TB.Name = "Valor_TB";
            this.Valor_TB.Size = new System.Drawing.Size(199, 24);
            this.Valor_TB.TabIndex = 0;
            this.Valor_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor da mensalidade";
            // 
            // ConfiguracaoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 277);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.Geral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfiguracaoGeral";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Configurações gerais";
            this.Load += new System.EventHandler(this.ConfiguracaoGeral_Load);
            this.Geral.ResumeLayout(false);
            this.Geral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Geral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Valor_TB;
        private MetroFramework.Controls.MetroButton Salvar_Button;
    }
}