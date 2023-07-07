using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GerardorDeTestes.WinApp.Compartilhado;

namespace GerardorDeTestes.WinApp.ModuloQuestoes
{
    internal class ControladorQuestoes : ControladorBase
    {
        private IRepositorioQuestoes repositorioQuestoes;
        private IRepesitorioMateria repositorioMaterias;
        private IRepositorioDisciplina repositorioDisciplina;
        private TabelaQuestoesControl tabelaQuestoes;
        public ControladorQuestoes(
            IRepesitorioMateria repositorioMaterias,
            IRepositorioQuestoes repositorioQuestoes,
            IRepositorioDisciplina repositorioDisciplina
            )
        {
            this.repositorioQuestoes = repositorioQuestoes;
            this.repositorioMaterias = repositorioMaterias;
            this.repositorioDisciplina = repositorioDisciplina;
        }
        public override string ToolTipInserir { get { return "Inserir nova Questão"; } }
        public override string ToolTipEditar { get { return "Editar Questão existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Questão existente"; } }

        public override void Editar()
        {
            List<Materia> materias = repositorioMaterias.SelecionarTodos();
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            TelaQuestoesForm telaQuestoes = new TelaQuestoesForm(materias, disciplinas);

            DialogResult opcaoEscolhida = telaQuestoes.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
            }
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            List<Materia> materias = repositorioMaterias.SelecionarTodos();
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            TelaQuestoesForm telaQuestoes = new TelaQuestoesForm(materias, disciplinas);

            DialogResult opcaoEscolhida = telaQuestoes.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestoes.ObterQuestao();
                List<Resposta> respostas = telaQuestoes.ObterRespostas();
                repositorioQuestoes.Inserir(questao, respostas);
            }
            CarregarQuestoes();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaQuestoes == null)
                tabelaQuestoes = new TabelaQuestoesControl();

            CarregarQuestoes();

            return tabelaQuestoes;
        }
        private void CarregarQuestoes()
        {
            List<Questao> disciplinas = repositorioQuestoes.SelecionarTodos();
            tabelaQuestoes.AtualizarRegistros(disciplinas);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Questões";
        }
    }
}
