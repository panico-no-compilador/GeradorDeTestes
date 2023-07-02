using GerardorDeTestes.WinApp.Compartilhado;
using GerardorDeTestes.WinApp.ModuloDisciplina;
using GerardorDeTestes.WinApp.ModuloQuestoes;
using GerardorDeTestes.WinApp.ModuloTestes;

namespace GerardorDeTestes.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase controlador;
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void disciplinaMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDisciplina();
            ConfigurarTelaPrincipal(controlador);
        }
        private void questoesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestoes();
            ConfigurarTelaPrincipal(controlador);
        }
        private void novoTesteMenuItem_Click(object sender, EventArgs e)
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
            throw new NotImplementedException();
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

    }
}