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
    public partial class form_cliente : Form
    {
        public form_cliente()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            txtNome.Clear();
            mskDataNascimento.Clear();
            mskCpf.Clear();
            mskRg.Clear();
            rbFeminino.Checked = true;
            cbEstadoCivil.SelectedIndex = -1;
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

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            class_cliente cCliente = new class_cliente();

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            //PREENCHER PELO MENOS 1 TELEFONE
            if ((mskPrincipal.Text != "(  )    -" || mskRecado.Text != "(  )     -") && txtNome.Text != "" && mskDataNascimento.Text != "  /  /" && mskCep.Text != "   .   .   -" && txtEmail.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCidade.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE CLIENTE TODAS AS INFORMAÇÕES DO FORM
                cCliente.nome = txtNome.Text;
                cCliente.data_nascimento = Convert.ToDateTime(mskDataNascimento.Text);
                cCliente.cpf = mskCpf.Text;
                //CAMPO MÁSCARA QUE NÃO É OBRIGATÓRIO TEM QUE FAZER IF, PARA NÃO MANDAR MÁSCARA PRO BD
                //MÁSCARA RG
                if (mskRg.Text == "  .   .   -")
                {
                    cCliente.rg = "";
                }
                else
                {
                    cCliente.rg = mskRg.Text;
                }
                //RADIOBUTTON SEXO
                if (rbFeminino.Checked == true)
                {
                    cCliente.sexo = "F";
                }
                else
                {
                    cCliente.sexo = "M";
                }
                //COMBO ESTADO CIVIL
                if (cbEstadoCivil.SelectedItem.ToString() == "Selecione:")
                {
                    cCliente.estado_civil = "";
                }
                else
                {
                    cCliente.estado_civil = cbEstadoCivil.SelectedItem.ToString();
                }

                //CAMPO MÁSCARA QUE NÃO É OBRIGATÓRIO TEM QUE FAZER IF, PARA NÃO MANDAR MÁSCARA PRO BD
                //MÁSCARA TELEFONE RESIDENCIAL
                if (mskPrincipal.Text == "(  )    -")
                {
                    cCliente.telefone_principal = "";
                }
                else
                {
                    cCliente.telefone_principal = mskPrincipal.Text;
                }
                //MÁSCARA TELEFONE RECADO
                if (mskRecado.Text == "(  )     -")
                {
                    cCliente.telefone_recado = "";
                }
                else
                {
                    cCliente.telefone_recado = mskRecado.Text;
                }
                cCliente.email = txtEmail.Text;
                //MÁSCARA CEP
                if (mskCep.Text == "     -")
                {
                    cCliente.cep = "";
                }
                else
                {
                    cCliente.cep = mskCep.Text;
                }
                cCliente.endereco = txtEndereco.Text;
                cCliente.numero = Convert.ToInt32(txtNumero.Text);
                cCliente.complemento = txtComplemento.Text;
                cCliente.bairro = txtBairro.Text;
                cCliente.cidade = txtCidade.Text;
                cCliente.estado = cbEstado.SelectedItem.ToString();

                //CHAMAR O MÉTODO CADASTRAR DA CLASSE FUNCIONÁRIO
                int resp = cCliente.CadastrarCliente();
                //PEGAR A RESPOSTA DO MÉTODO CADASTRAR - SE RETORNAR 1 FOI CADASTRADO
                if (resp == 1)
                {
                    MessageBox.Show("Cliente Cadastrado com Sucesso", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LIMPAR OS CAMPOS
                    limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Cliente", "Sistema Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar Campos Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //PINTAR OS CAMPOS OBRIGATÓRIOS
                txtNome.BackColor = Color.LemonChiffon;
            }
        }

        private void form_cliente_Load(object sender, EventArgs e)
        {
            //CARREGAR DATA NO FORM FUNCIONÁRIO
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

            //COMBOBOX ESTADO CIVIL
            cbEstadoCivil.Items.Add("Selecione:");
            cbEstadoCivil.Items.Add("Solteiro(a)");
            cbEstadoCivil.Items.Add("Casado(a)");
            cbEstadoCivil.Items.Add("Divorciado(a)");
            cbEstadoCivil.Items.Add("Viúvo(a)");
            cbEstadoCivil.Items.Add("Separado Judicialmente");

            cbEstadoCivil.Sorted = true;
            cbEstadoCivil.SelectedItem = "Selecione:";


        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema Loja de Cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SE A RECLA DIGITADA NÃO FOR NÚMERO BACKSPACE(08), ENTER(13) E ESPAÇO(32) - NUMEROS DA TABELA ASCII
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                //SE O USUÁRIO PRESSIONAR UMA TECLA NÃO NUMÉRICA NO TEXTBOX, CANCELA O EVENTO KEY PRESS
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas Números!", "Sistema Loja de Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mskDataNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida.", "Sistema de Loja Cosméticos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskDataNascimento.Focus();
            }
        }
    }
}
