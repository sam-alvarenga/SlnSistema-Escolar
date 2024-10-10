namespace PrjAtiv_SistemaEscolar
{
    partial class FormCadastroDisciplinas
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
            lblDisciplina = new Label();
            lblCarga = new Label();
            lblDescricao = new Label();
            lblCadastrarDisciplina = new Label();
            txtNomeDisciplina = new TextBox();
            ndCargaHoraria = new NumericUpDown();
            txtDesc_disciplina = new TextBox();
            btnCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)ndCargaHoraria).BeginInit();
            SuspendLayout();
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(106, 176);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(99, 16);
            lblDisciplina.TabIndex = 0;
            lblDisciplina.Text = "Nome da disciplina:";
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Location = new Point(106, 216);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(73, 16);
            lblCarga.TabIndex = 1;
            lblCarga.Text = "Carga horária:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(106, 256);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(117, 16);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição da disciplina:";
            // 
            // lblCadastrarDisciplina
            // 
            lblCadastrarDisciplina.AutoSize = true;
            lblCadastrarDisciplina.Font = new Font("Arial Narrow", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCadastrarDisciplina.Location = new Point(232, 73);
            lblCadastrarDisciplina.Name = "lblCadastrarDisciplina";
            lblCadastrarDisciplina.Size = new Size(227, 31);
            lblCadastrarDisciplina.TabIndex = 3;
            lblCadastrarDisciplina.Text = "Cadastrar Disciplina";
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(232, 173);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(242, 21);
            txtNomeDisciplina.TabIndex = 4;
            // 
            // ndCargaHoraria
            // 
            ndCargaHoraria.Location = new Point(232, 211);
            ndCargaHoraria.Name = "ndCargaHoraria";
            ndCargaHoraria.Size = new Size(242, 21);
            ndCargaHoraria.TabIndex = 5;
            // 
            // txtDesc_disciplina
            // 
            txtDesc_disciplina.Location = new Point(232, 253);
            txtDesc_disciplina.Name = "txtDesc_disciplina";
            txtDesc_disciplina.Size = new Size(242, 21);
            txtDesc_disciplina.TabIndex = 6;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Gray;
            btnCadastrar.Location = new Point(278, 337);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(134, 29);
            btnCadastrar.TabIndex = 16;
            btnCadastrar.Text = "Cadastrar Disciplina";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // FormCadastroDisciplinas
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 480);
            Controls.Add(btnCadastrar);
            Controls.Add(txtDesc_disciplina);
            Controls.Add(ndCargaHoraria);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(lblCadastrarDisciplina);
            Controls.Add(lblDescricao);
            Controls.Add(lblCarga);
            Controls.Add(lblDisciplina);
            Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "FormCadastroDisciplinas";
            Text = "Cadastro de Disciplinas";
            ((System.ComponentModel.ISupportInitialize)ndCargaHoraria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDisciplina;
        private Label lblCarga;
        private Label lblDescricao;
        private Label lblCadastrarDisciplina;
        private TextBox txtNomeDisciplina;
        private NumericUpDown ndCargaHoraria;
        private TextBox txtDesc_disciplina;
        private Button btnCadastrar;
    }
}