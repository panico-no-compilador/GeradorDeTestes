using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes
{
    public class MapeadorAlternativa : MapeadorBase<Resposta>
    {
        public void ConfigurarParametros(SqlCommand comando, Resposta registro, Questao questao)
        {
            comando.Parameters.AddWithValue("ALTERNATIVA", registro.Alternativa);
            comando.Parameters.AddWithValue("CORRETO", registro.Correto);

            comando.Parameters.AddWithValue("QUESTAO_ID", questao.Id);
        }

        public override void ConfigurarParametros(SqlCommand comando, Resposta registro)
        {
            throw new NotImplementedException();
        }

        public override Resposta ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["Id"]);
            string alternativa = Convert.ToString(leitorRegistros["Alternativa"]);
            bool correto = Convert.ToBoolean(leitorRegistros["Correto"]);
            Resposta resposta = new Resposta(id, alternativa, correto);
            return resposta;
        }
    }
}
