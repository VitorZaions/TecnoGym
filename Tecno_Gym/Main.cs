using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Tecno_Gym
{
    partial class Main_Form : MetroForm
    {
        Pessoas.Funcionario FuncionarioWorking;
        public Main_Form(Pessoas.Funcionario FuncionarioCame)
        {
            InitializeComponent();
            FuncionarioWorking = FuncionarioCame;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pessoas.ListarFuncionarios ListarFunc = new Pessoas.ListarFuncionarios();
            ListarFunc.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido.ListarCategorias ListarCat = new Pedido.ListarCategorias();
            ListarCat.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Pedido.ListarCategorias ListarCat = new Pedido.ListarCategorias();
            ListarCat.Show();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido.ListarPedidos ListarPed = new Pedido.ListarPedidos();
            ListarPed.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Pedido.ListarFornecedores ListarFor = new Pedido.ListarFornecedores();
            ListarFor.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Pessoas.ListarClientes ListarCli = new Pessoas.ListarClientes();
            ListarCli.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (FuncionarioWorking.GetAdmin() == true)
            {
                Pessoas.ListarFuncionarios ListarFu = new Pessoas.ListarFuncionarios();
                ListarFu.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nVocê não é administrador, acesso negado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Medida.ListarMedidas ListarMed = new Medida.ListarMedidas();
            ListarMed.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Turma.ListarTurma ListarTur = new Turma.ListarTurma();
            ListarTur.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            AvaliacaoFisica.ListarAvaliacoesFisicas ListarAF = new AvaliacaoFisica.ListarAvaliacoesFisicas();
            ListarAF.Show();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            Mensalidade.ListarMensalidades ListarMen = new Mensalidade.ListarMensalidades();
            ListarMen.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            if (FuncionarioWorking.GetAdmin() == true)
            {
                Contas.ListarContasPagar ListarConP = new Contas.ListarContasPagar();
                ListarConP.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nVocê não é administrador, acesso negado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            if (FuncionarioWorking.GetAdmin() == true)
            {
                Contas.ListarContasReceber ListarConR = new Contas.ListarContasReceber();
                ListarConR.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "\n\nVocê não é administrador, acesso negado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Pedido.ListarProdutos ListarProd = new Pedido.ListarProdutos();
            ListarProd.Show();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matricula.ListarMatriculas ListarMat = new Matricula.ListarMatriculas();
            ListarMat.Show();
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aula.ListarAulas ListarAu = new Aula.ListarAulas();
            ListarAu.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.RelatorioCliente RelatorioA = new Relatorios.RelatorioCliente();
            RelatorioA.Show();
        }

        private void aPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mensalidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.RelatorioAulas RelatorioA = new Relatorios.RelatorioAulas();
            RelatorioA.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.RelatorioAvaliacoesFisicas RelatorioF = new Relatorios.RelatorioAvaliacoesFisicas();
            RelatorioF.Show();
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.RelatorioFluxoFinanceiro RelatorioF = new Relatorios.RelatorioFluxoFinanceiro();
            RelatorioF.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.RelatorioFuncionarios RelatorioF = new Relatorios.RelatorioFuncionarios();
            RelatorioF.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conf.ConfiguracaoGeral conf = new Conf.ConfiguracaoGeral();
            conf.Show();
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contas.InformacoesFluxo InfoFluxo = new Contas.InformacoesFluxo();
            InfoFluxo.Show();
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            Pedido.ListarPedidos ListarPed = new Pedido.ListarPedidos();
            ListarPed.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
