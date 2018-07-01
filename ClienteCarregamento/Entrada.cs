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
            OpenFileDialog dialogo = new OpenFileDialog();
            dialogo.Title = "Procurar arquivos";
            dialogo.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            dialogo.Filter = "Arquivos rar particionados 4 mega (*.part001.rar)|*.part001.rar|Todos os arquivos (*.*)|*.*";
            DialogResult resposta = dialogo.ShowDialog();
            if (resposta == DialogResult.OK)
            {
                fileName = dialogo.FileName;
                Show();
                try
                {
                    string[] partes = fileName.Split('1');
                    PresenterCore.pastaEnvio = fileName.Split('\\').Last().Split('0')[0].Split('.')[0] + '_' + DateTime.Now.ToShortDateString().Replace('/', '-');
                    FileStream fileStream = System.IO.File.OpenRead(fileName);
                    for (int i = 2; i > 0; i++)
                    {
                        using (HttpClient client = new HttpClient())
                        using (MultipartFormDataContent content = new MultipartFormDataContent())
                        using (StreamContent fileContent = new StreamContent(fileStream))
                        {
                        
                            fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("text/plain");
                            fileContent.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
                            {
                                FileName = fileName.Split('\\').Last().Replace(' ', '_'),
                            };
                            fileContent.Headers.Add("name", fileName.Split('\\').Last().Replace(' ', '_'));
                            content.Add(fileContent);
                            var result = await client.PostAsync("http://localhost:52370/api/recepcao/arquivo/" + PresenterCore.pastaEnvio, content);
                            if (result.EnsureSuccessStatusCode().IsSuccessStatusCode)
                            {
                                // MessageBox.Show("Arquivo Enviado com sucesso");
                            }
                            else
                            {
                                MessageBox.Show("Erro no envio do arquivo");
                            }
                            fileName = "";

                            if ((i == 10) || (i == 100))
                            {
                                partes[0] = partes[0].Replace("00", "0");
                            }
                            fileName = partes[0] + i + partes[1];
                            if (File.Exists(fileName))
                                fileStream = System.IO.File.OpenRead(fileName);
                            else
                                i = -100;
                        }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Confirma _f = new Confirma();
                _f.Show();
            }
            else
            {
                MessageBox.Show("Nenhum arquivo carregado");
            }
            
            
        }
    }
}
