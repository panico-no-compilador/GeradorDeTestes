using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Dominio.ModuloTestes;
using GerardorDeTestes.WinApp.Compartilhado;
using GerardorDeTestes.WinApp.ModuloQuestoes;

namespace GerardorDeTestes.WinApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private IRepositorioTeste repositorioTeste;
        private IRepositorioDisciplina repositorioDisciplina;
        private IRepesitorioMateria repositorioMateria;
        private IRepositorioQuestoes repositorioQuestao;

        private TabelaTesteControl tabelaTeste;
        public override string ToolTipInserir { get { return "Inserir novo Teste"; } }
        public override string ToolTipEditar { get { return "Editar Teste existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Teste existente"; } }

        public ControladorTeste(
            IRepositorioTeste repositorioTeste,
            IRepositorioDisciplina repositorioDisciplina,
            IRepesitorioMateria repositorioMateria,
            IRepositorioQuestoes repositorioQuestao
            )
        {
            this.repositorioTeste = repositorioTeste;
            this.repositorioDisciplina = repositorioDisciplina;
            this.repositorioMateria = repositorioMateria;
            this.repositorioQuestao = repositorioQuestao;
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void DuplicarTestes()
        {
            TelaDuplicarTesteForm telaDuplicarTeste = new TelaDuplicarTesteForm();

            DialogResult opcaoEscolhida = telaDuplicarTeste.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {

            }
        }

        public override void Inserir()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            TelaCadastrarTesteForm telaCadastrarTeste = new TelaCadastrarTesteForm(materias, disciplinas);
            DialogResult opcaoEscolhida = telaCadastrarTeste.ShowDialog();
            if (opcaoEscolhida == DialogResult.OK)
            {
                Teste teste = telaCadastrarTeste.ObterTeste();
                repositorioTeste.Inserir(teste);
            }
            CarregarTestes();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTeste == null)
            {
                tabelaTeste = new TabelaTesteControl();
            }
            CarregarTestes();
            return tabelaTeste;
        }

        private void CarregarTestes()
        {
            List<Teste> testes = repositorioTeste.SelecionarTodos();
            tabelaTeste.AtualizarRegistros(testes);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Teste";
        }
    }
}
