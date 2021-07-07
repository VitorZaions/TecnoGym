namespace Tecno_Gym.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Senha_TB = new System.Windows.Forms.TextBox();
            this.Login_LBL = new System.Windows.Forms.Label();
            this.User_PB = new System.Windows.Forms.PictureBox();
            this.Senha_LBL = new System.Windows.Forms.Label();
            this.Login_Button = new MetroFramework.Controls.MetroButton();
            this.Desc_Label = new System.Windows.Forms.Label();
            this.Name_LBL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalvarSenha_CB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.User_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_TB
            // 
            this.Login_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_TB.Location = new System.Drawing.Point(402, 281);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.Size = new System.Drawing.Size(217, 24);
            this.Login_TB.TabIndex = 2;
            // 
            // Senha_TB
            // 
            this.Senha_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha_TB.Location = new System.Drawing.Point(402, 342);
            this.Senha_TB.Name = "Senha_TB";
            this.Senha_TB.PasswordChar = '*';
            this.Senha_TB.Size = new System.Drawing.Size(217, 24);
            this.Senha_TB.TabIndex = 3;
            // 
            // Login_LBL
            // 
            this.Login_LBL.AutoSize = true;
            this.Login_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_LBL.Location = new System.Drawing.Point(399, 260);
            this.Login_LBL.Name = "Login_LBL";
            this.Login_LBL.Size = new System.Drawing.Size(44, 18);
            this.Login_LBL.TabIndex = 4;
            this.Login_LBL.Text = "Login";
            // 
            // User_PB
            // 
            this.User_PB.Image = global::Tecno_Gym.Properties.Resources.profile;
            this.User_PB.Location = new System.Drawing.Point(421, 86);
            this.User_PB.Name = "User_PB";
            this.User_PB.Size = new System.Drawing.Size(158, 154);
            this.User_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.User_PB.TabIndex = 1;
            this.User_PB.TabStop = false;
            // 
            // Senha_LBL
            // 
            this.Senha_LBL.AutoSize = true;
            this.Senha_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha_LBL.Location = new System.Drawing.Point(399, 321);
            this.Senha_LBL.Name = "Senha_LBL";
            this.Senha_LBL.Size = new System.Drawing.Size(50, 18);
            this.Senha_LBL.TabIndex = 5;
            this.Senha_LBL.Text = "Senha";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(402, 395);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(217, 55);
            this.Login_Button.TabIndex = 7;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseSelectable = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // Desc_Label
            // 
            this.Desc_Label.AutoSize = true;
            this.Desc_Label.BackColor = System.Drawing.Color.Transparent;
            this.Desc_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc_Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Desc_Label.Location = new System.Drawing.Point(8, 45);
            this.Desc_Label.Name = "Desc_Label";
            this.Desc_Label.Size = new System.Drawing.Size(162, 18);
            this.Desc_Label.TabIndex = 1;
            this.Desc_Label.Text = "- Gestão de academias";
            // 
            // Name_LBL
            // 
            this.Name_LBL.AutoSize = true;
            this.Name_LBL.BackColor = System.Drawing.Color.Transparent;
            this.Name_LBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_LBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name_LBL.Location = new System.Drawing.Point(5, 9);
            this.Name_LBL.Name = "Name_LBL";
            this.Name_LBL.Size = new System.Drawing.Size(167, 33);
            this.Name_LBL.TabIndex = 0;
            this.Name_LBL.Text = "Tecno Gym";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tecno_Gym.Properties.Resources.academiaes;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 533);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.Name_LBL);
            this.panel1.Controls.Add(this.Desc_Label);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 77);
            this.panel1.TabIndex = 9;
            // 
            // SalvarSenha_CB
            // 
            this.SalvarSenha_CB.AutoSize = true;
            this.SalvarSenha_CB.Location = new System.Drawing.Point(402, 372);
            this.SalvarSenha_CB.Name = "SalvarSenha_CB";
            this.SalvarSenha_CB.Size = new System.Drawing.Size(81, 17);
            this.SalvarSenha_CB.TabIndex = 10;
            this.SalvarSenha_CB.Text = "Salvar login";
            this.SalvarSenha_CB.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 535);
            this.Controls.Add(this.SalvarSenha_CB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Senha_LBL);
            this.Controls.Add(this.Login_LBL);
            this.Controls.Add(this.Senha_TB);
            this.Controls.Add(this.Login_TB);
            this.Controls.Add(this.User_PB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.User_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox User_PB;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.TextBox Senha_TB;
        private System.Windows.Forms.Label Login_LBL;
        private System.Windows.Forms.Label Senha_LBL;
        private MetroFramework.Controls.MetroButton Login_Button;
        private System.Windows.Forms.Label Desc_Label;
        private System.Windows.Forms.Label Name_LBL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox SalvarSenha_CB;
    }
}