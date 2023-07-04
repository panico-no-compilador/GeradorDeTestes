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
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            cbDisciplina = new ComboBox();
            label4 = new Label();
            rBtnSerie1 = new RadioButton();
            rBtnSerie2 = new RadioButton();
            btnCancelar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(58, 23);
            txtId.TabIndex = 0;
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
            // txtNome
            // 
            txtNome.Location = new Point(88, 71);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(202, 23);
            txtNome.TabIndex = 2;
            // 
            // cbDisciplina
            // 
            cbDisciplina.FormattingEnabled = true;
            cbDisciplina.Location = new Point(88, 107);
            cbDisciplina.Name = "cbDisciplina";
            cbDisciplina.Size = new Size(121, 23);
            cbDisciplina.TabIndex = 5;
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
            // rBtnSerie1
            // 
            rBtnSerie1.AutoSize = true;
            rBtnSerie1.Location = new Point(88, 139);
            rBtnSerie1.Name = "rBtnSerie1";
            rBtnSerie1.Size = new Size(36, 19);
            rBtnSerie1.TabIndex = 7;
            rBtnSerie1.TabStop = true;
            rBtnSerie1.Text = "1°";
            rBtnSerie1.UseVisualStyleBackColor = true;
            
            // 
            // rBtnSerie2
            // 
            rBtnSerie2.AutoSize = true;
            rBtnSerie2.Location = new Point(143, 139);
            rBtnSerie2.Name = "rBtnSerie2";
            rBtnSerie2.Size = new Size(36, 19);
            rBtnSerie2.TabIndex = 8;
            rBtnSerie2.TabStop = true;
            rBtnSerie2.Text = "2º";
            rBtnSerie2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(388, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(290, 176);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Gravar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaMateriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 211);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(rBtnSerie2);
            Controls.Add(rBtnSerie1);
            Controls.Add(label4);
            Controls.Add(cbDisciplina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(txtId);
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

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private ComboBox cbDisciplina;
        private Label label4;
        private RadioButton rBtnSerie1;
        private RadioButton rBtnSerie2;
        private Button btnCancelar;
        private Button button1;
    }
}