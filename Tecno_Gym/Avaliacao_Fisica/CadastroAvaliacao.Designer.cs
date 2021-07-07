namespace Tecno_Gym.Turma
{
    partial class CadastroAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAvaliacao));
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.Cliente_LBL = new System.Windows.Forms.Label();
            this.Cliente_TB = new System.Windows.Forms.TextBox();
            this.Data_LBL = new System.Windows.Forms.Label();
            this.Data_DT = new System.Windows.Forms.DateTimePicker();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Hora_DT = new System.Windows.Forms.DateTimePicker();
            this.Hora_LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(36, 110);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(202, 24);
            this.Id_TB.TabIndex = 5;
            // 
            // Id_LBL
            // 
            this.Id_LBL.AutoSize = true;
            this.Id_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_LBL.Location = new System.Drawing.Point(33, 86);
            this.Id_LBL.Name = "Id_LBL";
            this.Id_LBL.Size = new System.Drawing.Size(56, 18);
            this.Id_LBL.TabIndex = 6;
            this.Id_LBL.Text = "Código";
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
            // Cliente_LBL
            // 
            this.Cliente_LBL.AutoSize = true;
            this.Cliente_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_LBL.Location = new System.Drawing.Point(259, 89);
            this.Cliente_LBL.Name = "Cliente_LBL";
            this.Cliente_LBL.Size = new System.Drawing.Size(63, 18);
            this.Cliente_LBL.TabIndex = 9;
            this.Cliente_LBL.Text = "* Cliente";
            // 
            // Cliente_TB
            // 
            this.Cliente_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_TB.Location = new System.Drawing.Point(262, 110);
            this.Cliente_TB.Name = "Cliente_TB";
            this.Cliente_TB.ReadOnly = true;
            this.Cliente_TB.Size = new System.Drawing.Size(193, 24);
            this.Cliente_TB.TabIndex = 8;
            // 
            // Data_LBL
            // 
            this.Data_LBL.AutoSize = true;
            this.Data_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_LBL.Location = new System.Drawing.Point(33, 163);
            this.Data_LBL.Name = "Data_LBL";
            this.Data_LBL.Size = new System.Drawing.Size(49, 18);
            this.Data_LBL.TabIndex = 11;
            this.Data_LBL.Text = "* Data";
            // 
            // Data_DT
            // 
            this.Data_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_DT.Location = new System.Drawing.Point(36, 183);
            this.Data_DT.Name = "Data_DT";
            this.Data_DT.Size = new System.Drawing.Size(202, 24);
            this.Data_DT.TabIndex = 13;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(461, 110);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(28, 23);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "🧑";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Hora_DT
            // 
            this.Hora_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_DT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hora_DT.Location = new System.Drawing.Point(262, 183);
            this.Hora_DT.Name = "Hora_DT";
            this.Hora_DT.Size = new System.Drawing.Size(227, 24);
            this.Hora_DT.TabIndex = 17;
            // 
            // Hora_LBL
            // 
            this.Hora_LBL.AutoSize = true;
            this.Hora_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_LBL.Location = new System.Drawing.Point(259, 163);
            this.Hora_LBL.Name = "Hora_LBL";
            this.Hora_LBL.Size = new System.Drawing.Size(51, 18);
            this.Hora_LBL.TabIndex = 16;
            this.Hora_LBL.Text = "* Hora";
            // 
            // CadastroAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 322);
            this.Controls.Add(this.Hora_DT);
            this.Controls.Add(this.Hora_LBL);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Data_DT);
            this.Controls.Add(this.Data_LBL);
            this.Controls.Add(this.Cliente_LBL);
            this.Controls.Add(this.Cliente_TB);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.Id_LBL);
            this.Controls.Add(this.Id_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroAvaliacao";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Cadastrar avaliacão física";
            this.Load += new System.EventHandler(this.CadastroAvaliacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.Label Id_LBL;
        private MetroFramework.Controls.MetroButton Salvar_Button;
        private System.Windows.Forms.Label Cliente_LBL;
        private System.Windows.Forms.TextBox Cliente_TB;
        private System.Windows.Forms.Label Data_LBL;
        private System.Windows.Forms.DateTimePicker Data_DT;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DateTimePicker Hora_DT;
        private System.Windows.Forms.Label Hora_LBL;
    }
}