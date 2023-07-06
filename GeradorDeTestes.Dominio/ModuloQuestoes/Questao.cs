using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using System.Security.Principal;

namespace GeradorDeTestes.Dominio.ModuloQuestoes
{
    namespace GeradorDeTestes.Dominio.ModuloQuestoes
    {
        public class Resposta
        {
            public string Alternativa { get; set; }
            public bool Correto { get; set; }

            public Resposta()
            {

            }
            public Resposta(string alternativa, bool correto)
            {
                Alternativa = alternativa;
                Correto = correto;
            }
        }
    }
    public class Questao : EntidadeBase<Questao>
    {
        public Materia Materia { get; set; }
        public string Enunciado { get; set; }
        public Resposta Resposta { get; set; }
        public List<Resposta> Alternativas { get; set; }

        public Questao()
        {
            
        }

        public Questao(int id, Materia materia, string enunciado, List<Resposta> alternativas)
        {
            Id = id;
            Materia = materia;
            Enunciado = enunciado;
            Alternativas = alternativas;
        }
        public Questao(int id ,Materia materia, string enunciado)
        {
            Id = id;
            Materia = materia;
            Enunciado = enunciado;
        }
        public Questao(Materia materia, string enunciado, List<Resposta> alternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            Alternativas = alternativas;
        }

        public Questao(Materia materia, string enunciado, Resposta resposta, List<Resposta> alternativas)
        {
            Materia = materia;
            Enunciado = enunciado;
            Resposta = resposta;
            Alternativas = alternativas;
        }

        public override void AtualizarInformacoes(Questao registroAtualizado)
        {
            this.Materia = registroAtualizado.Materia;
            this.Enunciado = registroAtualizado.Enunciado;
            this.Resposta = registroAtualizado.Resposta;
            this.Alternativas = registroAtualizado.Alternativas;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (Materia == null)
                erros.Add("O campo 'Materia' é obrigatório");
            if (Enunciado == null)
                erros.Add("O campo 'Enunciado' é obrigatório");
            if (Alternativas == null)
                erros.Add("O campo 'Alternativas' é obrigatório");
            return erros.ToArray();
        }
        public override bool Equals(object? obj)
        {
            return obj is Questao questao &&
                   Id == questao.Id &&
                   Materia.Nome == questao.Materia.Nome &&
                   Enunciado == questao.Enunciado &&
                   Resposta.Alternativa == Resposta.Alternativa &&
                   Alternativas == questao.Alternativas;
        }
        public override string ToString()
        {
            return $"{Enunciado}";
        }
    }
}
