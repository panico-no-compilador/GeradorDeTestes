using GerardorDeTestes.WinApp.Compartilhado;

namespace GerardorDeTestes.WinApp.ModuloQuestoes
{
    public partial class TelaQuestoesForm : Form
    {
        string[] alternativa;
        List<string[]> respostas;

        public TelaQuestoesForm()
        {
            InitializeComponent();
            ConfigurarColunas();
            tabelaRespostasAlternativas.ConfigurarGridSomenteLeitura();
            tabelaRespostasAlternativas.ConfigurarGridZebrado();
            this.respostas = new List<string[]>();
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "Letra",
                    HeaderText = "Letra"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Alternativa",
                    HeaderText = "Alternativa"
                }
            };
            tabelaRespostasAlternativas.Columns.AddRange(colunas);
        }
        private void btnAdicionarRespostas_Click(object sender, EventArgs e)
        {
            this.alternativa = ObterItem();
            respostas.Add(this.alternativa);
            AtualizarRegistros(respostas);
        }
        public string[] ObterItem()
        {
            this.alternativa = new string[2];
            char proximaLetra = (char)('a' + respostas.Count);
            alternativa[0] = proximaLetra.ToString();
            string respostaTexto = tbRespostaAlternativa.Text;
            alternativa[1] = respostaTexto;
            return alternativa;
        }
        public void AtualizarRegistros(List<string[]> itens)
        {
            tabelaRespostasAlternativas.Rows.Clear();

            foreach (string[] item in itens)
            {
                tabelaRespostasAlternativas.Rows.Add(
                    item[0],
                    item[1]
                    );
            }
        }
        public string ObterAlternativaSelecionado()
        {
            string alternativa;
            try
            {
                alternativa = tabelaRespostasAlternativas.SelectedRows[0].Cells["Alternativa"].Value.ToString();
            }
            catch
            {
                alternativa = "";
            }
            return alternativa;
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            string alternativaSelecionado = ObterAlternativaSelecionado();
            if (!string.IsNullOrEmpty(alternativaSelecionado))
            {
                string[] itemSelecionado = respostas.FirstOrDefault(i => i[0] == alternativaSelecionado);
                if (itemSelecionado != null)
                {
                    respostas.Remove(itemSelecionado);
                    AtualizarRegistros(respostas);
                }
            }
        }
    }
}
