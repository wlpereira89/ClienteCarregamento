using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteCarregamento
{
    public partial class Form1 : Form
    {
        private String fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCarregarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Procurar arquivos";
            dialogo.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //dialogo.Filter = "Arquivos texto (*.csv)|*.csv";
            DialogResult resposta = dialogo.ShowDialog();
            if (resposta == DialogResult.OK)
            {
                fileName = dialogo.FileName;
                Show();
                try
                {
                    using (HttpClient client = new HttpClient())
                    using (MultipartFormDataContent content = new MultipartFormDataContent())
                    using (FileStream fileStream = System.IO.File.OpenRead(fileName))
                    using (StreamContent fileContent = new StreamContent(fileStream))
                    {

                        fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("text/plain");
                        fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                        {
                            FileName = fileName.Split('\\').Last().Replace(' ', '_'),
                        };
                        fileContent.Headers.Add("name", fileName.Split('\\').Last().Replace(' ', '_'));
                        content.Add(fileContent);
                        var result = client.PostAsync("http://localhost:52370/api/recepcao/arquivo", content).Result;
                        if (result.EnsureSuccessStatusCode().IsSuccessStatusCode)
                        {
                            MessageBox.Show("Arquivo Enviado com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Erro no envio do arquivo");
                        }
                        fileName = "";
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhum arquivo carregado");
            }
            
            
        }
    }
}
