using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema_Loja_Hardware
{
    class class_fornecedor
    {
        //Contrutor
        public class_fornecedor()
        {
            codigo_fornecedor = 0;
            razao_social = null;
            nome_fantasia = null;
            cnpj = null;
            telefone_principal = null;
            telefone_recado = null;
            email = null;
            endereco = null;
            numero = 0;
            bairro = null;
            complemento = null;
            cidade = null;
            estado = null;
            cep = null;
            status = 0;
            data_cadastro = DateTime.Now;
         }

        public int codigo_fornecedor { get; set; }
        public string razao_social  { get; set; }
        public string nome_fantasia  { get; set; }
        public string cnpj  { get; set; }
        public string telefone_principal { get; set; }
        public string telefone_recado { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public int status  { get; set; }
        public DateTime data_cadastro  { get; set; }

        public int CadastrarFornecedor()
        {
            string query = "INSERT INTO fornecedor VALUES(0,'" + razao_social + "','" + nome_fantasia + "','" + cnpj + "','" + telefone_principal + "', '" + telefone_recado + "','" + email + "','" + endereco + "'," + numero + ",'" + bairro + "','" + complemento + "','" + cidade + "','" + estado + "','" + cep + "',1,now())";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(query);
        }

        public DataTable BuscarFornecedor()
        {
            string query = "SELECT codigo_fornecedor, razao_social FROM fornecedor WHERE status = 1 ORDER BY razao_social";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }
    }
}
