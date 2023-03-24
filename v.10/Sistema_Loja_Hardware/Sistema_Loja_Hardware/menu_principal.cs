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
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
            customize_design();
        }

        private void customize_design()
        {
            panel_cadastro_submenu.Visible = false;
            panel_venda_submenu.Visible = false;
            panel_consulta_submenu.Visible = false;
            panel_relatorio_submenu.Visible = false;
        }

        private void hide_submenu_design()
        {
            if (panel_cadastro_submenu.Visible == true)
                panel_cadastro_submenu.Visible = false;

            if (panel_venda_submenu.Visible == true)
                panel_venda_submenu.Visible = false;

            if (panel_consulta_submenu.Visible == true)
                panel_consulta_submenu.Visible = false;

            if (panel_relatorio_submenu.Visible == true)
                panel_relatorio_submenu.Visible = false;
        }

        private void show_submenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hide_submenu_design();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            show_submenu(panel_cadastro_submenu);
        }

        private void btn_cad_cargo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_cargo>().Count() > 0)
            {
                MessageBox.Show("O cadastro de Cargos já está ABERTO!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form_cargo obj_cad_cargo = new form_cargo();

                obj_cad_cargo.MdiParent = this;

                obj_cad_cargo.Show();
            }
            hide_submenu_design();
        }

        private void btn_cad_setor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_setor>().Count() > 0)
            {
                MessageBox.Show("O cadastro de Setores já está ABERTO!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form_setor obj_cad_setor = new form_setor();

                obj_cad_setor.MdiParent = this;

                obj_cad_setor.Show();
            }
            hide_submenu_design();
        }

        private void btn_cad_funcionario_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_funcionario>().Count() > 0)
            {
                MessageBox.Show("O cadastro de Funcionários já está ABERTO!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form_funcionario obj_cad_funcionario = new form_funcionario();

                obj_cad_funcionario.MdiParent = this;

                obj_cad_funcionario.Show();
            }
            hide_submenu_design();
        }

        private void btn_cad_cliente_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<form_cliente>().Count() > 0)
            {
                MessageBox.Show("O cadastro de Clientes já está ABERTO!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form_cliente obj_cad_cliente = new form_cliente();

                obj_cad_cliente.MdiParent = this;

                obj_cad_cliente.Show();
            }
            hide_submenu_design();
        }

        private void bt_cad_fornecedor_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<form_fornecedor>().Count() > 0)
            {
                MessageBox.Show("O cadastro de Fornecedor já está ABERTO!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form_fornecedor obj_cad_fornecedor = new form_fornecedor();

                obj_cad_fornecedor.MdiParent = this;

                obj_cad_fornecedor.Show();
            }
            hide_submenu_design();
        }

        private void bt_cad_categoria_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<form_categoria>().Count() > 0)
            {
                MessageBox.Show("O cadastro de Categoria já está ABERTO!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form_categoria obj_cad_categoria = new form_categoria();

                obj_cad_categoria.MdiParent = this;

                obj_cad_categoria.Show();
            }
        }

        private void bt_cad_marca_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<form_marca>().Count()> 0)
            {
                MessageBox.Show("O cadastro de Marca já está ABERTO!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form_marca obj_cad_marca = new form_marca();

                obj_cad_marca.MdiParent = this;

                obj_cad_marca.Show();
            }
        }

        private void bt_cad_produto_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<form_produto>().Count()> 0)
            {
                MessageBox.Show("O cadastro de Produto já está ABERTO!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                form_produto obj_cad_produto = new form_produto();

                obj_cad_produto.MdiParent = this;

                obj_cad_produto.Show();
            }
        }
    }
}
