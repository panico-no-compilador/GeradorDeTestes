﻿namespace GeradorDeTestes.Dominio.ModuloQuestoes
{
    public interface IRepositorioQuestoes
    {
        void Inserir(Questao novoQuestoes, List<Resposta> respostas);
        void Editar(int id, Questao questoes);
        void Excluir(Questao questaoSelecionado);
        List<Questao> SelecionarTodos();
        Questao SelecionarPorId(int id);
    }
}
