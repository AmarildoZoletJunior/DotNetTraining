﻿using Dapper;
using System.Data.SqlClient;
using TesteComEf.DTO;
using TesteComEf.Entidades.Favoritos;

namespace TesteComEf.Repository.Favoritos
{
    public class Favoritos : IFavoritos
    {
        public IConfiguration config { get; }
        private readonly string connection;
        public Favoritos(IConfiguration configuration)
        {
            config = configuration;
           connection = config.GetConnectionString("ConexaoBancoReceita");
        }
        public async Task<bool> AdicionarFavoritos(FavoritosRequest request, int idUsuario)
        {
            string sql = $@"Insert into Receitas_Favoritos (id_usuario,id_receita) values ({request.Id_Usuario},{request.Id_Receita})";
            using(var con = new SqlConnection(connection))
            {
                var insercao = await con.ExecuteAsync(sql);
                if(insercao > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public async Task<IEnumerable<FavoritosResponse>> FavoritosGeral()
        {
            string sql = $@"select u.nome as NomeUsuario,u.id_usuario as Idusuario,r.titulo_receita as NomeReceita,r.id_receita as IdReceita from Receitas_Favoritos b inner join Receita r on r.id_receita = b.id_receita inner join Usuario u on u.id_usuario = b.id_usuario";
            using (var con = new SqlConnection(connection))
            {
                return await con.QueryAsync<FavoritosResponse>(sql);

            }
        }

        public async Task<IEnumerable<FavoritosResponse>> FavoritosUsuario(int idUsuario)
        {
            string sql = $@"select u.nome as NomeUsuario,u.id_usuario as Idusuario,r.titulo_receita as NomeReceita,r.id_receita as IdReceita from Receitas_Favoritos b inner join Receita r on r.id_receita = b.id_receita inner join Usuario u on u.id_usuario = b.id_usuario where b.id_usuario = {idUsuario}";
            using (var con = new SqlConnection(connection))
            {
                return await con.QueryAsync<FavoritosResponse>(sql);
            }
        }

        public async Task<bool> RemoverFavoritos(int idUsuario, int idReceita)
        {
            string sql = $@"delete from receitas_favoritos where id_usuario = {idUsuario}, id_receita = {idReceita}; ";
            using (var con = new SqlConnection(connection))
            {
                return await con.QueryFirstOrDefaultAsync(sql);
            }
        }
    }
}
