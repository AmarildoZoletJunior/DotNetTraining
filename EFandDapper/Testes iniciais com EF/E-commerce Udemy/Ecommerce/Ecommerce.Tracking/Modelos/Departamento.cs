using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models.Modelop
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public ICollection<Usuario>? ListaUsuarios { get; set; }
    }
}
