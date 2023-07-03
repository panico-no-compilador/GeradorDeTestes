namespace GeradorDeTestes.Dominio.Compartilhado
{
    public abstract class EntidadeBase<TEntidade> 
    {
        public int Id { get; set; }
        public abstract void AtualizarInformacoes(TEntidade registroAtualizado);
        public abstract string[] Validar();
    }
}
