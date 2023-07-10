using GeradorDeTestes.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloQuestoes
{
    public class Resposta : EntidadeBase<Resposta>
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
        public Resposta(int id, string alternativa, bool correto)
        {
            Id = id;
            Alternativa = alternativa;
            Correto = correto;
        }

        public override void AtualizarInformacoes(Resposta registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}
