﻿namespace GerardorDeTestes.WinApp.ModuloTeste
{
    partial class TabelaTesteControl
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
            tabelaTestes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaTestes).BeginInit();
            SuspendLayout();
            // 
            // tabelaTestes
            // 
            tabelaTestes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaTestes.Dock = DockStyle.Fill;
            tabelaTestes.Location = new Point(0, 0);
            tabelaTestes.Name = "tabelaTestes";
            tabelaTestes.RowTemplate.Height = 25;
            tabelaTestes.Size = new Size(150, 150);
            tabelaTestes.TabIndex = 0;
            // 
            // TabelaTesteControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaTestes);
            Name = "TabelaTesteControl";
            ((System.ComponentModel.ISupportInitialize)tabelaTestes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaTestes;
    }
}
