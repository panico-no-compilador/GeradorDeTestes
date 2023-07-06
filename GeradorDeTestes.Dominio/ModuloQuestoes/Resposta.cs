using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
