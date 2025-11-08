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
    public partial class frm_turmas : Form
    {
        //INSTÂNCIA CLASSE TURMAS
        Turmas objTurma = new Turmas();

        public frm_turmas()
        {
            InitializeComponent();
        }

        //PREENCHE O COMBO-BOX COM O NOME DOS PROFESSORES CADASTRADOS NO BANCO
        //E SEU VALOR É SEU (CODIGO).
        public void preencherCbxProfessor()
        {
            cbx_professor.DataSource = objTurma.ListarProfessor();
            cbx_professor.DisplayMember = "nomeCompleto";
            cbx_professor.ValueMember = "codigo";
        }

        //PREENCHE O COMBO-BOX COM O NOME DOS CURSOS CADASTRADOS NO BANCO
        //E SEU VALOR É SEU (CODIGO).
        public void preencherCbxCurso()
        {
            cbx_curso.DataSource = objTurma.ListarCurso();
            cbx_curso.DisplayMember = "nomeCurso";
            cbx_curso.ValueMember = "codigo";
        }

        //CARREGA AS TURMAS CADASTRADAS NO BANCO AO ABRIR O FORMULÁRIO
        private void frm_turmas_Load(object sender, EventArgs e)
        {
            preencherCbxCurso();
            preencherCbxProfessor();
            dtg_turmas.DataSource = objTurma.ListarTurmas();
        }

        //CADASTRA NOVA TURMA NO BANCO
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            objTurma.dtInicio = txt_dtTermino.Text;
            objTurma.dtTermino = txt_dtTermino.Text;
            objTurma.HoraInicio = txt_horaInicio.Text;
            objTurma.HoraTermino = txt_horaTermino.Text;
            objTurma.cod_professor = cbx_professor.SelectedValue.ToString();
            objTurma.cod_curso = cbx_curso.SelectedValue.ToString();

            objTurma.CadastrarTurma();
            MessageBox.Show("Turma cadastrada com sucesso");

            txt_horaInicio.Clear();
            txt_horaTermino.Clear();
            txt_dtInicio.Clear();
            txt_dtTermino.Clear();
        }

        //ALTERA DADOS DA TURMA COM (CODIGO CORRESPONDENTE)
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            objTurma.codigo = int.Parse(txt_codTurma.Text);
            objTurma.dtInicio = txt_dtTermino.Text;
            objTurma.dtTermino = txt_dtTermino.Text;
            objTurma.HoraInicio = txt_horaInicio.Text;
            objTurma.HoraTermino = txt_horaTermino.Text;
            objTurma.cod_professor = cbx_professor.SelectedValue.ToString();
            objTurma.cod_curso = cbx_curso.SelectedValue.ToString();

            objTurma.AlterarTurma();
            MessageBox.Show("Turma alterada com sucesso!!");

            txt_codTurma.Clear();
            txt_horaInicio.Clear();
            txt_horaTermino.Clear();
            txt_dtInicio.Clear();
            txt_dtTermino.Clear();
        }

        //EXCLUI A TURMA COM (CODIGO CORRESPONDENTE)
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            objTurma.codigo = int.Parse(txt_codTurma.Text);
            objTurma.ExcluirTurma();
            MessageBox.Show("Turma excluída com sucesso!!");

            dtg_turmas.DataSource = objTurma.ListarTurmas();
            txt_codTurma.Clear();
        }

        //LISTA AS TURMAS CADASTRADAS NO BANCO
        private void btn_Listar_Click(object sender, EventArgs e)
        {
            dtg_turmas.DataSource = objTurma.ListarTurmas();
        }
    }
}
