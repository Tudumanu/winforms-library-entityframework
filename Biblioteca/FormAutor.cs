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

                    List<Livro> list = new List<Livro>();
                    list.Add(autor.Livro);

                    comboLivro.DataSource = list;
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
            listarLivros();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitarBotoesAcao(true);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textNome.Text.Equals(String.Empty))
            {
                MessageBox.Show("Digite ao menos um nome para o autor");
                return;
            }

            // Novo Autor
            if (textId.Text.Equals(String.Empty))
            {
                using (var contexto = new ControleBibliotecaContainer())
                {
                    var autor = new Autor();
                    autor.Nome = textNome.Text;

                    Livro livro = (Livro) comboLivro.SelectedValue;
                    autor.LivroId = livro.Id;

                    contexto.AutorSet.Add(autor);
                    contexto.SaveChanges();

                    textId.Text = autor.Id.ToString();
                }
            }
            else
            {
                //Editando Autor
                using (var contexto = new ControleBibliotecaContainer())
                {
                    int id;
                    String idStr = textId.Text;
                    if (int.TryParse(idStr, out id))
                    {
                        var autor = (from a in contexto.AutorSet
                                     where a.Id == id
                                     select a).First();

                        autor.Nome = textNome.Text;

                        Livro livro = (Livro) comboLivro.SelectedValue;
                        autor.LivroId = livro.Id;

                        contexto.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao converter o id " + idStr + " para inteiro");
                    }
                }
            }

            listarAutores();
            habilitarBotoesAcao(true);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(listAutores.SelectedValue.ToString(), out id))
            {
                exibirSelecionado(id);
                habilitarBotoesAcao(false);
            }
            else
                MessageBox.Show("Selecione um autor da lista");
        }
    }
}
