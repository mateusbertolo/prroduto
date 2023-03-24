using System;
using System.Data;

namespace Sistema_Loja_Hardware
{
    class class_marca
    {
        public class_marca()
        {
            codigo_marca = 0;
            nome = null;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        public int codigo_marca { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }

 
        public int CadastrarMarca()
        {
            string query = " INSERT INTO marca VALUES (0, '" + nome + "',    '" + observacao + "', 1, now() ) ";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(query);
        }

        public DataTable BuscarMarca()
        {
            string query = "SELECT codigo_marca, nome FROM marca WHERE status = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }
    }
}
