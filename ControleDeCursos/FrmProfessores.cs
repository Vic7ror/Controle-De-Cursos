using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class frm_professores : Form
    {
        //INSTÂNCIA CLASSE PROFESSOR
        Professor objProf = new Professor();
        public frm_professores()
        {
            InitializeComponent();
        }

        //LISTA PROFESSORES CADASTRADOS NO BANCO
        private void frm_professores_Load(object sender, EventArgs e)
        {
            dtg_professores.DataSource = objProf.ListarProfessor();
        }

        //CADASTRA NOVO PROFESSOR
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            objProf.nomeCompleto = txt_nomeProf.Text;
            objProf.valorHora = double.Parse(txt_valorHora.Text);
            objProf.telefone = txt_telefone.Text;

            objProf.CadastrarProfessor();
            MessageBox.Show("Professor cadastrado com sucesso!!");

            txt_nomeProf.Clear();
            txt_valorHora.Value = 0;
            txt_telefone.Clear();
        }

        //ALTERA OS DADOS DO PROFESSOR COM (CODIGO CORRESPONDENTE)
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            objProf.codigo = int.Parse(txt_codProf.Text);
            objProf.nomeCompleto = txt_nomeProf.Text;
            objProf.valorHora = double.Parse(txt_valorHora.Text);
            objProf.telefone = txt_telefone.Text;

            objProf.AlterarProfessor();
            MessageBox.Show("Professor alterado com sucesso!!");

            txt_codProf.Clear();
            txt_nomeProf.Clear();
            txt_valorHora.Value = 0;
            txt_telefone.Clear();
        }

        //EXCLUI PROFESSOR DO BANCO COM (CODIGO CORRESPONDENTE)
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            objProf.codigo = int.Parse(txt_codProf.Text);
            objProf.ExcluirProfessor();
            MessageBox.Show("Professor excluído!!");

            dtg_professores.DataSource = objProf.ListarProfessor();
            txt_codProf.Clear();
        }

        //LISTA OS PROFESSORES CADASTRADOS NO BANCO
        private void btn_listar_Click(object sender, EventArgs e)
        {
            dtg_professores.DataSource = objProf.ListarProfessor();
        }
    }
}
