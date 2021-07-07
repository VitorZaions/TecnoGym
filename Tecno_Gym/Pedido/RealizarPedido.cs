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

namespace Tecno_Gym.Pedido
{
    public partial class RealizarPedido : MetroForm
    {
        int tipo_op = 0;
        int id_cliente = 0;
        int id_produto = 0;
        double valor_total = 0;
        Pedido PedCame;
        public RealizarPedido(int tipo)
        {
            InitializeComponent();
            tipo_op = tipo;
            Desc_TB.ReadOnly = false;
            Desc_TB.Enabled = true;
        }



        public RealizarPedido(int tipo, Pedido Ped)
        {
            InitializeComponent();
            tipo_op = tipo;
            PedCame = Ped;
            CompletarCampos();
        }

        void CompletarCampos()
        {
            Id_TB.Text = Convert.ToString(PedCame.GetIdPedido());
            Desc_TB.Text = PedCame.GetDescricao();
            Desc_TB.ReadOnly = false;
            Desc_TB.Enabled = true;
            DataPedido_DT.Value = PedCame.GetData();
            ValorTotalValor_LBL.Text = Convert.ToString(PedCame.GetValorTotal());
            valor_total = PedCame.GetValorTotal();

            string tipo_pagamento = PedCame.GetTipoPagamento();

            if (tipo_pagamento == "Boleto")
            {
                Boleto_RB.Checked = true;
            }
            else if (tipo_pagamento == "Cartao")
            {
                Cartao_RB.Checked = true;
            }
            else // "À Vista"
            {
                Avista_RB.Checked = true;
            }

            Cliente_TB.Text = PedCame.GetNomeCliente();
            id_cliente = PedCame.GetIdCliente();
        }

        private void RealizarPedido_Load(object sender, EventArgs e)
        {
            if(tipo_op == 0)
                Salvar_Button.Text = "Iniciar pedido";
            else
                Salvar_Button.Text = "Salvar";
        }

        private void Salvar_Button_Click(object sender, EventArgs e)
        {
            if(Desc_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira uma descrição para o pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if(Cliente_TB.Text == "")
                MetroMessageBox.Show(this, "\n\nInsira um cliente para o pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //else if(Grid_Produtos.Rows != null && Grid_Produtos.Rows.Count != 0)
            //    MetroMessageBox.Show(this, "\n\nInsira pelo menos um produto no pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Pedido ped = new Pedido();

                ped.SetDescricao(Desc_TB.Text);
                ped.SetValorTotal(valor_total);
                ped.SetData(DataPedido_DT.Value);
                ped.SetIdCliente(id_cliente);

                if (Boleto_RB.Checked == true)
                {
                    ped.SetTipoPagamento("Boleto");
                }
                else if (Cartao_RB.Checked == true)
                {
                    ped.SetTipoPagamento("Cartao");
                }
                else
                {
                    ped.SetTipoPagamento("À Vista");
                }

                if (tipo_op == 0)
                {
                    int id = ped.novo();
                    ped.SetIdPedido(id);
                    ped.SetNomeCliente(Cliente_TB.Text);
                    id_cliente = id;
                    MetroMessageBox.Show(this, "\n\nCadastro realizado com sucesso, agora você pode adicionar produtos ao pedido.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    PedCame = ped;

                    CompletarCampos();
                    tipo_op = 1;
                    Salvar_Button.Text = "Salvar";
                }
                else
                {
                    ped.SetIdPedido(Convert.ToInt32(Id_TB.Text));
                    ped.atualizar();
                    this.Close();
                }
            }

        }

        private void Grid_Produtos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cliente_Button_Click(object sender, EventArgs e)
        {
            SelecionarCliente SelecionarCli = new SelecionarCliente();
            SelecionarCli.ShowDialog();

            id_cliente = SelecionarCli.selected_id;
            Cliente_TB.Text = SelecionarCli.selected_nome;
        }

        private void metroTabPage6_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage5_Click(object sender, EventArgs e)
        {

        }

        private void metroTabControl2_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void Geral_TAB_Enter(object sender, EventArgs e)
        {  
            Salvar_Button.Visible = true;
            Salvar_Button.Enabled = true;
        }

        private void CarregarProdutos()
        {
            using (NpgsqlConnection con = Database.Database.GetConnection())
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT it.id_pedido,it.id_produto, prod.descrição, it.quantidade from item_pedido it INNER JOIN produto prod ON prod.id_produto = it.id_produto WHERE it.id_pedido = " + PedCame.GetIdPedido(), Database.Database.GetConnection());
                DataTable myTable = new System.Data.DataTable();
                da.Fill(myTable);
                Grid_Produtos.DataSource = myTable.DefaultView;
                con.Close();
            }
            Grid_Produtos.Columns[0].HeaderText = "Id";
            Grid_Produtos.Columns[1].HeaderText = "Id produto";
            Grid_Produtos.Columns[2].HeaderText = "Nome";
            Grid_Produtos.Columns[3].HeaderText = "Quantidade";
            Grid_Produtos.Columns[0].Visible = false;
            Grid_Produtos.Columns[1].Visible = false;
        }

        private void Produtos_TAB_Enter(object sender, EventArgs e)
        {
            Salvar_Button.Visible = false;
            Salvar_Button.Enabled = false;
           

            if (PedCame == null || PedCame.GetIdPedido() == 0)
            {
                RemoverProduto_Button.Enabled = false;
                AdicionarProduto_Button.Enabled = false;
                Pesquisa_Button.Enabled = false;
            }
            else // aqui dentro carregar grid
            {
                RemoverProduto_Button.Enabled = true;
                AdicionarProduto_Button.Enabled = true;
                Pesquisa_Button.Enabled = true;
                CarregarProdutos();
            }

        }

        private void Pesquisa_Button_Click(object sender, EventArgs e)
        {
            SelecionarProduto SelecionarProd = new SelecionarProduto();
            SelecionarProd.ShowDialog();

            IdProduto_TB.Text = SelecionarProd.selected_id.ToString();
        }

        private void IdProduto_TB_TextChanged(object sender, EventArgs e)
        {
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();
            foreach (var ch in this.IdProduto_TB.Text)
            {
                if (char.IsDigit(ch))
                {
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            if (enteredLetter)
            {
                StringBuilder sb = new StringBuilder();
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                this.IdProduto_TB.Text = sb.ToString();
                this.IdProduto_TB.SelectionStart = this.IdProduto_TB.Text.Length;
            }

            using (NpgsqlConnection con = Database.Database.GetConnection())
            {

                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT p.id_produto,p.descrição,p.estoque,p.valor,p.id_categoria,p.id_fornecedor,cat.nome,forne.nome from produto p INNER JOIN categoria cat ON p.id_categoria = cat.id_categoria INNER JOIN fornecedor forne ON p.id_fornecedor = forne.id_fornecedor WHERE p.id_produto = " + Convert.ToInt32(IdProduto_TB.Text), con);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    NomeProduto_TB.Text = dr["descrição"].ToString();
                    ValorProduto_TB.Text = dr["valor"].ToString();
                    id_produto = Convert.ToInt32(dr["id_produto"]);
                }
                else
                {
                    NomeProduto_TB.Text = "";
                    ValorProduto_TB.Text = "";
                    QuantidadeProduto_NUM.Value = 1;
                    id_produto = 0;
                }
                con.Close();
            }
        }

        private void AdicionarProduto_Button_Click(object sender, EventArgs e)
        {
            if (IdProduto_TB.Text != "" && NomeProduto_TB.Text != "" && ValorProduto_TB.Text != "")
            {                
                ItemPedido ItemP = new ItemPedido();
                ItemP.SetIdPedido(Convert.ToInt32(PedCame.GetIdPedido()));
                ItemP.SetIdProduto(Convert.ToInt32(IdProduto_TB.Text));
                ItemP.SetQuantidade(Convert.ToInt32(QuantidadeProduto_NUM.Value));
                

                if(ItemP.CheckProdutoExiste() == true)
                {
                    if(ItemP.CheckProdutoTemEstoque() == true)
                    {
                        if (QuantidadeProduto_NUM.Value <= ItemP.CheckQuantidadeEstoque())
                        {
                            if (ItemP.CheckProdutoEstaNoPedido() == false){
                                ItemP.novo();                                
                                ItemP.BaixaNoEstoque();
                                double valor_total_new = Convert.ToDouble(ValorProduto_TB.Text) * Convert.ToInt32(QuantidadeProduto_NUM.Value);
                                ItemP.AtualizarValorTotal(Convert.ToDouble(ValorProduto_TB.Text) * Convert.ToInt32(QuantidadeProduto_NUM.Value));
                                valor_total = valor_total + valor_total_new;
                                ValorTotalValor_LBL.Text = Convert.ToString(valor_total);
                                CarregarProdutos();
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "\n\nEste produto já está contido no pedido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "\n\nA quantidade selecionada é maior que o estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "\n\nEste produto não tem estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nEste produto não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // produto não existe
                }

            }
            else
            {
                MetroMessageBox.Show(this, "\n\nSelecione um produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void RemoverProduto_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "\n\nDeseja realmente excluir o registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (Grid_Produtos.SelectedCells.Count > 0)
                {
                    int selectedrowindex = Grid_Produtos.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = Grid_Produtos.Rows[selectedrowindex];
                    ItemPedido ItemP = new ItemPedido();
                    ItemP.SetIdPedido(Convert.ToInt32(selectedRow.Cells[0].Value));
                    ItemP.SetIdProduto(Convert.ToInt32(selectedRow.Cells[1].Value));
                    ItemP.SetQuantidade(Convert.ToInt32(selectedRow.Cells[3].Value));
                    double Valor_Prod = ItemP.GetValorValorProduto();
                    valor_total = valor_total - Valor_Prod * ItemP.GetQuantidade();
                    ItemP.AtualizarValorTotal(valor_total);
                    ValorTotalValor_LBL.Text = Convert.ToString(valor_total);
                    ItemP.excluir();
                    CarregarProdutos();
                }
                else
                {
                    MetroMessageBox.Show(this, "\n\nSelecione um produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
