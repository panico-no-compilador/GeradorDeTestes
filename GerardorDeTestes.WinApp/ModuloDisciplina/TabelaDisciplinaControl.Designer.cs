namespace GerardorDeTestes.WinApp.ModuloDisciplina
{
    partial class TabelaDisciplinaControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaDisciplina = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaDisciplina).BeginInit();
            SuspendLayout();
            // 
            // tabelaDisciplina
            // 
            tabelaDisciplina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaDisciplina.Dock = DockStyle.Fill;
            tabelaDisciplina.Location = new Point(0, 0);
            tabelaDisciplina.Name = "tabelaDisciplina";
            tabelaDisciplina.RowTemplate.Height = 25;
            tabelaDisciplina.Size = new Size(450, 200);
            tabelaDisciplina.TabIndex = 0;
            // 
            // TabelaDisciplinaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaDisciplina);
            Name = "TabelaDisciplinaControl";
            Size = new Size(450, 200);
            ((System.ComponentModel.ISupportInitialize)tabelaDisciplina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaDisciplina;
    }
}
