namespace GerardorDeTestes.WinApp.ModuloTeste
{
    partial class TelaVizualizarDetalhesTesteForm
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
            lblTitulo = new Label();
            lblDisciplina = new Label();
            lblMateria = new Label();
            btnFechar = new Button();
            panel1 = new Panel();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            txtTitulo = new Label();
            txtDisciplina = new Label();
            txtMateria = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(37, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(40, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo:";
            // 
            // lblDisciplina
            // 
            lblDisciplina.AutoSize = true;
            lblDisciplina.Location = new Point(16, 61);
            lblDisciplina.Name = "lblDisciplina";
            lblDisciplina.Size = new Size(61, 15);
            lblDisciplina.TabIndex = 1;
            lblDisciplina.Text = "Disciplina:";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(27, 98);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(50, 15);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Materia:";
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(367, 476);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(27, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 288);
            panel1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, -1);
            label7.Name = "label7";
            label7.Size = new Size(130, 15);
            label7.TabIndex = 8;
            label7.Text = "Questões Selecionadas:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 17);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(348, 249);
            dataGridView1.TabIndex = 0;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Location = new Point(108, 21);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(60, 15);
            txtTitulo.TabIndex = 11;
            txtTitulo.Text = "TipoTitulo";
            // 
            // txtDisciplina
            // 
            txtDisciplina.AutoSize = true;
            txtDisciplina.Location = new Point(108, 61);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(81, 15);
            txtDisciplina.TabIndex = 12;
            txtDisciplina.Text = "TipoDisciplina";
            // 
            // txtMateria
            // 
            txtMateria.AutoSize = true;
            txtMateria.Location = new Point(108, 98);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(70, 15);
            txtMateria.TabIndex = 13;
            txtMateria.Text = "TipoMateria";
            // 
            // TelaVizualizarDetalhesTesteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 511);
            Controls.Add(txtMateria);
            Controls.Add(txtDisciplina);
            Controls.Add(txtTitulo);
            Controls.Add(panel1);
            Controls.Add(btnFechar);
            Controls.Add(lblMateria);
            Controls.Add(lblDisciplina);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaVizualizarDetalhesTesteForm";
            ShowIcon = false;
            Text = "Vizualização de Testes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDisciplina;
        private Label lblMateria;
        private Button btnFechar;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label txtTitulo;
        private Label txtDisciplina;
        private Label txtMateria;
    }
}