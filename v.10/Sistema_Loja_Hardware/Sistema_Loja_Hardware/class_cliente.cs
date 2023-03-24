using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Loja_Hardware
{
    class class_cliente
    {
        //CONSTRUTOR
        public class_cliente()
        {
            codigo_cliente = 0;
            nome = null;
            data_nascimento = DateTime.Now;
            sexo = null;
            estado_civil = null;
            cpf = null;
            rg = null;
            telefone_principal = null;
            telefone_recado = null;
            email = null;
            cep = null;
            endereco = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        //PROPRIEDADES
        public int codigo_cliente { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string telefone_principal { get; set; }
        public string telefone_recado { get; set; }
        public string email { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }

        public int CadastrarCliente()
        {
            string query = " INSERT INTO cliente VALUES (0, '" + nome + "', '" + data_nascimento.ToString("yyyy-MM-dd") + "', '" + sexo + "', '" + estado_civil + "', '" + cpf + "', '" + rg + "' ,'" + telefone_principal + "','" + telefone_recado + "', '" + email + "', '" + cep + "', '" + endereco + "' , " + numero + ", '" + complemento + "', '" + bairro + "', '" + cidade + "','" + estado + "', 1, now())  ";

            //CRIAR OBJETO DA CLASSE CONEXÃO, PARA USAR O MÉTODO EXECUTAQUERY QUE SERVE PARA EXECUTAR TODOS OS INSERT, UPDATE OU DELETE
            classConexao cConexao = new classConexao();
            //CHAMAR O MÉTODO EXECUTAQUERY PASSANDO OM PARÂMETRO 
            return cConexao.ExecutaQuery(query);



        }
    }

    
}
