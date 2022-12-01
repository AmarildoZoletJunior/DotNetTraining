using Receitas.Models.Models;

namespace ProjetoReceitas.Repositories.UsuarioRepository
{
    public interface IUsuarioRepository
    {
        Usuario UnicoUsuario(int id);
        void CriarConta(Usuario Usuario);
        void AtualizarConta(Usuario Usuario);
        void DeletarConta(int id);
    }
}
