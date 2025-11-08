using System;
using System.Data;
using System.Globalization;
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

        // Função centralizada para mostrar erros
        private void ShowError(string mensagem, Exception ex = null)
        {
            var detalhe = ex == null ? string.Empty : Environment.NewLine + "Detalhes: " + ex.Message;
            MessageBox.Show(mensagem + detalhe, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Função centralizada para avisos
        private void ShowWarning(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Função centralizada para info/sucesso
        private void ShowInfo(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Helper para executar ações com tratamento de erro centralizado
        private void TryExecute(Action action, string mensagemErro)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                ShowError(mensagemErro, ex);
            }
        }

        // Tenta ler uma data a partir do controle (TextBox). Retorna a string em ISO (yyyy-MM-dd) se ok.
        private bool TryGetDateIso(Control control, out string isoDate)
        {
            isoDate = null;
            DateTime dt;

            // Formatos aceitáveis mais comuns
            string[] formatos = new[] { "dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy", "yyyy-MM-dd" };

            // Primeiro, tentar parse exato com formatos esperados (invariant culture para formatos explícitos)
            foreach (var fmt in formatos)
            {
                if (DateTime.TryParseExact(control.Text.Trim(), fmt, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
                {
                    isoDate = dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    return true;
                }

                if (DateTime.TryParseExact(control.Text.Trim(), fmt, CultureInfo.CurrentCulture, DateTimeStyles.None, out dt))
                {
                    isoDate = dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                    return true;
                }
            }

            // Em seguida, tentar parse flexível (aceita várias variações locais)
            if (DateTime.TryParse(control.Text.Trim(), CultureInfo.CurrentCulture, DateTimeStyles.None, out dt) ||
                DateTime.TryParse(control.Text.Trim(), CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            {
                isoDate = dt.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                return true;
            }

            // falhou
            return false;
        }

        // Tenta ler um horário no formato reconhecido e retorna como HH:mm:ss
        private bool TryGetTimeIso(Control control, out string isoTime)
        {
            isoTime = null;
            TimeSpan ts;
            DateTime dt;

            // Tentar TimeSpan direto (HH:mm, HH:mm:ss)
            if (TimeSpan.TryParseExact(control.Text.Trim(), new[] { @"hh\:mm", @"h\:mm", @"hh\:mm\:ss" }, CultureInfo.InvariantCulture, out ts))
            {
                isoTime = ts.ToString(@"hh\:mm\:ss");
                return true;
            }

            // Tentar parse como DateTime (aceita 2:30 PM, 14:30 etc.)
            if (DateTime.TryParseExact(control.Text.Trim(), new[] { "HH:mm", "H:mm", "HH:mm:ss", "h:mm tt", "hh:mm tt" }, CultureInfo.CurrentCulture, DateTimeStyles.None, out dt) ||
                DateTime.TryParse(control.Text.Trim(), CultureInfo.CurrentCulture, DateTimeStyles.None, out dt))
            {
                isoTime = dt.TimeOfDay.ToString(@"hh\:mm\:ss");
                return true;
            }

            return false;
        }

        // PREENCHE O COMBO-BOX COM O NOME DOS PROFESSORES CADASTRADOS NO BANCO
        // E SEU VALOR É SEU (CODIGO).
        public void preencherCbxProfessor()
        {
            TryExecute(() =>
            {
                cbx_professor.DataSource = objTurma.ListarProfessor();
                cbx_professor.DisplayMember = "nomeCompleto";
                cbx_professor.ValueMember = "codigo";
            }, "Erro ao carregar lista de professores");
        }

        // PREENCHE O COMBO-BOX COM O NOME DOS CURSOS CADASTRADOS NO BANCO
        // E SEU VALOR É SEU (CODIGO).
        public void preencherCbxCurso()
        {
            TryExecute(() =>
            {
                cbx_curso.DataSource = objTurma.ListarCurso();
                cbx_curso.DisplayMember = "nomeCurso";
                cbx_curso.ValueMember = "codigo";
            }, "Erro ao carregar lista de cursos");
        }

        // CARREGA AS TURMAS CADASTRADAS NO BANCO AO ABRIR O FORMULÁRIO
        private void frm_turmas_Load(object sender, EventArgs e)
        {
            TryExecute(() =>
            {
                preencherCbxCurso();
                preencherCbxProfessor();
                dtg_turmas.DataSource = objTurma.ListarTurmas();
            }, "Erro ao carregar dados iniciais");
        }

        // CADASTRA NOVA TURMA NO BANCO
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            // Valida datas
            if (!TryGetDateIso(txt_dtInicio, out string dtInicioIso))
            {
                ShowWarning("Informe uma data de início válida.");
                txt_dtInicio.Focus();
                return;
            }

            if (!TryGetDateIso(txt_dtTermino, out string dtTerminoIso))
            {
                ShowWarning("Informe uma data de término válida.");
                txt_dtTermino.Focus();
                return;
            }

            // Confere ordem das datas
            if (DateTime.ParseExact(dtInicioIso, "yyyy-MM-dd", CultureInfo.InvariantCulture) >
                DateTime.ParseExact(dtTerminoIso, "yyyy-MM-dd", CultureInfo.InvariantCulture))
            {
                ShowWarning("Data de término deve ser igual ou posterior à data de início.");
                txt_dtTermino.Focus();
                return;
            }

            // Valida horários
            if (!TryGetTimeIso(txt_horaInicio, out string horaInicioIso))
            {
                ShowWarning("Informe um horário de início válido.");
                txt_horaInicio.Focus();
                return;
            }

            if (!TryGetTimeIso(txt_horaTermino, out string horaTerminoIso))
            {
                ShowWarning("Informe um horário de término válido.");
                txt_horaTermino.Focus();
                return;
            }

            // Valida professor selecionado
            if (cbx_professor.SelectedValue == null || !int.TryParse(cbx_professor.SelectedValue.ToString(), out int professorId))
            {
                ShowWarning("Selecione um professor válido.");
                cbx_professor.Focus();
                return;
            }

            // Valida curso selecionado
            if (cbx_curso.SelectedValue == null || !int.TryParse(cbx_curso.SelectedValue.ToString(), out int cursoId))
            {
                ShowWarning("Selecione um curso válido.");
                cbx_curso.Focus();
                return;
            }

            // Preenche objeto
            objTurma.dtInicio = dtInicioIso;
            objTurma.dtTermino = dtTerminoIso;
            objTurma.HoraInicio = horaInicioIso;
            objTurma.HoraTermino = horaTerminoIso;
            objTurma.cod_professor = professorId;
            objTurma.cod_curso = cursoId;

            TryExecute(() =>
            {
                objTurma.CadastrarTurma();
                ShowInfo("Turma cadastrada com sucesso");

                dtg_turmas.DataSource = objTurma.ListarTurmas();

                txt_horaInicio.Clear();
                txt_horaTermino.Clear();
                txt_dtInicio.Clear();
                txt_dtTermino.Clear();
            }, "Erro ao cadastrar turma");
        }

        // ALTERA DADOS DA TURMA COM (CODIGO CORRESPONDENTE)
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            // Valida código
            if (string.IsNullOrWhiteSpace(txt_codTurma.Text) || !int.TryParse(txt_codTurma.Text, out int codigo))
            {
                ShowWarning("Informe um código numérico válido.");
                txt_codTurma.Focus();
                return;
            }

            // Valida datas
            if (!TryGetDateIso(txt_dtInicio, out string dtInicioIso))
            {
                ShowWarning("Informe uma data de início válida.");
                txt_dtInicio.Focus();
                return;
            }

            if (!TryGetDateIso(txt_dtTermino, out string dtTerminoIso))
            {
                ShowWarning("Informe uma data de término válida.");
                txt_dtTermino.Focus();
                return;
            }

            // Valida horários
            if (!TryGetTimeIso(txt_horaInicio, out string horaInicioIso))
            {
                ShowWarning("Informe um horário de início válido.");
                txt_horaInicio.Focus();
                return;
            }

            if (!TryGetTimeIso(txt_horaTermino, out string horaTerminoIso))
            {
                ShowWarning("Informe um horário de término válido.");
                txt_horaTermino.Focus();
                return;
            }

            // Valida professor e curso selecionados
            if (cbx_professor.SelectedValue == null || !int.TryParse(cbx_professor.SelectedValue.ToString(), out int professorId))
            {
                ShowWarning("Selecione um professor válido.");
                cbx_professor.Focus();
                return;
            }

            if (cbx_curso.SelectedValue == null || !int.TryParse(cbx_curso.SelectedValue.ToString(), out int cursoId))
            {
                ShowWarning("Selecione um curso válido.");
                cbx_curso.Focus();
                return;
            }

            // Preenche objeto
            objTurma.codigo = codigo;
            objTurma.dtInicio = dtInicioIso;
            objTurma.dtTermino = dtTerminoIso;
            objTurma.HoraInicio = horaInicioIso;
            objTurma.HoraTermino = horaTerminoIso;
            objTurma.cod_professor = professorId;
            objTurma.cod_curso = cursoId;

            TryExecute(() =>
            {
                objTurma.AlterarTurma();
                ShowInfo("Turma alterada com sucesso!!");

                dtg_turmas.DataSource = objTurma.ListarTurmas();

                txt_codTurma.Clear();
                txt_horaInicio.Clear();
                txt_horaTermino.Clear();
                txt_dtInicio.Clear();
                txt_dtTermino.Clear();
            }, "Erro ao alterar turma");
        }

        // EXCLUI A TURMA COM (CODIGO CORRESPONDENTE)
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_codTurma.Text) || !int.TryParse(txt_codTurma.Text, out int codigo))
            {
                ShowWarning("Informe um código numérico válido para exclusão.");
                txt_codTurma.Focus();
                return;
            }

            var resp = MessageBox.Show("Confirma exclusão da turma com código " + codigo + "?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp != DialogResult.Yes) return;

            TryExecute(() =>
            {
                objTurma.codigo = codigo;
                objTurma.ExcluirTurma();
                ShowInfo("Turma excluída com sucesso!!");

                dtg_turmas.DataSource = objTurma.ListarTurmas();
                txt_codTurma.Clear();
            }, "Erro ao excluir turma");
        }

        // LISTA AS TURMAS CADASTRADAS NO BANCO
        private void btn_Listar_Click(object sender, EventArgs e)
        {
            TryExecute(() => dtg_turmas.DataSource = objTurma.ListarTurmas(),
                "Erro ao listar turmas");
        }
    }
}
