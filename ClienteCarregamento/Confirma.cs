using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteCarregamento
{
    public partial class Confirma : Form
    {
        public Confirma()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            label1.Text = "Aguarde...";
            using (HttpClient client = new HttpClient())
                MessageBox.Show(client.GetAsync("http://localhost:52370/api/recepcao/arquivo/" + PresenterCore.pastaEnvio).ToString());
            Close();
        }
    }
}
