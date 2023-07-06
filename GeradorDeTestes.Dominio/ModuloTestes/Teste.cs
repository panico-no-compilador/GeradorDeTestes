using GeradorDeTestes.Dominio.Compartilhado;

namespace GeradorDeTestes.Dominio.ModuloTestes
{
    public class Teste : EntidadeBase<Teste>
    {
        public override void AtualizarInformacoes(Teste registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }


        //public override bool Equals(object? obj)
        //{
        //    return obj is Materia materia &&
        //           Id == materia.Id &&
        //           Nome == materia.Nome &&
        //           Disciplina == materia.Disciplina &&
        //           Serie == materia.Serie;
        //}
        //public override string ToString()
        //{
        //    return $"{Nome} , {Disciplina} , {Serie}";
        //}
    }
}
