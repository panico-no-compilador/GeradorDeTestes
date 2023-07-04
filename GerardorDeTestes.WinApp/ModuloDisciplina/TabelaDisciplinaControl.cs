using GeradorDeTestes.Dominio.ModuloDisciplina;
using GerardorDeTestes.WinApp.Compartilhado;
namespace GerardorDeTestes.WinApp.ModuloDisciplina
{
    public partial class TabelaDisciplinaControl : UserControl
    {
        public TabelaDisciplinaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            tabelaDisciplina.ConfigurarGridZebrado();
            tabelaDisciplina.ConfigurarGridSomenteLeitura();
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
                    Name = "Nome",
                    HeaderText = "Nome"
                }
            };

            tabelaDisciplina.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Disciplina> disciplinas)
        {
            tabelaDisciplina.Rows.Clear();

            foreach (Disciplina disciplina in disciplinas)
            {
                tabelaDisciplina.Rows.Add(disciplina.Id, disciplina.Nome);
            }
        }

        public int ObterIdSelecionado()
        {
            if (tabelaDisciplina.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(tabelaDisciplina.SelectedRows[0].Cells["Id"].Value);

            return id;
        }
    }
}
