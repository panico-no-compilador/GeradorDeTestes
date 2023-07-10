using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina;
using GeradorDeTestes.Infra.Dados.Sql.ModuloMateria;
using GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes;
using GerardorDeTestes.WinApp.Compartilhado;
using GerardorDeTestes.WinApp.ModuloDisciplina;
using GerardorDeTestes.WinApp.ModuloMateria;
using GerardorDeTestes.WinApp.ModuloQuestoes;
using GerardorDeTestes.WinApp.ModuloTeste;

namespace GerardorDeTestes.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private static TelaPrincipalForm telaPrincipal;
        private ControladorBase controlador;
        private ControladorTeste controladorTeste;
        private IRepositorioDisciplina repositorioDisciplina = new RepositorioDisciplinaEmSql();
        private IRepesitorioMateria repositorioMateria = new RepositorioMateriaEmSql();
        private IRepositorioQuestoes repositorioQuestoes = new RepositorioQuestoesEmSql();
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }
        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }
        private void disciplinaMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina(repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }
        private void questoesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestoes(repositorioMateria ,repositorioQuestoes, repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }
        private void materiasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorMateria(repositorioMateria, repositorioDisciplina);
            ConfigurarTelaPrincipal(controlador);
        }
        private void testesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTeste();
            ConfigurarTelaPrincipal(controlador);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador)
        {
            labelTipoCadastro.Text = controlador.ObterTipoCadastro();
            ConfigurarBarraFerramentas(controlador);
            //ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controlador)
        {
            UserControl listagem = controlador.ObterListagem();
            listagem.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            barraFerramentas.Enabled = true;
            ConfigurarToolTips(controlador);
            ConfigurarEstados(controlador);
        }

        private void ConfigurarEstados(ControladorBase controlador)
        {
            btnInserir.Enabled = true;
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnDuplicarTestes_Click(object sender, EventArgs e)
        {
            controlador.DuplicarTestes();
        }
    }
}