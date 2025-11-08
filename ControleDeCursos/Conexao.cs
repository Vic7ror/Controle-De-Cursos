using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    internal class Conexao
    {
        //Definir qual é o banco de dados.
        MySqlConnection conexao;

        //Método para conectar ao banco de dados MySql.
        public void Conectar()
        {
            try
            {
                //Passo 1 -> Definir as informações da conexão.
                //"Pesist Security Info=false;" -> Exclui informações após conexão com o banco de dados.
                string dados_conexao = "server = localhost; " +
                                       "database = controle_de_curso; " +
                                       "uid = root; pwd = ";

                //Passo 2 -> Criar a conexão com o MySql.
                conexao = new MySqlConnection(dados_conexao);
                //Passo 3 -> Abrir a Conexão com o banco.
                conexao.Open();
            }
            catch (MySqlException erro) 
            {
                //Mostrando o erro
                throw new Exception("Não foi possível conectar ao banco!" + erro.Message);
            }
        }


        //Método para executar os comandos de insert, update ou delete.
        public void ExecutarComando(string sql)
        {
            try
            {
                //Passo 1 -> Conectar ao banco de dados.
                Conectar();
                //Passo 2 -> Preparar o comando sql.
                MySqlCommand comando = new MySqlCommand(sql,conexao);
                //Passo 3 -> Executar o comando sql.
                comando.ExecuteNonQuery();
                //Passo 4 -> Fechar a conexão com o banco.
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                //Mostrando o erro
                throw new Exception("Não foi possível executar a instrução" + "desejada! " + erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        //Método para executar as consultas sql - select.
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                //Passo 1 -> Conectar ao banco.
                Conectar();

                //Passo 2 -> Executar a consulta sql.
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);

                //Passo 3 -> Onde será guardado o resultado da consulta.
                DataTable dt = new DataTable(); //O(s) resultado(s) da consulta serão guardados neste DataTable.

                //Passo 4 -> Guardar os dados da consulta no DataTable.
                dados.Fill(dt);

                //Passo 5 -> Fechar a conexão com o banco.
                conexao.Close();
                return dt;
            }
            catch (MySqlException erro)
            {
                //Mostrando o erro
                throw new Exception("Não foi possível executar a instrução" + "desejada! " + erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
