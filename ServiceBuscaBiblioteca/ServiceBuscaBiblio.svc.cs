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
        public List<Livro> GetLivroCodigo(int id)
        {
            using (var contexto = new ControleBibliotecaContainer())
            {
                var lista = (from l in contexto.LivroSet
                             where l.Id == id
                             orderby l.Titulo
                             select l).ToList();

                return lista;
            }
        }

        public List<Livro> GetLivroTitulo(String titulo)
        {
            using (var contexto = new ControleBibliotecaContainer())
            {
                var lista = contexto.LivroSet.Where(l => l.Titulo.Contains(titulo)).ToList();

                return lista;
            }
        }

    }
}
