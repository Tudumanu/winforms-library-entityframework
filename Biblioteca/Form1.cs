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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listarLivros();
            habilitarBotoesAcao(true);

            textId.Enabled = false; //nunca edita Id
            buttonRelatorios.Enabled = true; //sempre pode acessar relatórios
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listarLivros()
        {
            using (var contexto = new ControleBibliotecaContainer()) {
                    listLivros.DataSource = contexto.LivroSet.ToList();
                    listLivros.DisplayMember = "Titulo";
                    listLivros.ValueMember = "Id";
            }
        }

        private void habilitarBotoesAcao(bool status)
        {
            //inputs
            textTitulo.Enabled = !status;
            textEditora.Enabled = !status;
            textAno.Enabled = !status;
            textNumeroChamada.Enabled = !status;

            //botoes depois que recebe dados
            buttonGerenciarAutores.Enabled = !status;
            buttonSalvar.Enabled = !status;
            buttonLimpar.Enabled = !status;

            //botoes antes de existir dados
            buttonNovo.Enabled = status;
            buttonEditar.Enabled = status;

        }

        private void limparCampos()
        {
            textId.Clear();
            textTitulo.Clear();
            textEditora.Clear();
            textAno.Clear();
            textNumeroChamada.Clear();
            //TODO: listAutores clear;
        }

        private void exibirSelecionado(int id)
        {
            using (var contexto = new ControleBibliotecaContainer())
            {
                try
                {
                    var livro = (from l in contexto.LivroSet
                                 where l.Id == id
                                 select l).First();

                    textId.Text = livro.Id.ToString();
                    textTitulo.Text = livro.Titulo;
                    textEditora.Text = livro.Editora;
                    textAno.Text = livro.Ano;
                    textNumeroChamada.Text = livro.NumeroChamada;

                    //TODO: list autores, carregar

                } catch (System.Exception)
                {
                    MessageBox.Show("Livro não encontrado!");
                }
            }
        }


        // AÇÕES DOS ELEMENTOS
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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (textTitulo.Text.Equals(String.Empty)) {
                MessageBox.Show("Digite ao menos um título para o livro");
                return;
            }
                

            // Novo Livro
            if (textId.Text.Equals(String.Empty))
            {
                using (var contexto = new ControleBibliotecaContainer()) {
                    var livro = new Livro();
                    livro.Titulo = textTitulo.Text;
                    livro.Editora = textEditora.Text;
                    livro.Ano = textAno.Text;
                    livro.NumeroChamada = textNumeroChamada.Text;

                    contexto.LivroSet.Add(livro);
                    contexto.SaveChanges();

                    textId.Text = livro.Id.ToString();
                }

            } else
            {
                //Editando Livro
                using (var contexto = new ControleBibliotecaContainer()) {
                    int id;
                    String idStr = textId.Text;
                    if (int.TryParse(idStr, out id))
                    {
                        var livro = (from l in contexto.LivroSet
                                     where l.Id == id
                                     select l).First();

                        livro.Titulo = textTitulo.Text;
                        livro.Editora = textEditora.Text;
                        livro.Ano = textAno.Text;
                        livro.NumeroChamada = textNumeroChamada.Text;

                        contexto.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao converter o id "+ idStr + " para inteiro");
                    }
                }
            }

            listarLivros();
            habilitarBotoesAcao(true);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(listLivros.SelectedValue.ToString(), out id))
            {
                exibirSelecionado(id);
                habilitarBotoesAcao(false);
            }
            else
                MessageBox.Show("Selecione um livro da lista");
        }

        private void buttonGerenciarAutores_Click(object sender, EventArgs e)
        {
            FormAutor formAutor = new FormAutor();
            formAutor.ShowDialog();
        }
    }
}
