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
    public partial class frm_Cursos : Form
    {
        //INSTÂNCIA CLASSE CURSO
        Curso objCurso = new Curso();

        public frm_Cursos()
        {
            InitializeComponent();
        }

        //PREENCHE O DATA GRID MOSTRANDO A LISTA DE CURSOS NO BANCO
        private void frm_Cursos_Load(object sender, EventArgs e)
        {
            dtg_cursos.DataSource = objCurso.ListarCurso();
        }

        //CADASTRAR NOVO CURSO
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

            objCurso.nomeCurso = txt_nomeCurso.Text;
            objCurso.conteudo = txt_conteudo.Text;
            objCurso.valorMensalidade = double.Parse(txt_mensalidade.Text);
            objCurso.cargaHoraria = int.Parse(txt_cargaHorária.Text);

            objCurso.CadastrarCurso();
            MessageBox.Show("Curso cadastrado com sucesso!!");

            txt_codCurso.Focus();
            txt_nomeCurso.Clear();
            txt_mensalidade.Clear();
            txt_conteudo.Clear();
            txt_cargaHorária.Clear();
        }

        //ALTERAR DADOS DO CURSO COM (CODIGO CORRESPONDENTE)
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            objCurso.codigo = int.Parse(txt_codCurso.Text);
            objCurso.nomeCurso = txt_nomeCurso.Text;
            objCurso.conteudo = txt_conteudo.Text;
            objCurso.valorMensalidade = double.Parse(txt_mensalidade.Text);
            objCurso.cargaHoraria = int.Parse(txt_cargaHorária.Text);

            objCurso.AlterarCurso();
            MessageBox.Show("Curso Alterado com sucess!!");

            txt_codCurso.Focus();
            txt_nomeCurso.Clear();
            txt_mensalidade.Clear();
            txt_conteudo.Clear();
            txt_cargaHorária.Clear();

            dtg_cursos.DataSource = objCurso.ListarCurso();
        }

        //EXCLUI O CURSO COM (CODIGO CORRESPONDENTE)
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            objCurso.codigo = int.Parse(txt_codCurso.Text);

            objCurso.ExcluirCurso();
            MessageBox.Show("Curso excluído!!");

            dtg_cursos.DataSource = objCurso.ListarCurso();
            txt_codCurso.Clear();
        }

        //LISTA OS CURSOS CADASTRADOS NO BANCO
        private void btn_Listar_Click(object sender, EventArgs e)
        {
            dtg_cursos.DataSource = objCurso.ListarCurso();
        }
    }
}
