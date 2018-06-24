using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Servidor.Models
{
    public class Reconstrucao
    {
        public void salvarArquivo(StreamReader arq, String nome)
        {
            StreamWriter novo = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + nome);
            string linha = null;
            while ((linha = arq.ReadLine()) != null)
            {
                novo.WriteLine(linha);
            }
        }
        public void reconstruir (string h, string g)
        {
            reconstruir(new StreamReader(h), new StreamReader(g));
        }
        public void reconstruir(StreamReader arquivoH, StreamReader arquivoG)
        {

        }
    }
}