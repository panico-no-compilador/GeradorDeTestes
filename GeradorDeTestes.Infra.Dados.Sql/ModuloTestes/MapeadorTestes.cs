using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Dominio.ModuloTestes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina;
using GeradorDeTestes.Infra.Dados.Sql.ModuloMateria;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloTestes
{
    public class MapeadorTestes : MapeadorBase<Teste>
    {
        public override void ConfigurarParametros(SqlCommand comando, Teste registro)
        {
            comando.Parameters.AddWithValue("Id", registro.Id);
            comando.Parameters.AddWithValue("Titulo", registro.Titulo);
            comando.Parameters.AddWithValue("Recuperacao", registro.Recuperacao);
            comando.Parameters.AddWithValue("QntdQuestao", registro.QntdQuestoes);
            comando.Parameters.AddWithValue("Materia_Id", registro.Mateira.Id);
            comando.Parameters.AddWithValue("Disciplina_Id", registro.Disciplina.Id);
            comando.Parameters.AddWithValue("DataTeste", registro.DataTeste);
        }

        public override Teste ConverterRegistro(SqlDataReader leitorRegistros)
        {
            int id = Convert.ToInt32(leitorRegistros["Id"]);
            string titulo = Convert.ToString(leitorRegistros["Titulo"]);
            bool ehRecuperacao = Convert.ToBoolean(leitorRegistros["Recuperacao"]);
            int quantidadeQuestoes = Convert.ToInt32(leitorRegistros["QntdQuestao"]);
            DateTime dataTeste = Convert.ToDateTime(leitorRegistros["DataTeste"]);
            Disciplina disciplina = new MapeadorDisciplina().ConverterRegistro(leitorRegistros);
            Materia materia = new MapeadorMateria().ConverterRegistro(leitorRegistros);
            return new Teste(id, titulo, materia, disciplina, ehRecuperacao, quantidadeQuestoes, dataTeste);
        }
    }
}
