using ProjetoDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Interfaces
{
    public interface IUserRepository
    {
        public ICollection<User> ListarUsuarios();
        public User ListarUsuario(int id);
        public void AdicionarUsuario(User usuario);
        public void RemoverUsuario(int id);
        public void EditarUsuario(User usuario);
    }
}
