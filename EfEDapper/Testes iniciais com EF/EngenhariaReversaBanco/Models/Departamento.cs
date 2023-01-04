using System;
using System.Collections.Generic;

namespace EngenhariaReversaBanco.Models;

public partial class Departamento
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Usuario> ListaUsuarios { get; } = new List<Usuario>();
}
