﻿using System.Windows.Forms;

namespace GerardorDeTestes.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            disciplinaMenuItem = new ToolStripMenuItem();
            materiasMenuItem = new ToolStripMenuItem();
            questoesToolStripMenuItem = new ToolStripMenuItem();
            testesToolStripMenuItem = new ToolStripMenuItem();
            duplicarOsTestesToolStripMenuItem = new ToolStripMenuItem();
            detalhesDosTestesToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            labelRodape = new ToolStripStatusLabel();
            barraFerramentas = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnDuplicarTestes = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnVisualizarDetalheTeste = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnVisualizarAlugueisCliente = new ToolStripButton();
            btnConcluirAluguel = new ToolStripButton();
            btnConfigurarDescontos = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            labelTipoCadastro = new ToolStripLabel();
            panelRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            barraFerramentas.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disciplinaMenuItem, materiasMenuItem, questoesToolStripMenuItem, testesToolStripMenuItem });
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(71, 20);
            cadastrosMenuItem.Text = "Cadastros";
            // 
            // disciplinaMenuItem
            // 
            disciplinaMenuItem.Name = "disciplinaMenuItem";
            disciplinaMenuItem.Size = new Size(180, 22);
            disciplinaMenuItem.Text = "Disciplina";
            disciplinaMenuItem.Click += disciplinaMenuItem_Click;
            // 
            // materiasMenuItem
            // 
            materiasMenuItem.Name = "materiasMenuItem";
            materiasMenuItem.Size = new Size(180, 22);
            materiasMenuItem.Text = "Materias";
            // 
            // questoesToolStripMenuItem
            // 
            questoesToolStripMenuItem.Name = "questoesToolStripMenuItem";
            questoesToolStripMenuItem.Size = new Size(180, 22);
            questoesToolStripMenuItem.Text = "Questoes";
            // 
            // testesToolStripMenuItem
            // 
            testesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { duplicarOsTestesToolStripMenuItem, detalhesDosTestesToolStripMenuItem });
            testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            testesToolStripMenuItem.Size = new Size(180, 22);
            testesToolStripMenuItem.Text = "Testes";
            // 
            // duplicarOsTestesToolStripMenuItem
            // 
            duplicarOsTestesToolStripMenuItem.Name = "duplicarOsTestesToolStripMenuItem";
            duplicarOsTestesToolStripMenuItem.Size = new Size(175, 22);
            duplicarOsTestesToolStripMenuItem.Text = "Duplicar os Testes";
            // 
            // detalhesDosTestesToolStripMenuItem
            // 
            detalhesDosTestesToolStripMenuItem.Name = "detalhesDosTestesToolStripMenuItem";
            detalhesDosTestesToolStripMenuItem.Size = new Size(175, 22);
            detalhesDosTestesToolStripMenuItem.Text = "Detalhes dos Testes";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { labelRodape });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // labelRodape
            // 
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(52, 17);
            labelRodape.Text = "[rodape]";
            // 
            // barraFerramentas
            // 
            barraFerramentas.Enabled = false;
            barraFerramentas.ImageScalingSize = new Size(20, 20);
            barraFerramentas.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator2, btnDuplicarTestes, toolStripSeparator3, btnVisualizarDetalheTeste, toolStripSeparator1, btnVisualizarAlugueisCliente, btnConcluirAluguel, btnConfigurarDescontos, toolStripSeparator5, labelTipoCadastro });
            barraFerramentas.Location = new Point(0, 24);
            barraFerramentas.Name = "barraFerramentas";
            barraFerramentas.Size = new Size(800, 45);
            barraFerramentas.TabIndex = 2;
            barraFerramentas.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(42, 42);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // btnDuplicarTestes
            // 
            btnDuplicarTestes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDuplicarTestes.Image = Properties.Resources.control_point_duplicate_FILL0_wght400_GRAD0_opsz24;
            btnDuplicarTestes.ImageScaling = ToolStripItemImageScaling.None;
            btnDuplicarTestes.ImageTransparentColor = Color.Magenta;
            btnDuplicarTestes.Name = "btnDuplicarTestes";
            btnDuplicarTestes.Padding = new Padding(7);
            btnDuplicarTestes.Size = new Size(42, 42);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 45);
            // 
            // btnVisualizarDetalheTeste
            // 
            btnVisualizarDetalheTeste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizarDetalheTeste.Image = Properties.Resources.details_FILL0_wght400_GRAD0_opsz24;
            btnVisualizarDetalheTeste.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizarDetalheTeste.ImageTransparentColor = Color.Magenta;
            btnVisualizarDetalheTeste.Name = "btnVisualizarDetalheTeste";
            btnVisualizarDetalheTeste.Padding = new Padding(7);
            btnVisualizarDetalheTeste.Size = new Size(42, 42);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // btnVisualizarAlugueisCliente
            // 
            btnVisualizarAlugueisCliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizarAlugueisCliente.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizarAlugueisCliente.ImageTransparentColor = Color.Magenta;
            btnVisualizarAlugueisCliente.Name = "btnVisualizarAlugueisCliente";
            btnVisualizarAlugueisCliente.Padding = new Padding(7);
            btnVisualizarAlugueisCliente.Size = new Size(23, 42);
            // 
            // btnConcluirAluguel
            // 
            btnConcluirAluguel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConcluirAluguel.ImageScaling = ToolStripItemImageScaling.None;
            btnConcluirAluguel.ImageTransparentColor = Color.Magenta;
            btnConcluirAluguel.Name = "btnConcluirAluguel";
            btnConcluirAluguel.Padding = new Padding(7);
            btnConcluirAluguel.Size = new Size(23, 42);
            // 
            // btnConfigurarDescontos
            // 
            btnConfigurarDescontos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnConfigurarDescontos.ImageScaling = ToolStripItemImageScaling.None;
            btnConfigurarDescontos.ImageTransparentColor = Color.Magenta;
            btnConfigurarDescontos.Name = "btnConfigurarDescontos";
            btnConfigurarDescontos.Padding = new Padding(7);
            btnConfigurarDescontos.Size = new Size(23, 42);
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 45);
            // 
            // labelTipoCadastro
            // 
            labelTipoCadastro.Name = "labelTipoCadastro";
            labelTipoCadastro.Size = new Size(75, 42);
            labelTipoCadastro.Text = "tipoCadastro";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 69);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(800, 359);
            panelRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRegistros);
            Controls.Add(barraFerramentas);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Testes 1.0";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            barraFerramentas.ResumeLayout(false);
            barraFerramentas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem disciplinaMenuItem;
        private ToolStripMenuItem materiasMenuItem;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripMenuItem questoesToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel labelRodape;
        private ToolStrip barraFerramentas;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private Panel panelRegistros;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel labelTipoCadastro;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnDuplicarTestes;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton btnVisualizarDetalheTeste;
        private ToolStripButton btnConfigurarDescontos;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton btnVisualizarAlugueisCliente;
        private ToolStripButton btnConcluirAluguel;
        private ToolStripMenuItem testesToolStripMenuItem;
        private ToolStripMenuItem duplicarOsTestesToolStripMenuItem;
        private ToolStripMenuItem detalhesDosTestesToolStripMenuItem;
    }
}