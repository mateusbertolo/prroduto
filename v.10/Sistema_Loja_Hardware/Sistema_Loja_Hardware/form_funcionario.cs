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
    public partial class form_funcionario : Form
    {
        public form_funcionario()
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
            cbCargo.SelectedIndex = -1;
            cbSetor.SelectedIndex = -1;
            txtSalario.Clear();
            mskTelefone.Clear();
            mskCelular.Clear();
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

        private void form_funcionario_Load(object sender, EventArgs e)
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
            cbEstado.SelectedItem = "SP";
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

            //CARREGAR COMBOBOX DO BD
            class_cargo cCargo = new class_cargo();
            cbCargo.DataSource = cCargo.BuscarCargo();
            //EXIBIR NA COMBO
            cbCargo.DisplayMember = "nome";
            //GUARDAR NO BD
            cbCargo.ValueMember = "codigo_cargo";
            cbCargo.SelectedIndex = -1;

            //CARREGAR COMBOBOX DO BD
            class_setor cSetor = new class_setor();
            cbSetor.DataSource = cSetor.BuscarSetor();
            //EXIBIR NA COMBO
            cbSetor.DisplayMember = "nome";
            //GUARDAR NO BD
            cbSetor.ValueMember = "codigo_setor";
            cbSetor.SelectedIndex = -1;

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


        //VALIDAR SE A DATA FOI PREENCHIDA CORRETAMENTE
        //USANDO O EVENTO VALIDATIONCOMPLETED MÁSCARA (QUANDO CRIAR A MARCA TEM QUE SER DO TIPO DATATIME)
        private void mskDataNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida.", "Sistema de Loja de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskDataNascimento.Focus();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE FUNCIONÁRIO
            class_funcionario cFuncionario = new class_funcionario();

            //VERIFICAR CAMPOS OBRIGATÓRIOS
            //PREENCHER PELO MENOS 1 TELEFONE
            if ((mskTelefone.Text != "(  )    -" || mskCelular.Text != "(  )     -" || mskRecado.Text != "(  )     -") && txtNome.Text != "" && mskDataNascimento.Text != "  /  /" && mskCpf.Text != "   .   .   -" && cbCargo.SelectedIndex != -1 && cbSetor.SelectedItem != null && txtEmail.Text != "" && txtEndereco.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCidade.Text != "")
            {
                //PASSAR PARA AS PROPRIEDADES DA CLASSE FUNCIONARIO TODAS AS INFORMAÇÕES DO FORM
                cFuncionario.nome = txtNome.Text;
                cFuncionario.data_nascimento = Convert.ToDateTime(mskDataNascimento.Text);
                cFuncionario.cpf = mskCpf.Text;
                //CAMPO MÁSCARA QUE NÃO É OBRIGATÓRIO TEM QUE FAZER IF, PARA NÃO MANDAR MÁSCARA PRO BD
                //MÁSCARA RG
                if (mskRg.Text == "  .   .   -")
                {
                    cFuncionario.rg = "";
                }
                else
                {
                    cFuncionario.rg = mskRg.Text;
                }
                //RADIOBUTTON SEXO
                if (rbFeminino.Checked == true)
                {
                    cFuncionario.sexo = "F";
                }
                else
                {
                    cFuncionario.sexo = "M";
                }
                //COMBO ESTADO CIVIL
                if (cbEstadoCivil.SelectedItem.ToString() == "Selecione:")
                {
                    cFuncionario.estado_civil = "";
                }
                else
                {
                    cFuncionario.estado_civil = cbEstadoCivil.SelectedItem.ToString();
                }
                //COMBO CARGO - FK
                cFuncionario.codigo_cargo = Convert.ToInt32(cbCargo.SelectedValue);
                //COMBO SETOR - FK
                cFuncionario.codigo_setor = Convert.ToInt32(cbSetor.SelectedValue);
                //CAMPO SALÁRIO - CAMPO NUMÉRICO NÃO PODE SER VAZIO
                if (txtSalario.Text == "")
                {
                    cFuncionario.salario = 0;
                }
                else
                {
                    cFuncionario.salario = Convert.ToDecimal(txtSalario.Text);
                }
                //CAMPO MÁSCARA QUE NÃO É OBRIGATÓRIO TEM QUE FAZER IF, PARA NÃO MANDAR MÁSCARA PRO BD
                //MÁSCARA TELEFONE RESIDENCIAL
                if (mskTelefone.Text == "(  )    -")
                {
                    cFuncionario.telefone_residencial = "";
                }
                else
                {
                    cFuncionario.telefone_residencial = mskTelefone.Text;
                }
                //MÁSCARA TELEFONE CELULAR
                if (mskCelular.Text == "(  )     -")
                {
                    cFuncionario.telefone_celular = "";
                }
                else
                {
                    cFuncionario.telefone_celular = mskCelular.Text;
                }
                //MÁSCARA TELEFONE RECADO
                if (mskRecado.Text == "(  )     -")
                {
                    cFuncionario.telefone_recado = "";
                }
                else
                {
                    cFuncionario.telefone_recado = mskRecado.Text;
                }
                cFuncionario.email = txtEmail.Text;
                //MÁSCARA CEP
                if (mskCep.Text == "     -")
                {
                    cFuncionario.cep = "";
                }
                else
                {
                    cFuncionario.cep = mskCep.Text;
                }
                cFuncionario.endereco = txtEndereco.Text;
                cFuncionario.numero = Convert.ToInt32(txtNumero.Text);
                cFuncionario.complemento = txtComplemento.Text;
                cFuncionario.bairro = txtBairro.Text;
                cFuncionario.cidade = txtCidade.Text;
                cFuncionario.estado = cbEstado.SelectedItem.ToString();

                //CHAMAR O MÉTODO CADASTRAR DA CLASSE FUNCIONÁRIO
                int resp = cFuncionario.CadastrarFuncionario();
                //PEGAR A RESPOSTA DO MÉTODO CADASTRAR - SE RETORNAR 1 FOI CADASTRADO
                if (resp == 1)
                {
                    MessageBox.Show("Funcionário Cadastrado com Sucesso", "Sistema Loja de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LIMPAR OS CAMPOS
                    limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Funcionário", "Sistema Loja de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar Campos Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //PINTAR OS CAMPOS OBRIGATÓRIOS
                txtNome.BackColor = Color.LemonChiffon;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema Loja de Hardware", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                //SE O USUÁRIO PRESSIONAR UMA TECLA NÃO NUMÉRICA NO TEXTBOX, CANCELA O EVENTO KEY PRESS
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas Números!", "Sistema Loja de Hardware", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
