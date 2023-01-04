using System;
using System.Collections.Generic;

namespace EngenhariaReversaBanco.Models;

public partial class Endereco
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public string NomeEndereco { get; set; } = null!;

    public string Cep { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Bairro { get; set; } = null!;

    public string Endereco1 { get; set; } = null!;

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
}
