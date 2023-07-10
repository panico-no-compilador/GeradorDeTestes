namespace GerardorDeTestes.WinApp.ModuloTeste
{
    partial class TelaCadastrarTesteForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbDisciplina = new ComboBox();
            cmbMateria = new ComboBox();
            txtTitulo = new TextBox();
            numericQtdQuestoes = new NumericUpDown();
            label4 = new Label();
            checkProva = new CheckBox();
            lbQuestoesSelecionadas = new Label();
            painelQuestoesSorteadas = new Panel();
            tabelaQuestoesSorteadas = new DataGridView();
            btnSortear = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericQtdQuestoes).BeginInit();
            painelQuestoesSorteadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaQuestoesSorteadas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Disciplina:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 118);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Matéria:";
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Location = new Point(72, 68);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(151, 23);
            cmbDisciplina.TabIndex = 3;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(72, 115);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(151, 23);
            cmbMateria.TabIndex = 4;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(72, 27);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(407, 23);
            txtTitulo.TabIndex = 5;
            // 
            // numericQtdQuestoes
            // 
            numericQtdQuestoes.Location = new Point(389, 68);
            numericQtdQuestoes.Name = "numericQtdQuestoes";
            numericQtdQuestoes.Size = new Size(44, 23);
            numericQtdQuestoes.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(292, 68);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "QTd.Questões";
            // 
            // checkProva
            // 
            checkProva.AutoSize = true;
            checkProva.Location = new Point(292, 116);
            checkProva.Name = "checkProva";
            checkProva.Size = new Size(143, 19);
            checkProva.TabIndex = 8;
            checkProva.Text = "Prova de Recuperação";
            checkProva.UseVisualStyleBackColor = true;
            // 
            // lbQuestoesSelecionadas
            // 
            lbQuestoesSelecionadas.AutoSize = true;
            lbQuestoesSelecionadas.Location = new Point(75, 168);
            lbQuestoesSelecionadas.Name = "lbQuestoesSelecionadas";
            lbQuestoesSelecionadas.Size = new Size(130, 15);
            lbQuestoesSelecionadas.TabIndex = 12;
            lbQuestoesSelecionadas.Text = "Questões Selecionadas:";
            // 
            // painelQuestoesSorteadas
            // 
            painelQuestoesSorteadas.BorderStyle = BorderStyle.FixedSingle;
            painelQuestoesSorteadas.Controls.Add(tabelaQuestoesSorteadas);
            painelQuestoesSorteadas.Controls.Add(btnSortear);
            painelQuestoesSorteadas.Location = new Point(68, 177);
            painelQuestoesSorteadas.Name = "painelQuestoesSorteadas";
            painelQuestoesSorteadas.Size = new Size(367, 287);
            painelQuestoesSorteadas.TabIndex = 11;
            // 
            // tabelaQuestoesSorteadas
            // 
            tabelaQuestoesSorteadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaQuestoesSorteadas.Location = new Point(3, 41);
            tabelaQuestoesSorteadas.Name = "tabelaQuestoesSorteadas";
            tabelaQuestoesSorteadas.RowTemplate.Height = 25;
            tabelaQuestoesSorteadas.Size = new Size(359, 241);
            tabelaQuestoesSorteadas.TabIndex = 2;
            // 
            // btnSortear
            // 
            btnSortear.Location = new Point(6, 8);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(115, 23);
            btnSortear.TabIndex = 1;
            btnSortear.Text = "Sortear Questões";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(320, 470);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 29);
            btnGravar.TabIndex = 13;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(416, 470);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 29);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastrarTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 511);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lbQuestoesSelecionadas);
            Controls.Add(painelQuestoesSorteadas);
            Controls.Add(checkProva);
            Controls.Add(label4);
            Controls.Add(numericQtdQuestoes);
            Controls.Add(txtTitulo);
            Controls.Add(cmbMateria);
            Controls.Add(cmbDisciplina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastrarTesteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Testes";
            ((System.ComponentModel.ISupportInitialize)numericQtdQuestoes).EndInit();
            painelQuestoesSorteadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabelaQuestoesSorteadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbDisciplina;
        private ComboBox cmbMateria;
        private TextBox txtTitulo;
        private NumericUpDown numericQtdQuestoes;
        private Label label4;
        private CheckBox checkProva;
        private Label lbQuestoesSelecionadas;
        private Panel painelQuestoesSorteadas;
        private DataGridView tabelaQuestoesSorteadas;
        private Button btnSortear;
        private Button btnGravar;
        private Button btnCancelar;
    }
}