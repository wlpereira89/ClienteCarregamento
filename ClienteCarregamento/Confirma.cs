using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ClienteCarregamento
{
    public partial class Confirma : Form
    {
        bool feito = false;
        public Confirma()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {            
            if (feito)
            {
                Close();
            }
            else
            {
                using (HttpClient client = new HttpClient())
                {
                    var task = client.GetAsync("http://localhost:52370/api/recepcao/arquivo/" + PresenterCore.pastaEnvio + "/" + EditFZero.Value + "/" + EditIteracoes.Value);
                    BtnOk.Enabled = false;
                    label1.Text = "Aguarde...";
                    task.Wait();
                    label1.Text = task.Result.Content.ReadAsStringAsync().Result;
                    
                    BtnOk.Text = "Fechar";
                    BtnOk.Enabled = true;
                    feito = true;
                }
            }
        }

       
    }
}
