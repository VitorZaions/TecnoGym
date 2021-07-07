namespace Tecno_Gym.Aula
{
    partial class CadastrarAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarAula));
            this.Turma_Button = new MetroFramework.Controls.MetroButton();
            this.Data_LBL = new System.Windows.Forms.Label();
            this.Turma_TB = new System.Windows.Forms.TextBox();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.Turma_LBL = new System.Windows.Forms.Label();
            this.Data_DT = new System.Windows.Forms.DateTimePicker();
            this.Hora_DT = new System.Windows.Forms.DateTimePicker();
            this.Hora_LBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Turma_Button
            // 
            this.Turma_Button.Location = new System.Drawing.Point(470, 111);
            this.Turma_Button.Name = "Turma_Button";
            this.Turma_Button.Size = new System.Drawing.Size(28, 23);
            this.Turma_Button.TabIndex = 20;
            this.Turma_Button.Text = "📘";
            this.Turma_Button.UseSelectable = true;
            this.Turma_Button.Click += new System.EventHandler(this.Turma_Button_Click);
            // 
            // Data_LBL
            // 
            this.Data_LBL.AutoSize = true;
            this.Data_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_LBL.Location = new System.Drawing.Point(33, 163);
            this.Data_LBL.Name = "Data_LBL";
            this.Data_LBL.Size = new System.Drawing.Size(49, 18);
            this.Data_LBL.TabIndex = 19;
            this.Data_LBL.Text = "* Data";
            // 
            // Turma_TB
            // 
            this.Turma_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turma_TB.Location = new System.Drawing.Point(271, 110);
            this.Turma_TB.Name = "Turma_TB";
            this.Turma_TB.ReadOnly = true;
            this.Turma_TB.Size = new System.Drawing.Size(193, 24);
            this.Turma_TB.TabIndex = 18;
            // 
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(362, 254);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 45);
            this.Salvar_Button.TabIndex = 15;
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
            this.Id_LBL.TabIndex = 14;
            this.Id_LBL.Text = "Código";
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(36, 110);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(202, 24);
            this.Id_TB.TabIndex = 13;
            // 
            // Turma_LBL
            // 
            this.Turma_LBL.AutoSize = true;
            this.Turma_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turma_LBL.Location = new System.Drawing.Point(268, 86);
            this.Turma_LBL.Name = "Turma_LBL";
            this.Turma_LBL.Size = new System.Drawing.Size(61, 18);
            this.Turma_LBL.TabIndex = 22;
            this.Turma_LBL.Text = "* Turma";
            // 
            // Data_DT
            // 
            this.Data_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_DT.Location = new System.Drawing.Point(36, 184);
            this.Data_DT.Name = "Data_DT";
            this.Data_DT.Size = new System.Drawing.Size(202, 24);
            this.Data_DT.TabIndex = 23;
            // 
            // Hora_DT
            // 
            this.Hora_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_DT.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hora_DT.Location = new System.Drawing.Point(271, 184);
            this.Hora_DT.Name = "Hora_DT";
            this.Hora_DT.Size = new System.Drawing.Size(227, 24);
            this.Hora_DT.TabIndex = 25;
            // 
            // Hora_LBL
            // 
            this.Hora_LBL.AutoSize = true;
            this.Hora_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora_LBL.Location = new System.Drawing.Point(268, 163);
            this.Hora_LBL.Name = "Hora_LBL";
            this.Hora_LBL.Size = new System.Drawing.Size(51, 18);
            this.Hora_LBL.TabIndex = 24;
            this.Hora_LBL.Text = "* Hora";
            // 
            // CadastrarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 322);
            this.Controls.Add(this.Hora_DT);
            this.Controls.Add(this.Hora_LBL);
            this.Controls.Add(this.Data_DT);
            this.Controls.Add(this.Turma_LBL);
            this.Controls.Add(this.Turma_Button);
            this.Controls.Add(this.Data_LBL);
            this.Controls.Add(this.Turma_TB);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.Id_LBL);
            this.Controls.Add(this.Id_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastrarAula";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Cadastrar Aula";
            this.Load += new System.EventHandler(this.CadastrarAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Turma_Button;
        private System.Windows.Forms.Label Data_LBL;
        private System.Windows.Forms.TextBox Turma_TB;
        private MetroFramework.Controls.MetroButton Salvar_Button;
        private System.Windows.Forms.Label Id_LBL;
        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.Label Turma_LBL;
        private System.Windows.Forms.DateTimePicker Data_DT;
        private System.Windows.Forms.DateTimePicker Hora_DT;
        private System.Windows.Forms.Label Hora_LBL;
    }
}