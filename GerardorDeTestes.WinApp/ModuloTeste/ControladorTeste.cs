﻿using GerardorDeTestes.WinApp.Compartilhado;

namespace GerardorDeTestes.WinApp.ModuloTeste
{
    internal class ControladorTeste : ControladorBase
    {
        public override string ToolTipInserir => throw new NotImplementedException();

        public override string ToolTipEditar => throw new NotImplementedException();

        public override string ToolTipExcluir => throw new NotImplementedException();

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
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            throw new NotImplementedException();
        }
    }
}
