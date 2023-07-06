namespace GerardorDeTestes.WinApp.Compartilhado
{
    public static class GridExtensions
    {
        public static void ConfigurarGridZebrado(this DataGridView tabela)
        {
            Font font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);

            DataGridViewCellStyle linhaEscura = new DataGridViewCellStyle
            {
                BackColor = Color.LightGray,
                Font = font,
                ForeColor = Color.Black,
                SelectionBackColor = Color.LightYellow,
                SelectionForeColor = Color.Black
            };

            tabela.AlternatingRowsDefaultCellStyle = linhaEscura;
            tabela.RowHeadersVisible = false;

            DataGridViewCellStyle linhaClara = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                Font = font,
                SelectionBackColor = Color.LightYellow,
                SelectionForeColor = Color.Black
            };

            tabela.RowsDefaultCellStyle = linhaClara;
        }
        public static void CofigurarGridAlternativasQuestoes(this DataGridView tabela)
        {
            tabela.Columns[0].Width = 50;
            tabela.Columns[2].Width = 60;
        }
        public static void ConfigurarGridSomenteLeitura(this DataGridView tabela)
        {
            tabela.AllowUserToAddRows = false;
            tabela.AllowUserToDeleteRows = false;

            tabela.BorderStyle = BorderStyle.None;
            tabela.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabela.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            tabela.MultiSelect = false;
            tabela.ReadOnly = true;

            tabela.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabela.AutoGenerateColumns = false;

            tabela.AllowUserToResizeRows = false;

            int idCellWidth = 50;
            tabela.Columns[0].Width = idCellWidth;
        }
    }
}
