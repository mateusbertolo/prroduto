using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLojaCosmeticosInfo42
{
    class classFuncionario
    {
        //CONSTRUTOR
        public classFuncionario()
        {
            codigo_funcionario = 0;
            nome = null;
            data_nascimento = DateTime.Now;
            sexo = null;
            estado_civil = null;
            cpf = null;
            rg = null;
            salario = 0;
            endereco = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            cep = null;
            telefone_residencial = null;
            telefone_recado = null;
            telefone_celular = null;
            email = null;
            status = 0;
            data_cadastro = DateTime.Now;
            codigo_cargo = 0;
            codigo_setor = 0;
        }

        //PROPRIEDADES
        public int codigo_funcionario { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public string sexo { get; set; }
        public string estado_civil { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public decimal salario { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string telefone_residencial { get; set; }
        public string telefone_recado { get; set; }
        public string telefone_celular { get; set; }
        public string email { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }
        public int codigo_cargo { get; set; }
        public int codigo_setor { get; set; }

        //CAMPOS DATE: propiedade.ToString("yyyy-MM-dd")
        //CAMPOS DECIMAL: propriedade.ToString().Replace("," , ".")

        //MÉTODO PARA CADASTRAR FUNCIONÁRIO
        public int CadastrarFuncionario()
        {
            string query = " INSERT INTO funcionario VALUES (0, '"+ nome +"', '"+ data_nascimento.ToString("yyyy-MM-dd")+"', '"+ sexo +"', '"+ estado_civil +"', '"+ cpf + "', '" + rg + "' , '" + salario.ToString().Replace("," , ".") + "', '" + endereco + "', " + numero + ", '" + complemento + "' , '" + bairro + "', '" + cidade + "', '" + estado + "', '" + cep + "', '" + telefone_residencial + "', '" + telefone_recado + "', '" + telefone_celular + "', '" + email + "', 1, now(), " + codigo_cargo + ", " + codigo_setor + " )  ";

            //CRIAR OBJETO DA CLASSE CONEXÃO, PARA USAR O MÉTODO EXECUTAQUERY QUE SERVE PARA EXECUTAR TODOS OS INSERT, UPDATE OU DELETE
            classConexao cConexao = new classConexao();
            //CHAMAR O MÉTODO EXECUTAQUERY PASSANDO OM PARÂMETRO 
            return cConexao.ExecutaQuery(query);



        }

    }
}
