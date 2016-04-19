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
    }
}
