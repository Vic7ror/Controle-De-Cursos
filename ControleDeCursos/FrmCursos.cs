using System;
using System.Globalization;
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

        // Helper para ler double de controles que podem ser NumericUpDown ou TextBox
        private bool TryGetDoubleFromControl(Control control, out double valor)
        {
            valor = 0;
            var prop = control.GetType().GetProperty("Value");
            if (prop != null)
            {
                try
                {
                    var val = prop.GetValue(control);
                    valor = Convert.ToDouble(val);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            // fallback para Text
            return double.TryParse(control.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out valor);
        }

        //LISTA PROFESSORES CADASTRADOS NO BANCO
        private void frm_Cursos_Load(object sender, EventArgs e)
        {
            TryExecute(() => dtg_cursos.DataSource = objCurso.ListarCurso(),
                "Erro ao carregar lista de cursos");
        }

        //CADASTRAR NOVO CURSO
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            // Valida nome do curso
            if (string.IsNullOrWhiteSpace(txt_nomeCurso.Text))
            {
                ShowWarning("Informe o nome do curso.");
                txt_nomeCurso.Focus();
                return;
            }

            // Valida valor da mensalidade
            if (!TryGetDoubleFromControl(txt_mensalidade, out double valorMensalidade) || valorMensalidade < 0)
            {
                ShowWarning("Informe um valor de mensalidade válido (>= 0).");
                txt_mensalidade.Focus();
                return;
            }

            // Valida carga horária
            if (!int.TryParse(txt_cargaHorária.Text, out int cargaHoraria) || cargaHoraria < 0)
            {
                ShowWarning("Informe uma carga horária válida (inteiro >= 0).");
                txt_cargaHorária.Focus();
                return;
            }

            // Conteúdo pode ser opcional — ajuste conforme regra de negócio
            var conteudo = txt_conteudo.Text;

            objCurso.nomeCurso = txt_nomeCurso.Text;
            objCurso.conteudo = conteudo;
            objCurso.valorMensalidade = valorMensalidade;
            objCurso.cargaHoraria = cargaHoraria;

            TryExecute(() =>
            {
                objCurso.CadastrarCurso();
                ShowInfo("Curso cadastrado com sucesso!!");

                // Atualiza lista e limpa campos
                dtg_cursos.DataSource = objCurso.ListarCurso();
                txt_nomeCurso.Clear();
                txt_mensalidade.Clear();
                txt_conteudo.Clear();
                txt_cargaHorária.Clear();
                txt_codCurso.Focus();
            }, "Erro ao cadastrar curso");
        }

        //ALTERAR DADOS DO CURSO COM (CODIGO CORRESPONDENTE)
        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            // Valida código
            if (string.IsNullOrWhiteSpace(txt_codCurso.Text) || !int.TryParse(txt_codCurso.Text, out int codigo))
            {
                ShowWarning("Informe um código numérico válido.");
                txt_codCurso.Focus();
                return;
            }

            // Valida nome do curso
            if (string.IsNullOrWhiteSpace(txt_nomeCurso.Text))
            {
                ShowWarning("Informe o nome do curso.");
                txt_nomeCurso.Focus();
                return;
            }

            // Valida valor da mensalidade
            if (!TryGetDoubleFromControl(txt_mensalidade, out double valorMensalidade) || valorMensalidade < 0)
            {
                ShowWarning("Informe um valor de mensalidade válido (>= 0).");
                txt_mensalidade.Focus();
                return;
            }

            // Valida carga horária
            if (!int.TryParse(txt_cargaHorária.Text, out int cargaHoraria) || cargaHoraria < 0)
            {
                ShowWarning("Informe uma carga horária válida (inteiro >= 0).");
                txt_cargaHorária.Focus();
                return;
            }

            var conteudo = txt_conteudo.Text;

            objCurso.codigo = codigo;
            objCurso.nomeCurso = txt_nomeCurso.Text;
            objCurso.conteudo = conteudo;
            objCurso.valorMensalidade = valorMensalidade;
            objCurso.cargaHoraria = cargaHoraria;

            TryExecute(() =>
            {
                objCurso.AlterarCurso();
                ShowInfo("Curso alterado com sucesso!!");

                // Atualiza lista e limpa campos
                dtg_cursos.DataSource = objCurso.ListarCurso();
                txt_codCurso.Clear();
                txt_nomeCurso.Clear();
                txt_mensalidade.Clear();
                txt_conteudo.Clear();
                txt_cargaHorária.Clear();
                txt_codCurso.Focus();
            }, "Erro ao alterar curso");
        }

        //EXCLUI O CURSO COM (CODIGO CORRESPONDENTE)
        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // Valida código
            if (string.IsNullOrWhiteSpace(txt_codCurso.Text) || !int.TryParse(txt_codCurso.Text, out int codigo))
            {
                ShowWarning("Informe um código numérico válido para exclusão.");
                txt_codCurso.Focus();
                return;
            }

            // Confirma exclusão
            var resp = MessageBox.Show("Confirma exclusão do curso com código " + codigo + "?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp != DialogResult.Yes) return;

            TryExecute(() =>
            {
                objCurso.codigo = codigo;
                objCurso.ExcluirCurso();
                ShowInfo("Curso excluído!!");

                dtg_cursos.DataSource = objCurso.ListarCurso();
                txt_codCurso.Clear();
            }, "Erro ao excluir curso");
        }

        //LISTA OS CURSOS CADASTRADOS NO BANCO
        private void btn_Listar_Click(object sender, EventArgs e)
        {
            TryExecute(() => dtg_cursos.DataSource = objCurso.ListarCurso(),
                "Erro ao listar cursos");
        }
    }
}
