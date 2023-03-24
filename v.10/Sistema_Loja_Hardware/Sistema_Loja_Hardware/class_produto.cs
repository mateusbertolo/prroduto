using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Loja_Hardware
{
    class class_produto
    {
        public class_produto()
        {
            codigo_produto = 0;
            nome = null;
            descricao = null;
            quantidade = 0;
            valor_compra = 0;
            valor_venda = 0;
            margem_de_lucro = 0;
            status = 0;
            data_cadastro = DateTime.Now;
            codigo_fornecedor = 0;
            codigo_categoria = 0;
            codigo_marca = 0;
        }

        public int codigo_produto { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public decimal valor_compra { get; set; }
        public int margem_de_lucro { get; set; }
        public decimal valor_venda { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }
        public int codigo_fornecedor { get; set; }
        public int codigo_categoria { get; set; }
        public int codigo_marca { get; set; }

        public int CadastrarProduto()
        {
            string query = "INSERT INTO produto VALUES(0,'" + nome + "','" + descricao + "', " + quantidade + ", '" + valor_compra.ToString().Replace(",", ".") + "', " + margem_de_lucro + ",'" + valor_venda.ToString().Replace(",", ".") + "',1,now()," + codigo_fornecedor + ", " + codigo_categoria + "," + codigo_marca + ")";


            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(query);
        }
    }
}

