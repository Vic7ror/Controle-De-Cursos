namespace ControleDeCursos
{
    partial class frm_turmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_codTurma = new System.Windows.Forms.Label();
            this.lbl_dtInicio = new System.Windows.Forms.Label();
            this.lbl_hrInicio = new System.Windows.Forms.Label();
            this.lbl_professor = new System.Windows.Forms.Label();
            this.lbl_Curso = new System.Windows.Forms.Label();
            this.dt_termino = new System.Windows.Forms.Label();
            this.lbl_hrTermino = new System.Windows.Forms.Label();
            this.txt_codTurma = new System.Windows.Forms.TextBox();
            this.txt_dtInicio = new System.Windows.Forms.MaskedTextBox();
            this.txt_horaInicio = new System.Windows.Forms.MaskedTextBox();
            this.cbx_professor = new System.Windows.Forms.ComboBox();
            this.cbx_curso = new System.Windows.Forms.ComboBox();
            this.txt_dtTermino = new System.Windows.Forms.MaskedTextBox();
            this.txt_horaTermino = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtg_turmas = new System.Windows.Forms.DataGridView();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codTurma
            // 
            this.lbl_codTurma.AutoSize = true;
            this.lbl_codTurma.Location = new System.Drawing.Point(3, 13);
            this.lbl_codTurma.Name = "lbl_codTurma";
            this.lbl_codTurma.Size = new System.Drawing.Size(370, 21);
            this.lbl_codTurma.TabIndex = 0;
            this.lbl_codTurma.Text = "Código da Turma para edição ou exclusão:";
            // 
            // lbl_dtInicio
            // 
            this.lbl_dtInicio.AutoSize = true;
            this.lbl_dtInicio.Location = new System.Drawing.Point(3, 122);
            this.lbl_dtInicio.Name = "lbl_dtInicio";
            this.lbl_dtInicio.Size = new System.Drawing.Size(145, 21);
            this.lbl_dtInicio.TabIndex = 1;
            this.lbl_dtInicio.Text = "Data de Início:";
            // 
            // lbl_hrInicio
            // 
            this.lbl_hrInicio.AutoSize = true;
            this.lbl_hrInicio.Location = new System.Drawing.Point(3, 162);
            this.lbl_hrInicio.Name = "lbl_hrInicio";
            this.lbl_hrInicio.Size = new System.Drawing.Size(118, 21);
            this.lbl_hrInicio.TabIndex = 2;
            this.lbl_hrInicio.Text = "Hora Início:";
            // 
            // lbl_professor
            // 
            this.lbl_professor.AutoSize = true;
            this.lbl_professor.Location = new System.Drawing.Point(3, 202);
            this.lbl_professor.Name = "lbl_professor";
            this.lbl_professor.Size = new System.Drawing.Size(127, 21);
            this.lbl_professor.TabIndex = 3;
            this.lbl_professor.Text = "Professor(a):";
            // 
            // lbl_Curso
            // 
            this.lbl_Curso.AutoSize = true;
            this.lbl_Curso.Location = new System.Drawing.Point(3, 51);
            this.lbl_Curso.Name = "lbl_Curso";
            this.lbl_Curso.Size = new System.Drawing.Size(64, 21);
            this.lbl_Curso.TabIndex = 4;
            this.lbl_Curso.Text = "Curso:";
            // 
            // dt_termino
            // 
            this.dt_termino.AutoSize = true;
            this.dt_termino.Location = new System.Drawing.Point(278, 122);
            this.dt_termino.Name = "dt_termino";
            this.dt_termino.Size = new System.Drawing.Size(154, 21);
            this.dt_termino.TabIndex = 5;
            this.dt_termino.Text = "Data de Término:";
            // 
            // lbl_hrTermino
            // 
            this.lbl_hrTermino.AutoSize = true;
            this.lbl_hrTermino.Location = new System.Drawing.Point(278, 162);
            this.lbl_hrTermino.Name = "lbl_hrTermino";
            this.lbl_hrTermino.Size = new System.Drawing.Size(154, 21);
            this.lbl_hrTermino.TabIndex = 6;
            this.lbl_hrTermino.Text = "Hora de Término:";
            // 
            // txt_codTurma
            // 
            this.txt_codTurma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codTurma.Location = new System.Drawing.Point(379, 11);
            this.txt_codTurma.Name = "txt_codTurma";
            this.txt_codTurma.Size = new System.Drawing.Size(159, 26);
            this.txt_codTurma.TabIndex = 7;
            // 
            // txt_dtInicio
            // 
            this.txt_dtInicio.Location = new System.Drawing.Point(154, 122);
            this.txt_dtInicio.Mask = "00/00/0000";
            this.txt_dtInicio.Name = "txt_dtInicio";
            this.txt_dtInicio.Size = new System.Drawing.Size(109, 26);
            this.txt_dtInicio.TabIndex = 8;
            this.txt_dtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txt_horaInicio
            // 
            this.txt_horaInicio.Location = new System.Drawing.Point(127, 162);
            this.txt_horaInicio.Mask = "90:00";
            this.txt_horaInicio.Name = "txt_horaInicio";
            this.txt_horaInicio.Size = new System.Drawing.Size(53, 26);
            this.txt_horaInicio.TabIndex = 9;
            this.txt_horaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // cbx_professor
            // 
            this.cbx_professor.FormattingEnabled = true;
            this.cbx_professor.Location = new System.Drawing.Point(127, 199);
            this.cbx_professor.Name = "cbx_professor";
            this.cbx_professor.Size = new System.Drawing.Size(136, 29);
            this.cbx_professor.TabIndex = 10;
            // 
            // cbx_curso
            // 
            this.cbx_curso.FormattingEnabled = true;
            this.cbx_curso.Location = new System.Drawing.Point(7, 75);
            this.cbx_curso.Name = "cbx_curso";
            this.cbx_curso.Size = new System.Drawing.Size(531, 29);
            this.cbx_curso.TabIndex = 11;
            // 
            // txt_dtTermino
            // 
            this.txt_dtTermino.Location = new System.Drawing.Point(429, 122);
            this.txt_dtTermino.Mask = "00/00/0000";
            this.txt_dtTermino.Name = "txt_dtTermino";
            this.txt_dtTermino.Size = new System.Drawing.Size(109, 26);
            this.txt_dtTermino.TabIndex = 12;
            this.txt_dtTermino.ValidatingType = typeof(System.DateTime);
            // 
            // txt_horaTermino
            // 
            this.txt_horaTermino.Location = new System.Drawing.Point(429, 162);
            this.txt_horaTermino.Mask = "90:00";
            this.txt_horaTermino.Name = "txt_horaTermino";
            this.txt_horaTermino.Size = new System.Drawing.Size(53, 26);
            this.txt_horaTermino.TabIndex = 13;
            this.txt_horaTermino.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_codTurma);
            this.panel1.Controls.Add(this.txt_horaTermino);
            this.panel1.Controls.Add(this.lbl_dtInicio);
            this.panel1.Controls.Add(this.txt_dtTermino);
            this.panel1.Controls.Add(this.lbl_hrInicio);
            this.panel1.Controls.Add(this.cbx_curso);
            this.panel1.Controls.Add(this.lbl_professor);
            this.panel1.Controls.Add(this.cbx_professor);
            this.panel1.Controls.Add(this.lbl_Curso);
            this.panel1.Controls.Add(this.txt_horaInicio);
            this.panel1.Controls.Add(this.dt_termino);
            this.panel1.Controls.Add(this.txt_dtInicio);
            this.panel1.Controls.Add(this.lbl_hrTermino);
            this.panel1.Controls.Add(this.txt_codTurma);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 250);
            this.panel1.TabIndex = 14;
            // 
            // dtg_turmas
            // 
            this.dtg_turmas.BackgroundColor = System.Drawing.Color.White;
            this.dtg_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_turmas.Location = new System.Drawing.Point(12, 348);
            this.dtg_turmas.Name = "dtg_turmas";
            this.dtg_turmas.Size = new System.Drawing.Size(555, 226);
            this.dtg_turmas.TabIndex = 16;
            // 
            // btn_Listar
            // 
            this.btn_Listar.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar.Location = new System.Drawing.Point(408, 293);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(102, 32);
            this.btn_Listar.TabIndex = 21;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = false;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.btn_Excluir.Location = new System.Drawing.Point(286, 293);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(102, 32);
            this.btn_Excluir.TabIndex = 20;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.Khaki;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Location = new System.Drawing.Point(175, 293);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(102, 32);
            this.btn_Alterar.TabIndex = 19;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(56, 293);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(102, 32);
            this.btn_cadastrar.TabIndex = 18;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // frm_turmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(579, 588);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.dtg_turmas);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_turmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turmas";
            this.Load += new System.EventHandler(this.frm_turmas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_turmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_codTurma;
        private System.Windows.Forms.Label lbl_dtInicio;
        private System.Windows.Forms.Label lbl_hrInicio;
        private System.Windows.Forms.Label lbl_professor;
        private System.Windows.Forms.Label lbl_Curso;
        private System.Windows.Forms.Label dt_termino;
        private System.Windows.Forms.Label lbl_hrTermino;
        private System.Windows.Forms.TextBox txt_codTurma;
        private System.Windows.Forms.MaskedTextBox txt_dtInicio;
        private System.Windows.Forms.MaskedTextBox txt_horaInicio;
        private System.Windows.Forms.ComboBox cbx_professor;
        private System.Windows.Forms.ComboBox cbx_curso;
        private System.Windows.Forms.MaskedTextBox txt_dtTermino;
        private System.Windows.Forms.MaskedTextBox txt_horaTermino;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg_turmas;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}