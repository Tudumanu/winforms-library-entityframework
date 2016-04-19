using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Model;

namespace Biblioteca
{
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();

            listarAutores();
            listarLivros();
            listAutores.Enabled = false; //não há necessidade de selecionar
            listLivros.Enabled = false; 
        }

        private void listarAutores()
        {
            using (var contexto = new ControleBibliotecaContainer())
            {
                listAutores.DataSource = (from a in contexto.AutorSet
                                          orderby a.Nome
                                          select a).ToList();
                listAutores.DisplayMember = "Nome";
                listAutores.ValueMember = "Id";
            }
        }

        private void listarLivros()
        {
            using (var contexto = new ControleBibliotecaContainer())
            {
                listLivros.DataSource = (from l in contexto.LivroSet
                                         orderby l.Titulo
                                         select l).ToList();
                listLivros.DisplayMember = "Titulo";
                listLivros.ValueMember = "Id";
            }
        }
    }
}
