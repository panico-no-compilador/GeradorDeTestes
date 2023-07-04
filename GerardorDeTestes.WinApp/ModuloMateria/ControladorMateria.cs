using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GerardorDeTestes.WinApp.Compartilhado;


namespace GerardorDeTestes.WinApp.ModuloMateria
{
    internal class ControladorMateria : ControladorBase
    {
        private IRepesitorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;

        private TabelaMateriaControl tabelaMateria;
        public override string ToolTipInserir { get { return "Inserir nova Matéria"; } }
        public override string ToolTipEditar { get { return "Editar Matéria existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Matéria existente"; } }

        public ControladorMateria(IRepesitorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }
        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }
        public override void Inserir()
        {
            List<Disciplina> disciplinas = repositorioDisciplina.SelecionarTodos();
            TelaMateriaForm telaMateria = new TelaMateriaForm(disciplinas);

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Materia materia = telaMateria.ObterMateria();
                repositorioMateria.Inserir(materia);
            }
            CarregarMaterias();
        }
        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                 tabelaMateria = new TabelaMateriaControl();

            CarregarMaterias();

            return tabelaMateria;
        }

        private void CarregarMaterias()
        {
            List<Materia> materias = repositorioMateria.SelecionarTodos();

            tabelaMateria.AtualizarRegistros(materias);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Matérias";
        }
    }
}
