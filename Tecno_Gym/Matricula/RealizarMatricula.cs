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

namespace Tecno_Gym.Matricula
{
    public partial class RealizarMatricula : MetroForm
    {
        int tipo_op = 0;
        int id_cliente;
        string nome_cliente;


        public RealizarMatricula(int tipo)
        {            
            InitializeComponent();
            tipo_op = tipo;
        }

       /* public RealizarMatricula(int tipo, Matricula Mat)
        {
            InitializeComponent();
            tipo_op = tipo;
            MatCame = Mat;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(MatCame.GetIdMatricula());
            nome_cliente = MatCame.GetNomeCliente();
            Cliente_TB.Text = nome_cliente;
            DataInicial_DT.Value = MatCame.GetDataInicial();
            DataFinal_DT.Value = MatCame.GetDataFinal();
            id_cliente = MatCame.GetIdCliente();          
        }*/

        private void RealizarMatricula_Load(object sender, EventArgs e)
        {
                try
                {
                    if (Properties.Settings.Default["valor_mensalidade"] != null && Convert.ToDouble(Properties.Settings.Default["valor_mensalidade"]) != 0)
                        GerarMensalidades_DT.Enabled = true;
                }
                catch
                {
                //nada
                }
        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if (Cliente_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira um cliente para a matrícula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DataInicial_DT.Value == null)
                MetroMessageBox.Show(this, "\n\nInsira a data inicial da matrícula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DataFinal_DT.Value == null)
                MetroMessageBox.Show(this, "\n\nInsira a data final da matrícula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

                Matricula Matri = new Matricula();
                Matri.SetIdCliente(id_cliente);
                Matri.SetDataInicial(DataInicial_DT.Value);
                Matri.SetDataFinal(DataFinal_DT.Value);

                //if (tipo_op == 0) // novo
               // {
                    Matri.novo();

                    if (GerarMensalidades_DT.Checked == true)
                    {
                        string DataInicial = DataInicial_DT.Value.ToShortDateString();
                        string DataFinal = DataFinal_DT.Value.ToShortDateString();

                        DateTime DataInicial1 = Convert.ToDateTime(DataInicial);
                        DateTime DataFinal1 = Convert.ToDateTime(DataFinal);

                        for (DateTime i = DataInicial1 ; i <= DataFinal1; )
                        {
                            Mensalidade.Mensalidade Mensa = new Mensalidade.Mensalidade();
                            Mensa.SetIdCliente(id_cliente);
                            Mensa.SetStatus(0);
                            Mensa.SetValorMensalidade(Convert.ToDouble(Properties.Settings.Default["valor_mensalidade"]));
                            Mensa.SetDataPagamento(i);
                            Mensa.novo();
                            i = i.AddMonths(1);
                        }
                    MetroMessageBox.Show(this, "\n\nMatrícula realizada com sucesso, assim como gerado as mensalidades do cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                    this.Close();
                //}
                /*else
                {
                    Matri.SetIdMatricula(Convert.ToInt32(Id_TB.Text));
                    Matri.atualizar();

                    if (GerarMensalidades_DT.Checked == true)
                    {
                    }

                    this.Close();

                }*/
            }
            
        }

        private void Cliente_Button_Click(object sender, EventArgs e)
        {
            SelecionarCliente SelecionarCli = new SelecionarCliente();
            SelecionarCli.ShowDialog();

            id_cliente = SelecionarCli.selected_id;
            nome_cliente = SelecionarCli.selected_nome;
            Cliente_TB.Text = nome_cliente;
        }
    }
}
