using GeradorDeTestes.Dominio.ModuloQuestoes;
using GeradorDeTestes.Infra.Dados.Sql.Compartilhado;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestoes
{
    public class RepositorioQuestoesEmSql : RepositorioEmSqlBase<Questao, MapeadorQuestoes>, IRepositorioQuestoes
    {
        protected override string sqlEditar => throw new NotImplementedException();

        protected override string sqlExcluir => throw new NotImplementedException();

        private const string sqlCriarTabela =
            @"CREATE TABLE [TbQuestao] (
                [Id] INT IDENTITY(1,1),
                [Enunciado] VARCHAR(255) NOT NULL,

                [Materia_Id] INT NOT NULL,
                [Disciplina_Id] INT NOT NULL,

                CONSTRAINT[PK_TbQuestao]                PRIMARY KEY CLUSTERED([Id] ASC),
                CONSTRAINT[FK_TbQuestao_TbMateria]      FOREIGN KEY(Materia_Id)      REFERENCES[dbo].[TbMateria] ([Id]),
                CONSTRAINT[FK_TbQuestao_TbDisciplina]   FOREIGN KEY(Disciplina_Id)   REFERENCES[dbo].[TbDisciplina] ([Id])
            )";
        private const string sqlCriarTbAlternativa =
            @"CREATE TABLE [TbAlternativa] (
                [Id] INT IDENTITY(1,1),
                [Alternativa] VARCHAR(250) NOT NULL,
                [Correto] BIT NOT NULL,
                
                [Questao_Id] INT NOT NULL,

	            CONSTRAINT [FK_TbAlternativa_TbQuestao] FOREIGN KEY (Questao_Id) REFERENCES [dbo].[TbQuestao] ([Id])
            )";
        protected string SelectAllCommand =>
            @"SELECT   
                 Q.[ID]                 Questao_Id
                ,Q.[ENUNCIADO]          Questao_Enunciado
                
                ,M.[Id]                 Materia_Id
                ,M.[Nome]               Materia_Nome
                ,M.[Serie]              Materia_Serie

                ,D.[Id]                 Disciplina_Id
                ,D.[Id]                 Disciplina_Nome
                                                           
                FROM [dbo].[TbQuestao] AS Q
                                                           
                INNER JOIN [dbo].[TbMateria] AS M                                  
                    ON Q.Materia_Id = M.Id
                                                           
                INNER JOIN [dbo].[TbDisciplina] AS D
                    ON M.Disciplina_Id = D.Id";
        protected override string sqlInserir =>
            @"INSERT INTO [TBQuestao] 
	            (
		            [Enunciado],
					[Disciplina_Id],
					[MATERIA_ID]
	            )
	            VALUES 
	            (
		            @Enunciado,
					@Disciplina_Id,
					@Materia_Id
	            );                 

            SELECT SCOPE_IDENTITY();";

        protected override string sqlSelecionarTodos =>
            @"SELECT   
                 Q.[ID]                 Questao_Id
                ,Q.[ENUNCIADO]          Questao_Enunciado
                
                ,M.[Id]                 Materia_Id
                ,M.[Nome]               Materia_Nome
                ,M.[Serie]              Materia_Serie

                ,D.[Id]                 Disciplina_Id
                ,D.[Id]                 Disciplina_Nome
                                                           
                FROM [dbo].[TbQuestao] AS Q
                                                           
                INNER JOIN [dbo].[TbMateria] AS M                                  
                    ON Q.Materia_Id = M.Id
                                                           
                INNER JOIN [dbo].[TbDisciplina] AS D
                    ON M.Disciplina_Id = D.Id";

        protected override string sqlSelecionarPorId =>
            @"SELECT 
	            Q.[Id]				Id,
                Q.[Enunciado]		Enunciado,

				D.[Id]		        Disciplina_Id,
				D.[Nome]	        Disciplina_Nome,

				M.[Id] Materia_Id,
				M.[Nome] Materia_Id
	
            FROM 

				[dbo].[TbQuestao] AS Q 
				
				INNER JOIN [dbo].[TbDisciplina]  AS D
					ON Q.Disciplina_Id = D.Id

				INNER JOIN [dbo].[TbMateria]     AS M
					ON Q.Materia_Id = M.Id

			WHERE 
					Q.[ID] = @ID";

        protected const string sqlInserirRespostaQuestao =
            @"INSERT INTO [dbo].[TbAlternativa]
                (
                    [Alternativa],
                    [Correto],
                    [Questao_Id]
                )
                 VALUES
                (
                    @Alternativa,
                    @Correto,
                    @Questao_Id
                ); SELECT SCOPE_IDENTITY();";
        public void Inserir(Questao novoRegistro, List<Resposta> respostas)
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = this.sqlInserir;

            MapeadorQuestoes mapeador = new MapeadorQuestoes();

            //adiciona os parâmetros no comando
            mapeador.ConfigurarParametros(comandoInserir, novoRegistro);

            //executa o comando
            object id = comandoInserir.ExecuteScalar();

            novoRegistro.Id = Convert.ToInt32(id);

            //encerra a conexão
            conexaoComBanco.Close();

            foreach (Resposta item in respostas)
            {
                InserirAlternativas(item, novoRegistro);
            }
        }
        public override Questao SelecionarPorId(int id)
        {
            Questao questao = base.SelecionarPorId(id);

            return questao;
        }
        public override List<Questao> SelecionarTodos()
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoSelecionarTodos = conexaoComBanco.CreateCommand();
            comandoSelecionarTodos.CommandText = sqlSelecionarTodos;

            //executa o comando
            SqlDataReader leitorItens = comandoSelecionarTodos.ExecuteReader();

            List<Questao> registros = new List<Questao>();

            MapeadorQuestoes mapeador = new MapeadorQuestoes();

            while (leitorItens.Read())
            {
                Questao registro = mapeador.ConverterRegistro(leitorItens);

                registros.Add(registro);
            }

            //encerra a conexão
            conexaoComBanco.Close();

            return registros;
        }
        public List<Resposta> SelecionarTodes()
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoSelecionarTodos = conexaoComBanco.CreateCommand();
            comandoSelecionarTodos.CommandText = SelectAllCommand;

            //executa o comando
            SqlDataReader leitorItens = comandoSelecionarTodos.ExecuteReader();

            List<Resposta> registros = new List<Resposta>();

            MapeadorAlternativa mapeadorAlternativas = new MapeadorAlternativa();

            while (leitorItens.Read())
            {
                Resposta registro = mapeadorAlternativas.ConverterRegistro(leitorItens);

                registros.Add(registro);
            }

            //encerra a conexão
            conexaoComBanco.Close();

            return registros;
        }
        private void InserirAlternativas(Resposta resposta, Questao novoRegistro)
        {
            SqlConnection conexaoComBanco = new SqlConnection(enderecoBanco);

            conexaoComBanco.Open();

            SqlCommand comandoInsercao = new SqlCommand(sqlInserirRespostaQuestao, conexaoComBanco);

            MapeadorAlternativa mapeador = new MapeadorAlternativa();

            mapeador.ConfigurarParametros(comandoInsercao, resposta, novoRegistro);

            var id = comandoInsercao.ExecuteScalar();

            resposta.Id = Convert.ToInt32(id);

            conexaoComBanco.Close();
        }

    }
}
