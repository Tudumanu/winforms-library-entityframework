//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biblioteca.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Livro
    {
        public Livro()
        {
            this.Autor = new HashSet<Autor>();
        }
    
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Ano { get; set; }
        public string NumeroChamada { get; set; }
    
        public virtual ICollection<Autor> Autor { get; set; }
    }
}
