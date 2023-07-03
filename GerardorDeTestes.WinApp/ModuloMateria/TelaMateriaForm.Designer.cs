namespace GerardorDeTestes.WinApp.ModuloMateria
{
    partial class TelaMateriaForm
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
            TxtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtNome = new TextBox();
            CbDisciplina = new ComboBox();
            label4 = new Label();
            RBtnSerie1 = new RadioButton();
            RBtnSerie2 = new RadioButton();
            btnCancelar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // TxtId
            // 
            TxtId.Location = new Point(88, 30);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(58, 23);
            TxtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 30);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 74);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 110);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Disciplina:";
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(88, 71);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(202, 23);
            TxtNome.TabIndex = 2;
            // 
            // CbDisciplina
            // 
            CbDisciplina.FormattingEnabled = true;
            CbDisciplina.Location = new Point(88, 107);
            CbDisciplina.Name = "CbDisciplina";
            CbDisciplina.Size = new Size(121, 23);
            CbDisciplina.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 141);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 6;
            label4.Text = "Série:";
            // 
            // RBtnSerie1
            // 
            RBtnSerie1.AutoSize = true;
            RBtnSerie1.Location = new Point(88, 139);
            RBtnSerie1.Name = "RBtnSerie1";
            RBtnSerie1.Size = new Size(36, 19);
            RBtnSerie1.TabIndex = 7;
            RBtnSerie1.TabStop = true;
            RBtnSerie1.Text = "1°";
            RBtnSerie1.UseVisualStyleBackColor = true;
            // 
            // RBtnSerie2
            // 
            RBtnSerie2.AutoSize = true;
            RBtnSerie2.Location = new Point(143, 139);
            RBtnSerie2.Name = "RBtnSerie2";
            RBtnSerie2.Size = new Size(36, 19);
            RBtnSerie2.TabIndex = 8;
            RBtnSerie2.TabStop = true;
            RBtnSerie2.Text = "2º";
            RBtnSerie2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(291, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(397, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 211);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(RBtnSerie2);
            Controls.Add(RBtnSerie1);
            Controls.Add(label4);
            Controls.Add(CbDisciplina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtNome);
            Controls.Add(label1);
            Controls.Add(TxtId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaMateriaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Matéria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtId;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtNome;
        private ComboBox CbDisciplina;
        private Label label4;
        private RadioButton RBtnSerie1;
        private RadioButton RBtnSerie2;
        private Button btnCancelar;
        private Button button1;
    }
}