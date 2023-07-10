using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GerardorDeTestes.WinApp.Compartilhado;

namespace GerardorDeTestes.WinApp.ModuloQuestoes
{
    public partial class TabelaQuestoesControl : UserControl
    {
        public TabelaQuestoesControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            tabelaQuestoes.ConfigurarGridSomenteLeitura();
            tabelaQuestoes.ConfigurarGridZebrado();
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
                    Name = "Materia",
                    HeaderText = "Materia"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Enunciado",
                    HeaderText = "Enunciado"
                }
            };
            tabelaQuestoes.Columns.AddRange(colunas);
        }
        public int ObterIdSelecionado()
        {
            if (tabelaQuestoes.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(tabelaQuestoes.SelectedRows[0].Cells["Id"].Value);

            return id;
        }
        internal void AtualizarRegistros(List<Questao> materias)
        {
            tabelaQuestoes.Rows.Clear();

            foreach (Questao materia in materias)
            {
                tabelaQuestoes.Rows.Add(materia.Id, materia.Materia.Nome, materia.Enunciado);
            }
        }
    }
}
