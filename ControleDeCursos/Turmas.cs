using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    internal class Turmas
    {
        //VARIÁVEIS E CONEXÃO 
        public int codigo;
        public string HoraInicio, cod_professor, cod_curso, HoraTermino, dtInicio, dtTermino;
        public string tabela = "turma";
        Conexao objConexao = new Conexao();

        //LISTA PROFESSORES
        public DataTable ListarProfessor()
        {
            string professores = "SELECT codigo, nomeProfessor FROM professor ORDER BY codigo;";
            return objConexao.ExecutarConsulta(professores);
        }

        //LISTA CURSOS
        public DataTable ListarCurso()
        {
            string cursos = "SELECT codigo, nomeCurso FROM curso ORDER BY codigo;";
            return objConexao.ExecutarConsulta(cursos);
        }

        //CADASTRA NOVA TURMA
        public void CadastrarTurma()
        {
            int codigo_prof = int.Parse(cod_professor);
            int codigo_curso = int.Parse(cod_curso);

            string cadastrar = $@"INSERT INTO {tabela}
            VALUES(
            null, '{HoraInicio}', '{HoraTermino}', 
            '{dtInicio}', '{dtTermino}',
            '{codigo_prof}', '{codigo_curso}'
            );";
            objConexao.ExecutarComando(cadastrar);
        }

        //LISTA AS TURMAS
        public DataTable ListarTurmas()
        {
            string turmas = $"SELECT * FROM {tabela} ORDER BY codigo";
            return objConexao.ExecutarConsulta(turmas);
        }

        //EXCLUI A TURMA
        public void ExcluirTurma()
        {
            string excluir = $"DELETE FROM {tabela} WHERE codigo = '{codigo}';";
            objConexao.ExecutarComando(excluir);
        }

        //ALTERA DADOS DA ATURMA
        public void AlterarTurma()
        {
            int codigo_prof = int.Parse(cod_professor);
            int codigo_curso = int.Parse(cod_curso);

            string alterar = $@"UPDATE {tabela} 
            SET HoraInicio = '{HoraInicio}', HoraTermino = '{HoraTermino}',
            dataInicio = '{dtInicio}', dataTermino = '{dtTermino}',
            cod_professor = '{codigo_prof}', cod_curso = '{codigo_curso}'";
            objConexao.ExecutarComando(alterar);
        }
    }
}
