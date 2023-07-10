using GeradorDeTestes.Dominio.ModuloTestes;
using GerardorDeTestes.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerardorDeTestes.WinApp.ModuloTeste
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            tabelaTestes.ConfigurarGridSomenteLeitura();
            tabelaTestes.ConfigurarGridZebrado();
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "Id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Titulo",
                    HeaderText = "Titulo"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "QntdQuestao",
                    HeaderText = "QntdQuestao"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Serie",
                    HeaderText = "Serie"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Recuperacao",
                    HeaderText = "Recuperacao",
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Materia",
                    HeaderText = "Materia"
                }
            };
            tabelaTestes.Columns.AddRange(colunas);
        }
        public int ObterIdSelecionado()
        {
            if (tabelaTestes.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(tabelaTestes.SelectedRows[0].Cells["Id"].Value);

            return id;
        }
        internal void AtualizarRegistros(List<Teste> testes)
        {
            tabelaTestes.Rows.Clear();
            foreach (Teste teste in testes) 
            {
                tabelaTestes.Rows.Add(teste.Id, teste.Titulo, teste.QntdQuestoes, teste.Mateira.Serie, teste.Recuperacao, teste.Mateira.Nome);
            }
        }
    }
}
