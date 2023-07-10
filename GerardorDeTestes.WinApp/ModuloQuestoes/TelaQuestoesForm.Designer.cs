namespace GerardorDeTestes.WinApp.ModuloQuestoes
{
    partial class TelaQuestoesForm
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
            lbMateria = new Label();
            cboxMaterias = new ComboBox();
            lbEnunciado = new Label();
            txtEnunciado = new TextBox();
            lbResposta = new Label();
            txtRespostaAlternativa = new TextBox();
            btnAdicionarRespostasNoDataGridView = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            lbAlternativas = new Label();
            painelRespostasAlternativas = new Panel();
            tabelaRespostasAlternativas = new DataGridView();
            btnRemover = new Button();
            cboxEstaCorreta = new CheckBox();
            lbDisciplina = new Label();
            cboxDisciplina = new ComboBox();
            painelRespostasAlternativas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaRespostasAlternativas).BeginInit();
            SuspendLayout();
            // 
            // lbMateria
            // 
            lbMateria.AutoSize = true;
            lbMateria.Location = new Point(50, 75);
            lbMateria.Name = "lbMateria";
            lbMateria.Size = new Size(50, 15);
            lbMateria.TabIndex = 0;
            lbMateria.Text = "Matéria:";
            // 
            // cboxMaterias
            // 
            cboxMaterias.FormattingEnabled = true;
            cboxMaterias.Location = new Point(106, 72);
            cboxMaterias.Name = "cboxMaterias";
            cboxMaterias.Size = new Size(151, 23);
            cboxMaterias.TabIndex = 1;
            // 
            // lbEnunciado
            // 
            lbEnunciado.AutoSize = true;
            lbEnunciado.Location = new Point(34, 137);
            lbEnunciado.Name = "lbEnunciado";
            lbEnunciado.Size = new Size(66, 15);
            lbEnunciado.TabIndex = 2;
            lbEnunciado.Text = "Enunciado:";
            // 
            // txtEnunciado
            // 
            txtEnunciado.Location = new Point(106, 117);
            txtEnunciado.Multiline = true;
            txtEnunciado.Name = "txtEnunciado";
            txtEnunciado.Size = new Size(304, 62);
            txtEnunciado.TabIndex = 3;
            // 
            // lbResposta
            // 
            lbResposta.AutoSize = true;
            lbResposta.Location = new Point(43, 217);
            lbResposta.Name = "lbResposta";
            lbResposta.Size = new Size(57, 15);
            lbResposta.TabIndex = 4;
            lbResposta.Text = "Resposta:";
            // 
            // txtRespostaAlternativa
            // 
            txtRespostaAlternativa.Location = new Point(106, 197);
            txtRespostaAlternativa.Multiline = true;
            txtRespostaAlternativa.Name = "txtRespostaAlternativa";
            txtRespostaAlternativa.Size = new Size(204, 62);
            txtRespostaAlternativa.TabIndex = 5;
            // 
            // btnAdicionarRespostasNoDataGridView
            // 
            btnAdicionarRespostasNoDataGridView.Location = new Point(325, 197);
            btnAdicionarRespostasNoDataGridView.Name = "btnAdicionarRespostasNoDataGridView";
            btnAdicionarRespostasNoDataGridView.Size = new Size(85, 62);
            btnAdicionarRespostasNoDataGridView.TabIndex = 6;
            btnAdicionarRespostasNoDataGridView.Text = "Adicionar";
            btnAdicionarRespostasNoDataGridView.UseVisualStyleBackColor = true;
            btnAdicionarRespostasNoDataGridView.Click += btnAdicionarRespostasNoGridView_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(282, 462);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 37);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(375, 462);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 37);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbAlternativas
            // 
            lbAlternativas.AutoSize = true;
            lbAlternativas.Location = new Point(50, 270);
            lbAlternativas.Name = "lbAlternativas";
            lbAlternativas.Size = new Size(72, 15);
            lbAlternativas.TabIndex = 10;
            lbAlternativas.Text = "Alternativas:";
            // 
            // painelRespostasAlternativas
            // 
            painelRespostasAlternativas.BorderStyle = BorderStyle.FixedSingle;
            painelRespostasAlternativas.Controls.Add(tabelaRespostasAlternativas);
            painelRespostasAlternativas.Controls.Add(btnRemover);
            painelRespostasAlternativas.Location = new Point(43, 279);
            painelRespostasAlternativas.Name = "painelRespostasAlternativas";
            painelRespostasAlternativas.Size = new Size(367, 166);
            painelRespostasAlternativas.TabIndex = 7;
            // 
            // tabelaRespostasAlternativas
            // 
            tabelaRespostasAlternativas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaRespostasAlternativas.Location = new Point(3, 37);
            tabelaRespostasAlternativas.Name = "tabelaRespostasAlternativas";
            tabelaRespostasAlternativas.RowTemplate.Height = 25;
            tabelaRespostasAlternativas.Size = new Size(359, 124);
            tabelaRespostasAlternativas.TabIndex = 2;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(6, 8);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 1;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // cboxEstaCorreta
            // 
            cboxEstaCorreta.AutoSize = true;
            cboxEstaCorreta.Location = new Point(27, 240);
            cboxEstaCorreta.Name = "cboxEstaCorreta";
            cboxEstaCorreta.Size = new Size(70, 19);
            cboxEstaCorreta.TabIndex = 12;
            cboxEstaCorreta.Text = "Correta?";
            cboxEstaCorreta.UseVisualStyleBackColor = true;
            // 
            // lbDisciplina
            // 
            lbDisciplina.AutoSize = true;
            lbDisciplina.Location = new Point(36, 35);
            lbDisciplina.Name = "lbDisciplina";
            lbDisciplina.Size = new Size(61, 15);
            lbDisciplina.TabIndex = 13;
            lbDisciplina.Text = "Disciplina:";
            // 
            // cboxDisciplina
            // 
            cboxDisciplina.FormattingEnabled = true;
            cboxDisciplina.Location = new Point(106, 32);
            cboxDisciplina.Name = "cboxDisciplina";
            cboxDisciplina.Size = new Size(151, 23);
            cboxDisciplina.TabIndex = 14;
            // 
            // TelaQuestoesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 511);
            Controls.Add(cboxDisciplina);
            Controls.Add(lbDisciplina);
            Controls.Add(cboxEstaCorreta);
            Controls.Add(lbAlternativas);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(painelRespostasAlternativas);
            Controls.Add(btnAdicionarRespostasNoDataGridView);
            Controls.Add(txtRespostaAlternativa);
            Controls.Add(lbResposta);
            Controls.Add(txtEnunciado);
            Controls.Add(lbEnunciado);
            Controls.Add(cboxMaterias);
            Controls.Add(lbMateria);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaQuestoesForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Questões";
            painelRespostasAlternativas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabelaRespostasAlternativas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMateria;
        private Label lbEnunciado;
        private Label lbResposta;
        private Label lbAlternativas;
        private ComboBox cboxMaterias;
        private TextBox txtEnunciado;
        private TextBox txtRespostaAlternativa;
        private Panel painelRespostasAlternativas;
        private Button btnAdicionarRespostasNoDataGridView;
        private Button btnGravar;
        private Button btnCancelar;
        private Button btnRemover;
        private DataGridView tabelaRespostasAlternativas;
        private CheckBox cboxEstaCorreta;
        private Label lbDisciplina;
        private ComboBox cboxDisciplina;
    }
}