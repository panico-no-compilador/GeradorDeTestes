namespace GerardorDeTestes.WinApp.ModuloQuestoes
{
    partial class TabelaQuestoesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaQuestoes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaQuestoes).BeginInit();
            SuspendLayout();
            // 
            // tabelaQuestoes
            // 
            tabelaQuestoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaQuestoes.Dock = DockStyle.Fill;
            tabelaQuestoes.Location = new Point(0, 0);
            tabelaQuestoes.Name = "tabelaQuestoes";
            tabelaQuestoes.Size = new Size(513, 208);
            tabelaQuestoes.TabIndex = 0;
            // 
            // TabelaQuestoesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaQuestoes);
            Name = "TabelaQuestoesControl";
            Size = new Size(513, 208);
            ((System.ComponentModel.ISupportInitialize)tabelaQuestoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView tabelaQuestoes;
    }
}
