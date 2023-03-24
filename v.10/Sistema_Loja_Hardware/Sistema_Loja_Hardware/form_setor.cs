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
    public partial class form_setor : Form
    {
        public form_setor()
        {
            InitializeComponent();
        }

        private void form_setor_Load(object sender, EventArgs e)
        {
            lbDataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void Limpar()
        {
            txtNomeSetor.Clear();
            txtObservacao.Clear();
            txtNomeSetor.Focus();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE SETOR PARA USAR PROPRIEDADES E MÉTODOS
            class_setor cSetor = new class_setor();

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            if (txtNomeSetor.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE SETOR TODOS OS CAMPOS QUE NÃO SÃO AUTOMÁTICOS
                cSetor.nome = txtNomeSetor.Text;
                cSetor.observacao = txtObservacao.Text;

                //CHAMAR MÉTODO CADASTRAR DA CLASSE SETOR
                int resp = cSetor.CadastrarSetor();

                if (resp == 1) //SE O CADASTRO DEU CERTO
                {
                    MessageBox.Show("Setor Cadastrado com Sucesso", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Setor", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else//NÃO PREENCHEU TODOS OS CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeSetor.BackColor = Color.LemonChiffon;
                txtNomeSetor.Focus();

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (txtNomeSetor.Text == "" && txtObservacao.Text == "")
            {
                this.Close();
            }
            else if (MessageBox.Show("Tem certeza que deseja fechar o sistema", "Sistema loja cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }
    }
}
