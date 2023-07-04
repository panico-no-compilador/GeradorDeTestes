namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public interface IRepesitorioMateria
    {
        void Inserir(Materia novoMateria);
        void Editar(int id, Materia materia);
        void Excluir(Materia MateriaSelecionada);
        List<Materia> SelecionarTodos();
        Materia SelecionarPorId(int id);
    }
}
