namespace ClienteCarregamento
{
    partial class Entrada
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCarregarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCarregarArquivo
            // 
            this.BtnCarregarArquivo.Location = new System.Drawing.Point(122, 50);
            this.BtnCarregarArquivo.Name = "BtnCarregarArquivo";
            this.BtnCarregarArquivo.Size = new System.Drawing.Size(70, 51);
            this.BtnCarregarArquivo.TabIndex = 0;
            this.BtnCarregarArquivo.Text = "Carregar Arquivo";
            this.BtnCarregarArquivo.UseVisualStyleBackColor = true;
            this.BtnCarregarArquivo.Click += new System.EventHandler(this.BtnCarregarArquivo_ClickAsync);
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 169);
            this.Controls.Add(this.BtnCarregarArquivo);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCarregarArquivo;
    }
}

