namespace PrjAtiv_SistemaEscolar
{
    partial class FormCadastrarTurmas
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
            lblCadastroDeTurmas = new Label();
            lblTurma = new Label();
            lblAno = new Label();
            lblProfessor = new Label();
            lblQMAluno = new Label();
            label1 = new Label();
            txtNome_turma = new TextBox();
            cbAnoLetivo = new ComboBox();
            cbProf_responsavel = new ComboBox();
            ndQuant_Alunos = new NumericUpDown();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)ndQuant_Alunos).BeginInit();
            SuspendLayout();
            // 
            // lblCadastroDeTurmas
            // 
            lblCadastroDeTurmas.AutoSize = true;
            lblCadastroDeTurmas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastroDeTurmas.Location = new Point(299, 41);
            lblCadastroDeTurmas.Name = "lblCadastroDeTurmas";
            lblCadastroDeTurmas.Size = new Size(241, 37);
            lblCadastroDeTurmas.TabIndex = 0;
            lblCadastroDeTurmas.Text = "Cadastrar Turmas";
            // 
            // lblTurma
            // 
            lblTurma.AutoSize = true;
            lblTurma.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurma.Location = new Point(240, 150);
            lblTurma.Name = "lblTurma";
            lblTurma.Size = new Size(81, 16);
            lblTurma.TabIndex = 1;
            lblTurma.Text = "Nome da turma:";
            // 
            // lblAno
            // 
            lblAno.AutoSize = true;
            lblAno.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAno.Location = new Point(240, 193);
            lblAno.Name = "lblAno";
            lblAno.Size = new Size(58, 16);
            lblAno.TabIndex = 2;
            lblAno.Text = "Ano letivo:";
            // 
            // lblProfessor
            // 
            lblProfessor.AutoSize = true;
            lblProfessor.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProfessor.Location = new Point(240, 239);
            lblProfessor.Name = "lblProfessor";
            lblProfessor.Size = new Size(114, 16);
            lblProfessor.TabIndex = 3;
            lblProfessor.Text = "Professor responsável:";
            // 
            // lblQMAluno
            // 
            lblQMAluno.AutoSize = true;
            lblQMAluno.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblQMAluno.Location = new Point(240, 280);
            lblQMAluno.Name = "lblQMAluno";
            lblQMAluno.Size = new Size(150, 16);
            lblQMAluno.TabIndex = 4;
            lblQMAluno.Text = "Quantidade máxima de alunos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(542, 151);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // txtNome_turma
            // 
            txtNome_turma.Location = new Point(396, 151);
            txtNome_turma.Name = "txtNome_turma";
            txtNome_turma.Size = new Size(121, 23);
            txtNome_turma.TabIndex = 6;
            // 
            // cbAnoLetivo
            // 
            cbAnoLetivo.FormattingEnabled = true;
            cbAnoLetivo.Items.AddRange(new object[] { "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            cbAnoLetivo.Location = new Point(396, 191);
            cbAnoLetivo.Name = "cbAnoLetivo";
            cbAnoLetivo.Size = new Size(121, 23);
            cbAnoLetivo.TabIndex = 7;
            // 
            // cbProf_responsavel
            // 
            cbProf_responsavel.FormattingEnabled = true;
            cbProf_responsavel.Location = new Point(396, 237);
            cbProf_responsavel.Name = "cbProf_responsavel";
            cbProf_responsavel.Size = new Size(121, 23);
            cbProf_responsavel.TabIndex = 8;
            // 
            // ndQuant_Alunos
            // 
            ndQuant_Alunos.Location = new Point(396, 279);
            ndQuant_Alunos.Name = "ndQuant_Alunos";
            ndQuant_Alunos.Size = new Size(120, 23);
            ndQuant_Alunos.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Gray;
            btnCadastrar.Location = new Point(335, 357);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(134, 29);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastrar turma";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FormCadastrarTurmas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(ndQuant_Alunos);
            Controls.Add(cbProf_responsavel);
            Controls.Add(cbAnoLetivo);
            Controls.Add(txtNome_turma);
            Controls.Add(label1);
            Controls.Add(lblQMAluno);
            Controls.Add(lblProfessor);
            Controls.Add(lblAno);
            Controls.Add(lblTurma);
            Controls.Add(lblCadastroDeTurmas);
            Name = "FormCadastrarTurmas";
            Text = "Cadastro de Turmas";
            ((System.ComponentModel.ISupportInitialize)ndQuant_Alunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastroDeTurmas;
        private Label lblTurma;
        private Label lblAno;
        private Label lblProfessor;
        private Label lblQMAluno;
        private Label label1;
        private TextBox txtNome_turma;
        private ComboBox cbAnoLetivo;
        private ComboBox cbProf_responsavel;
        private NumericUpDown ndQuant_Alunos;
        private Button btnCadastrar;
    }
}