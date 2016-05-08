using Biblioteca.Model;
using ServiceBuscaBiblioteca;
using System;
using System.Collections.Generic;
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
                if (l != null)
                    labelMensagemCodigo.Text = "Foi encontrado o livro com título: "+ l.Titulo;
                else
                    labelMensagemCodigo.Text = "Não foi encontrado o livro!";
            } catch (FormatException ex)
            {
                labelMensagemCodigo.Text = "Para buscar use só números!";
            }            
        }

        protected void btnTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}