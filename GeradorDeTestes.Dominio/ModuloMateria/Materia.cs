using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using System.ComponentModel.Design;

namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string Nome { get; set; }
        public Disciplina Disciplina { get; set; }
        public SerieMateriaEnum Serie { get; set; }
        public Materia(string nome, Disciplina disciplina, SerieMateriaEnum serie)
        {
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;
        }
        public Materia(int id, string nome, Disciplina disciplina, SerieMateriaEnum serie)
        {
            Id = id;
            Nome = nome;
            Disciplina = disciplina;
            Serie = serie;
        }


        public override void AtualizarInformacoes(Materia registroAtualizado)
        {
            this.Nome = registroAtualizado.Nome;
            this.Disciplina = registroAtualizado.Disciplina;
            this.Serie = registroAtualizado.Serie;
        }
        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(Nome))
                erros.Add("O campo 'Nome' é obrigatório");

            if (this.Disciplina == null)
                erros.Add("O campo 'Disciplina' é obrigatório");
            if (this.Serie == null)
                erros.Add("O campo 'Serie' é obrigatório");
            
            return erros.ToArray();       
        }
        public override bool Equals(object? obj)
        {
            return obj is Materia materia &&
                   Id == materia.Id &&
                   Nome == materia.Nome &&
                   Disciplina == materia.Disciplina &&
                   Serie == materia.Serie;
        }
        public override string ToString()
        {
            return $"{Nome} , {Disciplina} , {Serie}";  
        }
    }
}
