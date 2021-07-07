using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecno_Gym.Aula
{
    public partial class CadastrarAula : MetroForm
    {
        int tipo_op = 0;
        int id_turma = 0;
        string nome_turma;
        Aula AulaCame;
        public CadastrarAula(int tipo)
        {
            InitializeComponent();
            tipo_op = tipo;
        }

        public CadastrarAula(int tipo, Aula aula)
        {
            InitializeComponent();
            tipo_op = tipo;
            AulaCame = aula;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(AulaCame.GetIdAula());
            Turma_TB.Text = AulaCame.GetNomeTurma();
            Data_DT.Value = AulaCame.GetDia();


            DateTime dt = new DateTime(2012, 01, 01);
            TimeSpan ts = new TimeSpan(1, 0, 0, 0, 0);
            dt = AulaCame.GetDia() + AulaCame.GetHora();
            Hora_DT.Value = dt;
            id_turma = AulaCame.GetIdTurma();
        }

        private void CadastrarAula_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if (Turma_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira uma TURMA para a aula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Aula Aul = new Aula();
                Aul.SetDia(Data_DT.Value);
                //mbe
                TimeSpan CurrentTime = Hora_DT.Value.TimeOfDay;
                TimeSpan newTimeSpan = new TimeSpan(CurrentTime.Hours, CurrentTime.Minutes, 0);
                Aul.SetHora(newTimeSpan);
                Aul.SetIdTurma(id_turma);                

                if(tipo_op == 0)
                {
                    Aul.novo();
                    this.Close();
                }
                else
                {
                    Aul.SetIdAula(Convert.ToInt32(Id_TB.Text));
                    Aul.atualizar();
                    this.Close();
                }

            }
        }

        private void Turma_Button_Click(object sender, EventArgs e)
        {
            SelecionarTurma SelecionarTur = new SelecionarTurma();
            SelecionarTur.ShowDialog();

            id_turma = SelecionarTur.selected_id;
            nome_turma = SelecionarTur.selected_nome;
            Turma_TB.Text = nome_turma;
        }
    }
}
