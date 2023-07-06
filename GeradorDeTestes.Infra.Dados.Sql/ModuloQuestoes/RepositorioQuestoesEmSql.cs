using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes
{
    public class RepositorioQuestoesEmSql : RepositorioEmSqlBase<Questao, MapeadorQuestoes>, IRepositorioQuestoes
    {
        private const string sqlCriarTabela =
            @"CREATE TABLE [TbQuestao] (
                [Id] INT IDENTITY(1,1),
                [Enunciado] VARCHAR(255) NOT NULL,
                [Alternativas] VARCHAR(MAX),

                [Materia_Id] INT NOT NULL,
                [Disciplina_Id] INT NOT NULL,

                CONSTRAINT[PK_TbQuestao] PRIMARY KEY CLUSTERED([Id] ASC),
                CONSTRAINT[FK_TbQuestao_TbMateria] FOREIGN KEY(Materia_Id) REFERENCES[dbo].[TbMateria] ([Id]),
                CONSTRAINT[FK_TbQuestao_TbDisciplina] FOREIGN KEY(Disciplina_Id) REFERENCES[dbo].[TbDisciplina] ([Id])
            )";
        protected override string sqlInserir =>
            @"INSERT INTO [TBQUESTAO] 
	            (
		            [ENUNCIADO],
					[ALTERNATIVAS],
					[DISCIPLINA_ID],
					[MATERIA_ID]
	            )
	            VALUES 
	            (
		            @ENUNCIADO,
					@ALTERNATIVAS,
					@DISCIPLINA_ID,
					@MATERIA_ID
	            );                 

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => throw new NotImplementedException();

        protected override string sqlExcluir => throw new NotImplementedException();

        protected override string sqlSelecionarTodos =>
            @"SELECT 

	            Q.[ID]					ID,
                Q.[ENUNCIADO]			ENUNCIADO,
				Q.[ALTERNATIVAS]		ALTERNATIVAS,

				D.[ID]		DISCIPLINA_ID,
				D.[NOME]	DISCIPLINA_NOME,

				M.[ID] MATERIA_ID,
				M.[NOME] MATERIA_NOME

	
            FROM 
				[DBO].[TBQUESTAO] AS Q 
				
				INNER JOIN [DBO].[TBDISCIPLINA] AS D
			
					ON Q.DISCIPLINA_ID = D.ID

				INNER JOIN [DBO].[TBMATERIA] AS M

					ON Q.MATERIA_ID = M.ID";

        protected override string sqlSelecionarPorId =>
            @"SELECT 

	            Q.[ID]					ID,
                Q.[ENUNCIADO]			ENUNCIADO,
				Q.[ALTERNATIVAS]		ALTERNATIVAS

				D.[ID]		DISCIPLINA_ID,
				D.[NOME]	DISCIPLINA_NOME,

				M.[ID]		MATERIA_ID,
				M.[NOME]	MATERIA_NOME,
				M.[SERIE]	MATERIA_SERIE

	
            FROM 
				[DBO].[TBQUESTAO] AS Q 
				
				INNER JOIN [DBO].[TBDISCIPLINA] AS D
			
					ON Q.DISCIPLINA_ID = D.ID

				INNER JOIN [DBO].[TBMATERIA] AS M
					ON Q.MATERIA_ID = M.ID

			WHERE 
					Q.[ID] = @ID";

        public override Questao SelecionarPorId(int id)
        {
            Questao questao = base.SelecionarPorId(id);

            return questao;
        }

        public override List<Questao> SelecionarTodos()
        {
            List<Questao> questao = base.SelecionarTodos();

            return questao;
        }
    }
}
