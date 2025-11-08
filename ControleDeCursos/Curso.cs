using System;
using System.Data;

namespace ControleDeCursos
{
    internal class Curso
    {
        //VARIÁVEIS E CONEXÃO 
        public int codigo;
        public int cargaHoraria;
        public string nomeCurso;
        public string conteudo;
        public string tabela = "curso";
        public double valorMensalidade;
        Conexao objConexao = new Conexao();

        // Helper para escapar aspas simples em literais SQL (quando usar string concatenada)
        private string SqlEscape(string valor)
        {
            return valor == null ? string.Empty : valor.Replace("'", "''");
        }

        //CADASTRA NOVO CURSO
        public void CadastrarCurso()
        {
            string sql = $"INSERT INTO {tabela} (nomeCurso, conteudo, valorMensalidade, cargaHoraria) " +
                         $"VALUES ('{SqlEscape(nomeCurso)}', '{SqlEscape(conteudo)}', {valorMensalidade.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {cargaHoraria})";
            objConexao.ExecutarComando(sql);
        }

        //LISTA OS CURSOS
        public DataTable ListarCurso()
        {
            string listar = $"SELECT codigo, nomeCurso, conteudo, valorMensalidade, cargaHoraria FROM {tabela} ORDER BY codigo";
            return objConexao.ExecutarConsulta(listar);
        }

        //EXCLUI O CURSO
        public void ExcluirCurso()
        {
            string excluir = $"DELETE FROM {tabela} WHERE codigo = {codigo}";
            objConexao.ExecutarComando(excluir);
        }

        //ALTERA DADOS DO CURSO
        public void AlterarCurso()
        {
            string alterar = $"UPDATE {tabela} SET " +
                             $"nomeCurso = '{SqlEscape(nomeCurso)}', " +
                             $"conteudo = '{SqlEscape(conteudo)}', " +
                             $"valorMensalidade = {valorMensalidade.ToString(System.Globalization.CultureInfo.InvariantCulture)}, " +
                             $"cargaHoraria = {cargaHoraria} " +
                             $"WHERE codigo = {codigo}";
            objConexao.ExecutarComando(alterar);
        }
    }
}
