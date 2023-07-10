using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;

namespace GeradorDeTestes.Dominio.ModuloTestes
{
    public class Teste : EntidadeBase<Teste>
    {
        public string Titulo { get; set; }
        public Materia Mateira { get; set; }
        public Disciplina Disciplina { get; set; }
        public List<Questao> Questoes { get; set; }
        public bool Recuperacao { get; set; }
        public int QntdQuestoes { get; set; }
        public DateTime DataTeste { get; set; }

        public Teste(
            string titulo,
            Materia mateira,
            Disciplina disciplina,
            bool recuperacao,
            int qntdQuestoes,
            DateTime dataTeste)
        {
            Titulo = titulo;
            Mateira = mateira;
            Disciplina = disciplina;
            Recuperacao = recuperacao;
            QntdQuestoes = qntdQuestoes;
            DataTeste = dataTeste;
        }
        public Teste(
            int id,
            string titulo,
            Materia mateira,
            Disciplina disciplina,
            bool recuperacao,
            int qntdQuestoes,
            DateTime dataTeste)
        {
            Id = id;
            Titulo = titulo;
            Mateira = mateira;
            Disciplina = disciplina;
            Recuperacao = recuperacao;
            QntdQuestoes = qntdQuestoes;
            DataTeste = dataTeste;
        }


        public override void AtualizarInformacoes(Teste registroAtualizado)
        {
            this.Titulo = registroAtualizado.Titulo;
            this.Mateira = registroAtualizado.Mateira;
            this.Disciplina = registroAtualizado.Disciplina;
            this.Recuperacao = registroAtualizado.Recuperacao;
            this.QntdQuestoes = registroAtualizado.QntdQuestoes;
            this.DataTeste = registroAtualizado.DataTeste;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(Titulo))
                erros.Add("O campo 'Titulo' é obrigatório");

            if (this.Disciplina == null)
                erros.Add("O campo 'Disciplina' é obrigatório");

            return erros.ToArray();
        }
    }
}
