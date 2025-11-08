namespace ControleDeCursos
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.ms_principal = new System.Windows.Forms.MenuStrip();
            this.tsm_cursos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_turmas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_professor = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ms_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_principal
            // 
            this.ms_principal.BackColor = System.Drawing.Color.Black;
            this.ms_principal.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_cursos,
            this.tsm_turmas,
            this.tsm_professor});
            this.ms_principal.Location = new System.Drawing.Point(0, 0);
            this.ms_principal.Name = "ms_principal";
            this.ms_principal.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.ms_principal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_principal.Size = new System.Drawing.Size(423, 31);
            this.ms_principal.TabIndex = 0;
            this.ms_principal.Text = "menuStrip1";
            // 
            // tsm_cursos
            // 
            this.tsm_cursos.ForeColor = System.Drawing.Color.White;
            this.tsm_cursos.Name = "tsm_cursos";
            this.tsm_cursos.Size = new System.Drawing.Size(76, 25);
            this.tsm_cursos.Text = "Cursos";
            this.tsm_cursos.Click += new System.EventHandler(this.tsm_cursos_Click);
            // 
            // tsm_turmas
            // 
            this.tsm_turmas.ForeColor = System.Drawing.Color.White;
            this.tsm_turmas.Name = "tsm_turmas";
            this.tsm_turmas.Size = new System.Drawing.Size(76, 25);
            this.tsm_turmas.Text = "Turmas";
            this.tsm_turmas.Click += new System.EventHandler(this.tsm_turmas_Click);
            // 
            // tsm_professor
            // 
            this.tsm_professor.ForeColor = System.Drawing.Color.White;
            this.tsm_professor.Name = "tsm_professor";
            this.tsm_professor.Size = new System.Drawing.Size(121, 25);
            this.tsm_professor.Text = "Professores";
            this.tsm_professor.Click += new System.EventHandler(this.tsm_professor_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(423, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ms_principal);
            this.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.ms_principal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Cursos";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.ms_principal.ResumeLayout(false);
            this.ms_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_principal;
        private System.Windows.Forms.ToolStripMenuItem tsm_cursos;
        private System.Windows.Forms.ToolStripMenuItem tsm_turmas;
        private System.Windows.Forms.ToolStripMenuItem tsm_professor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}