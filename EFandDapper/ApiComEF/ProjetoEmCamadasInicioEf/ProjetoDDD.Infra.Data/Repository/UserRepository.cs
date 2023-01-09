using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces;
using ProjetoDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infra.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _data;
        public UserRepository(DataContext data)
        {
            _data = data;
        }

        public  void AdicionarUsuario(User usuario)
        {
            _data.Usuarios.Add(usuario);
            _data.SaveChanges();
        }

        public void EditarUsuario(User usuario)
        {
            _data.Usuarios.Update(usuario);
            _data.SaveChanges();
        }

        public User ListarUsuario(int id)
        {
            return _data.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public ICollection<User> ListarUsuarios()
        {
            return _data.Usuarios.ToList();
        }

        public void RemoverUsuario(int id)
        {
            var usuario = _data.Usuarios.FirstOrDefault(x => x.Id == id);
            if(usuario != null)
            {
                _data.Usuarios.Remove(usuario);
                _data.SaveChanges();
            }
        }
    }
}
