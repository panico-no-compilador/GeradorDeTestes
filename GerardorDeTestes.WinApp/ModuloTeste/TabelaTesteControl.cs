using GeradorDeTestes.Dominio.ModuloTestes;
using GerardorDeTestes.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerardorDeTestes.WinApp.ModuloTeste
{
    public partial class TabelaTesteControl : UserControl
    {
        public TabelaTesteControl()
        {
            InitializeComponent();
            tabelaTestes.ConfigurarGridZebrado();
            tabelaTestes.ConfigurarGridSomenteLeitura();
        }

        internal void AtualizarRegistros(List<Teste> testes)
        {
            tabelaTestes.Rows.Clear();
            foreach (Teste teste in testes) 
            {
                tabelaTestes.Rows.Add(teste);
            }
        }
    }
}
