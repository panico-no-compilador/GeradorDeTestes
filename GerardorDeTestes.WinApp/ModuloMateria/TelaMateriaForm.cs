using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;

namespace GerardorDeTestes.WinApp.ModuloMateria
{
    public partial class TelaMateriaForm : Form
    {
        List<Disciplina> disciplinas;
        public TelaMateriaForm(List<Disciplina> disciplinas)
        {
            this.disciplinas = disciplinas;
            InitializeComponent();
            PopularComboBox(disciplinas);
        }


        private void PopularComboBox(List<Disciplina> disciplinas)
        {
            cbDisciplina.Items.Clear();
            foreach(Disciplina disciplina in disciplinas)
            {
                cbDisciplina.Items.Add(disciplina);
            }
            cbDisciplina.DisplayMember = "Nome";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Materia Materia = ObterMateria();
            string[] erros = Materia.Validar();
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

        public Materia ObterMateria()
        {
            int id = Convert.ToInt32(txtId.Text);
            SerieMateriaEnum serie = SerieMateriaEnum.serie1;
            string nome = txtNome.Text;

            if(rBtnSerie1.Checked != false)
            {
                serie = SerieMateriaEnum.serie1;
            }
            else if(rBtnSerie2.Checked != false)
            {
                serie = SerieMateriaEnum.serie2;
            }
            Disciplina disciplina = (Disciplina)cbDisciplina.SelectedItem;


            Materia materia = new Materia(id, nome, disciplina, serie);


            return materia;
        }

      
    }
}
