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

namespace Tecno_Gym.Pedido
{
    public partial class CadastrarCategoria : MetroForm
    {
        int tipo_op = 0;
        Categoria CatCame;
        public CadastrarCategoria(int tipo)
        {
            InitializeComponent();
            tipo_op = tipo;
        }

        public CadastrarCategoria(int tipo, Categoria Cat)
        {
            InitializeComponent();
            tipo_op = tipo;
            CatCame = Cat;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(CatCame.GetIdCategoria());
            Nome_TB.Text = CatCame.GetNome();
        }

        private void CadastrarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if (Nome_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o nome da categoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Categoria Cat = new Categoria();
            if (tipo_op == 0)
            {  
                Cat.SetNome(Nome_TB.Text);
                Cat.novo();
                this.Close();
            }
            else
            {
                Cat.SetIdCategoria(Convert.ToInt32(Id_TB.Text));
                Cat.SetNome(Nome_TB.Text);
                Cat.atualizar();
                this.Close();
            }

        }
    }
}
