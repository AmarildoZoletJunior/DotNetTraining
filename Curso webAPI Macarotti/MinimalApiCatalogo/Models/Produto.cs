﻿using System.Text.Json.Serialization;

namespace MinimalApiCatalogo.Models
{
    public class Produto : BaseEntity
    {
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? ImagemI { get; set; }
        public DateTime DataCompra { get; set; }
        public int Estoque { get; set; }

        [JsonIgnore]
        public Categoria? Categoria { get; set; }
        public int CategoriaId { get; set; }

        public Produto()
        {
            DataCompra = DateTime.Now;
        }

    }
}
