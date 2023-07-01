using GerardorDeTestes.WinApp.Compartilhado;
using GerardorDeTestes.WinApp.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerardorDeTestes.WinApp.ModuloQuestoes
{
    internal class ControladorQuestoes : ControladorBase
    {
        public override string ToolTipInserir { get { return "Inserir nova Questão"; } }
        public override string ToolTipEditar { get { return "Editar Questão existente"; } }
        public override string ToolTipExcluir { get { return "Excluir Questão existente"; } }

        public override void Editar()
        {
            TelaQuestoesForm telaQuestoes = new TelaQuestoesForm();

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
            TelaQuestoesForm telaQuestoes = new TelaQuestoesForm();

            DialogResult opcaoEscolhida = telaQuestoes.ShowDialog();

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
            return "Cadastro de Questões";
        }
    }
}
