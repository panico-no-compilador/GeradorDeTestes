using GerardorDeTestes.WinApp.Compartilhado;
using GerardorDeTestes.WinApp.ModuloDisciplina;


namespace GerardorDeTestes.WinApp.ModuloMateria
{
    internal class ControladorMateria : ControladorBase
    {
        private TabelaDisciplinaControl tabelaDisciplinaControl;
        public override string ToolTipInserir { get { return "Inserir nova Matéria"; } }
        public override string ToolTipEditar { get { return "Editar Matéria existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Matéria existente"; } }

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
            TelaMateriaForm telaMateria = new TelaMateriaForm();

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();

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
            return "Cadastro de Matérias";
        }
    }
}
