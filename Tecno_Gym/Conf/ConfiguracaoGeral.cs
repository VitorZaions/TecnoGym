using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecno_Gym.Conf
{
    public partial class ConfiguracaoGeral : MetroForm
    {
        public ConfiguracaoGeral()
        {
            InitializeComponent();
        }

        private void ConfiguracaoGeral_Load(object sender, EventArgs e)
        {
            carregar_valor();
        }

        void carregar_valor()
        {
            try
            {
                if (Properties.Settings.Default["valor_mensalidade"] != null || Convert.ToDouble(Properties.Settings.Default["valor_mensalidade"]) != 0)
                {
                    Valor_TB.Text = Convert.ToString(Properties.Settings.Default["valor_mensalidade"]);
                }
            }
            catch
            {
                //nada
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if(Valor_TB.Text != "" || Valor_TB.Text != ".")
            {
              string valor = Valor_TB.Text.Replace(".", ",");
              Properties.Settings.Default["valor_mensalidade"] = Convert.ToDouble(valor);
              Properties.Settings.Default.Save(); // Saves settings in application configuration file
              this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nInsira o valor da mensalidade.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
