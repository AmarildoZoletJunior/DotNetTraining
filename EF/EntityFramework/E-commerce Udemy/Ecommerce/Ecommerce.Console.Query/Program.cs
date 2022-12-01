using eCommerce.Models.Modelop;
using ECommerce.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System.Security.Cryptography.X509Certificates;

var db = new EcommerceContext();
//var usuarios = db.Usuarios.ToList();
//var usuarios = db.Usuarios.Where(X => X.Nome == "Amarildo").OrderBy(x => x.Id).LastOrDefault();
//var usuarios = db.Usuarios.SingleOrDefault(x => x.Nome == "Amarildo");
//var usuarios = db.Usuarios.Where(x => x.Nome.Contains("a")).OrderBy(x => x.Id).LastOrDefault();
//var usuarios = db.Usuarios.Where(a => EF.Functions.Like(a.Nome,"%ldo")).FirstOrDefault();
//var USUARIOS = db.Usuarios.OrderBy(x => x.Sexo).ThenBy(x => x.Nome);
//var USUARIOS = db.Usuarios.Where(x => x.Id > 20).Select(x => new Usuario { Nome = x.Nome, NomeMae = x.NomeMae}).FirstOrDefault();
var USUARIOS = db.Usuarios.Include(x => x.ListaEnderecos).FirstOrDefault();
var lista = USUARIOS.ListaEnderecos.Select(x => x.Numero).FirstOrDefault();
Console.WriteLine(lista);
