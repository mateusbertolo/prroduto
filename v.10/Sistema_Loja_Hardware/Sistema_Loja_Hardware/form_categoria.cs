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
    public partial class form_categoria : Form
    {
        public form_categoria()
        {
            InitializeComponent();
        }

        private void form_categoria_Load(object sender, EventArgs e)
        {
            lbDataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void Limpar()
        {
            txtNomeCategoria.Clear();
            txtObservacao.Clear();
            txtNomeCategoria.Focus();
        }



        private void btCadastrar_Click(object sender, EventArgs e)
        {
            class_categoria cCategoria = new class_categoria();

            if (txtNomeCategoria.Text != "")
            {
                cCategoria.nome = txtNomeCategoria.Text;
                cCategoria.observacao = txtObservacao.Text;

                //CHAMAR MÉTODO CADASTRAR DA CLASSE CATEGORIA
                int resp = cCategoria.CadastrarCategoria();

                if (resp == 1) //SE O CADASTRO DEU CERTO
                {
                    MessageBox.Show("Categoria Cadastrada com Sucesso", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Categoria", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else//NÃO PREENCHEU TODOS OS CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCategoria.BackColor = Color.LemonChiffon;
                txtNomeCategoria.Focus();

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (txtNomeCategoria.Text == "" && txtObservacao.Text == "")
            {
                this.Close();
            }
            else if (MessageBox.Show("Tem certeza que deseja fechar o sistema", "Sistema loja cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }
    }
}
