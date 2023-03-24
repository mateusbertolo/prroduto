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
    public partial class form_marca : Form
    {
        public form_marca()
        {
            InitializeComponent();
        }

        private void form_marca_Load(object sender, EventArgs e)
        {
            lbDataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void Limpar()
        {
            txtNomeMarca.Clear();
            txtObservacao.Clear();
            txtNomeMarca.Focus();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            class_marca cMarca = new class_marca();

            if (txtNomeMarca.Text != "")
            {
                cMarca.nome = txtNomeMarca.Text;
                cMarca.observacao = txtObservacao.Text;

                //CHAMAR MÉTODO CADASTRAR DA CLASSE CARGO
                int resp = cMarca.CadastrarMarca();

                if (resp == 1) //SE O CADASTRO DEU CERTO
                {
                    MessageBox.Show("Marca Cadastrada com Sucesso", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Marca", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else//NÃO PREENCHEU TODOS OS CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeMarca.BackColor = Color.LemonChiffon;
                txtNomeMarca.Focus();

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (txtNomeMarca.Text == "" && txtObservacao.Text == "")
            {
                this.Close();
            }
            else if (MessageBox.Show("Tem certeza que deseja fechar o sistema", "Sistema loja cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();

        }
    }
}
