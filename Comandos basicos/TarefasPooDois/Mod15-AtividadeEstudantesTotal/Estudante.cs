using System;

namespace Mod15_AtividadeEstudantesTotal
{
     class Estudante
    {
        public int Id { get; set; }
        public Estudante(int id)
        {
            Id = id;
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is Estudante))
            {
                throw new Exception("Erro");
            }
            Estudante estudante = (Estudante)obj;
            return Id.Equals(estudante.Id);
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();    
        }
    }
}
