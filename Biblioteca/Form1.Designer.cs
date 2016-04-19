namespace Biblioteca
{
    partial class Form1
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
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditora = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNumeroChamada = new System.Windows.Forms.TextBox();
            this.buttonGerenciarAutores = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listLivros = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listAutores = new System.Windows.Forms.ListBox();
            this.buttonRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(12, 342);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(84, 31);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(102, 342);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(91, 31);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(199, 342);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(88, 31);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(293, 342);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(88, 30);
            this.buttonLimpar.TabIndex = 3;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(12, 32);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(66, 20);
            this.textId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Título";
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(102, 32);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(279, 20);
            this.textTitulo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Editora";
            // 
            // textEditora
            // 
            this.textEditora.Location = new System.Drawing.Point(12, 75);
            this.textEditora.Name = "textEditora";
            this.textEditora.Size = new System.Drawing.Size(254, 20);
            this.textEditora.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ano";
            // 
            // textAno
            // 
            this.textAno.Location = new System.Drawing.Point(293, 75);
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(88, 20);
            this.textAno.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Número Chamada";
            // 
            // textNumeroChamada
            // 
            this.textNumeroChamada.Location = new System.Drawing.Point(12, 119);
            this.textNumeroChamada.Name = "textNumeroChamada";
            this.textNumeroChamada.Size = new System.Drawing.Size(181, 20);
            this.textNumeroChamada.TabIndex = 13;
            // 
            // buttonGerenciarAutores
            // 
            this.buttonGerenciarAutores.Location = new System.Drawing.Point(199, 288);
            this.buttonGerenciarAutores.Name = "buttonGerenciarAutores";
            this.buttonGerenciarAutores.Size = new System.Drawing.Size(182, 33);
            this.buttonGerenciarAutores.TabIndex = 14;
            this.buttonGerenciarAutores.Text = "Gerenciar Autores";
            this.buttonGerenciarAutores.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Livros";
            // 
            // listLivros
            // 
            this.listLivros.FormattingEnabled = true;
            this.listLivros.Location = new System.Drawing.Point(391, 32);
            this.listLivros.Name = "listLivros";
            this.listLivros.Size = new System.Drawing.Size(317, 290);
            this.listLivros.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Autores";
            // 
            // listAutores
            // 
            this.listAutores.FormattingEnabled = true;
            this.listAutores.Location = new System.Drawing.Point(12, 163);
            this.listAutores.Name = "listAutores";
            this.listAutores.Size = new System.Drawing.Size(369, 121);
            this.listAutores.TabIndex = 18;
            // 
            // buttonRelatorios
            // 
            this.buttonRelatorios.Location = new System.Drawing.Point(587, 342);
            this.buttonRelatorios.Name = "buttonRelatorios";
            this.buttonRelatorios.Size = new System.Drawing.Size(120, 30);
            this.buttonRelatorios.TabIndex = 19;
            this.buttonRelatorios.Text = "Relatórios";
            this.buttonRelatorios.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 385);
            this.Controls.Add(this.buttonRelatorios);
            this.Controls.Add(this.listAutores);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listLivros);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonGerenciarAutores);
            this.Controls.Add(this.textNumeroChamada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textAno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEditora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNovo);
            this.Name = "Form1";
            this.Text = "Controle de Livros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEditora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNumeroChamada;
        private System.Windows.Forms.Button buttonGerenciarAutores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listLivros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listAutores;
        private System.Windows.Forms.Button buttonRelatorios;
    }
}

