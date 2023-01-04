using Microsoft.EntityFrameworkCore;
using Receitas.Models.Models;

namespace ProjetoReceitas.Repositories.UsuarioRepository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public readonly DbArquivo _db;

        public UsuarioRepository(DbArquivo db)
        {
            _db = db;
        }

        public void AtualizarConta(Usuario Usuario)
        {
            _db.Usuario.Update(Usuario);
            _db.SaveChanges();
        }

        public void CriarConta(Usuario Usuario)
        {
            _db.Usuario.Add(Usuario);
            _db.SaveChanges();
        }

        public void DeletarConta(int id)
        {
            Usuario Unico = _db.Usuario.Where(x => x.Id == id).FirstOrDefault();
            _db.Usuario.Remove(Unico);
            _db.SaveChanges();
        }

        public Usuario UnicoUsuario(int id)
        {
            Usuario Unico = _db.Usuario.Where(x => x.Id == id).FirstOrDefault();
            return Unico;
        }
    }
}
