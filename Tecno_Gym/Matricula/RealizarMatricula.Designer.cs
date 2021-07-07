namespace Tecno_Gym.Matricula
{
    partial class RealizarMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarMatricula));
            this.Cliente_Button = new MetroFramework.Controls.MetroButton();
            this.DataInicial_DT = new System.Windows.Forms.DateTimePicker();
            this.DataInicial_LBL = new System.Windows.Forms.Label();
            this.Cliente_LBL = new System.Windows.Forms.Label();
            this.Cliente_TB = new System.Windows.Forms.TextBox();
            this.Salvar_Button = new MetroFramework.Controls.MetroButton();
            this.Id_LBL = new System.Windows.Forms.Label();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.DataFinal_DT = new System.Windows.Forms.DateTimePicker();
            this.DataFinal_LBL = new System.Windows.Forms.Label();
            this.GerarMensalidades_DT = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Cliente_Button
            // 
            this.Cliente_Button.Location = new System.Drawing.Point(461, 112);
            this.Cliente_Button.Name = "Cliente_Button";
            this.Cliente_Button.Size = new System.Drawing.Size(28, 23);
            this.Cliente_Button.TabIndex = 23;
            this.Cliente_Button.Text = "🧑";
            this.Cliente_Button.UseSelectable = true;
            this.Cliente_Button.Click += new System.EventHandler(this.Cliente_Button_Click);
            // 
            // DataInicial_DT
            // 
            this.DataInicial_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicial_DT.Location = new System.Drawing.Point(36, 183);
            this.DataInicial_DT.Name = "DataInicial_DT";
            this.DataInicial_DT.Size = new System.Drawing.Size(204, 24);
            this.DataInicial_DT.TabIndex = 22;
            // 
            // DataInicial_LBL
            // 
            this.DataInicial_LBL.AutoSize = true;
            this.DataInicial_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicial_LBL.Location = new System.Drawing.Point(33, 161);
            this.DataInicial_LBL.Name = "DataInicial_LBL";
            this.DataInicial_LBL.Size = new System.Drawing.Size(89, 18);
            this.DataInicial_LBL.TabIndex = 21;
            this.DataInicial_LBL.Text = "* Data inicial";
            // 
            // Cliente_LBL
            // 
            this.Cliente_LBL.AutoSize = true;
            this.Cliente_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_LBL.Location = new System.Drawing.Point(167, 88);
            this.Cliente_LBL.Name = "Cliente_LBL";
            this.Cliente_LBL.Size = new System.Drawing.Size(63, 18);
            this.Cliente_LBL.TabIndex = 20;
            this.Cliente_LBL.Text = "* Cliente";
            // 
            // Cliente_TB
            // 
            this.Cliente_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente_TB.Location = new System.Drawing.Point(170, 112);
            this.Cliente_TB.Name = "Cliente_TB";
            this.Cliente_TB.ReadOnly = true;
            this.Cliente_TB.Size = new System.Drawing.Size(285, 24);
            this.Cliente_TB.TabIndex = 19;
            // 
            // Salvar_Button
            // 
            this.Salvar_Button.Location = new System.Drawing.Point(353, 253);
            this.Salvar_Button.Name = "Salvar_Button";
            this.Salvar_Button.Size = new System.Drawing.Size(136, 45);
            this.Salvar_Button.TabIndex = 18;
            this.Salvar_Button.Text = "Salvar";
            this.Salvar_Button.UseSelectable = true;
            this.Salvar_Button.Click += new System.EventHandler(this.Salvar_Button_Click);
            // 
            // Id_LBL
            // 
            this.Id_LBL.AutoSize = true;
            this.Id_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_LBL.Location = new System.Drawing.Point(33, 88);
            this.Id_LBL.Name = "Id_LBL";
            this.Id_LBL.Size = new System.Drawing.Size(56, 18);
            this.Id_LBL.TabIndex = 17;
            this.Id_LBL.Text = "Código";
            // 
            // Id_TB
            // 
            this.Id_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_TB.Location = new System.Drawing.Point(36, 112);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(104, 24);
            this.Id_TB.TabIndex = 16;
            // 
            // DataFinal_DT
            // 
            this.DataFinal_DT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFinal_DT.Location = new System.Drawing.Point(285, 183);
            this.DataFinal_DT.Name = "DataFinal_DT";
            this.DataFinal_DT.Size = new System.Drawing.Size(204, 24);
            this.DataFinal_DT.TabIndex = 25;
            // 
            // DataFinal_LBL
            // 
            this.DataFinal_LBL.AutoSize = true;
            this.DataFinal_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFinal_LBL.Location = new System.Drawing.Point(282, 161);
            this.DataFinal_LBL.Name = "DataFinal_LBL";
            this.DataFinal_LBL.Size = new System.Drawing.Size(79, 18);
            this.DataFinal_LBL.TabIndex = 24;
            this.DataFinal_LBL.Text = "* Data final";
            // 
            // GerarMensalidades_DT
            // 
            this.GerarMensalidades_DT.AutoSize = true;
            this.GerarMensalidades_DT.Checked = true;
            this.GerarMensalidades_DT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GerarMensalidades_DT.Enabled = false;
            this.GerarMensalidades_DT.Location = new System.Drawing.Point(36, 235);
            this.GerarMensalidades_DT.Name = "GerarMensalidades_DT";
            this.GerarMensalidades_DT.Size = new System.Drawing.Size(119, 17);
            this.GerarMensalidades_DT.TabIndex = 26;
            this.GerarMensalidades_DT.Text = "Gerar mensalidades";
            this.GerarMensalidades_DT.UseVisualStyleBackColor = true;
            // 
            // RealizarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 322);
            this.Controls.Add(this.GerarMensalidades_DT);
            this.Controls.Add(this.DataFinal_DT);
            this.Controls.Add(this.DataFinal_LBL);
            this.Controls.Add(this.Cliente_Button);
            this.Controls.Add(this.DataInicial_DT);
            this.Controls.Add(this.DataInicial_LBL);
            this.Controls.Add(this.Cliente_LBL);
            this.Controls.Add(this.Cliente_TB);
            this.Controls.Add(this.Salvar_Button);
            this.Controls.Add(this.Id_LBL);
            this.Controls.Add(this.Id_TB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RealizarMatricula";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Realizar matrícula";
            this.Load += new System.EventHandler(this.RealizarMatricula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton Cliente_Button;
        private System.Windows.Forms.DateTimePicker DataInicial_DT;
        private System.Windows.Forms.Label DataInicial_LBL;
        private System.Windows.Forms.Label Cliente_LBL;
        private System.Windows.Forms.TextBox Cliente_TB;
        private MetroFramework.Controls.MetroButton Salvar_Button;
        private System.Windows.Forms.Label Id_LBL;
        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.DateTimePicker DataFinal_DT;
        private System.Windows.Forms.Label DataFinal_LBL;
        private System.Windows.Forms.CheckBox GerarMensalidades_DT;
    }
}