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
            this.Label1 = new System.Windows.Forms.Label();
            this.EditNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCarregarArquivo
            // 
            this.BtnCarregarArquivo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnCarregarArquivo.Location = new System.Drawing.Point(0, 29);
            this.BtnCarregarArquivo.Name = "BtnCarregarArquivo";
            this.BtnCarregarArquivo.Size = new System.Drawing.Size(176, 69);
            this.BtnCarregarArquivo.TabIndex = 0;
            this.BtnCarregarArquivo.Text = "Fazer Novo\r\nUpload\r\nSinal";
            this.BtnCarregarArquivo.UseVisualStyleBackColor = true;
            this.BtnCarregarArquivo.Click += new System.EventHandler(this.BtnCarregarArquivo_ClickAsync);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Nome";
            // 
            // EditNome
            // 
            this.EditNome.Location = new System.Drawing.Point(53, 6);
            this.EditNome.Name = "EditNome";
            this.EditNome.Size = new System.Drawing.Size(111, 20);
            this.EditNome.TabIndex = 2;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 98);
            this.Controls.Add(this.EditNome);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnCarregarArquivo);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCarregarArquivo;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox EditNome;
    }
}

