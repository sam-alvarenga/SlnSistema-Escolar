namespace PrjAtiv_SistemaEscolar
{
    partial class FormCadastroProfessor
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
            lblNomeP = new Label();
            lblCpf = new Label();
            lblEndereco_Prof = new Label();
            lblTelefone_Prof = new Label();
            lblEmail_Prof = new Label();
            lblDisciplina_Prof = new Label();
            txtNomeProfessor = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            txtEnderecoProfessor = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            txtEmailProfessor = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            lblDA = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblNomeP
            // 
            lblNomeP.AutoSize = true;
            lblNomeP.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNomeP.Location = new Point(111, 146);
            lblNomeP.Name = "lblNomeP";
            lblNomeP.Size = new Size(85, 16);
            lblNomeP.TabIndex = 0;
            lblNomeP.Text = "Nome Completo:";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCpf.Location = new Point(506, 146);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(30, 16);
            lblCpf.TabIndex = 1;
            lblCpf.Text = "CPF:";
            // 
            // lblEndereco_Prof
            // 
            lblEndereco_Prof.AutoSize = true;
            lblEndereco_Prof.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco_Prof.Location = new Point(111, 238);
            lblEndereco_Prof.Name = "lblEndereco_Prof";
            lblEndereco_Prof.Size = new Size(53, 16);
            lblEndereco_Prof.TabIndex = 2;
            lblEndereco_Prof.Text = "Endereço:";
            // 
            // lblTelefone_Prof
            // 
            lblTelefone_Prof.AutoSize = true;
            lblTelefone_Prof.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone_Prof.Location = new Point(506, 238);
            lblTelefone_Prof.Name = "lblTelefone_Prof";
            lblTelefone_Prof.Size = new Size(50, 16);
            lblTelefone_Prof.TabIndex = 3;
            lblTelefone_Prof.Text = "Telefone:";
            // 
            // lblEmail_Prof
            // 
            lblEmail_Prof.AutoSize = true;
            lblEmail_Prof.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail_Prof.Location = new Point(111, 190);
            lblEmail_Prof.Name = "lblEmail_Prof";
            lblEmail_Prof.Size = new Size(39, 16);
            lblEmail_Prof.TabIndex = 4;
            lblEmail_Prof.Text = "E-mail:";
            // 
            // lblDisciplina_Prof
            // 
            lblDisciplina_Prof.AutoSize = true;
            lblDisciplina_Prof.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisciplina_Prof.Location = new Point(506, 188);
            lblDisciplina_Prof.Name = "lblDisciplina_Prof";
            lblDisciplina_Prof.Size = new Size(56, 16);
            lblDisciplina_Prof.TabIndex = 5;
            lblDisciplina_Prof.Text = "Disciplina:";
            // 
            // txtNomeProfessor
            // 
            txtNomeProfessor.Location = new Point(202, 144);
            txtNomeProfessor.Name = "txtNomeProfessor";
            txtNomeProfessor.Size = new Size(270, 23);
            txtNomeProfessor.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(568, 144);
            maskedTextBox1.Mask = "999,999,999-99";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(121, 23);
            maskedTextBox1.TabIndex = 7;
            // 
            // txtEnderecoProfessor
            // 
            txtEnderecoProfessor.Location = new Point(202, 236);
            txtEnderecoProfessor.Name = "txtEnderecoProfessor";
            txtEnderecoProfessor.Size = new Size(270, 23);
            txtEnderecoProfessor.TabIndex = 8;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(568, 236);
            maskedTextBox2.Mask = "(99)99999-9999";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(121, 23);
            maskedTextBox2.TabIndex = 9;
            // 
            // txtEmailProfessor
            // 
            txtEmailProfessor.Location = new Point(202, 188);
            txtEmailProfessor.Name = "txtEmailProfessor";
            txtEmailProfessor.Size = new Size(270, 23);
            txtEmailProfessor.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Língua portuguesa", "Matemática", "Arte  ", "Química", "Física ", "Biologia", "Geografia", "História", "Filosofia", "Sociologia", "Educação física", "Inglês", "Espanhol." });
            comboBox1.Location = new Point(568, 186);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(253, 39);
            label1.Name = "label1";
            label1.Size = new Size(297, 37);
            label1.TabIndex = 12;
            label1.Text = "Cadastrar Professores";
            // 
            // lblDA
            // 
            lblDA.AutoSize = true;
            lblDA.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDA.Location = new Point(260, 302);
            lblDA.Name = "lblDA";
            lblDA.Size = new Size(93, 16);
            lblDA.TabIndex = 13;
            lblDA.Text = "Data de Admissão:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(375, 297);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(161, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Gray;
            btnCadastrar.Location = new Point(338, 367);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(134, 29);
            btnCadastrar.TabIndex = 15;
            btnCadastrar.Text = "Cadastrar Professor";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FormCadastroProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDA);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(txtEmailProfessor);
            Controls.Add(maskedTextBox2);
            Controls.Add(txtEnderecoProfessor);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtNomeProfessor);
            Controls.Add(lblDisciplina_Prof);
            Controls.Add(lblEmail_Prof);
            Controls.Add(lblTelefone_Prof);
            Controls.Add(lblEndereco_Prof);
            Controls.Add(lblCpf);
            Controls.Add(lblNomeP);
            Name = "FormCadastroProfessor";
            Text = "Cadastro de Professores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeP;
        private Label lblCpf;
        private Label lblEndereco_Prof;
        private Label lblTelefone_Prof;
        private Label lblEmail_Prof;
        private Label lblDisciplina_Prof;
        private TextBox txtNomeProfessor;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtEnderecoProfessor;
        private MaskedTextBox maskedTextBox2;
        private TextBox txtEmailProfessor;
        private ComboBox comboBox1;
        private Label label1;
        private Label lblDA;
        private DateTimePicker dateTimePicker1;
        private Button btnCadastrar;
    }
}