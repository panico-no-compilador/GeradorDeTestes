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
                 M.[ID]                MATERIA_ID
                ,M.[NOME]              MATERIA_NOME
                ,M.[DISCIPLINA_ID]     MATERIA_DISCIPLINA_ID
                ,M.[SERIE]             MATERIA_SERIE

	            ,D.[ID]                DISCIPLINA_ID
	            ,D.[NOME]              DISCIPLINA_NOME	  

                    FROM 

                    [TBMATERIA] AS M INNER JOIN [TBDISCIPLINA] AS D
                    ON
                    M.[DISCIPLINA_ID] = D.[ID]";

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
           @"UPDATE [TBMATERIA] 
	            SET 
                      
		           [NOME] = @NOME
                  ,[SERIE] = @SERIE
                  ,[DISCIPLINA_ID] = @DISCIPLINA_ID
                   
                   
	            WHERE 
		            [ID] = @ID";

        protected override string sqlExcluir =>
            @"DELETE FROM [TBMATERIA]
	            WHERE 
		            [ID] = @ID";



        protected override string sqlSelecionarPorId =>
        @"SELECT 
                 M.[ID]                MATERIA_ID
                ,M.[NOME]              MATERIA_NOME
                ,M.[SERIE]             MATERIA_SERIE

	            ,D.[ID]                DISCIPLINA_ID
	            ,D.[NOME]              DISCIPLINA_NOME
			    
                FROM 
                [TBMATERIA] AS M INNER JOIN [TBDISCIPLINA] AS D
                ON
                M.[DISCIPLINA_ID] = D.[ID]
                
                  WHERE
                   M.[ID] = @ID";

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
