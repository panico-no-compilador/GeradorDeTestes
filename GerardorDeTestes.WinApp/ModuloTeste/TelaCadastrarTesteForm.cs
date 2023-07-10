using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Dominio.ModuloTestes;

namespace GerardorDeTestes.WinApp.ModuloTeste
{
    public partial class TelaCadastrarTesteForm : Form
    {
        public TelaCadastrarTesteForm(List<Materia> materias, List<Disciplina> disciplinas)
        {
            InitializeComponent();
            ConfigurarComboBox(materias, disciplinas);
        }
        private void ConfigurarComboBox(List<Materia> materias, List<Disciplina> disciplinas)
        {
            cmbMateria.Items.Clear();
            cmbMateria.Text = "Selecione uma opção";
            foreach (var materia in materias)
            {
                cmbMateria.Items.Add(materia);
            }
            cmbMateria.DisplayMember = "Nome";

            cmbDisciplina.Items.Clear();
            cmbDisciplina.Text = "Selecione uma opção";
            foreach (var disciplina in disciplinas)
            {
                cmbDisciplina.Items.Add(disciplina);
            }
            cmbDisciplina.DisplayMember = "Nome";
        }
        public Teste ObterTeste()
        {
            string titulo = txtTitulo.Text;
            Disciplina disciplina = (Disciplina)cmbDisciplina.SelectedItem;
            Materia materia = (Materia)cmbMateria.SelectedItem;
            bool ehRecuperacao = checkProva.Checked;
            int quantidadeDeQuestoes = (int)numericQtdQuestoes.Value;
            DateTime dateTime = DateTime.Now;

            Teste teste = new Teste(
                titulo,
                materia,
                disciplina,
                ehRecuperacao,
                quantidadeDeQuestoes,
                dateTime
                );
            return teste;
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Teste teste = ObterTeste();
            string[] erros = teste.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
