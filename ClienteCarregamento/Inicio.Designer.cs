namespace ClienteCarregamento
{
    partial class Inicio
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
            this.CarrgarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarrgarArquivo
            // 
            this.CarrgarArquivo.Location = new System.Drawing.Point(81, 63);
            this.CarrgarArquivo.Name = "CarrgarArquivo";
            this.CarrgarArquivo.Size = new System.Drawing.Size(75, 23);
            this.CarrgarArquivo.TabIndex = 0;
            this.CarrgarArquivo.Text = "button1";
            this.CarrgarArquivo.UseVisualStyleBackColor = true;
            this.CarrgarArquivo.Click += new System.EventHandler(this.CarrgarArquivo_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 160);
            this.Controls.Add(this.CarrgarArquivo);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CarrgarArquivo;
    }
}

