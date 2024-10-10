namespace PrjAtiv_SistemaEscolar
{
    partial class FormCadastroAluno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblData_Nascimento = new Label();
            lblEndereco = new Label();
            lblTelefone = new Label();
            lblEmail = new Label();
            lblGenero = new Label();
            lblSerie_turma = new Label();
            lblFormulario = new Label();
            txtNome = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            maskedTextBox1 = new MaskedTextBox();
            lblCpf = new Label();
            txtEndereco = new TextBox();
            MtxtTelefone = new MaskedTextBox();
            cbGenero = new ComboBox();
            cbSerieTurma = new ComboBox();
            maskedTextBox2 = new MaskedTextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNome.Location = new Point(78, 159);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(95, 16);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome Completo:";
            // 
            // lblData_Nascimento
            // 
            lblData_Nascimento.AutoSize = true;
            lblData_Nascimento.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblData_Nascimento.Location = new Point(78, 199);
            lblData_Nascimento.Name = "lblData_Nascimento";
            lblData_Nascimento.Size = new Size(116, 16);
            lblData_Nascimento.TabIndex = 1;
            lblData_Nascimento.Text = "Data de Nascimento:";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEndereco.Location = new Point(78, 279);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(61, 16);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTelefone.Location = new Point(454, 241);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(56, 16);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(78, 241);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(43, 16);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenero.Location = new Point(454, 159);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(49, 16);
            lblGenero.TabIndex = 5;
            lblGenero.Text = "Gênero:";
            // 
            // lblSerie_turma
            // 
            lblSerie_turma.AutoSize = true;
            lblSerie_turma.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSerie_turma.Location = new Point(454, 281);
            lblSerie_turma.Name = "lblSerie_turma";
            lblSerie_turma.Size = new Size(73, 16);
            lblSerie_turma.TabIndex = 6;
            lblSerie_turma.Text = "Série/Turma:";
            // 
            // lblFormulario
            // 
            lblFormulario.AutoSize = true;
            lblFormulario.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormulario.Location = new Point(276, 69);
            lblFormulario.Name = "lblFormulario";
            lblFormulario.Size = new Size(242, 32);
            lblFormulario.TabIndex = 7;
            lblFormulario.Text = "Cadastrar Alunos";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(202, 157);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(219, 23);
            txtNome.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(202, 194);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(202, 239);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(219, 23);
            maskedTextBox1.TabIndex = 10;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCpf.Location = new Point(454, 199);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(33, 16);
            lblCpf.TabIndex = 11;
            lblCpf.Text = "CPF:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(202, 277);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(219, 23);
            txtEndereco.TabIndex = 12;
            // 
            // MtxtTelefone
            // 
            MtxtTelefone.Location = new Point(534, 241);
            MtxtTelefone.Mask = "(99)99999-9999";
            MtxtTelefone.Name = "MtxtTelefone";
            MtxtTelefone.Size = new Size(153, 23);
            MtxtTelefone.TabIndex = 13;
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "Feminino", "Masculino", "Outro" });
            cbGenero.Location = new Point(534, 159);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(153, 23);
            cbGenero.TabIndex = 14;
            // 
            // cbSerieTurma
            // 
            cbSerieTurma.FormattingEnabled = true;
            cbSerieTurma.Items.AddRange(new object[] { "1º Ano ", "2º Ano ", "3º Ano ", "4º Ano ", "5º Ano ", "6º Ano ", "7º Ano ", "8º Ano ", "9º Ano " });
            cbSerieTurma.Location = new Point(534, 279);
            cbSerieTurma.Name = "cbSerieTurma";
            cbSerieTurma.Size = new Size(153, 23);
            cbSerieTurma.TabIndex = 15;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(534, 196);
            maskedTextBox2.Mask = "999,999,999-99";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(153, 23);
            maskedTextBox2.TabIndex = 16;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Gray;
            btnCadastrar.Location = new Point(336, 358);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(134, 29);
            btnCadastrar.TabIndex = 17;
            btnCadastrar.Text = "Cadastrar Aluno";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FormCadastroAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(maskedTextBox2);
            Controls.Add(cbSerieTurma);
            Controls.Add(cbGenero);
            Controls.Add(MtxtTelefone);
            Controls.Add(txtEndereco);
            Controls.Add(lblCpf);
            Controls.Add(maskedTextBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtNome);
            Controls.Add(lblFormulario);
            Controls.Add(lblSerie_turma);
            Controls.Add(lblGenero);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblEndereco);
            Controls.Add(lblData_Nascimento);
            Controls.Add(lblNome);
            Name = "FormCadastroAluno";
            Text = "Cadastro de Alunos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblData_Nascimento;
        private Label lblEndereco;
        private Label lblTelefone;
        private Label lblEmail;
        private Label lblGenero;
        private Label lblSerie_turma;
        private Label lblFormulario;
        private TextBox txtNome;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Label lblCpf;
        private TextBox txtEndereco;
        private MaskedTextBox MtxtTelefone;
        private ComboBox cbGenero;
        private ComboBox cbSerieTurma;
        private MaskedTextBox maskedTextBox2;
        private Button btnCadastrar;
    }
}