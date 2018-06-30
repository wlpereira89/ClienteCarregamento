using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteCarregamento
{
    public partial class Inicio : Form
    {
        private String arquivo;
        public Inicio()
        {
            InitializeComponent();
        }

        private void CarrgarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Procurar arquivos";
            dialogo.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //dialogo.Filter = "Arquivos texto (*.csv)|*.csv";
            DialogResult resposta = dialogo.ShowDialog();
            if (resposta == DialogResult.OK)
            {
                arquivo = dialogo.FileName;
            }
        }
    }
}
