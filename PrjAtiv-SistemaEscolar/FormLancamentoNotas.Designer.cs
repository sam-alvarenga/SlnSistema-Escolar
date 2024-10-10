namespace PrjAtiv_SistemaEscolar
{
    partial class FormLancamentoNotas
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
            lblAluno = new Label();
            lblListDisiciplina = new Label();
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblNF = new Label();
            cbAlunos = new ComboBox();
            cbListaDeDisiciplina = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            lblLacamentoNotas = new Label();
            txtFinal = new TextBox();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // lblAluno
            // 
            lblAluno.AutoSize = true;
            lblAluno.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAluno.Location = new Point(252, 108);
            lblAluno.Name = "lblAluno";
            lblAluno.Size = new Size(38, 16);
            lblAluno.TabIndex = 0;
            lblAluno.Text = "Aluno:";
            // 
            // lblListDisiciplina
            // 
            lblListDisiciplina.AutoSize = true;
            lblListDisiciplina.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblListDisiciplina.Location = new Point(252, 150);
            lblListDisiciplina.Name = "lblListDisiciplina";
            lblListDisiciplina.Size = new Size(59, 16);
            lblListDisiciplina.TabIndex = 1;
            lblListDisiciplina.Text = "Disiciplina:";
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNota1.Location = new Point(252, 198);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(39, 16);
            lblNota1.TabIndex = 2;
            lblNota1.Text = "Nota 1:";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNota2.Location = new Point(252, 243);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(39, 16);
            lblNota2.TabIndex = 3;
            lblNota2.Text = "Nota 2:";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNota3.Location = new Point(252, 280);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(39, 16);
            lblNota3.TabIndex = 4;
            lblNota3.Text = "Nota 3:";
            // 
            // lblNF
            // 
            lblNF.AutoSize = true;
            lblNF.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNF.Location = new Point(252, 320);
            lblNF.Name = "lblNF";
            lblNF.Size = new Size(57, 16);
            lblNF.TabIndex = 5;
            lblNF.Text = "Nota Final:";
            // 
            // cbAlunos
            // 
            cbAlunos.FormattingEnabled = true;
            cbAlunos.Items.AddRange(new object[] { "Helena", "Alice", "Laura", "Maria Alice", "Sophia", "Manuela", "Maitê", "Liz", "Cecília", "Isabella", "Luísa", "Eloá", "Heloísa", "Júlia", "Ayla", "Maria Luísa", "Isis", "Elisa", "Antonella", "Valentina" });
            cbAlunos.Location = new Point(331, 108);
            cbAlunos.Name = "cbAlunos";
            cbAlunos.Size = new Size(130, 23);
            cbAlunos.TabIndex = 6;
            // 
            // cbListaDeDisiciplina
            // 
            cbListaDeDisiciplina.FormattingEnabled = true;
            cbListaDeDisiciplina.Location = new Point(331, 148);
            cbListaDeDisiciplina.Name = "cbListaDeDisiciplina";
            cbListaDeDisiciplina.Size = new Size(129, 23);
            cbListaDeDisiciplina.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(331, 197);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(130, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(331, 280);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(130, 23);
            numericUpDown2.TabIndex = 9;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(331, 242);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(130, 23);
            numericUpDown3.TabIndex = 10;
            // 
            // lblLacamentoNotas
            // 
            lblLacamentoNotas.AutoSize = true;
            lblLacamentoNotas.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLacamentoNotas.Location = new Point(264, 39);
            lblLacamentoNotas.Name = "lblLacamentoNotas";
            lblLacamentoNotas.Size = new Size(244, 31);
            lblLacamentoNotas.TabIndex = 12;
            lblLacamentoNotas.Text = "Lançamento de Notas";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(331, 318);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(129, 23);
            txtFinal.TabIndex = 13;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Gray;
            btnCadastrar.Location = new Point(331, 380);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(129, 29);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FormLancamentoNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(txtFinal);
            Controls.Add(lblLacamentoNotas);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(cbListaDeDisiciplina);
            Controls.Add(cbAlunos);
            Controls.Add(lblNF);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(lblListDisiciplina);
            Controls.Add(lblAluno);
            Name = "FormLancamentoNotas";
            Text = "Lançamento de Notas";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAluno;
        private Label lblListDisiciplina;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblNF;
        private ComboBox cbAlunos;
        private ComboBox cbListaDeDisiciplina;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label lblLacamentoNotas;
        private TextBox txtFinal;
        private Button btnCadastrar;
    }
}