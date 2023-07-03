using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.WinApp.Compartilhado;

namespace GerardorDeTestes.WinApp.ModuloDisciplina
{
    public partial class TelaDisciplinaForm : Form
    {
        public TelaDisciplinaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }
        public Disciplina ObterDisciplina()
        {
            int id = Convert.ToInt32(tbId.Text);

            string nome = tbNome.Text;

            Disciplina disciplina = new Disciplina(id, nome);


            return disciplina;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Disciplina Disciplina = ObterDisciplina();
            string[] erros = Disciplina.Validar();
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
