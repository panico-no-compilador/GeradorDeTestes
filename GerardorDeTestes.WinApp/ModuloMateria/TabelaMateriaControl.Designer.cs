namespace GerardorDeTestes.WinApp.ModuloMateria
{
    partial class TabelaMateriaControl
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
            tabelaMateria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaMateria).BeginInit();
            SuspendLayout();
            // 
            // tabelaMateria
            // 
            tabelaMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaMateria.Location = new Point(0, 0);
            tabelaMateria.Name = "tabelaMateria";
            tabelaMateria.RowTemplate.Height = 25;
            tabelaMateria.Size = new Size(489, 431);
            tabelaMateria.TabIndex = 0;
            // 
            // TabelaMateriaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaMateria);
            Name = "TabelaMateriaControl";
            Size = new Size(489, 431);
            ((System.ComponentModel.ISupportInitialize)tabelaMateria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaMateria;
    }
}
