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
    public partial class Entrada : Form
    {
        private String fileName;
        public Entrada()
        {
            InitializeComponent();
        }

        private async void BtnCarregarArquivo_ClickAsync(object sender, EventArgs e)
        {
            BtnCarregarArquivo.Enabled = false;
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Procurar arquivos";
            dialogo.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            dialogo.Filter = "Arquivo de sinal (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            DialogResult resposta = dialogo.ShowDialog();
            if (resposta == DialogResult.OK)
            {
                fileName = dialogo.FileName;
                Show();
                try
                {                    
                    PresenterCore.pastaEnvio = EditNome.Text + '_' + DateTime.Now.ToString().Replace(':', '-').Replace('/', '-').Replace(' ','_');
                    
                    using (HttpClient client = new HttpClient())
                    using (FileStream fileStream = File.OpenRead(fileName))
                    using (MultipartFormDataContent content = new MultipartFormDataContent())
                    using (StreamContent fileContent = new StreamContent(fileStream))
                    {
                        fileName = dialogo.FileName.Split('\\').Last().Replace(' ', '_');
                        fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("text/plain");
                        fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                        {
                            FileName = fileName,
                        };
                        fileContent.Headers.Add("name", fileName);
                        content.Add(fileContent);
                        var result = await client.PostAsync("http://localhost:52370/api/recepcao/arquivo/" + PresenterCore.pastaEnvio, content);
                        if (result.EnsureSuccessStatusCode().IsSuccessStatusCode)
                        {
                            Confirma _f = new Confirma();
                            _f.Show();
                        }
                        else
                        {
                            MessageBox.Show("Erro no envio do arquivo");
                        }
                        fileName = "";
                    }                      
                    
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
                
            }
            else
            {
                MessageBox.Show("Nenhum arquivo carregado");
            }
            BtnCarregarArquivo.Enabled = true;
        }
    }
}
