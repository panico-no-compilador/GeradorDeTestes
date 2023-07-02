namespace GerardorDeTestes.WinApp.ModuloTestes
{
    partial class TelaCadastroTestesForm
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
            lbTitulo = new Label();
            tbTitulo = new TextBox();
            lbDisciplina = new Label();
            cbDisciplina = new ComboBox();
            lbQtdQuestoes = new Label();
            numQtdQuestoes = new NumericUpDown();
            lbMateria = new Label();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            gbQuestoesSelecionadas = new GroupBox();
            btnSortearQuestoes = new Button();
            dataGridView1 = new DataGridView();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numQtdQuestoes).BeginInit();
            gbQuestoesSelecionadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Location = new Point(44, 38);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(40, 15);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Título:";
            // 
            // tbTitulo
            // 
            tbTitulo.Location = new Point(90, 35);
            tbTitulo.Name = "tbTitulo";
            tbTitulo.PlaceholderText = "Exp: Teste de Matemática";
            tbTitulo.Size = new Size(340, 23);
            tbTitulo.TabIndex = 1;
            // 
            // lbDisciplina
            // 
            lbDisciplina.AutoSize = true;
            lbDisciplina.Location = new Point(23, 86);
            lbDisciplina.Name = "lbDisciplina";
            lbDisciplina.Size = new Size(61, 15);
            lbDisciplina.TabIndex = 2;
            lbDisciplina.Text = "Disciplina:";
            // 
            // cbDisciplina
            // 
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(90, 83);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(177, 23);
            cbDisciplina.TabIndex = 3;
            // 
            // lbQtdQuestoes
            // 
            lbQtdQuestoes.AutoSize = true;
            lbQtdQuestoes.Location = new Point(283, 86);
            lbQtdQuestoes.Name = "lbQtdQuestoes";
            lbQtdQuestoes.Size = new Size(88, 15);
            lbQtdQuestoes.TabIndex = 4;
            lbQtdQuestoes.Text = "Qtd. Questões: ";
            // 
            // numQtdQuestoes
            // 
            numQtdQuestoes.Location = new Point(377, 83);
            numQtdQuestoes.Name = "numQtdQuestoes";
            numQtdQuestoes.Size = new Size(53, 23);
            numQtdQuestoes.TabIndex = 5;
            numQtdQuestoes.TextAlign = HorizontalAlignment.Center;
            // 
            // lbMateria
            // 
            lbMateria.AutoSize = true;
            lbMateria.Location = new Point(34, 131);
            lbMateria.Name = "lbMateria";
            lbMateria.Size = new Size(50, 15);
            lbMateria.TabIndex = 6;
            lbMateria.Text = "Matéria:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(90, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(177, 23);
            comboBox1.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(283, 130);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(148, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Prova de Recuperaçao?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // gbQuestoesSelecionadas
            // 
            gbQuestoesSelecionadas.Controls.Add(dataGridView1);
            gbQuestoesSelecionadas.Controls.Add(btnSortearQuestoes);
            gbQuestoesSelecionadas.Location = new Point(34, 177);
            gbQuestoesSelecionadas.Name = "gbQuestoesSelecionadas";
            gbQuestoesSelecionadas.Size = new Size(382, 260);
            gbQuestoesSelecionadas.TabIndex = 9;
            gbQuestoesSelecionadas.TabStop = false;
            gbQuestoesSelecionadas.Text = "Questões Selecionadas";
            // 
            // btnSortearQuestoes
            // 
            btnSortearQuestoes.Location = new Point(10, 22);
            btnSortearQuestoes.Name = "btnSortearQuestoes";
            btnSortearQuestoes.Size = new Size(113, 24);
            btnSortearQuestoes.TabIndex = 0;
            btnSortearQuestoes.Text = "Sortear Questões";
            btnSortearQuestoes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(382, 208);
            dataGridView1.TabIndex = 1;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(305, 476);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 25);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(397, 476);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 25);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroTestesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 511);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(gbQuestoesSelecionadas);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(lbMateria);
            Controls.Add(numQtdQuestoes);
            Controls.Add(lbQtdQuestoes);
            Controls.Add(cbDisciplina);
            Controls.Add(lbDisciplina);
            Controls.Add(tbTitulo);
            Controls.Add(lbTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroTestesForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Testes";
            ((System.ComponentModel.ISupportInitialize)numQtdQuestoes).EndInit();
            gbQuestoesSelecionadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private TextBox tbTitulo;
        private Label lbDisciplina;
        private ComboBox cbDisciplina;
        private Label lbQtdQuestoes;
        private NumericUpDown numQtdQuestoes;
        private Label lbMateria;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private GroupBox gbQuestoesSelecionadas;
        private Button btnSortearQuestoes;
        private DataGridView dataGridView1;
        private Button btnGravar;
        private Button btnCancelar;
    }
}