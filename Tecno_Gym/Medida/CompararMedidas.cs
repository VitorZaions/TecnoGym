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

namespace Tecno_Gym.Avaliacao_Fisica
{
    public partial class CompararMedidas : MetroForm
    {
        Medida.Medida Medida1 = new Medida.Medida();
        Medida.Medida Medida2 = new Medida.Medida();
        public CompararMedidas(Medida.Medida Med1, Medida.Medida Med2)
        {
            InitializeComponent();
            Medida1 = Med1;
            Medida2 = Med2;
            ExecutarComparacao();

        }

        private void CompararMedidas_Load(object sender, EventArgs e)
        {

        }

        void ExecutarComparacao()
        {
            double altura1 = Medida1.GetAltura();
            double altura2 = Medida2.GetAltura();
            double peitoral1 = Medida1.GetPeitoral();
            double peitoral2 = Medida2.GetPeitoral();
            double braçoesq1 = Medida1.GetBrc_esquerdo();
            double braçoesq2 = Medida2.GetBrc_esquerdo();
            double braçodir1 = Medida1.GetBrc_direito();
            double braçodir2 = Medida2.GetBrc_direito();
            double pantdireita1 = Medida1.GetPnt_direita();
            double pantdireita2 = Medida2.GetPnt_direita();
            double pantesquerda1 = Medida1.GetPnt_esquerda();
            double pantesquerda2 = Medida2.GetPnt_esquerda();
            double quadril1 = Medida1.GetQuadril();
            double quadril2 = Medida2.GetQuadril();
            double coxadireita1 = Medida1.GetCoxa_direita();
            double coxadireita2 = Medida2.GetCoxa_direita();
            double coxaesquerda1 = Medida1.GetCoxa_esquerda();
            double coxaesquerda2 = Medida2.GetCoxa_esquerda();
            DateTime data1 = Medida1.GetDataMedida();
            DateTime data2 = Medida1.GetDataMedida();

            if (coxaesquerda1 > coxaesquerda2)
            {
                Status_CoxaEsq1.BackColor = Color.Green;
                Status_CoxaEsq2.BackColor = Color.Red;
            }
            else if (coxaesquerda1 < coxaesquerda2)
            {
                Status_CoxaEsq1.BackColor = Color.Red;
                Status_CoxaEsq2.BackColor = Color.Green;
            }

            if (coxadireita1 > coxadireita2)
            {
                Status_CoxaDir1.BackColor = Color.Green;
                Status_CoxaDir2.BackColor = Color.Red;
            }
            else if (coxadireita1 < coxadireita2)
            {
                Status_CoxaDir1.BackColor = Color.Red;
                Status_CoxaDir2.BackColor = Color.Green;
            }

            if (quadril1 > quadril2)
            {
                Status_Quadril1.BackColor = Color.Green;
                Status_Quadril2.BackColor = Color.Red;
            }
            else if (quadril1 < quadril2)
            {
                Status_Quadril1.BackColor = Color.Red;
                Status_Quadril2.BackColor = Color.Green;
            }

            if (pantesquerda1 > pantesquerda2)
            {
                Status_PantEsq1.BackColor = Color.Green;
                Status_PantEsq2.BackColor = Color.Red;
            }
            else if (pantesquerda1 < pantesquerda2)
            {
                Status_PantEsq1.BackColor = Color.Red;
                Status_PantEsq2.BackColor = Color.Green;
            }

            if (pantdireita1 > pantdireita2)
            {
                Status_PantDir1.BackColor = Color.Green;
                Status_PantDir2.BackColor = Color.Red;
            }
            else if (pantdireita1 < pantdireita2)
            {
                Status_PantDir1.BackColor = Color.Red;
                Status_PantDir2.BackColor = Color.Green;
            }

            if (braçodir1 > braçodir2)
            {
                Status_BraçoDir1.BackColor = Color.Green;
                Status_BraçoDir2.BackColor = Color.Red;
            }
            else if (braçodir1 < braçodir2)
            {
                Status_BraçoDir1.BackColor = Color.Red;
                Status_BraçoDir2.BackColor = Color.Green;
            }



            if (braçoesq1 > braçoesq2)
            {
                Status_BraçoEsq1.BackColor = Color.Green;
                Status_BraçoEsq2.BackColor = Color.Red;
            }
            else if (braçoesq1 < braçoesq2)
            {
                Status_BraçoEsq1.BackColor = Color.Red;
                Status_BraçoEsq2.BackColor = Color.Green;
            }
            
            if(peitoral1 > peitoral2)
            {
                Status_Peitoral1.BackColor = Color.Green;
                Status_Peitoral2.BackColor = Color.Red;
            }
            else if (peitoral1 < peitoral2)
            {
                Status_Peitoral1.BackColor = Color.Red;
                Status_Peitoral2.BackColor = Color.Green;
            }


            if(altura1 > altura2)
            {
                Status_Altura1.BackColor = Color.Green;
                Status_Altura2.BackColor = Color.Red;
            }
            else if (altura1 < altura2)
            {
                Status_Altura1.BackColor = Color.Red;
                Status_Altura2.BackColor = Color.Green;
            }

            Cliente1_TB.Text = Medida1.GetNomeCliente();
            Cliente2_TB.Text = Medida2.GetNomeCliente();
            Altura1.Text = Convert.ToString(Medida1.GetAltura());
            Peitoral1.Text = Convert.ToString(Medida1.GetPeitoral());
            BraçoDir1.Text = Convert.ToString(Medida1.GetBrc_direito());
            BraçoEsq1.Text = Convert.ToString(Medida1.GetBrc_esquerdo());
            PantDir1.Text = Convert.ToString(Medida1.GetPnt_direita());
            PantEsq1.Text = Convert.ToString(Medida1.GetPnt_esquerda());
            Quadril1.Text = Convert.ToString(Medida1.GetQuadril());
            CoxaDir1.Text = Convert.ToString(Medida1.GetCoxa_direita());
            CoxaEsq1.Text = Convert.ToString(Medida1.GetCoxa_esquerda());
            DataMedida1.Text = Medida1.GetDataMedida().ToShortDateString();

            Altura2.Text = Convert.ToString(Medida2.GetAltura());
            Peitoral2.Text = Convert.ToString(Medida2.GetPeitoral());
            BraçoDir2.Text = Convert.ToString(Medida2.GetBrc_direito());
            BraçoEsq2.Text = Convert.ToString(Medida2.GetBrc_esquerdo());
            PantDir2.Text = Convert.ToString(Medida2.GetPnt_direita());
            PantEsq2.Text = Convert.ToString(Medida2.GetPnt_esquerda());
            Quadril2.Text = Convert.ToString(Medida2.GetQuadril());
            CoxaDir2.Text = Convert.ToString(Medida2.GetCoxa_direita());
            CoxaEsq2.Text = Convert.ToString(Medida2.GetCoxa_esquerda());
            DataMedida2.Text = Medida2.GetDataMedida().ToShortDateString();


        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
