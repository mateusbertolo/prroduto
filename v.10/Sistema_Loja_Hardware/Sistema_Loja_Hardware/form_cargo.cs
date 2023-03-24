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
    public partial class form_cargo : Form
    {
        public form_cargo()
        {
            InitializeComponent();
        }

        private void form_cargo_Load(object sender, EventArgs e)
        {
            lbDataCadastro.Text = DateTime.Now.ToShortDateString();
        }

        private void Limpar()
        {
            txtNomeCargo.Clear();
            txtObservacao.Clear();
            txtNomeCargo.Focus();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE CARGO PARA USAR PROPRIEDADES E MÉTODOS
            class_cargo cCargo = new class_cargo();

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            if (txtNomeCargo.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE CARGO TODOS OS CAMPOS QUE NÃO SÃO AUTOMÁTICOS
                cCargo.nome = txtNomeCargo.Text;
                cCargo.observacao = txtObservacao.Text;

                //CHAMAR MÉTODO CADASTRAR DA CLASSE CARGO
                int resp = cCargo.CadastrarCargo();

                if (resp == 1) //SE O CADASTRO DEU CERTO
                {
                    MessageBox.Show("Cargo Cadastrado com Sucesso", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Cargo", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else//NÃO PREENCHEU TODOS OS CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCargo.BackColor = Color.LemonChiffon;
                txtNomeCargo.Focus();

            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (txtNomeCargo.Text == "" && txtObservacao.Text == "")
            {
                this.Close();
            }
            else if (MessageBox.Show("Tem certeza que deseja fechar o sistema", "Sistema loja cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }
    }
}
