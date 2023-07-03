using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina
{
    public class RepositorioDisciplinaEmSql : RepositorioEmSqlBase<Disciplina, MapeadorDisciplina>, IRepositorioDisciplina
    {
        protected string sqlCriarTabela =>
            @"CREATE TABLE [dbo].[TbDisciplina] 
	            (
		            [Id] INT NOT NULL PRIMARY KEY IDENTITY,
                    [Nome] VARCHAR(200) NOT NULL
	            )";
        protected override string sqlInserir =>
            @"
                INSERT INTO [TBDISCIPLINA] 
	                (
		                [NOME]
	                )
	            VALUES 
	                (
		                @NOME
	                );
                SELECT SCOPE_IDENTITY();
            ";

        protected override string sqlEditar =>
            @"UPDATE [TBDISCIPLINA] 
	            SET 
		            [NOME] = @NOME
	            WHERE 
		            [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBDISCIPLINA]
	            WHERE 
		            [ID] = @ID";

        protected override string sqlSelecionarTodos =>
            @"SELECT 

	            [ID]        DISCIPLINA_ID 
	           ,[NOME]      DISCIPLINA_NOME

            FROM 
	            [TBDISCIPLINA]";

        protected override string sqlSelecionarPorId =>
            @"SELECT 

	            [ID]        DISCIPLINA_ID 
	           ,[NOME]      DISCIPLINA_NOME

            FROM 
	            [TBDISCIPLINA]
            WHERE 
                [ID] = @ID";

        public override Disciplina SelecionarPorId(int id)
        {
            Disciplina cliente = base.SelecionarPorId(id);

            return cliente;
        }

        public override List<Disciplina> SelecionarTodos()
        {
            List<Disciplina> clientes = base.SelecionarTodos();

            return clientes;
        }
    }
}
