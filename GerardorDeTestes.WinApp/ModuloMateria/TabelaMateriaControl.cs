using GeradorDeTestes.Dominio.ModuloMateria;
using GerardorDeTestes.WinApp.Compartilhado;
namespace GerardorDeTestes.WinApp.ModuloMateria
{
    public partial class TabelaMateriaControl : UserControl
    {
        public TabelaMateriaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            tabelaMateria.ConfigurarGridZebrado();
            tabelaMateria.ConfigurarGridSomenteLeitura();
        }

        internal void AtualizarRegistros(List<Materia> materias)
        {
            tabelaMateria.Rows.Clear();

            foreach (Materia materia in materias)
            {
                tabelaMateria.Rows.Add(materia.Id, materia.Nome, materia.Disciplina.Nome, materia.Serie);
            }
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
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Disciplina",
                    HeaderText = "Disciplina"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Serie",
                    HeaderText = "Serie"
                }
            };

            tabelaMateria.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            if (tabelaMateria.SelectedRows.Count == 0)
                return -1;

            int id = Convert.ToInt32(tabelaMateria.SelectedRows[0].Cells["Id"].Value);

            return id;
        }
    }
}
