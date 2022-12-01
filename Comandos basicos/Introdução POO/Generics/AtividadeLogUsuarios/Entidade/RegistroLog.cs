using System;
using System.Collections.Generic;


namespace AtividadeLogUsuarios.Entidade
{
    internal class RegistroLog
    {
        public string Nome { get; set; }
        public DateTime dataLog { get; set; }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if(!(obj is RegistroLog))
            {
                return false;
            }
            RegistroLog other = obj as RegistroLog;

            return Nome.Equals(other.Nome);
        }
    }
}
