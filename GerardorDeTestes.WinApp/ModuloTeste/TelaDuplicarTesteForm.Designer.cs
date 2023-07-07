namespace GerardorDeTestes.WinApp.ModuloTeste
{
    partial class TelaDuplicarTesteForm
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            checkBox1 = new CheckBox();
            lbQuestoesSelecionadas = new Label();
            painelQuestoesSorteadas = new Panel();
            tabelaQuestoesSorteadas = new DataGridView();
            btnSortear = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(72, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 23);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(72, 115);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 23);
            comboBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 23);
            textBox1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(389, 68);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 23);
            numericUpDown1.TabIndex = 6;
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
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(292, 116);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(143, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Prova de Recuperação";
            checkBox1.UseVisualStyleBackColor = true;
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
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(320, 470);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 29);
            btnGravar.TabIndex = 13;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
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
            // TelaDuplicarTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 511);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lbQuestoesSelecionadas);
            Controls.Add(painelQuestoesSorteadas);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaDuplicarTesteForm";
            Text = "Duplicação de Testes";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            painelQuestoesSorteadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabelaQuestoesSorteadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Label label4;
        private CheckBox checkBox1;
        private Label lbQuestoesSelecionadas;
        private Panel painelQuestoesSorteadas;
        private DataGridView tabelaQuestoesSorteadas;
        private Button btnSortear;
        private Button btnGravar;
        private Button btnCancelar;
    }
}