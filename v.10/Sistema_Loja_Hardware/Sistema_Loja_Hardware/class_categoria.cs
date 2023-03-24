using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema_Loja_Hardware
{
    class class_categoria
    {
        public class_categoria()
        {
            codigo_categoria = 0;
            nome = null;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        public int codigo_categoria { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }


        public int CadastrarCategoria()
        {
            string query = " INSERT INTO categoria VALUES (0, '" + nome + "',    '" + observacao + "', 1, now() ) ";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(query);
        }

        public DataTable BuscarCategoria()
        {
            string query = "SELECT codigo_categoria, nome FROM categoria WHERE status = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }
    }
}
