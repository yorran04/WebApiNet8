using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNet8.Models
{
    public class LivroModel
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public AutorModel Autor { get; set; }
    }
}