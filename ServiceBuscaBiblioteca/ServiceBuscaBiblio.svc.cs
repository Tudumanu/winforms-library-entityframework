using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiceBuscaBiblioteca
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceBuscaBiblio : IServiceBuscaBiblio
    {
        public Livro GetLivroCodigo(int id)
        {
            using (var contexto = new ControleBibliotecaContainer())
            {
                var livro = contexto.LivroSet.Include("Autor")
                    .Where(l => l.Id == id)
                    .FirstOrDefault();

                return livro;
            }
        }

        public List<Livro> GetLivroTitulo(String titulo)
        {
            using (var contexto = new ControleBibliotecaContainer())
            {
                var lista = contexto.LivroSet
                    .Where(l => l.Titulo.Contains(titulo))
                    .OrderBy(l => l.Titulo)
                    .ToList();

                return lista;
            }
        }

    }
}
