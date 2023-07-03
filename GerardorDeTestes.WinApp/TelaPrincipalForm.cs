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
            ConfigurarTelaPrincipal(controlador, false);
        }
        private void questoesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorQuestoes();
            ConfigurarTelaPrincipal(controlador, false);
        }
        private void testesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTeste();
            ConfigurarTelaPrincipal(controlador, true);
        }

        private void ConfigurarTelaPrincipal(ControladorBase controlador, bool temTeste)
        {
            labelTipoCadastro.Text = controlador.ObterTipoCadastro();
            ConfigurarBarraFerramentas(controlador, temTeste);
            //ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controlador)
        {
            throw new NotImplementedException();
        }

        private void ConfigurarBarraFerramentas(ControladorBase controlador, bool temTeste)
        {
            barraFerramentas.Enabled = true;
            ConfigurarToolTips(controlador, temTeste);
            ConfigurarEstados(controlador, temTeste);
        }

        private void ConfigurarEstados(ControladorBase controlador, bool temTeste)
        {
            if (temTeste)
            {
                btnDuplicarTestes.Enabled = true;
                btnVisualizarDetalheTeste.Enabled = true;
                btnEditar.Enabled = false;
                btnInserir.Enabled = true;
                btnExcluir.Enabled = true;
            }
            else
            {
                btnDuplicarTestes.Enabled = false;
                btnVisualizarDetalheTeste.Enabled = false;
                btnInserir.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void ConfigurarToolTips(ControladorBase controlador, bool temTeste)
        {
            if (temTeste)
            {
                btnDuplicarTestes.ToolTipText = controlador.ToolTipDuplicarTestes;
                btnVisualizarDetalheTeste.ToolTipText = controlador.ToolTipVisualizarTestes;
            }
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