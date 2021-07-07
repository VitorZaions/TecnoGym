using MetroFramework;
using MetroFramework.Forms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tecno_Gym.Turma
{
    public partial class CadastroTurma : MetroForm
    {
        int id_funcio;
        int tipo_op = 0;
        Turma TurmaCame;

        public CadastroTurma(int tipo)
        {
            InitializeComponent();
            tipo_op = tipo;
        }

        public CadastroTurma(int tipo, Turma Tur)
        {
            InitializeComponent();
            tipo_op = tipo;
            TurmaCame = Tur;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(TurmaCame.GetIdTurma());
            Descricao_TB.Text = TurmaCame.GetDescricao();
            Responsavel_TB.Text = TurmaCame.GetNomeFuncionario();
            id_funcio = TurmaCame.GetIdFuncionario();
        }

        private void CadastroTurma_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if(Descricao_TB.Text == "")
            {
                MetroMessageBox.Show(this, "\n\nPreencha a descrição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Responsavel_TB.Text == "")
            {
                MetroMessageBox.Show(this, "\n\nSelecione um funcionário responsável.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Turma TurmaT = new Turma();
                TurmaT.SetDescricao(Descricao_TB.Text);
                TurmaT.SetIdFuncionario(id_funcio);

                if (tipo_op == 0) // novo cadastro
                {
                    TurmaT.novo();
                    this.Close();
                 }
                else // atualizar cadastro
                {
                    TurmaT.SetIdTurma(Convert.ToInt32(Id_TB.Text));
                    TurmaT.atualizar();
                    this.Close();
                }

            }


        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            SelecionarFuncionario SelecionarFun = new SelecionarFuncionario();
            SelecionarFun.ShowDialog();

            id_funcio = SelecionarFun.selected_id;
            Responsavel_TB.Text = SelecionarFun.selected_nome;
        }
    }
}
