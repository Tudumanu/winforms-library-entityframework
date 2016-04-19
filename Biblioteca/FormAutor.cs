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
    public partial class FormAutor : Form
    {
        public FormAutor()
        {
            InitializeComponent();

            listarAutores();
            listarLivros();
            habilitarBotoesAcao(true);

            textId.Enabled = false; //nunca edita Id
            buttonFechar.Enabled = true; //sempre pode fechar
        }

        private void listarAutores()
        {
            using (var contexto = new ControleBibliotecaContainer())
            {
                listAutores.DataSource = contexto.AutorSet.ToList();
                listAutores.DisplayMember = "Nome";
                listAutores.ValueMember = "Id";
            }
        }

        private void listarLivros()
        {
            using (var contexto = new ControleBibliotecaContainer())
            {
                comboLivro.DataSource = contexto.LivroSet.ToList();
                comboLivro.DisplayMember = "Titulo";
                listAutores.ValueMember = "Id";
            }
        }

        private void habilitarBotoesAcao(bool status)
        {
            //inputs
            textNome.Enabled = !status;
            comboLivro.Enabled = !status;

            //botoes depois que recebe dados
            buttonSalvar.Enabled = !status;
            buttonLimpar.Enabled = !status;

            //botoes antes de existir dados
            buttonNovo.Enabled = status;
            buttonEditar.Enabled = status;
        }

        private void limparCampos()
        {
            textId.Clear();
            textNome.Clear();

            comboLivro.SelectedIndex = 0;
        }

        private void exibirSelecionado(int id)
        {
            using (var contexto = new ControleBibliotecaContainer())
            {
                try
                {
                    var autor = (from a in contexto.AutorSet
                                 where a.Id == id
                                 select a).First();

                    textId.Text = autor.Id.ToString();
                    textNome.Text = autor.Nome;

                }
                catch (System.Exception)
                {
                    MessageBox.Show("Autor não encontrado!");
                }
            }
        }


        // AÇÕES DOS ELEMENTOS
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            habilitarBotoesAcao(false);
            limparCampos();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitarBotoesAcao(true);
        }
    }
}
