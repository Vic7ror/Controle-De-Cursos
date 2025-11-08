using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    internal class Curso
    {
        //VARIÁVEIS E CONEXÃO 
        public int codigo, cargaHoraria;
        public string nomeCurso, conteudo;
        public string tabela = "curso";
        public double valorMensalidade;
        Conexao objConexao = new Conexao();

        //CADASTRA NOVO CURSO
        public void CadastrarCurso()
        {
            string cadastrar = 
                $@"INSERT INTO {tabela} 
                VALUES (
                null, '{nomeCurso}', '{conteudo}',
                '{valorMensalidade}', '{cargaHoraria}'
                )";
            objConexao.ExecutarComando(cadastrar);
        }

        //LISTA OS CURSOS
        public DataTable ListarCurso()
        {
            string listar = $"SELECT * FROM {tabela} ORDER BY codigo;";
            return objConexao.ExecutarConsulta(listar);
        }

        //EXCLUI O CURSO
        public void ExcluirCurso()
        {
            string excluir = $"DELETE FROM {tabela} WHERE codigo = '{codigo}';";
            objConexao.ExecutarComando(excluir);
        }

        //ALTERA DADOS DO CURSO
        public void AlterarCurso()
        {
            string alterar = $@"UPDATE {tabela} 
                SET  nome = '{nomeCurso}', conteudo = '{conteudo}',
                valorMensalidade = '{valorMensalidade}', cargaHoraria = '{cargaHoraria}',
                WHERE codigo = '{codigo}';";
            objConexao.ExecutarComando(alterar);
        }

    }
}
