using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloMateria
{
    public class RepositorioMateriaEmSql : RepositorioEmSqlBase<Materia, MapeadorMateria>,IRepesitorioMateria
    {
        private const string sqlCriarTabela =
        @" CREATE TABLE[dbo].[TbMateria]
        (
           [Id] INT NOT NULL IDENTITY(1,1),
           [Nome] VARCHAR(200) NOT NULL,
           [Serie] INT NOT NULL,
           [Disciplina_Id] INT NOT NULL,

           CONSTRAINT[PK_TbMateria] PRIMARY KEY CLUSTERED([Id] ASC),
           CONSTRAINT[FK_TbMateria_TbDisciplina] FOREIGN KEY([Disciplina_Id]) REFERENCES[dbo].[TbDisciplina] ([Id]),
        )";
        protected override string sqlSelecionarTodos =>      
            @"Select
                MT.ID AS MATERIA_ID,
                MT.NOME AS MATERIA_NOME,
                MT.SERIE AS MATERIA_SERIE,

                D.ID AS DISCIPLINA_ID,
                D.NOME AS DISCIPLINA_NOME
            
             From
                 TBMATERIA AS MT INNER JOIN TBDISCIPLINA AS D ON
                 MT.DISCIPLINA_ID = D.ID";

        protected override string sqlInserir =>
           @"
                INSERT INTO [TBMATERIA] 
	                (
		                [NOME]
                        ,[SERIE]
                        ,[DISCIPLINA_ID]
	                )
	            VALUES 
	                (
		                @NOME
                        ,@SERIE
                        ,@DISCIPLINA_ID
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

        

        protected override string sqlSelecionarPorId =>
            @"SELECT 

	            [ID]        DISCIPLINA_ID 
	           ,[NOME]      DISCIPLINA_NOME

            FROM 
	            [TBDISCIPLINA]
            WHERE 
                [ID] = @ID";

        public override Materia SelecionarPorId(int id)
        {
            Materia materia = base.SelecionarPorId(id);

            return materia;
        }

        public override List<Materia> SelecionarTodos()
        {
            List<Materia> materias = base.SelecionarTodos();

            return materias;
        }

    }


}
