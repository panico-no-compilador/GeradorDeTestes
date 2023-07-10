using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloTestes;
using GerardorDeTestes.WinApp.Compartilhado;

namespace GerardorDeTestes.WinApp.ModuloTeste
{
    public class ControladorTeste : ControladorBase
    {
        private IRepositorioTeste repositorioTeste;
        private TabelaTesteControl tabelaTeste;
        public override string ToolTipInserir { get { return "Inserir novo Teste"; } }
        public override string ToolTipEditar { get { return "Editar Teste existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Teste existente"; } }

        public ControladorTeste()
        {
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
            throw new NotImplementedException();
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
