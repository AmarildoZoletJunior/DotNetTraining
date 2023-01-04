using eCommerce.Models.Modelop;
using ECommerce.API.Database;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EcommerceContext _db;
        public UsuarioRepository(EcommerceContext db)
        {
            _db = db;
        }
        public List<Usuario> Get()
        {
            return _db.Usuarios.Include(x => x.Contato).ToList();
        }
        public Usuario Get(int id)
        {
            return _db.Usuarios.Include(x => x.Contato).Include(x => x.ListaDepartamentos).Include(x => x.ListaEnderecos).FirstOrDefault(x => x.Id == id);
        }
        public void Add(Usuario usuario)
        {
            VincularUsuarioComDepartamentosNovosOuExistentes(usuario);
            _db.Usuarios.Add(usuario);
            _db.SaveChanges();
        }

  

        public void Update(Usuario usuario)
        {
            ExcluirDepartamentosUsuario(usuario);
            VincularUsuarioComDepartamentosNovosOuExistentes(usuario);
            _db.Usuarios.Update(usuario);
            _db.SaveChanges();
        }

     

        public void Delete(int id)
        {
            //_db.Remove(Get(id));
            _db.Usuarios.Remove(Get(id));
            _db.SaveChanges();
        }
        //Referencia usada para adicionar
        private void VincularUsuarioComDepartamentosNovosOuExistentes(Usuario usuario)
        {
            if (usuario.ListaDepartamentos != null)
            {
                var departamentos = usuario.ListaDepartamentos;
                usuario.ListaDepartamentos = new List<Departamento>();

                foreach (var depart in departamentos)
                {
                    var resultado = _db.Departamentos.Where(x => x.Nome == depart.Nome).FirstOrDefault();
                    if (resultado?.Nome != null)
                    {
                        usuario.ListaDepartamentos.Add(_db.Departamentos.Find(resultado.Id)!);
                    }
                    else
                    {
                        usuario.ListaDepartamentos.Add(depart);
                    }
                }
            }
        }
        //Referencia usada apenas para comparar
        private void ExcluirDepartamentosUsuario(Usuario usuario)
        {
            var UsuarioBanco = _db.Usuarios.Include(a => a.ListaDepartamentos).FirstOrDefault(a => a.Id == usuario.Id);
            foreach (var departamento in UsuarioBanco!.ListaDepartamentos!)
            {
                UsuarioBanco.ListaDepartamentos.Remove(departamento);
            }
            _db.SaveChanges();
            _db.ChangeTracker.Clear();
        }
    }
}
