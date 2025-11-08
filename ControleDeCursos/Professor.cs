using System;
using System.Data;

namespace ControleDeCursos
{
    internal class Professor
    {
        //VARIÁVEIS E CONEXÃO 
        public int codigo;
        public string nomeCompleto;
        public string telefone;
        public string tabela = "professor";
        public double valorHora;
        Conexao objConexao = new Conexao();

        // Helper para escapar aspas simples em literais SQL (quando usar string concatenada)
        private string SqlEscape(string valor)
        {
            return valor == null ? string.Empty : valor.Replace("'", "''");
        }

        //CADASTRA NOVO PROFESSOR
        public void CadastrarProfessor()
        {
            // Ajuste: usar o nome da coluna que existe no banco ("nomeProfessor") e formatar double com InvariantCulture
            string sql = $"INSERT INTO {tabela} (nomeProfessor, valorHora, telefone) " +
                         $"VALUES ('{SqlEscape(nomeCompleto)}', {valorHora.ToString(System.Globalization.CultureInfo.InvariantCulture)}, '{SqlEscape(telefone)}')";
            objConexao.ExecutarComando(sql);
        }

        //LISTA PROFESSORES
        public DataTable ListarProfessor()
        {
            // Seleciona colunas explicitamente para evitar dependência de ordem do SELECT *
            string listar = $"SELECT codigo, nomeProfessor AS nomeCompleto, valorHora, telefone FROM {tabela} ORDER BY codigo";
            return objConexao.ExecutarConsulta(listar);
        }

        //EXCLUI PROFESSOR
        public void ExcluirProfessor()
        {
            // código é numérico — não é necessário aspas
            string excluir = $"DELETE FROM {tabela} WHERE codigo = {codigo}";
            objConexao.ExecutarComando(excluir);
        }

        //ALTERA DADOS DO PROFESSOR
        public void AlterarProfessor()
        {
            // Removido vírgula extra antes do WHERE e uso de nomes de coluna consistentes
            string alterar = $"UPDATE {tabela} SET " +
                             $"nomeProfessor = '{SqlEscape(nomeCompleto)}', " +
                             $"valorHora = {valorHora.ToString(System.Globalization.CultureInfo.InvariantCulture)}, " +
                             $"telefone = '{SqlEscape(telefone)}' " +
                             $"WHERE codigo = {codigo}";
            objConexao.ExecutarComando(alterar);
        }
    }
}
