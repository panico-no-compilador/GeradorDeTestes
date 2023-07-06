using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina;
using GeradorDeTestes.Infra.Dados.Sql.ModuloMateria;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes
{
    public class MapeadorQuestoes : MapeadorBase<Questao>
    {
        public override void ConfigurarParametros(SqlCommand comando, Questao registro)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);
            comando.Parameters.AddWithValue("ENUNCIADO", registro.Enunciado);
            comando.Parameters.AddWithValue("ALTERNATIVAS", DBNull.Value);
            comando.Parameters.AddWithValue("DISCIPLINA_ID", registro.Materia.Disciplina.Id);
            comando.Parameters.AddWithValue("MATERIA_ID", registro.Materia.Id);
        }

        public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["ID"]);
            string enunciado = Convert.ToString(leitorRegistros["ENUNCIADO"]);
            Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);
            List<Resposta> alternativas = (List<Resposta>)leitorRegistros["ALTERNATIVAS"];
            Questao questao = new Questao(id, materia, enunciado, alternativas);

            return questao;
        }
    }
}
