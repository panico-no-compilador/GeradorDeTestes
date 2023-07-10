using GeradorDeTestes.Dominio.ModuloMateria;

namespace GeradorDeTestes.Dominio.ModuloTestes
{
    public interface IRepositorioTeste
    {
        void Inserir(Teste novoTeste);
        void Editar(int id, Teste teste);
        void Excluir(Teste TesteSelecionado);
        List<Teste> SelecionarTodos();
        Teste SelecionarPorId(int id);
    }
}
