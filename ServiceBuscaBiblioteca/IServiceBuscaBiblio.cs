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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceBuscaBiblio
    {

        [OperationContract]
        Livro GetLivroCodigo(int id);

        [OperationContract]
        List<Livro> GetLivroTitulo(String titulo);

    }

}
