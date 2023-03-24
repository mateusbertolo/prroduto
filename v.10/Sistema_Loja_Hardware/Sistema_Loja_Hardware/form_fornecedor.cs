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
    public partial class form_fornecedor : Form
    {
        public form_fornecedor()
        {
            InitializeComponent();
        }

        private void form_fornecedor_Load(object sender, EventArgs e)
        {
            lbDataCadastro.Text = DateTime.Now.ToShortDateString();

            //POPULAR COMBOBOX MANUAL
            //COMBOBOX ESTADO
            cbEstado.Items.Add("AC");
            cbEstado.Items.Add("AL");
            cbEstado.Items.Add("AP");
            cbEstado.Items.Add("AM");
            cbEstado.Items.Add("BA");
            cbEstado.Items.Add("CE");
            cbEstado.Items.Add("DF");
            cbEstado.Items.Add("ES");
            cbEstado.Items.Add("GO");
            cbEstado.Items.Add("MA");
            cbEstado.Items.Add("MT");
            cbEstado.Items.Add("MS");
            cbEstado.Items.Add("MG");
            cbEstado.Items.Add("PA");
            cbEstado.Items.Add("PB");
            cbEstado.Items.Add("PR");
            cbEstado.Items.Add("PE");
            cbEstado.Items.Add("PI");
            cbEstado.Items.Add("RJ");
            cbEstado.Items.Add("RN");
            cbEstado.Items.Add("RS");
            cbEstado.Items.Add("RO");
            cbEstado.Items.Add("RR");
            cbEstado.Items.Add("SC");
            cbEstado.Items.Add("SP");
            cbEstado.Items.Add("SE");
            cbEstado.Items.Add("TO");
            //COLOCAR COMBO EM ORDEM ALFABÉTICA
            cbEstado.Sorted = true;
            //DEIXAR O ESTADO SP SELECIONADO - USANDO O NOME DO ESTADO
            cbEstado.SelectedIndex = -1;
            //DEIXAR O ESTADO SP SELECIONADO - USANDO O ÍNDICE DA LINHA (POSIÇÃO)
            //cbEstado.SelectedIndex = 0;
        }

        private void limpar()
        {
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            mskCnpj.Clear();
            mskPrincipal.Clear();
            mskRecado.Clear();
            txtEmail.Clear();
            mskCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbEstado.SelectedIndex = -1;
        }


        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema Loja de Cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            class_fornecedor cFornecedor = new class_fornecedor();

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            //PREENCHER PELO MENOS 1 TELEFONE
            if ((mskPrincipal.Text != "(  )    -" || mskRecado.Text != "(  )     -") && txtRazaoSocial.Text != "" && mskCnpj.Text != "  .   .   /    -  " && txtEmail.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCidade.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE FORNECEDOR TODAS AS INFORMAÇÕES DO FORM
                cFornecedor.razao_social = txtRazaoSocial.Text;
                cFornecedor.cnpj = mskCnpj.Text;
                //CAMPO MÁSCARA QUE NÃO É OBRIGATÓRIO TEM QUE FAZER IF, PARA NÃO MANDAR MÁSCARA PRO BD
                //MÁSCARA TELEFONE RESIDENCIAL
                if (mskPrincipal.Text == "(  )    -")
                {
                    cFornecedor.telefone_principal = "";
                }
                else
                {
                    cFornecedor.telefone_principal = mskPrincipal.Text;
                }
                //MÁSCARA TELEFONE RECADO
                if (mskRecado.Text == "(  )     -")
                {
                    cFornecedor.telefone_recado = "";
                }
                else
                {
                    cFornecedor.telefone_recado = mskRecado.Text;
                }
                cFornecedor.email = txtEmail.Text;
                //MÁSCARA CEP
                if (mskCep.Text == "     -")
                {
                    cFornecedor.cep = "";
                }
                else
                {
                    cFornecedor.cep = mskCep.Text;
                }
                cFornecedor.endereco = txtEndereco.Text;
                cFornecedor.numero = Convert.ToInt32(txtNumero.Text);
                cFornecedor.complemento = txtComplemento.Text;
                cFornecedor.bairro = txtBairro.Text;
                cFornecedor.cidade = txtCidade.Text;
                cFornecedor.estado = cbEstado.SelectedItem.ToString();

                //CHAMAR O MÉTODO CADASTRAR DA CLASSE FUNCIONÁRIO
                int resp = cFornecedor.CadastrarFornecedor();
                //PEGAR A RESPOSTA DO MÉTODO CADASTRAR - SE RETORNAR 1 FOI CADASTRADO
                if (resp == 1)
                {
                    MessageBox.Show("Fornecedor Cadastrado com Sucesso", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LIMPAR OS CAMPOS
                    limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Fornecedor", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar Campos Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //PINTAR OS CAMPOS OBRIGATÓRIOS
                txtRazaoSocial.BackColor = Color.LemonChiffon;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //SE O USUÁRIO PRESSIONAR UMA TECLA NÃO NUMÉRICA NO TEXTBOX, CANCELA O EVENTO KEY PRESS
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas Números!", "Sistema Loja de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
