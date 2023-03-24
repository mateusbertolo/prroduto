using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Loja_Hardware
{
    public partial class form_produto : Form
    {
        public form_produto()
        {
            InitializeComponent();
        }



        private void limpar()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();
            txtMargemDeLucro.Clear();
            cbFornecedor.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
        }

        private void form_produto_Load(object sender, EventArgs e)
        {
            lbDataCadastro.Text = DateTime.Now.ToShortDateString();

            //CARREGAR COMBOBOX DO BD
            class_fornecedor cFornecedor = new class_fornecedor();
            cbFornecedor.DataSource = cFornecedor.BuscarFornecedor();
            //EXIBIR NA COMBO
            cbFornecedor.DisplayMember = "razao_social";
            //GUARDAR NO BD
            cbFornecedor.ValueMember = "codigo_fornecedor";
            cbFornecedor.SelectedIndex = -1;

            class_categoria cCategoria = new class_categoria();
            cbCategoria.DataSource = cCategoria.BuscarCategoria();
            //EXIBIR NA COMBO
            cbCategoria.DisplayMember = "nome";
            //GUARDAR NO BD
            cbCategoria.ValueMember = "codigo_categoria";
            cbCategoria.SelectedIndex = -1;

            class_marca cMarca = new class_marca();
            cbMarca.DataSource = cMarca.BuscarMarca();
            //EXIBIR NA COMBO
            cbMarca.DisplayMember = "nome";
            //GUARDAR NO BD
            cbMarca.ValueMember = "codigo_marca";
            cbMarca.SelectedIndex = -1;

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema Loja de Cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtMargemDeLucro_TextChanged(object sender, EventArgs e)
        {
            if (txtValorCompra.Text != "" && txtMargemDeLucro.Text != "")
            {
                int Lucro = 0;
                decimal ValorCompra = Convert.ToDecimal(txtValorCompra.Text);
                Lucro = Convert.ToInt32(txtMargemDeLucro.Text);
                decimal ValorVenda = 0;


                ValorVenda = ValorCompra + (ValorCompra * Lucro / 100);
                txtValorVenda.Text = ValorVenda.ToString("n2");
            }
            else
            {
                MessageBox.Show("Informe um valor válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMargemDeLucro.Text = "0";
                txtMargemDeLucro.SelectAll();
            }


            if (txtValorCompra.Text == "" && txtMargemDeLucro.Text == "0")
            {
                txtValorVenda.Clear();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            class_produto cProduto = new class_produto();
            if (txtNome.Text != "" && txtDescricao.Text != "" && txtQuantidade.Text != "" && txtValorCompra.Text != "" && txtValorVenda.Text != "" && txtMargemDeLucro.Text != "" && cbFornecedor.SelectedIndex != -1 && cbCategoria.SelectedItem != null && cbMarca.SelectedItem != null)
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE PRODUTO TODAS AS INFORMAÇÕES DO FORM
                cProduto.nome = txtNome.Text;
                cProduto.descricao = txtDescricao.Text;
                cProduto.quantidade = Convert.ToInt32(txtQuantidade.Text);


                cProduto.valor_compra = Convert.ToDecimal(txtValorCompra.Text);
                cProduto.valor_venda = Convert.ToDecimal(txtValorVenda.Text);
                cProduto.margem_de_lucro = Convert.ToInt32(txtMargemDeLucro.Text);

                //COMBO FORNECEDOR - FK
                cProduto.codigo_fornecedor = Convert.ToInt32(cbFornecedor.SelectedValue);
                //COMBO CATEGORIA- FK
                cProduto.codigo_categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                //COMBO MARCA - FK
                cProduto.codigo_marca = Convert.ToInt32(cbMarca.SelectedValue);



                //CHAMAR O MÉTODO CADASTRAR DA CLASSE FUNCIONÁRIO
                int resp = cProduto.CadastrarProduto();
                //PEGAR A RESPOSTA DO MÉTODO CADASTRAR - SE RETORNAR 1 FOI CADASTRADO
                if (resp == 1)
                {
                    MessageBox.Show("Produto Cadastrado com Sucesso", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LIMPAR OS CAMPOS
                    limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Produto", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar Campos Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //PINTAR OS CAMPOS OBRIGATÓRIOS
                txtNome.BackColor = Color.LemonChiffon;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SE A RECLA DIGITADA NÃO FOR NÚMERO BACKSPACE(08), ENTER(13) E ESPAÇO(32) - NUMEROS DA TABELA ASCII
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                //SE O USUÁRIO PRESSIONAR UMA TECLA NÃO NUMÉRICA NO TEXTBOX, CANCELA O EVENTO KEY PRESS
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas Números!", "Sistema Loja de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                //SE O USUÁRIO PRESSIONAR UMA TECLA NÃO NUMÉRICA NO TEXTBOX, CANCELA O EVENTO KEY PRESS
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas Números!", "Sistema Loja de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtMargemDeLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //SE O USUÁRIO PRESSIONAR UMA TECLA NÃO NUMÉRICA NO TEXTBOX, CANCELA O EVENTO KEY PRESS
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas Números!", "Sistema Loja de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtValorCompra_TextChanged(object sender, EventArgs e)
        {
            if (txtValorCompra.Text == "")
            {
                txtMargemDeLucro.Clear();
            }
        }

    }
}
