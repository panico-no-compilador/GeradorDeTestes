using GerardorDeTestes.WinApp.Compartilhado;

namespace GerardorDeTestes.WinApp.ModuloTestes
{
    internal class ControladorTeste : ControladorBase
    {
        public override string ToolTipInserir { get { return "Inserir novo Teste"; } }
        public override string ToolTipEditar { get { return "Editar Testes existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Testes existente"; } }

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
            TelaCadastroTestesForm telaCadastroNovoTeste = new TelaCadastroTestesForm();

            DialogResult opcaoEscolhida = telaCadastroNovoTeste.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
            }
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Testes";
        }
    }
}
