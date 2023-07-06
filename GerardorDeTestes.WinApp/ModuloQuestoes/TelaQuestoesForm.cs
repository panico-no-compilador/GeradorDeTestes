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
        List<string[]> listaAlternativasEmString;
        List<Resposta> listaAlternativas;
        public TelaQuestoesForm(List<Materia> materias, List<Disciplina> disciplinas)
        {
            InitializeComponent();
            ConfigurarColunas();
            ConfigurarComboBox(materias, disciplinas);
            tabelaRespostasAlternativas.ConfigurarGridSomenteLeitura();
            tabelaRespostasAlternativas.ConfigurarGridZebrado();
            tabelaRespostasAlternativas.CofigurarGridAlternativasQuestoes();
            this.listaAlternativasEmString = new List<string[]>();
            this.listaAlternativas = new List<Resposta>();
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
        public Questao ObterQuestao()
        {
            Materia materia = (Materia)cboxMaterias.SelectedItem;
            string enunciado = txtEnunciado.Text;
            foreach (string[] alternativaEmString in listaAlternativasEmString)
            {
                string alternativa = alternativaEmString[1];
                bool correto = bool.Parse(alternativaEmString[2]);
                Resposta resposta = new Resposta(alternativa, correto);
                this.listaAlternativas.Add(resposta);
            }
            List<Resposta> alternativas = this.listaAlternativas;
            return new Questao(materia,enunciado, alternativas);
        }
        private void btnAdicionarRespostas_Click(object sender, EventArgs e)
        {
            this.alternativa = ObterAlternativa();
            listaAlternativasEmString.Add(this.alternativa);
            AtualizarRegistros(listaAlternativasEmString);
        }
        public string[] ObterAlternativa()
        {
            this.alternativa = new string[3];

            char proximaLetra = (char)('a' + listaAlternativasEmString.Count);
            alternativa[0] = proximaLetra.ToString();

            string respostaTexto = txtRespostaAlternativa.Text;
            alternativa[1] = respostaTexto;

            bool teste = cboxEstaCorreta.Checked;
            alternativa[2] = teste.ToString();

            return alternativa;
        }
        public void AtualizarRegistros(List<string[]> itens)
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
        private void btnRemover_Click(object sender, EventArgs e)
        {
            string alternativaSelecionado = ObterAlternativaSelecionado();
            if (!string.IsNullOrEmpty(alternativaSelecionado))
            {
                string[] itemSelecionado = listaAlternativasEmString
                    .FirstOrDefault
                    (
                        i => i[0] == alternativaSelecionado
                    );
                if (itemSelecionado != null)
                {
                    listaAlternativasEmString.Remove(itemSelecionado);
                    AtualizarRegistros(listaAlternativasEmString);
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
