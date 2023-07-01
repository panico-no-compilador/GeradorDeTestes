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
            cbMaterias = new ComboBox();
            lbEnunciado = new Label();
            textBox1 = new TextBox();
            lbResposta = new Label();
            tbRespostaAlternativa = new TextBox();
            btnAdicionarRespostas = new Button();
            button1 = new Button();
            btnCancelar = new Button();
            lbAlternativas = new Label();
            painelRespostasAlternativas = new Panel();
            tabelaRespostasAlternativas = new DataGridView();
            btnRemover = new Button();
            painelRespostasAlternativas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelaRespostasAlternativas).BeginInit();
            SuspendLayout();
            // 
            // lbMateria
            // 
            lbMateria.AutoSize = true;
            lbMateria.Location = new Point(50, 42);
            lbMateria.Name = "lbMateria";
            lbMateria.Size = new Size(50, 15);
            lbMateria.TabIndex = 0;
            lbMateria.Text = "Matéria:";
            // 
            // cbMaterias
            // 
            cbMaterias.FormattingEnabled = true;
            cbMaterias.Location = new Point(106, 39);
            cbMaterias.Name = "cbMaterias";
            cbMaterias.Size = new Size(151, 23);
            cbMaterias.TabIndex = 1;
            // 
            // lbEnunciado
            // 
            lbEnunciado.AutoSize = true;
            lbEnunciado.Location = new Point(34, 116);
            lbEnunciado.Name = "lbEnunciado";
            lbEnunciado.Size = new Size(66, 15);
            lbEnunciado.TabIndex = 2;
            lbEnunciado.Text = "Enunciado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 78);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 95);
            textBox1.TabIndex = 3;
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
            // tbRespostaAlternativa
            // 
            tbRespostaAlternativa.Location = new Point(106, 197);
            tbRespostaAlternativa.Multiline = true;
            tbRespostaAlternativa.Name = "tbRespostaAlternativa";
            tbRespostaAlternativa.Size = new Size(204, 62);
            tbRespostaAlternativa.TabIndex = 5;
            // 
            // btnAdicionarRespostas
            // 
            btnAdicionarRespostas.Location = new Point(325, 197);
            btnAdicionarRespostas.Name = "btnAdicionarRespostas";
            btnAdicionarRespostas.Size = new Size(85, 62);
            btnAdicionarRespostas.TabIndex = 6;
            btnAdicionarRespostas.Text = "Adicionar";
            btnAdicionarRespostas.UseVisualStyleBackColor = true;
            btnAdicionarRespostas.Click += btnAdicionarRespostas_Click;
            // 
            // button1
            // 
            button1.Location = new Point(282, 462);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 8;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
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
            // TelaQuestoesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 511);
            Controls.Add(lbAlternativas);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(painelRespostasAlternativas);
            Controls.Add(btnAdicionarRespostas);
            Controls.Add(tbRespostaAlternativa);
            Controls.Add(lbResposta);
            Controls.Add(textBox1);
            Controls.Add(lbEnunciado);
            Controls.Add(cbMaterias);
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
        private ComboBox cbMaterias;
        private Label lbEnunciado;
        private TextBox textBox1;
        private Label lbResposta;
        private TextBox tbRespostaAlternativa;
        private Button btnAdicionarRespostas;
        private Button button1;
        private Button btnCancelar;
        private Label lbAlternativas;
        private Panel painelRespostasAlternativas;
        private Button btnRemover;
        private DataGridView tabelaRespostasAlternativas;
    }
}