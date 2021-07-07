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
    public partial class CadastrarProduto : MetroForm
    {
        int tipo_op = 0;
        int id_categoria = 0;
        int id_fornecedor = 0;
        Produto ProdutoCame;

        public CadastrarProduto(int tipo)
        {
            InitializeComponent();
            tipo_op = tipo;
        }

        public CadastrarProduto(int tipo, Produto Prod)
        {
            InitializeComponent();
            tipo_op = tipo;
            ProdutoCame = Prod;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(ProdutoCame.GetIdProduto());
            Nome_TB.Text = ProdutoCame.GetDescricao();
            Estoque_NUM.Value = ProdutoCame.GetEstoque();
            Valor_TB.Text = Convert.ToString(ProdutoCame.GetValor());
            Categoria_TB.Text = Convert.ToString(ProdutoCame.GetNomeCategoria());
            Fornecedor_TB.Text = Convert.ToString(ProdutoCame.GetNomeFornecedor());
            id_categoria = ProdutoCame.GetIdCategoria();
            id_fornecedor = ProdutoCame.GetIdFornecedor();
        }


        private void CadastrarProduto_Load(object sender, EventArgs e)
        {

        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if(Nome_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o nome do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(Valor_TB.Text == "" || Valor_TB.Text == ".")
                MetroMessageBox.Show(this, "\n\nInsira o valor do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(Categoria_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira a categoria do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(Fornecedor_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira o fornecedor do produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Produto Prod = new Produto();
                Prod.SetDescricao(Nome_TB.Text);
                Prod.SetCategoria(id_categoria);
                Prod.SetFornecedor(id_fornecedor);
                Prod.SetEstoque(Convert.ToInt32(Estoque_NUM.Value));
                Prod.SetValor(Convert.ToDouble(Valor_TB.Text));

                if (tipo_op == 0)
                {
                    Prod.novo();
                    this.Close();
                }
                else
                {
                    Prod.SetIdProduto(Convert.ToInt32(Id_TB.Text));
                    Prod.atualizar();
                    this.Close();
                }
            }
        }

        private void Valor_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Fornecedor_Button_Click(object sender, EventArgs e)
        {
            SelecionarFornecedor SelecionarFor = new SelecionarFornecedor();
            SelecionarFor.ShowDialog();

            id_fornecedor = SelecionarFor.selected_id;
            Fornecedor_TB.Text = SelecionarFor.selected_nome;
        }

        private void Categoria_Button_Click(object sender, EventArgs e)
        {
            SelecionarCategoria SelecionarCat = new SelecionarCategoria();
            SelecionarCat.ShowDialog();

            id_categoria = SelecionarCat.selected_id;
            Categoria_TB.Text = SelecionarCat.selected_nome;
        }
    }
}
