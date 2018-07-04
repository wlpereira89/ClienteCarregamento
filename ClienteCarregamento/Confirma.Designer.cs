namespace ClienteCarregamento
{
    partial class Confirma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditFZero = new System.Windows.Forms.NumericUpDown();
            this.EditIteracoes = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.EditFZero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditIteracoes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnOk.Location = new System.Drawing.Point(0, 106);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(484, 23);
            this.BtnOk.TabIndex = 11;
            this.BtnOk.Text = "Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(111, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(373, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Os arquivos foram carregados, agora aguarde \r\nenquanto eles são descompactados no" +
    " servidor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Iterações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ganho";
            // 
            // EditFZero
            // 
            this.EditFZero.DecimalPlaces = 2;
            this.EditFZero.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.EditFZero.Location = new System.Drawing.Point(69, 10);
            this.EditFZero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EditFZero.Name = "EditFZero";
            this.EditFZero.Size = new System.Drawing.Size(51, 20);
            this.EditFZero.TabIndex = 9;
            this.EditFZero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EditIteracoes
            // 
            this.EditIteracoes.Location = new System.Drawing.Point(69, 72);
            this.EditIteracoes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EditIteracoes.Name = "EditIteracoes";
            this.EditIteracoes.Size = new System.Drawing.Size(51, 20);
            this.EditIteracoes.TabIndex = 10;
            this.EditIteracoes.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Confirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 129);
            this.Controls.Add(this.EditIteracoes);
            this.Controls.Add(this.EditFZero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOk);
            this.Name = "Confirma";
            this.Text = "Confirma";
            ((System.ComponentModel.ISupportInitialize)(this.EditFZero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditIteracoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown EditFZero;
        private System.Windows.Forms.NumericUpDown EditIteracoes;
    }
}