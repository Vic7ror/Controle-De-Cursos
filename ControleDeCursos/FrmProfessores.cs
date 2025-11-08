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

        //LISTA PROFESSORES CADASTRADOS NO BANCO
        private void frm_professores_Load(object sender, EventArgs e)
        {
            TryExecute(() => dtg_professores.DataSource = objProf.ListarProfessor(),
                "Erro ao carregar lista de professores");
        }

        //CADASTRA NOVO PROFESSOR
        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            // Valida nome
            if (string.IsNullOrWhiteSpace(txt_nomeProf.Text))
            {
                ShowWarning("Informe o nome do professor.");
                txt_nomeProf.Focus();
                return;
            }

            // Obtém valor por hora de forma segura (NumericUpDown.Value)
            double valorHora = Convert.ToDouble(txt_valorHora.Value);
            if (valorHora < 0)
            {
                ShowWarning("Informe um valor por hora válido (>= 0).");
                txt_valorHora.Focus();
                return;
            }

            // Telefone opcional — ajuste conforme regra de negócio
            var telefone = mkd_telefone.Text;

            objProf.nomeCompleto = txt_nomeProf.Text;
            objProf.valorHora = valorHora;
            objProf.telefone = telefone;

            TryExecute(() =>
            {
                objProf.CadastrarProfessor();
                ShowInfo("Professor cadastrado com sucesso!!");

                // Atualiza lista e limpa campos
                dtg_professores.DataSource = objProf.ListarProfessor();
                txt_nomeProf.Clear();
                txt_valorHora.Value = 0;
                mkd_telefone.Clear();
            }, "Erro ao cadastrar professor");
        }

        //ALTERA OS DADOS DO PROFESSOR COM (CODIGO CORRESPONDENTE)
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            // Valida código
            if (string.IsNullOrWhiteSpace(txt_codProf.Text) || !int.TryParse(txt_codProf.Text, out int codigo))
            {
                ShowWarning("Informe um código numérico válido.");
                txt_codProf.Focus();
                return;
            }

            // Valida nome
            if (string.IsNullOrWhiteSpace(txt_nomeProf.Text))
            {
                ShowWarning("Informe o nome do professor.");
                txt_nomeProf.Focus();
                return;
            }

            // Valida valor por hora (NumericUpDown)
            double valorHora = Convert.ToDouble(txt_valorHora.Value);
            if (valorHora < 0)
            {
                ShowWarning("Informe um valor por hora válido (>= 0).");
                txt_valorHora.Focus();
                return;
            }

            // Telefone pode ficar em branco — ajuste conforme regra de negócio
            var telefone = mkd_telefone.Text;

            // Atribui e chama alteração com tratamento de exceção
            objProf.codigo = codigo;
            objProf.nomeCompleto = txt_nomeProf.Text;
            objProf.valorHora = valorHora;
            objProf.telefone = telefone;

            TryExecute(() =>
            {
                objProf.AlterarProfessor();
                ShowInfo("Professor alterado com sucesso!!");

                // Atualiza lista e limpa campos
                dtg_professores.DataSource = objProf.ListarProfessor();
                txt_codProf.Clear();
                txt_nomeProf.Clear();
                txt_valorHora.Value = 0;
                mkd_telefone.Clear();
            }, "Erro ao alterar professor");
        }

        //EXCLUI PROFESSOR DO BANCO COM (CODIGO CORRESPONDENTE)
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            // Valida código
            if (string.IsNullOrWhiteSpace(txt_codProf.Text) || !int.TryParse(txt_codProf.Text, out int codigo))
            {
                ShowWarning("Informe um código numérico válido para exclusão.");
                txt_codProf.Focus();
                return;
            }

            // Confirma exclusão
            var resp = MessageBox.Show("Confirma exclusão do professor com código " + codigo + "?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp != DialogResult.Yes) return;

            TryExecute(() =>
            {
                objProf.codigo = codigo;
                objProf.ExcluirProfessor();
                ShowInfo("Professor excluído!!");

                dtg_professores.DataSource = objProf.ListarProfessor();
                txt_codProf.Clear();
            }, "Erro ao excluir professor");
        }

        //LISTA OS PROFESSORES CADASTRADOS NO BANCO
        private void btn_listar_Click(object sender, EventArgs e)
        {
            TryExecute(() => dtg_professores.DataSource = objProf.ListarProfessor(),
                "Erro ao listar professores");
        }
    }
}
