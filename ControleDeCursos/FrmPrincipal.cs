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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        //Botão para abrir formulário de cursos.
        private void tsm_cursos_Click(object sender, EventArgs e)
        {
            frm_Cursos formCursos = new frm_Cursos();
            formCursos.ShowDialog();
        }
        //Botão para abrir formulário de turmas.
        private void tsm_turmas_Click(object sender, EventArgs e)
        {
            frm_turmas formTurmas = new frm_turmas();   
            formTurmas.ShowDialog();
        }
        //Botão para abrir formulário de professor.
        private void tsm_professor_Click(object sender, EventArgs e)
        {
            frm_professores formProfessores = new frm_professores();
            formProfessores.ShowDialog();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }
    }
}
