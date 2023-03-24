
namespace Sistema_Loja_Hardware
{
    partial class form_fornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_fornecedor));
            this.mskCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.txtCodigoFornecedor = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskRecado = new System.Windows.Forms.MaskedTextBox();
            this.mskPrincipal = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCamposObrigatorios = new System.Windows.Forms.Label();
            this.gbCidade = new System.Windows.Forms.GroupBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.gbBairro = new System.Windows.Forms.GroupBox();
            this.gbComplemento = new System.Windows.Forms.GroupBox();
            this.gbNumero = new System.Windows.Forms.GroupBox();
            this.gbRua = new System.Windows.Forms.GroupBox();
            this.gbCep = new System.Windows.Forms.GroupBox();
            this.gbDataCadastro = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbCamposObrigatoriosContato = new System.Windows.Forms.Label();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.gbRecado = new System.Windows.Forms.GroupBox();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gbCodigoFornecedor = new System.Windows.Forms.GroupBox();
            this.gbDadosFornecedor = new System.Windows.Forms.GroupBox();
            this.gbNomeFantasia = new System.Windows.Forms.GroupBox();
            this.gbRazaoSocial = new System.Windows.Forms.GroupBox();
            this.gbCnpj = new System.Windows.Forms.GroupBox();
            this.pnTituloFornecedor = new System.Windows.Forms.Panel();
            this.lbCadForncecedor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.gbBairro.SuspendLayout();
            this.gbComplemento.SuspendLayout();
            this.gbNumero.SuspendLayout();
            this.gbRua.SuspendLayout();
            this.gbCep.SuspendLayout();
            this.gbDataCadastro.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbEmail.SuspendLayout();
            this.gbRecado.SuspendLayout();
            this.gbPrincipal.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbCodigoFornecedor.SuspendLayout();
            this.gbDadosFornecedor.SuspendLayout();
            this.gbNomeFantasia.SuspendLayout();
            this.gbRazaoSocial.SuspendLayout();
            this.gbCnpj.SuspendLayout();
            this.pnTituloFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskCnpj
            // 
            this.mskCnpj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCnpj.Location = new System.Drawing.Point(5, 24);
            this.mskCnpj.Mask = "00,000,000/0000-00";
            this.mskCnpj.Name = "mskCnpj";
            this.mskCnpj.Size = new System.Drawing.Size(311, 27);
            this.mskCnpj.TabIndex = 5;
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(5, 27);
            this.txtNomeFantasia.MaxLength = 50;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(294, 27);
            this.txtNomeFantasia.TabIndex = 3;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(6, 29);
            this.txtRazaoSocial.MaxLength = 50;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(311, 27);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.Location = new System.Drawing.Point(29, 35);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(63, 24);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.Text = "Ativo";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDataCadastro.ForeColor = System.Drawing.Color.White;
            this.lbDataCadastro.Location = new System.Drawing.Point(59, 34);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(44, 20);
            this.lbDataCadastro.TabIndex = 4;
            this.lbDataCadastro.Text = "Data";
            // 
            // txtCodigoFornecedor
            // 
            this.txtCodigoFornecedor.Enabled = false;
            this.txtCodigoFornecedor.Location = new System.Drawing.Point(5, 28);
            this.txtCodigoFornecedor.MaxLength = 50;
            this.txtCodigoFornecedor.Name = "txtCodigoFornecedor";
            this.txtCodigoFornecedor.Size = new System.Drawing.Size(230, 29);
            this.txtCodigoFornecedor.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(7, 30);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // mskRecado
            // 
            this.mskRecado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskRecado.Location = new System.Drawing.Point(5, 24);
            this.mskRecado.Mask = "(00)0000-0000";
            this.mskRecado.Name = "mskRecado";
            this.mskRecado.Size = new System.Drawing.Size(131, 27);
            this.mskRecado.TabIndex = 4;
            // 
            // mskPrincipal
            // 
            this.mskPrincipal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPrincipal.Location = new System.Drawing.Point(5, 24);
            this.mskPrincipal.Mask = "(00)0000-0000";
            this.mskPrincipal.Name = "mskPrincipal";
            this.mskPrincipal.Size = new System.Drawing.Size(131, 27);
            this.mskPrincipal.TabIndex = 3;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(6, 24);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtComplemento.MaxLength = 40;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(157, 26);
            this.txtComplemento.TabIndex = 4;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(5, 23);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(106, 26);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // mskCep
            // 
            this.mskCep.Location = new System.Drawing.Point(5, 23);
            this.mskCep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(106, 26);
            this.mskCep.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(6, 24);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(311, 26);
            this.txtBairro.TabIndex = 3;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(5, 23);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(106, 27);
            this.cbEstado.TabIndex = 6;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(6, 24);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(309, 26);
            this.txtCidade.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 24);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEndereco.MaxLength = 70;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(354, 26);
            this.txtEndereco.TabIndex = 0;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Silver;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(380, 726);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(114, 40);
            this.btExcluir.TabIndex = 85;
            this.btExcluir.Text = "      Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.Silver;
            this.btAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAtualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btAtualizar.Image")));
            this.btAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAtualizar.Location = new System.Drawing.Point(207, 726);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(114, 40);
            this.btAtualizar.TabIndex = 84;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizar.UseVisualStyleBackColor = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Silver;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btCadastrar.Image")));
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrar.Location = new System.Drawing.Point(40, 726);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(114, 40);
            this.btCadastrar.TabIndex = 83;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Silver;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(554, 726);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(114, 40);
            this.btSair.TabIndex = 86;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gbDataCadastro);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.gbCodigoFornecedor);
            this.groupBox1.Controls.Add(this.gbDadosFornecedor);
            this.groupBox1.Location = new System.Drawing.Point(11, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 635);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCamposObrigatorios);
            this.groupBox2.Controls.Add(this.gbCidade);
            this.groupBox2.Controls.Add(this.gbEstado);
            this.groupBox2.Controls.Add(this.gbBairro);
            this.groupBox2.Controls.Add(this.gbComplemento);
            this.groupBox2.Controls.Add(this.gbNumero);
            this.groupBox2.Controls.Add(this.gbRua);
            this.groupBox2.Controls.Add(this.gbCep);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(5, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 233);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // lbCamposObrigatorios
            // 
            this.lbCamposObrigatorios.AutoSize = true;
            this.lbCamposObrigatorios.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamposObrigatorios.ForeColor = System.Drawing.Color.Gold;
            this.lbCamposObrigatorios.Location = new System.Drawing.Point(341, 189);
            this.lbCamposObrigatorios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCamposObrigatorios.Name = "lbCamposObrigatorios";
            this.lbCamposObrigatorios.Size = new System.Drawing.Size(295, 19);
            this.lbCamposObrigatorios.TabIndex = 30;
            this.lbCamposObrigatorios.Text = "Todos os Campos com * são Obrigatórios !!!";
            // 
            // gbCidade
            // 
            this.gbCidade.Controls.Add(this.txtCidade);
            this.gbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCidade.ForeColor = System.Drawing.Color.White;
            this.gbCidade.Location = new System.Drawing.Point(8, 167);
            this.gbCidade.Name = "gbCidade";
            this.gbCidade.Size = new System.Drawing.Size(321, 60);
            this.gbCidade.TabIndex = 78;
            this.gbCidade.TabStop = false;
            this.gbCidade.Text = "*Cidade:";
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.cbEstado);
            this.gbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbEstado.ForeColor = System.Drawing.Color.White;
            this.gbEstado.Location = new System.Drawing.Point(533, 102);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEstado.Size = new System.Drawing.Size(116, 58);
            this.gbEstado.TabIndex = 77;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "*Estado:";
            // 
            // gbBairro
            // 
            this.gbBairro.Controls.Add(this.txtBairro);
            this.gbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBairro.ForeColor = System.Drawing.Color.White;
            this.gbBairro.Location = new System.Drawing.Point(7, 102);
            this.gbBairro.Name = "gbBairro";
            this.gbBairro.Size = new System.Drawing.Size(322, 59);
            this.gbBairro.TabIndex = 76;
            this.gbBairro.TabStop = false;
            this.gbBairro.Text = "*Bairro:";
            // 
            // gbComplemento
            // 
            this.gbComplemento.Controls.Add(this.txtComplemento);
            this.gbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbComplemento.ForeColor = System.Drawing.Color.White;
            this.gbComplemento.Location = new System.Drawing.Point(344, 102);
            this.gbComplemento.Name = "gbComplemento";
            this.gbComplemento.Size = new System.Drawing.Size(168, 59);
            this.gbComplemento.TabIndex = 75;
            this.gbComplemento.TabStop = false;
            this.gbComplemento.Text = "Complemento:";
            // 
            // gbNumero
            // 
            this.gbNumero.Controls.Add(this.txtNumero);
            this.gbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbNumero.ForeColor = System.Drawing.Color.White;
            this.gbNumero.Location = new System.Drawing.Point(532, 26);
            this.gbNumero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNumero.Name = "gbNumero";
            this.gbNumero.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNumero.Size = new System.Drawing.Size(116, 58);
            this.gbNumero.TabIndex = 74;
            this.gbNumero.TabStop = false;
            this.gbNumero.Text = "*Número:";
            // 
            // gbRua
            // 
            this.gbRua.Controls.Add(this.txtEndereco);
            this.gbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRua.ForeColor = System.Drawing.Color.White;
            this.gbRua.Location = new System.Drawing.Point(147, 26);
            this.gbRua.Name = "gbRua";
            this.gbRua.Size = new System.Drawing.Size(365, 59);
            this.gbRua.TabIndex = 73;
            this.gbRua.TabStop = false;
            this.gbRua.Text = "*Rua:";
            // 
            // gbCep
            // 
            this.gbCep.Controls.Add(this.mskCep);
            this.gbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbCep.ForeColor = System.Drawing.Color.White;
            this.gbCep.Location = new System.Drawing.Point(8, 27);
            this.gbCep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCep.Name = "gbCep";
            this.gbCep.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCep.Size = new System.Drawing.Size(116, 58);
            this.gbCep.TabIndex = 6;
            this.gbCep.TabStop = false;
            this.gbCep.Text = "CEP:";
            // 
            // gbDataCadastro
            // 
            this.gbDataCadastro.Controls.Add(this.lbDataCadastro);
            this.gbDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataCadastro.ForeColor = System.Drawing.Color.White;
            this.gbDataCadastro.Location = new System.Drawing.Point(295, 19);
            this.gbDataCadastro.Name = "gbDataCadastro";
            this.gbDataCadastro.Size = new System.Drawing.Size(223, 74);
            this.gbDataCadastro.TabIndex = 32;
            this.gbDataCadastro.TabStop = false;
            this.gbDataCadastro.Text = "*Data de Cadastro:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbCamposObrigatoriosContato);
            this.groupBox3.Controls.Add(this.gbEmail);
            this.groupBox3.Controls.Add(this.gbRecado);
            this.groupBox3.Controls.Add(this.gbPrincipal);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(5, 279);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 108);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contatos";
            // 
            // lbCamposObrigatoriosContato
            // 
            this.lbCamposObrigatoriosContato.AutoSize = true;
            this.lbCamposObrigatoriosContato.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamposObrigatoriosContato.ForeColor = System.Drawing.Color.Gold;
            this.lbCamposObrigatoriosContato.Location = new System.Drawing.Point(369, 85);
            this.lbCamposObrigatoriosContato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCamposObrigatoriosContato.Name = "lbCamposObrigatoriosContato";
            this.lbCamposObrigatoriosContato.Size = new System.Drawing.Size(261, 19);
            this.lbCamposObrigatoriosContato.TabIndex = 6;
            this.lbCamposObrigatoriosContato.Text = "* Preencher pelo menos um telefone";
            // 
            // gbEmail
            // 
            this.gbEmail.Controls.Add(this.txtEmail);
            this.gbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmail.ForeColor = System.Drawing.Color.White;
            this.gbEmail.Location = new System.Drawing.Point(6, 25);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(342, 74);
            this.gbEmail.TabIndex = 73;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "*Email:";
            // 
            // gbRecado
            // 
            this.gbRecado.Controls.Add(this.mskRecado);
            this.gbRecado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbRecado.ForeColor = System.Drawing.Color.White;
            this.gbRecado.Location = new System.Drawing.Point(498, 25);
            this.gbRecado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRecado.Name = "gbRecado";
            this.gbRecado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbRecado.Size = new System.Drawing.Size(146, 58);
            this.gbRecado.TabIndex = 7;
            this.gbRecado.TabStop = false;
            this.gbRecado.Text = "Recado:";
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.mskPrincipal);
            this.gbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbPrincipal.ForeColor = System.Drawing.Color.White;
            this.gbPrincipal.Location = new System.Drawing.Point(353, 25);
            this.gbPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbPrincipal.Size = new System.Drawing.Size(141, 58);
            this.gbPrincipal.TabIndex = 6;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Principal:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.cbStatus);
            this.gbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.Color.White;
            this.gbStatus.Location = new System.Drawing.Point(543, 19);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(121, 74);
            this.gbStatus.TabIndex = 31;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "*Status:";
            // 
            // gbCodigoFornecedor
            // 
            this.gbCodigoFornecedor.Controls.Add(this.txtCodigoFornecedor);
            this.gbCodigoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCodigoFornecedor.ForeColor = System.Drawing.Color.White;
            this.gbCodigoFornecedor.Location = new System.Drawing.Point(5, 19);
            this.gbCodigoFornecedor.Name = "gbCodigoFornecedor";
            this.gbCodigoFornecedor.Size = new System.Drawing.Size(252, 74);
            this.gbCodigoFornecedor.TabIndex = 33;
            this.gbCodigoFornecedor.TabStop = false;
            this.gbCodigoFornecedor.Text = "*Código do Fornecedor:";
            // 
            // gbDadosFornecedor
            // 
            this.gbDadosFornecedor.Controls.Add(this.gbNomeFantasia);
            this.gbDadosFornecedor.Controls.Add(this.gbRazaoSocial);
            this.gbDadosFornecedor.Controls.Add(this.gbCnpj);
            this.gbDadosFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosFornecedor.ForeColor = System.Drawing.Color.White;
            this.gbDadosFornecedor.Location = new System.Drawing.Point(5, 111);
            this.gbDadosFornecedor.Name = "gbDadosFornecedor";
            this.gbDadosFornecedor.Size = new System.Drawing.Size(661, 167);
            this.gbDadosFornecedor.TabIndex = 34;
            this.gbDadosFornecedor.TabStop = false;
            this.gbDadosFornecedor.Text = "Dados do Fornecedor";
            // 
            // gbNomeFantasia
            // 
            this.gbNomeFantasia.Controls.Add(this.txtNomeFantasia);
            this.gbNomeFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbNomeFantasia.ForeColor = System.Drawing.Color.White;
            this.gbNomeFantasia.Location = new System.Drawing.Point(350, 27);
            this.gbNomeFantasia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNomeFantasia.Name = "gbNomeFantasia";
            this.gbNomeFantasia.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNomeFantasia.Size = new System.Drawing.Size(304, 72);
            this.gbNomeFantasia.TabIndex = 7;
            this.gbNomeFantasia.TabStop = false;
            this.gbNomeFantasia.Text = "*Nome Fantasia:";
            // 
            // gbRazaoSocial
            // 
            this.gbRazaoSocial.Controls.Add(this.txtRazaoSocial);
            this.gbRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRazaoSocial.ForeColor = System.Drawing.Color.White;
            this.gbRazaoSocial.Location = new System.Drawing.Point(7, 25);
            this.gbRazaoSocial.Name = "gbRazaoSocial";
            this.gbRazaoSocial.Size = new System.Drawing.Size(328, 73);
            this.gbRazaoSocial.TabIndex = 72;
            this.gbRazaoSocial.TabStop = false;
            this.gbRazaoSocial.Text = "*Razao Social:";
            // 
            // gbCnpj
            // 
            this.gbCnpj.Controls.Add(this.mskCnpj);
            this.gbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbCnpj.ForeColor = System.Drawing.Color.White;
            this.gbCnpj.Location = new System.Drawing.Point(8, 103);
            this.gbCnpj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCnpj.Name = "gbCnpj";
            this.gbCnpj.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCnpj.Size = new System.Drawing.Size(321, 59);
            this.gbCnpj.TabIndex = 4;
            this.gbCnpj.TabStop = false;
            this.gbCnpj.Text = "*CNPJ:";
            // 
            // pnTituloFornecedor
            // 
            this.pnTituloFornecedor.Controls.Add(this.lbCadForncecedor);
            this.pnTituloFornecedor.ForeColor = System.Drawing.Color.White;
            this.pnTituloFornecedor.Location = new System.Drawing.Point(11, 11);
            this.pnTituloFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTituloFornecedor.Name = "pnTituloFornecedor";
            this.pnTituloFornecedor.Size = new System.Drawing.Size(655, 53);
            this.pnTituloFornecedor.TabIndex = 81;
            // 
            // lbCadForncecedor
            // 
            this.lbCadForncecedor.AutoSize = true;
            this.lbCadForncecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadForncecedor.ForeColor = System.Drawing.Color.White;
            this.lbCadForncecedor.Location = new System.Drawing.Point(183, 10);
            this.lbCadForncecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadForncecedor.Name = "lbCadForncecedor";
            this.lbCadForncecedor.Size = new System.Drawing.Size(352, 33);
            this.lbCadForncecedor.TabIndex = 67;
            this.lbCadForncecedor.Text = "Cadastro de Fornecedor";
            // 
            // form_fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(693, 776);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnTituloFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H&C - Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.form_fornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCidade.ResumeLayout(false);
            this.gbCidade.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbBairro.ResumeLayout(false);
            this.gbBairro.PerformLayout();
            this.gbComplemento.ResumeLayout(false);
            this.gbComplemento.PerformLayout();
            this.gbNumero.ResumeLayout(false);
            this.gbNumero.PerformLayout();
            this.gbRua.ResumeLayout(false);
            this.gbRua.PerformLayout();
            this.gbCep.ResumeLayout(false);
            this.gbCep.PerformLayout();
            this.gbDataCadastro.ResumeLayout(false);
            this.gbDataCadastro.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.gbRecado.ResumeLayout(false);
            this.gbRecado.PerformLayout();
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbCodigoFornecedor.ResumeLayout(false);
            this.gbCodigoFornecedor.PerformLayout();
            this.gbDadosFornecedor.ResumeLayout(false);
            this.gbNomeFantasia.ResumeLayout(false);
            this.gbNomeFantasia.PerformLayout();
            this.gbRazaoSocial.ResumeLayout(false);
            this.gbRazaoSocial.PerformLayout();
            this.gbCnpj.ResumeLayout(false);
            this.gbCnpj.PerformLayout();
            this.pnTituloFornecedor.ResumeLayout(false);
            this.pnTituloFornecedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox txtComplemento;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.MaskedTextBox mskCep;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.Label lbDataCadastro;
        public System.Windows.Forms.TextBox txtCodigoFornecedor;
        public System.Windows.Forms.CheckBox cbStatus;
        public System.Windows.Forms.MaskedTextBox mskCnpj;
        public System.Windows.Forms.TextBox txtNomeFantasia;
        public System.Windows.Forms.TextBox txtRazaoSocial;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.MaskedTextBox mskRecado;
        public System.Windows.Forms.MaskedTextBox mskPrincipal;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        public System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbCamposObrigatorios;
        private System.Windows.Forms.GroupBox gbCidade;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.GroupBox gbBairro;
        private System.Windows.Forms.GroupBox gbComplemento;
        private System.Windows.Forms.GroupBox gbNumero;
        private System.Windows.Forms.GroupBox gbRua;
        private System.Windows.Forms.GroupBox gbCep;
        private System.Windows.Forms.GroupBox gbDataCadastro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbCamposObrigatoriosContato;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.GroupBox gbRecado;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbCodigoFornecedor;
        private System.Windows.Forms.GroupBox gbDadosFornecedor;
        private System.Windows.Forms.GroupBox gbNomeFantasia;
        private System.Windows.Forms.GroupBox gbRazaoSocial;
        private System.Windows.Forms.GroupBox gbCnpj;
        private System.Windows.Forms.Panel pnTituloFornecedor;
        private System.Windows.Forms.Label lbCadForncecedor;
    }
}