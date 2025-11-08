namespace ControleDeCursos
{
    partial class frm_Cursos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_codCurso = new System.Windows.Forms.TextBox();
            this.lbl_codCurso = new System.Windows.Forms.Label();
            this.lbl_nomeCurso = new System.Windows.Forms.Label();
            this.txt_nomeCurso = new System.Windows.Forms.TextBox();
            this.lbl_conteudo = new System.Windows.Forms.Label();
            this.txt_conteudo = new System.Windows.Forms.TextBox();
            this.txt_mensalidade = new System.Windows.Forms.TextBox();
            this.lbl_mensalidade = new System.Windows.Forms.Label();
            this.lbl_cargaHoraria = new System.Windows.Forms.Label();
            this.txt_cargaHorária = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Listar = new System.Windows.Forms.Button();
            this.dtg_cursos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cursos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codCurso
            // 
            this.txt_codCurso.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codCurso.Location = new System.Drawing.Point(163, 10);
            this.txt_codCurso.Name = "txt_codCurso";
            this.txt_codCurso.Size = new System.Drawing.Size(100, 26);
            this.txt_codCurso.TabIndex = 0;
            // 
            // lbl_codCurso
            // 
            this.lbl_codCurso.AutoSize = true;
            this.lbl_codCurso.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codCurso.Location = new System.Drawing.Point(3, 10);
            this.lbl_codCurso.Name = "lbl_codCurso";
            this.lbl_codCurso.Size = new System.Drawing.Size(154, 21);
            this.lbl_codCurso.TabIndex = 1;
            this.lbl_codCurso.Text = "Código do Curso:";
            // 
            // lbl_nomeCurso
            // 
            this.lbl_nomeCurso.AutoSize = true;
            this.lbl_nomeCurso.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeCurso.Location = new System.Drawing.Point(3, 48);
            this.lbl_nomeCurso.Name = "lbl_nomeCurso";
            this.lbl_nomeCurso.Size = new System.Drawing.Size(136, 21);
            this.lbl_nomeCurso.TabIndex = 2;
            this.lbl_nomeCurso.Text = "Nome do Curso:";
            // 
            // txt_nomeCurso
            // 
            this.txt_nomeCurso.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeCurso.Location = new System.Drawing.Point(138, 51);
            this.txt_nomeCurso.Name = "txt_nomeCurso";
            this.txt_nomeCurso.Size = new System.Drawing.Size(263, 26);
            this.txt_nomeCurso.TabIndex = 3;
            // 
            // lbl_conteudo
            // 
            this.lbl_conteudo.AutoSize = true;
            this.lbl_conteudo.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conteudo.Location = new System.Drawing.Point(3, 87);
            this.lbl_conteudo.Name = "lbl_conteudo";
            this.lbl_conteudo.Size = new System.Drawing.Size(208, 21);
            this.lbl_conteudo.TabIndex = 4;
            this.lbl_conteudo.Text = "Conteúdo Programático:";
            // 
            // txt_conteudo
            // 
            this.txt_conteudo.Location = new System.Drawing.Point(3, 111);
            this.txt_conteudo.Multiline = true;
            this.txt_conteudo.Name = "txt_conteudo";
            this.txt_conteudo.Size = new System.Drawing.Size(444, 138);
            this.txt_conteudo.TabIndex = 5;
            // 
            // txt_mensalidade
            // 
            this.txt_mensalidade.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensalidade.Location = new System.Drawing.Point(7, 295);
            this.txt_mensalidade.Name = "txt_mensalidade";
            this.txt_mensalidade.Size = new System.Drawing.Size(195, 26);
            this.txt_mensalidade.TabIndex = 6;
            // 
            // lbl_mensalidade
            // 
            this.lbl_mensalidade.AutoSize = true;
            this.lbl_mensalidade.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mensalidade.Location = new System.Drawing.Point(3, 262);
            this.lbl_mensalidade.Name = "lbl_mensalidade";
            this.lbl_mensalidade.Size = new System.Drawing.Size(199, 21);
            this.lbl_mensalidade.TabIndex = 7;
            this.lbl_mensalidade.Text = "Valor da Mensalidade:";
            // 
            // lbl_cargaHoraria
            // 
            this.lbl_cargaHoraria.AutoSize = true;
            this.lbl_cargaHoraria.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargaHoraria.Location = new System.Drawing.Point(277, 262);
            this.lbl_cargaHoraria.Name = "lbl_cargaHoraria";
            this.lbl_cargaHoraria.Size = new System.Drawing.Size(145, 21);
            this.lbl_cargaHoraria.TabIndex = 8;
            this.lbl_cargaHoraria.Text = "Carga Horária: ";
            // 
            // txt_cargaHorária
            // 
            this.txt_cargaHorária.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cargaHorária.Location = new System.Drawing.Point(252, 295);
            this.txt_cargaHorária.Name = "txt_cargaHorária";
            this.txt_cargaHorária.Size = new System.Drawing.Size(195, 26);
            this.txt_cargaHorária.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_nomeCurso);
            this.panel1.Controls.Add(this.txt_cargaHorária);
            this.panel1.Controls.Add(this.txt_codCurso);
            this.panel1.Controls.Add(this.lbl_cargaHoraria);
            this.panel1.Controls.Add(this.lbl_codCurso);
            this.panel1.Controls.Add(this.lbl_mensalidade);
            this.panel1.Controls.Add(this.lbl_nomeCurso);
            this.panel1.Controls.Add(this.txt_mensalidade);
            this.panel1.Controls.Add(this.lbl_conteudo);
            this.panel1.Controls.Add(this.txt_conteudo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 342);
            this.panel1.TabIndex = 10;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar.Location = new System.Drawing.Point(12, 371);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(102, 32);
            this.btn_Cadastrar.TabIndex = 11;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.Khaki;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Location = new System.Drawing.Point(131, 371);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(102, 32);
            this.btn_Alterar.TabIndex = 12;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.White;
            this.btn_Excluir.Location = new System.Drawing.Point(242, 371);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(102, 32);
            this.btn_Excluir.TabIndex = 13;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Listar
            // 
            this.btn_Listar.BackColor = System.Drawing.Color.Turquoise;
            this.btn_Listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listar.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar.Location = new System.Drawing.Point(364, 371);
            this.btn_Listar.Name = "btn_Listar";
            this.btn_Listar.Size = new System.Drawing.Size(102, 32);
            this.btn_Listar.TabIndex = 14;
            this.btn_Listar.Text = "Listar";
            this.btn_Listar.UseVisualStyleBackColor = false;
            this.btn_Listar.Click += new System.EventHandler(this.btn_Listar_Click);
            // 
            // dtg_cursos
            // 
            this.dtg_cursos.BackgroundColor = System.Drawing.Color.White;
            this.dtg_cursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_cursos.Location = new System.Drawing.Point(12, 418);
            this.dtg_cursos.Name = "dtg_cursos";
            this.dtg_cursos.Size = new System.Drawing.Size(454, 199);
            this.dtg_cursos.TabIndex = 15;
            // 
            // frm_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(478, 629);
            this.Controls.Add(this.dtg_cursos);
            this.Controls.Add(this.btn_Listar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Alterar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.frm_Cursos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codCurso;
        private System.Windows.Forms.Label lbl_codCurso;
        private System.Windows.Forms.Label lbl_nomeCurso;
        private System.Windows.Forms.TextBox txt_nomeCurso;
        private System.Windows.Forms.Label lbl_conteudo;
        private System.Windows.Forms.TextBox txt_conteudo;
        private System.Windows.Forms.TextBox txt_mensalidade;
        private System.Windows.Forms.Label lbl_mensalidade;
        private System.Windows.Forms.Label lbl_cargaHoraria;
        private System.Windows.Forms.TextBox txt_cargaHorária;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Listar;
        private System.Windows.Forms.DataGridView dtg_cursos;
    }
}

