using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
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
