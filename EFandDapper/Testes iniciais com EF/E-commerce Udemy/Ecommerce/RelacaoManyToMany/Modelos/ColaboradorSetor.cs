using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacaoManyToMany.Modelos
{
    internal class ColaboradorSetor
    {
        public int ColaboradorId { get; set; }
        public int SetorId { get; set; }
        public Colaborador? Colaborador { get; set; }
        public Setor? Setor { get; set; }
    }
}
