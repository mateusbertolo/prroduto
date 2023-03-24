using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Sistema_Loja_Hardware
{
    class class_cargo
    {
        public class_cargo()
        {
            codigo_cargo = 0;
            nome = null;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now;
        }

        //PROPRIEDADES - LER, GRAVAR E CALCULAR 
        //ATALHO PARA CRIAR AS PROPRIEDADES: PROP TAB TAB
        public int codigo_cargo { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public int status { get; set; }
        public DateTime data_cadastro { get; set; }

        //MÉTODOS - AÇÕES DO SISTEMA

        //PARA CRIAR UM MÉTODO: TIPO DO MÉTODO - TIPO DE RETORNO - NOME DO MÉTODO - PARÂMETROS()

        //FAZER O INSERT NA SEQUENCIA DA TABELA CRIADA NO BD - NÃO USAR ASPAS SIMPLES PARA CAMPOS DO TIPO BIT

        //MÉTODO PARA CADASTRAR CARGO
        public int CadastrarCargo()
        {
            string query = " INSERT INTO cargo VALUES (0, '" + nome + "',    '" + observacao + "', 1, now() ) ";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(query);
        }

        //MÉTODO PARA CARREGAR A COMBO DE CARGO NO FORM DE FUNCIONÁRIO
        public DataTable BuscarCargo()
        {
            string query = "SELECT codigo_cargo, nome FROM cargo WHERE status = 1 ORDER BY nome";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDataTable(query);

        }
    }
}
