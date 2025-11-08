using System;
using System.Data;
using System.Globalization;

namespace ControleDeCursos
{
    internal class Turmas
    {
        //VARIÁVEIS E CONEXÃO 
        public int codigo;
        // datas em ISO yyyy-MM-dd
        public string dtInicio;
        public string dtTermino;
        // horários em HH:mm:ss
        public string HoraInicio;
        public string HoraTermino;
        // chaves estrangeiras (numéricas)
        public int cod_professor;
        public int cod_curso;
        public string tabela = "turma";
        Conexao objConexao = new Conexao();

        // Helper para escapar aspas simples em literais SQL (quando usar string concatenada)
        private string SqlEscape(string valor)
        {
            return valor == null ? string.Empty : valor.Replace("'", "''");
        }

        // LISTA PROFESSORES (repete comportamento esperado pelo formulário)
        public DataTable ListarProfessor()
        {
            string sql = "SELECT codigo, nomeProfessor AS nomeCompleto FROM professor ORDER BY codigo";
            return objConexao.ExecutarConsulta(sql);
        }

        // LISTA CURSOS
        public DataTable ListarCurso()
        {
            string sql = "SELECT codigo, nomeCurso FROM curso ORDER BY codigo";
            return objConexao.ExecutarConsulta(sql);
        }

        // CADASTRA NOVA TURMA
        public void CadastrarTurma()
        {
            // Ajuste: usar os nomes de coluna corretos existentes no banco (ex.: dataInicio / dataTermino)
            string sql = $"INSERT INTO {tabela} (dataInicio, dataTermino, HoraInicio, HoraTermino, cod_professor, cod_curso) " +
                         $"VALUES ('{SqlEscape(dtInicio)}', '{SqlEscape(dtTermino)}', '{SqlEscape(HoraInicio)}', '{SqlEscape(HoraTermino)}', {cod_professor}, {cod_curso})";
            objConexao.ExecutarComando(sql);
        }

        // LISTA AS TURMAS
        public DataTable ListarTurmas()
        {
            // Seleciona colunas explicitamente de acordo com o esquema que a UI apresenta
            string sql = $"SELECT codigo, HoraInicio, HoraTermino, dataInicio, dataTermino, cod_professor, cod_curso FROM {tabela} ORDER BY codigo";
            return objConexao.ExecutarConsulta(sql);
        }

        // EXCLUI A TURMA
        public void ExcluirTurma()
        {
            string sql = $"DELETE FROM {tabela} WHERE codigo = {codigo}";
            objConexao.ExecutarComando(sql);
        }

        // ALTERA DADOS DA TURMA
        public void AlterarTurma()
        {
            string sql = $"UPDATE {tabela} SET " +
                         $"dataInicio = '{SqlEscape(dtInicio)}', " +
                         $"dataTermino = '{SqlEscape(dtTermino)}', " +
                         $"HoraInicio = '{SqlEscape(HoraInicio)}', " +
                         $"HoraTermino = '{SqlEscape(HoraTermino)}', " +
                         $"cod_professor = {cod_professor}, " +
                         $"cod_curso = {cod_curso} " +
                         $"WHERE codigo = {codigo}";
            objConexao.ExecutarComando(sql);
        }
    }
}
