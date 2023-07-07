using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
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

            comando.Parameters.AddWithValue("DISCIPLINA_ID", registro.Materia.Disciplina.Id);
            comando.Parameters.AddWithValue("MATERIA_ID", registro.Materia.Id);
        }

        public override Questao ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["Questao_Id"]);

            string enunciado = Convert.ToString(leitorRegistros["Questao_Enunciado"]);

            Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);

            Questao questao = new Questao(id, materia, enunciado);

            return questao;
        }
    }
}
