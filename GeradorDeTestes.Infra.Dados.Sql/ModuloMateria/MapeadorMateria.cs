using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using Microsoft.Data.SqlClient;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.Compartilhado;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloMateria
{
    public class MapeadorMateria : MapeadorBase<Materia>
    {      
        public override void ConfigurarParametros(SqlCommand comando, Materia registro)
        {
            comando.Parameters.AddWithValue("ID", registro.Id);
            comando.Parameters.AddWithValue("NOME", registro.Nome);
            comando.Parameters.AddWithValue("Disciplina", registro.Disciplina);
            comando.Parameters.AddWithValue("Serie", registro.Serie);
        }

        public override Materia ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["MATERIA_ID"]);
            string nome = Convert.ToString(leitorRegistros["MATERIA_NOME"]);
            SerieMateriaEnum serie = (SerieMateriaEnum)leitorRegistros["MATERIA_SERIE"];

            int numeroDisciplina = Convert.ToInt32(leitorRegistros["DISCIPLINA_ID"]);
            string nomeDisciplina = Convert.ToString(leitorRegistros["DISCIPLINA_NOME"]);

            Disciplina disciplina = new Disciplina(numeroDisciplina, nomeDisciplina);
            Materia materia = new Materia(id, nome, disciplina, serie);
            return materia;
        }
    }
}
