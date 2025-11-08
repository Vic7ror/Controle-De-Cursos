namespace ControleDeCursos
{
    partial class frm_professores
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
            this.lbl_codProfessor = new System.Windows.Forms.Label();
            this.lbl_nomeProf = new System.Windows.Forms.Label();
            this.lbl_valorAula = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txt_codProf = new System.Windows.Forms.TextBox();
            this.txt_nomeProf = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_valorHora = new System.Windows.Forms.NumericUpDown();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.dtg_professores = new System.Windows.Forms.DataGridView();
            this.mkd_telefone = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valorHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_professores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codProfessor
            // 
            this.lbl_codProfessor.AutoSize = true;
            this.lbl_codProfessor.Location = new System.Drawing.Point(3, 12);
            this.lbl_codProfessor.Name = "lbl_codProfessor";
            this.lbl_codProfessor.Size = new System.Drawing.Size(487, 21);
            this.lbl_codProfessor.TabIndex = 0;
            this.lbl_codProfessor.Text = "Digite o código do professor para editar ou excluir: ";
            // 
            // lbl_nomeProf
            // 
            this.lbl_nomeProf.AutoSize = true;
            this.lbl_nomeProf.Location = new System.Drawing.Point(3, 57);
            this.lbl_nomeProf.Name = "lbl_nomeProf";
            this.lbl_nomeProf.Size = new System.Drawing.Size(172, 21);
            this.lbl_nomeProf.TabIndex = 1;
            this.lbl_nomeProf.Text = "Nome do Professor:";
            // 
            // lbl_valorAula
            // 
            this.lbl_valorAula.AutoSize = true;
            this.lbl_valorAula.Location = new System.Drawing.Point(3, 104);
            this.lbl_valorAula.Name = "lbl_valorAula";
            this.lbl_valorAula.Size = new System.Drawing.Size(181, 21);
            this.lbl_valorAula.TabIndex = 2;
            this.lbl_valorAula.Text = "Valor da Hora/Aula:";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(331, 104);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(91, 21);
            this.lbl_telefone.TabIndex = 3;
            this.lbl_telefone.Text = "Telefone:";
            // 
            // txt_codProf
            // 
            this.txt_codProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_codProf.Location = new System.Drawing.Point(496, 10);
            this.txt_codProf.Name = "txt_codProf";
            this.txt_codProf.Size = new System.Drawing.Size(76, 26);
            this.txt_codProf.TabIndex = 4;
            // 
            // txt_nomeProf
            // 
            this.txt_nomeProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nomeProf.Location = new System.Drawing.Point(190, 55);
            this.txt_nomeProf.Name = "txt_nomeProf";
            this.txt_nomeProf.Size = new System.Drawing.Size(382, 26);
            this.txt_nomeProf.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.mkd_telefone);
            this.panel1.Controls.Add(this.txt_valorHora);
            this.panel1.Controls.Add(this.lbl_codProfessor);
            this.panel1.Controls.Add(this.lbl_nomeProf);
            this.panel1.Controls.Add(this.lbl_valorAula);
            this.panel1.Controls.Add(this.txt_nomeProf);
            this.panel1.Controls.Add(this.lbl_telefone);
            this.panel1.Controls.Add(this.txt_codProf);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 142);
            this.panel1.TabIndex = 8;
            // 
            // txt_valorHora
            // 
            this.txt_valorHora.Location = new System.Drawing.Point(190, 102);
            this.txt_valorHora.Name = "txt_valorHora";
            this.txt_valorHora.Size = new System.Drawing.Size(135, 26);
            this.txt_valorHora.TabIndex = 8;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Location = new System.Drawing.Point(12, 174);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(119, 33);
            this.btn_Cadastrar.TabIndex = 9;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Khaki;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Location = new System.Drawing.Point(170, 174);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(119, 33);
            this.btn_alterar.TabIndex = 10;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.IndianRed;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(326, 174);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(119, 33);
            this.btn_excluir.TabIndex = 11;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.BackColor = System.Drawing.Color.Turquoise;
            this.btn_listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listar.Location = new System.Drawing.Point(479, 174);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(119, 33);
            this.btn_listar.TabIndex = 12;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = false;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // dtg_professores
            // 
            this.dtg_professores.BackgroundColor = System.Drawing.Color.White;
            this.dtg_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_professores.Location = new System.Drawing.Point(12, 227);
            this.dtg_professores.Name = "dtg_professores";
            this.dtg_professores.Size = new System.Drawing.Size(586, 220);
            this.dtg_professores.TabIndex = 13;
            // 
            // mkd_telefone
            // 
            this.mkd_telefone.Location = new System.Drawing.Point(428, 101);
            this.mkd_telefone.Mask = "(99) 00000-0000";
            this.mkd_telefone.Name = "mkd_telefone";
            this.mkd_telefone.Size = new System.Drawing.Size(144, 26);
            this.mkd_telefone.TabIndex = 9;
            // 
            // frm_professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(610, 458);
            this.Controls.Add(this.dtg_professores);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_professores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Professores";
            this.Load += new System.EventHandler(this.frm_professores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_valorHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_professores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_codProfessor;
        private System.Windows.Forms.Label lbl_nomeProf;
        private System.Windows.Forms.Label lbl_valorAula;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox txt_codProf;
        private System.Windows.Forms.TextBox txt_nomeProf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.DataGridView dtg_professores;
        private System.Windows.Forms.NumericUpDown txt_valorHora;
        private System.Windows.Forms.MaskedTextBox mkd_telefone;
    }
}