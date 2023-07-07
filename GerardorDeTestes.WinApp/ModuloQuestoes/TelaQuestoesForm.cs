using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestoes;
using GerardorDeTestes.WinApp.Compartilhado;
using System.Collections.Generic;

namespace GerardorDeTestes.WinApp.ModuloQuestoes
{
    public partial class TelaQuestoesForm : Form
    {
        string[] alternativa;
        IRepesitorioMateria repositorioMateria;
        List<string[]> listaAlternativasParaExibicao;
        List<Resposta> listaAlternativas;
        public TelaQuestoesForm(List<Materia> materias, List<Disciplina> disciplinas)
        {
            InitializeComponent();
            ConfigurarColunas();
            ConfigurarComboBox(materias, disciplinas);

            tabelaRespostasAlternativas.ConfigurarGridSomenteLeitura();
            tabelaRespostasAlternativas.ConfigurarGridZebrado();
            tabelaRespostasAlternativas.CofigurarGridAlternativasQuestoes();

            this.listaAlternativasParaExibicao = new List<string[]>();
            this.listaAlternativas = new List<Resposta>();
        }
        public Questao ObterQuestao()
        {
            Materia materia = (Materia)cboxMaterias.SelectedItem;
            string enunciado = txtEnunciado.Text;
            foreach (string[] _alternativa in listaAlternativasParaExibicao)
            {
                string alternativa = _alternativa[1];
                bool correto = bool.Parse(_alternativa[2]);
                Resposta resposta = new Resposta(alternativa, correto);
                this.listaAlternativas.Add(resposta);
            }
            List<Resposta> alternativas = this.listaAlternativas;
            return new Questao(materia, enunciado, alternativas);
        }
        public string[] ObterAlternativa()
        {
            this.alternativa = new string[3];

            char proximaLetra = (char)('a' + listaAlternativasParaExibicao.Count);
            this.alternativa[0] = proximaLetra.ToString();

            string alternativa = txtRespostaAlternativa.Text;
            this.alternativa[1] = alternativa;

            bool estaCorreto = cboxEstaCorreta.Checked;
            this.alternativa[2] = estaCorreto.ToString();

            return this.alternativa;
        }
        public List<Resposta> ObterRespostas()
        {
            List<Resposta> respostas = new List<Resposta>();

            foreach (string[] alternativaEmString in listaAlternativasParaExibicao)
            {
                string alternativa = alternativaEmString[1];
                bool correto = bool.Parse(alternativaEmString[2]);
                Resposta resposta = new Resposta(alternativa, correto);

                respostas.Add(resposta);
            }
            return respostas;
        }
        public string ObterAlternativaSelecionado()
        {
            string alternativa;
            try
            {
                alternativa = tabelaRespostasAlternativas
                    .SelectedRows[0]
                    .Cells["Alternativa"]
                    .Value.ToString();
            }
            catch
            {
                alternativa = "";
            }
            return alternativa;
        }
        private void ConfigurarComboBox(List<Materia> materias, List<Disciplina> disciplinas)
        {
            cboxMaterias.Items.Clear();
            cboxMaterias.Text = "Selecione uma opção";
            foreach (var materia in materias)
            {
                cboxMaterias.Items.Add(materia);
            }
            cboxMaterias.DisplayMember = "Nome";

            cboxDisciplina.Items.Clear();
            cboxDisciplina.Text = "Selecione uma opção";
            foreach (var disciplina in disciplinas)
            {
                cboxDisciplina.Items.Add(disciplina);
            }
            cboxDisciplina.DisplayMember = "Nome";
        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "Letra",
                    HeaderText = "Letra"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Alternativa",
                    HeaderText = "Alternativa"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "Correto",
                    HeaderText = "Correto"
                }
            };
            tabelaRespostasAlternativas.Columns.AddRange(colunas);
        }
        private void btnAdicionarRespostasNoGridView_Click(object sender, EventArgs e)
        {
            this.alternativa = ObterAlternativa();
            listaAlternativasParaExibicao.Add(this.alternativa);
            AtualizarRegistrosNoDataGridView(listaAlternativasParaExibicao);
        }
        private void AtualizarRegistrosNoDataGridView(List<string[]> itens)
        {
            tabelaRespostasAlternativas.Rows.Clear();

            foreach (string[] item in itens)
            {
                tabelaRespostasAlternativas.Rows.Add(
                    item[0],
                    item[1],
                    item[2]
                    );
            }
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            string alternativaSelecionado = ObterAlternativaSelecionado();
            if (!string.IsNullOrEmpty(alternativaSelecionado))
            {
                string[] itemSelecionado = listaAlternativasParaExibicao.FirstOrDefault(i => i[0] == alternativaSelecionado);
                if (itemSelecionado != null)
                {
                    listaAlternativasParaExibicao.Remove(itemSelecionado);
                    AtualizarRegistrosNoDataGridView(listaAlternativasParaExibicao);
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Questao questao = ObterQuestao();
            string[] erros = questao.Validar();
            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
