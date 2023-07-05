using GeradorDeTestes.Dominio.ModuloDisciplina;
using GerardorDeTestes.WinApp.Compartilhado;

namespace GerardorDeTestes.WinApp.ModuloDisciplina
{
    internal class ControladorDisciplina : ControladorBase
    {
        private TabelaDisciplinaControl tabelaDisciplina;
        private IRepositorioDisciplina repositorioDisciplina;
        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }
        public override string ToolTipInserir { get { return "Inserir nova Disciplina"; } }
        public override string ToolTipEditar { get { return "Editar Disciplina existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Disciplina existente"; } }

        public override void Editar()
        {
            Disciplina Disciplina = ObterDisciplinaSelecionada();
            if (Disciplina == null)
            {
                MessageBox.Show($"Selecione uma disciplina primeiro!",
                    "Edição de Disciplinas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            TelaDisciplinaForm telaCliente = new TelaDisciplinaForm();
            telaCliente.ConfigurarTela(Disciplina);
            DialogResult opcaoEscolhida = telaCliente.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplinaAtualizada = telaCliente.ObterDisciplina();
                repositorioDisciplina.Editar(disciplinaAtualizada.Id, disciplinaAtualizada);
            }
            CarregarDisciplinas();
        }

        private Disciplina ObterDisciplinaSelecionada()
        {
            int id = tabelaDisciplina.ObterIdSelecionado();
            return repositorioDisciplina.SelecionarPorId(id);
        }
        public override void Excluir()
        {
            Disciplina disciplina = ObterDisciplinaSelecionada();
            if (disciplina == null)
            {
                MessageBox.Show
                    (
                         "Selecione uma Disciplina Primeiro!",
                         "Exclusão de Disciplinas",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation
                    );
                return;
            }
            DialogResult opcaoEscolhida = MessageBox.Show
                (
                    $"Deseja excluir a disciplina {disciplina.Nome}?",
                    "Exclusão de Disciplinas",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );
            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDisciplina.Excluir(disciplina);
                CarregarDisciplinas();
            }
        }

        public override void Inserir()
        {
            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplina = telaDisciplina.ObterDisciplina();
                repositorioDisciplina.Inserir(disciplina);
            }
            CarregarDisciplinas();
        }
        private void CarregarDisciplinas()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();

            tabelaDisciplina.AtualizarRegistros(disciplinas);
        }
        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarDisciplinas();

            return tabelaDisciplina;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Disciplina";
        }
    }
}
