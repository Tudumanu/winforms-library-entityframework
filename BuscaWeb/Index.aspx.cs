using Biblioteca.Model;
using ServiceBuscaBiblioteca;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuscaWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ServiceBuscaBiblio service = new ServiceBuscaBiblio();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCodigo_Click(object sender, EventArgs e)
        {
            try {
                int i = int.Parse(txtCodigo.Text);

                Livro l = service.GetLivroCodigo(i);
                if (l != null) {
                    var autores = "";
                    foreach (Autor autor in l.Autor)
                        autores += autor.Nome + ", ";

                    labelMensagemCodigo.Text = "Foi encontrado o livro com Título: " + l.Titulo + " Ano: " + l.Ano + " Editora: " + l.Editora + " Número de Chamada: " + l.NumeroChamada + " Autores: " + autores;
                }
                else
                    labelMensagemCodigo.Text = "Não foi encontrado o livro!";
            } catch (FormatException ex)
            {
                labelMensagemCodigo.Text = "Para buscar use só números!";
            }            
        }

        protected void btnTitulo_Click(object sender, EventArgs e)
        {
            var lista = service.GetLivroTitulo(txtTitulo.Text);

            var size = lista.Count;

            if (size > 0)
            {
                gridLivros.DataSource = lista;
                gridLivros.DataBind();
                labelMensagemTitulo.Text = "Achou " + size + " Livros!";
            }
            else
            {
                gridLivros.DataSource = null;
                gridLivros.DataBind();
                labelMensagemTitulo.Text = "Não foi encontrado livro com título: " + txtTitulo.Text;
            }
        }
    }
}