
namespace Sistema_Loja_Hardware
{
    partial class form_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_produto));
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.gbMargemLucro = new System.Windows.Forms.GroupBox();
            this.txtMargemDeLucro = new System.Windows.Forms.TextBox();
            this.gbValorVenda = new System.Windows.Forms.GroupBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.gbValorCompra = new System.Windows.Forms.GroupBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCampoObrigatorio = new System.Windows.Forms.Label();
            this.gbCalculo = new System.Windows.Forms.GroupBox();
            this.lbIgual = new System.Windows.Forms.Label();
            this.lbMultiplicacao = new System.Windows.Forms.Label();
            this.gbInformacaoProduto = new System.Windows.Forms.GroupBox();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.gbFornecedor = new System.Windows.Forms.GroupBox();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.gbQuantidade = new System.Windows.Forms.GroupBox();
            this.gbDescricao = new System.Windows.Forms.GroupBox();
            this.gbNome = new System.Windows.Forms.GroupBox();
            this.gbDataCadastro = new System.Windows.Forms.GroupBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gbCodigoProduto = new System.Windows.Forms.GroupBox();
            this.pnTituloCliente = new System.Windows.Forms.Panel();
            this.lbCadProduto = new System.Windows.Forms.Label();
            this.gbMargemLucro.SuspendLayout();
            this.gbValorVenda.SuspendLayout();
            this.gbValorCompra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCalculo.SuspendLayout();
            this.gbInformacaoProduto.SuspendLayout();
            this.gbMarca.SuspendLayout();
            this.gbFornecedor.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbQuantidade.SuspendLayout();
            this.gbDescricao.SuspendLayout();
            this.gbNome.SuspendLayout();
            this.gbDataCadastro.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbCodigoProduto.SuspendLayout();
            this.pnTituloCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStatus.ForeColor = System.Drawing.Color.White;
            this.cbStatus.Location = new System.Drawing.Point(30, 34);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(63, 24);
            this.cbStatus.TabIndex = 11;
            this.cbStatus.Text = "Ativo";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbDataCadastro.ForeColor = System.Drawing.Color.White;
            this.lbDataCadastro.Location = new System.Drawing.Point(74, 35);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(44, 20);
            this.lbDataCadastro.TabIndex = 10;
            this.lbDataCadastro.Text = "Data";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Enabled = false;
            this.txtCodigoProduto.Location = new System.Drawing.Point(6, 29);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(211, 29);
            this.txtCodigoProduto.TabIndex = 9;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(5, 24);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(162, 28);
            this.cbMarca.TabIndex = 0;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(4, 27);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(185, 28);
            this.cbCategoria.TabIndex = 0;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(5, 26);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(226, 28);
            this.cbFornecedor.TabIndex = 0;
            // 
            // gbMargemLucro
            // 
            this.gbMargemLucro.Controls.Add(this.txtMargemDeLucro);
            this.gbMargemLucro.ForeColor = System.Drawing.Color.White;
            this.gbMargemLucro.Location = new System.Drawing.Point(228, 28);
            this.gbMargemLucro.Name = "gbMargemLucro";
            this.gbMargemLucro.Size = new System.Drawing.Size(187, 59);
            this.gbMargemLucro.TabIndex = 14;
            this.gbMargemLucro.TabStop = false;
            this.gbMargemLucro.Text = "*Margem de Lucro:";
            // 
            // txtMargemDeLucro
            // 
            this.txtMargemDeLucro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargemDeLucro.Location = new System.Drawing.Point(6, 26);
            this.txtMargemDeLucro.Name = "txtMargemDeLucro";
            this.txtMargemDeLucro.Size = new System.Drawing.Size(175, 27);
            this.txtMargemDeLucro.TabIndex = 11;
            this.txtMargemDeLucro.TextChanged += new System.EventHandler(this.txtMargemDeLucro_TextChanged);
            this.txtMargemDeLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMargemDeLucro_KeyPress);
            // 
            // gbValorVenda
            // 
            this.gbValorVenda.Controls.Add(this.txtValorVenda);
            this.gbValorVenda.ForeColor = System.Drawing.Color.White;
            this.gbValorVenda.Location = new System.Drawing.Point(449, 28);
            this.gbValorVenda.Name = "gbValorVenda";
            this.gbValorVenda.Size = new System.Drawing.Size(185, 59);
            this.gbValorVenda.TabIndex = 13;
            this.gbValorVenda.TabStop = false;
            this.gbValorVenda.Text = "Valor Venda:";
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Enabled = false;
            this.txtValorVenda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVenda.Location = new System.Drawing.Point(6, 26);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(173, 27);
            this.txtValorVenda.TabIndex = 10;
            // 
            // gbValorCompra
            // 
            this.gbValorCompra.Controls.Add(this.txtValorCompra);
            this.gbValorCompra.ForeColor = System.Drawing.Color.White;
            this.gbValorCompra.Location = new System.Drawing.Point(8, 28);
            this.gbValorCompra.Name = "gbValorCompra";
            this.gbValorCompra.Size = new System.Drawing.Size(185, 59);
            this.gbValorCompra.TabIndex = 12;
            this.gbValorCompra.TabStop = false;
            this.gbValorCompra.Text = "*Valor Compra:";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorCompra.Location = new System.Drawing.Point(6, 28);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(173, 27);
            this.txtValorCompra.TabIndex = 9;
            this.txtValorCompra.TextChanged += new System.EventHandler(this.txtValorCompra_TextChanged);
            this.txtValorCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorCompra_KeyPress);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(5, 23);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(116, 26);
            this.txtQuantidade.TabIndex = 5;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 25);
            this.txtDescricao.MaxLength = 60;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(183, 26);
            this.txtDescricao.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(4, 22);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(286, 27);
            this.txtNome.TabIndex = 1;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Silver;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btExcluir.Image")));
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btExcluir.Location = new System.Drawing.Point(366, 520);
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
            this.btAtualizar.Location = new System.Drawing.Point(193, 520);
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
            this.btCadastrar.Location = new System.Drawing.Point(26, 520);
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
            this.btSair.Location = new System.Drawing.Point(540, 520);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(114, 40);
            this.btSair.TabIndex = 86;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCampoObrigatorio);
            this.groupBox1.Controls.Add(this.gbCalculo);
            this.groupBox1.Controls.Add(this.gbInformacaoProduto);
            this.groupBox1.Controls.Add(this.gbDataCadastro);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.gbCodigoProduto);
            this.groupBox1.Location = new System.Drawing.Point(11, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 437);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            // 
            // lbCampoObrigatorio
            // 
            this.lbCampoObrigatorio.AutoSize = true;
            this.lbCampoObrigatorio.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampoObrigatorio.ForeColor = System.Drawing.Color.Gold;
            this.lbCampoObrigatorio.Location = new System.Drawing.Point(354, 407);
            this.lbCampoObrigatorio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCampoObrigatorio.Name = "lbCampoObrigatorio";
            this.lbCampoObrigatorio.Size = new System.Drawing.Size(295, 19);
            this.lbCampoObrigatorio.TabIndex = 30;
            this.lbCampoObrigatorio.Text = "Todos os Campos com * são Obrigatórios !!!";
            // 
            // gbCalculo
            // 
            this.gbCalculo.Controls.Add(this.lbIgual);
            this.gbCalculo.Controls.Add(this.lbMultiplicacao);
            this.gbCalculo.Controls.Add(this.gbValorVenda);
            this.gbCalculo.Controls.Add(this.gbValorCompra);
            this.gbCalculo.Controls.Add(this.gbMargemLucro);
            this.gbCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalculo.ForeColor = System.Drawing.Color.White;
            this.gbCalculo.Location = new System.Drawing.Point(6, 296);
            this.gbCalculo.Name = "gbCalculo";
            this.gbCalculo.Size = new System.Drawing.Size(643, 99);
            this.gbCalculo.TabIndex = 36;
            this.gbCalculo.TabStop = false;
            this.gbCalculo.Text = "Calculo do Produto";
            // 
            // lbIgual
            // 
            this.lbIgual.AutoSize = true;
            this.lbIgual.Location = new System.Drawing.Point(422, 53);
            this.lbIgual.Name = "lbIgual";
            this.lbIgual.Size = new System.Drawing.Size(21, 24);
            this.lbIgual.TabIndex = 16;
            this.lbIgual.Text = "=";
            // 
            // lbMultiplicacao
            // 
            this.lbMultiplicacao.AutoSize = true;
            this.lbMultiplicacao.Location = new System.Drawing.Point(201, 53);
            this.lbMultiplicacao.Name = "lbMultiplicacao";
            this.lbMultiplicacao.Size = new System.Drawing.Size(20, 24);
            this.lbMultiplicacao.TabIndex = 15;
            this.lbMultiplicacao.Text = "x";
            // 
            // gbInformacaoProduto
            // 
            this.gbInformacaoProduto.Controls.Add(this.gbMarca);
            this.gbInformacaoProduto.Controls.Add(this.gbFornecedor);
            this.gbInformacaoProduto.Controls.Add(this.gbCategoria);
            this.gbInformacaoProduto.Controls.Add(this.gbQuantidade);
            this.gbInformacaoProduto.Controls.Add(this.gbDescricao);
            this.gbInformacaoProduto.Controls.Add(this.gbNome);
            this.gbInformacaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInformacaoProduto.ForeColor = System.Drawing.Color.White;
            this.gbInformacaoProduto.Location = new System.Drawing.Point(6, 113);
            this.gbInformacaoProduto.Name = "gbInformacaoProduto";
            this.gbInformacaoProduto.Size = new System.Drawing.Size(643, 172);
            this.gbInformacaoProduto.TabIndex = 35;
            this.gbInformacaoProduto.TabStop = false;
            this.gbInformacaoProduto.Text = "Informações do Produto";
            // 
            // gbMarca
            // 
            this.gbMarca.Controls.Add(this.cbMarca);
            this.gbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbMarca.ForeColor = System.Drawing.Color.White;
            this.gbMarca.Location = new System.Drawing.Point(461, 103);
            this.gbMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbMarca.Size = new System.Drawing.Size(173, 58);
            this.gbMarca.TabIndex = 77;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "*Marca:";
            // 
            // gbFornecedor
            // 
            this.gbFornecedor.Controls.Add(this.cbFornecedor);
            this.gbFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFornecedor.ForeColor = System.Drawing.Color.White;
            this.gbFornecedor.Location = new System.Drawing.Point(8, 102);
            this.gbFornecedor.Name = "gbFornecedor";
            this.gbFornecedor.Size = new System.Drawing.Size(237, 59);
            this.gbFornecedor.TabIndex = 76;
            this.gbFornecedor.TabStop = false;
            this.gbFornecedor.Text = "*Fornecedor:";
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.ForeColor = System.Drawing.Color.White;
            this.gbCategoria.Location = new System.Drawing.Point(251, 102);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(205, 59);
            this.gbCategoria.TabIndex = 75;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "*Categoria:";
            // 
            // gbQuantidade
            // 
            this.gbQuantidade.Controls.Add(this.txtQuantidade);
            this.gbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbQuantidade.ForeColor = System.Drawing.Color.White;
            this.gbQuantidade.Location = new System.Drawing.Point(508, 27);
            this.gbQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbQuantidade.Name = "gbQuantidade";
            this.gbQuantidade.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbQuantidade.Size = new System.Drawing.Size(126, 58);
            this.gbQuantidade.TabIndex = 74;
            this.gbQuantidade.TabStop = false;
            this.gbQuantidade.Text = "*Quantidade:";
            // 
            // gbDescricao
            // 
            this.gbDescricao.Controls.Add(this.txtDescricao);
            this.gbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDescricao.ForeColor = System.Drawing.Color.White;
            this.gbDescricao.Location = new System.Drawing.Point(308, 26);
            this.gbDescricao.Name = "gbDescricao";
            this.gbDescricao.Size = new System.Drawing.Size(195, 59);
            this.gbDescricao.TabIndex = 73;
            this.gbDescricao.TabStop = false;
            this.gbDescricao.Text = "*Descrição:";
            // 
            // gbNome
            // 
            this.gbNome.Controls.Add(this.txtNome);
            this.gbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbNome.ForeColor = System.Drawing.Color.White;
            this.gbNome.Location = new System.Drawing.Point(8, 27);
            this.gbNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNome.Name = "gbNome";
            this.gbNome.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNome.Size = new System.Drawing.Size(295, 58);
            this.gbNome.TabIndex = 6;
            this.gbNome.TabStop = false;
            this.gbNome.Text = "*Nome:";
            // 
            // gbDataCadastro
            // 
            this.gbDataCadastro.Controls.Add(this.lbDataCadastro);
            this.gbDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDataCadastro.ForeColor = System.Drawing.Color.White;
            this.gbDataCadastro.Location = new System.Drawing.Point(267, 19);
            this.gbDataCadastro.Name = "gbDataCadastro";
            this.gbDataCadastro.Size = new System.Drawing.Size(223, 74);
            this.gbDataCadastro.TabIndex = 32;
            this.gbDataCadastro.TabStop = false;
            this.gbDataCadastro.Text = "*Data de Cadastro";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.cbStatus);
            this.gbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.Color.White;
            this.gbStatus.Location = new System.Drawing.Point(527, 19);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(121, 74);
            this.gbStatus.TabIndex = 31;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "*Status";
            // 
            // gbCodigoProduto
            // 
            this.gbCodigoProduto.Controls.Add(this.txtCodigoProduto);
            this.gbCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCodigoProduto.ForeColor = System.Drawing.Color.White;
            this.gbCodigoProduto.Location = new System.Drawing.Point(5, 19);
            this.gbCodigoProduto.Name = "gbCodigoProduto";
            this.gbCodigoProduto.Size = new System.Drawing.Size(223, 74);
            this.gbCodigoProduto.TabIndex = 33;
            this.gbCodigoProduto.TabStop = false;
            this.gbCodigoProduto.Text = "*Código do Produto";
            // 
            // pnTituloCliente
            // 
            this.pnTituloCliente.Controls.Add(this.lbCadProduto);
            this.pnTituloCliente.ForeColor = System.Drawing.Color.White;
            this.pnTituloCliente.Location = new System.Drawing.Point(11, 11);
            this.pnTituloCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTituloCliente.Name = "pnTituloCliente";
            this.pnTituloCliente.Size = new System.Drawing.Size(655, 53);
            this.pnTituloCliente.TabIndex = 81;
            // 
            // lbCadProduto
            // 
            this.lbCadProduto.AutoSize = true;
            this.lbCadProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCadProduto.ForeColor = System.Drawing.Color.White;
            this.lbCadProduto.Location = new System.Drawing.Point(183, 10);
            this.lbCadProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCadProduto.Name = "lbCadProduto";
            this.lbCadProduto.Size = new System.Drawing.Size(317, 33);
            this.lbCadProduto.TabIndex = 67;
            this.lbCadProduto.Text = "Cadastro de Produtos";
            // 
            // form_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(677, 575);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnTituloCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "H&C - Cadastro de Produtos";
            this.Load += new System.EventHandler(this.form_produto_Load);
            this.gbMargemLucro.ResumeLayout(false);
            this.gbMargemLucro.PerformLayout();
            this.gbValorVenda.ResumeLayout(false);
            this.gbValorVenda.PerformLayout();
            this.gbValorCompra.ResumeLayout(false);
            this.gbValorCompra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCalculo.ResumeLayout(false);
            this.gbCalculo.PerformLayout();
            this.gbInformacaoProduto.ResumeLayout(false);
            this.gbMarca.ResumeLayout(false);
            this.gbFornecedor.ResumeLayout(false);
            this.gbCategoria.ResumeLayout(false);
            this.gbQuantidade.ResumeLayout(false);
            this.gbQuantidade.PerformLayout();
            this.gbDescricao.ResumeLayout(false);
            this.gbDescricao.PerformLayout();
            this.gbNome.ResumeLayout(false);
            this.gbNome.PerformLayout();
            this.gbDataCadastro.ResumeLayout(false);
            this.gbDataCadastro.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbCodigoProduto.ResumeLayout(false);
            this.gbCodigoProduto.PerformLayout();
            this.pnTituloCliente.ResumeLayout(false);
            this.pnTituloCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.CheckBox cbStatus;
        public System.Windows.Forms.Label lbDataCadastro;
        public System.Windows.Forms.TextBox txtCodigoProduto;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtMargemDeLucro;
        public System.Windows.Forms.TextBox txtValorVenda;
        public System.Windows.Forms.TextBox txtValorCompra;
        public System.Windows.Forms.ComboBox cbFornecedor;
        public System.Windows.Forms.ComboBox cbMarca;
        public System.Windows.Forms.ComboBox cbCategoria;
        public System.Windows.Forms.GroupBox gbMargemLucro;
        public System.Windows.Forms.GroupBox gbValorVenda;
        public System.Windows.Forms.GroupBox gbValorCompra;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btAtualizar;
        public System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbInformacaoProduto;
        private System.Windows.Forms.Label lbCampoObrigatorio;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.GroupBox gbFornecedor;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.GroupBox gbQuantidade;
        private System.Windows.Forms.GroupBox gbDescricao;
        private System.Windows.Forms.GroupBox gbNome;
        private System.Windows.Forms.GroupBox gbDataCadastro;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.GroupBox gbCodigoProduto;
        private System.Windows.Forms.Panel pnTituloCliente;
        private System.Windows.Forms.Label lbCadProduto;
        private System.Windows.Forms.GroupBox gbCalculo;
        private System.Windows.Forms.Label lbIgual;
        private System.Windows.Forms.Label lbMultiplicacao;
    }
}