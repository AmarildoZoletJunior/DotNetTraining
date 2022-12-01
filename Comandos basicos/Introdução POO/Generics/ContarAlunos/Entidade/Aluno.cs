using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarAlunos.Entidade
{
     class Aluno
    {
        public int Id { get; set; }

        public Aluno(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();    
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is Aluno))
            {
                return false;
            }
            Aluno teste = obj as Aluno;
            return Id.Equals(teste.Id);
        }
    }
}
