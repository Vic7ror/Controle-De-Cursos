using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    internal class Professor
    {
        //VARIÁVEIS E CONEXÃO 
        public int codigo;
        public string nomeCompleto, telefone;
        public string tabela = "professor";
        public double valorHora;
        Conexao objConexao = new Conexao();

        //CADASTRA NOVO PROFESSOR
        public void CadastrarProfessor()
        {
            string cadastrar =
                $@"INSERT INTO {tabela} 
                VALUES (
                null, '{nomeCompleto}', 
                '{valorHora}','{telefone}'
                )";
            objConexao.ExecutarComando(cadastrar);
        }

        //LISTA PROFESSORES
        public DataTable ListarProfessor()
        {
            string listar = $"SELECT * FROM {tabela} ORDER BY codigo;";
            return objConexao.ExecutarConsulta(listar);
        }

        //EXCLUI PROFESSOR
        public void ExcluirProfessor()
        {
            string excluir = $"DELETE FROM {tabela} WHERE codigo = '{codigo}';";
            objConexao.ExecutarComando(excluir);
        }

        //ATERA DADOS DO PROFESSOR
        public void AlterarProfessor()
        {
            string alterar = $@"UPDATE {tabela} 
                SET nomeProfessor = '{nomeCompleto}', valorHora = '{valorHora}',
                telefone = '{telefone}',
                WHERE codigo = '{codigo}';";
            objConexao.ExecutarComando(alterar);
        }
    }
}
