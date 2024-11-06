using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiNet8.Models
{
    public class AutorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SobreNome { get; set; }
        [JsonIgnore] // ignora a propriedade de abaixo.
        public ICollection<LivroModel> Livros { get; set; }
    }
}