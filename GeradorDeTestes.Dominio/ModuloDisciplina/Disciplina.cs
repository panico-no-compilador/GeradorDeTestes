using GeradorDeTestes.Dominio.Compartilhado;

namespace GeradorDeTestes.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string Nome { get; set; }
        public Disciplina(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override void AtualizarInformacoes(Disciplina registroAtualizado)
        {
            this.Nome = registroAtualizado.Nome;
        }
        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo 'Nome' é obrigatório");
            return erros.ToArray();
        }
        public override bool Equals(object? obj)
        {
            return obj is Disciplina disciplina &&
                   Id == disciplina.Id &&
                   Nome == disciplina.Nome;
        }
        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
