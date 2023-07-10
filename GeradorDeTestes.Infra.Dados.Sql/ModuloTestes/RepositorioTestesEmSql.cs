using GeradorDeTestes.Dominio.ModuloTestes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using System.Data;
using System;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloTestes
{
    public class RepositorioTestesEmSql : RepositorioEmSqlBase<Teste, MapeadorTestes>, IRepositorioTeste
    {
        protected string sqlCriarTabela =>
            @"CREATE TABLE[dbo].[TbTeste]
            (

                [Id] INT IDENTITY(1,1) NOT NULL,
            
                [Titulo] VARCHAR(200) NOT NULL,
            
                [QntdQuestao] INT NOT NULL,
            	[Disciplina_Id] INT NOT NULL,
            	[Materia_Id] INT NOT NULL,
            	[Recuperacao] BIT NOT NULL,
            	[DataTeste] DATETIME NOT NULL
            
                CONSTRAINT[Pk_TbTeste] PRIMARY KEY CLUSTERED([Id] ASC),
                CONSTRAINT[Fk_TbBTeste_TbDisciplina] FOREIGN KEY([Disciplina_Id]) REFERENCES[dbo].[TbDisciplina] ([Id]),
                CONSTRAINT[Fk_TbTeste_TbMateria] FOREIGN KEY([Materia_Id]) REFERENCES[dbo].[TbMateria] ([Id])
            )";
        protected override string sqlInserir =>
            @"INSERT INTO [TBTESTE]
                (
                    [TITULO]
                    ,[RECUPERACAO]
                    ,[QntdQuestao]
                    ,[DataTeste]
                    ,[MATERIA_ID]
                    ,[DISCIPLINA_ID]
                   
                )
                VALUES
                (
                    @TITULO
                    ,@RECUPERACAO
                    ,@QntdQuestao
                    ,@DataTeste
                    ,@MATERIA_ID
                    ,@DISCIPLINA_ID
                )

            SELECT SCOPE_IDENTITY();";

        protected override string sqlEditar => throw new NotImplementedException();

        protected override string sqlExcluir => throw new NotImplementedException();

        protected override string sqlSelecionarTodos =>
          @"SELECT 
                T.[Id]                   Id
                ,T.[Titulo]              Titulo
                ,T.[Recuperacao]         Recuperacao
                ,T.[QntdQuestao]         QntdQuestao
                ,T.[DataTeste]           DataTeste

               ,M.[ID]                   MATERIA_ID
               ,M.[NOME]                 MATERIA_NOME
               ,M.[SERIE]                MATERIA_SERIE

               ,D.[ID]                   DISCIPLINA_ID
               ,D.[NOME]                 DISCIPLINA_NOME
            FROM
                [TBTESTE] AS T INNER JOIN [TBMATERIA] AS M
            ON
              T.[MATERIA_ID] = M.[ID]
              
            INNER JOIN [TBDISCIPLINA] AS D
            ON
              M.[DISCIPLINA_ID] = D.[ID]";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
                T.[ID]                   TESTE_ID
                ,T.[TITULO]              TESTE_TITULO
                ,T.[RECUPERACAO]         TESTE_RECUPERACAO
                ,T.[QntdQuestao]         TESTE_QUANTIDADE_QUESTOES
                ,T.[DataTeste]   
                ,T.[DISCIPLINA_ID]       TESTE_DISCIPLINA_ID

               ,M.[ID]                   MATERIA_ID
               ,M.[NOME]                 MATERIA_NOME
               ,M.[SERIE]                MATERIA_SERIE

               ,D.[ID]                   DISCIPLINA_ID
               ,D.[NOME]                 DISCIPLINA_NOME
            FROM
                [TBTESTE] AS T INNER JOIN [TBMATERIA] AS M
            ON
              T.[MATERIA_ID] = M.[ID]
              
            INNER JOIN [TBDISCIPLINA] AS D
            ON
              M.[DISCIPLINA_ID] = D.[ID]
			
            WHERE 
					T.[ID] = @ID";

        public override Teste SelecionarPorId(int id)
        {
            Teste teste = base.SelecionarPorId(id);

            return teste;
        }

        public override List<Teste> SelecionarTodos()
        {
            List<Teste> testes = base.SelecionarTodos();

            return testes;
        }
    }
}
