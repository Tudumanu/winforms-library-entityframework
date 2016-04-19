namespace Biblioteca
{
    partial class Relatorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listAutores = new System.Windows.Forms.ListBox();
            this.listLivros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Livros por ordem Alfabética";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Autores por ordem Alfabética";
            // 
            // listAutores
            // 
            this.listAutores.FormattingEnabled = true;
            this.listAutores.Location = new System.Drawing.Point(311, 30);
            this.listAutores.Name = "listAutores";
            this.listAutores.Size = new System.Drawing.Size(354, 303);
            this.listAutores.TabIndex = 1;
            // 
            // listLivros
            // 
            this.listLivros.FormattingEnabled = true;
            this.listLivros.Location = new System.Drawing.Point(16, 30);
            this.listLivros.Name = "listLivros";
            this.listLivros.Size = new System.Drawing.Size(289, 303);
            this.listLivros.TabIndex = 2;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 349);
            this.Controls.Add(this.listLivros);
            this.Controls.Add(this.listAutores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listAutores;
        private System.Windows.Forms.ListBox listLivros;
    }
}