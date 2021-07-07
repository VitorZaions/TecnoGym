using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace Tecno_Gym.Login
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            TestConnection();

            try
            {
                if (Properties.Settings.Default["login"] != null)
                {
                    Login_TB.Text = Properties.Settings.Default["login"].ToString();
                    SalvarSenha_CB.Checked = true;
                    Senha_TB.Focus();
                   // Senha_TB.Click();
                    Senha_TB.Select();
                }
            }
            catch
            {
                //nada
            }
        }

        private void TestConnection()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                con.Open();
                if (con.State != ConnectionState.Open)
                {
                    MetroMessageBox.Show(this, "\n\nFalha ao se conectar com o banco de dados, entre em contato com um administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if(Login_TB.Text == "")
            {
                MetroMessageBox.Show(this, "\n\nInsira seu login para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Senha_TB.Text == "")
            {
                MetroMessageBox.Show(this, "\n\nInsira sua senha para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(SalvarSenha_CB.Checked == true){ 
                    Properties.Settings.Default["login"] = Login_TB.Text;
                    Properties.Settings.Default.Save(); // Saves settings in application configuration file
                }

                string[] infos = { Login_TB.Text, Senha_TB.Text };
                Pessoas.Funcionario Funcionario = new Pessoas.Funcionario();
                if (Funcionario.DoLogin(infos) == true)
                {
                    // abrir tela de login
                    Main_Form Main = new Main_Form(Funcionario);
                    Main.Show();
                    this.Visible = false;
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nUsuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            }
        }
    }

