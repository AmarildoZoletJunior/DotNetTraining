using eCommerce.Models.Modelop;
using ECommerce.API.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using System.Runtime.CompilerServices;

var db = new EcommerceContext();

//var usuarioNovo = new Usuario() { Nome = "Rodrigo", Email="jao.rodrigue@gmail.com",Sexo = "Masculino", NomeMae = "Joana",RG = "182379817312",CPF = "12389123.123",SituacaoCadastro =  "Ativo",DataCadastro = DateTimeOffset.Now };
//var usuarioFind = db.Usuarios.Find(1);
//usuarioFind.Nome = "FelipeRodrigo";
//db.SaveChanges();

var usuTemp = db.Usuarios.TemporalAll().Where(a => a.Id == 1).ToList();
var usuTempFilter = db.Usuarios.TemporalAll().Where(a => a.Id == 1).OrderBy(a => EF.Property<DateTime>(a, "PeriodoInicial")).ToList();
var hasOf = new DateTime(2022,11,28,23,31,00);
var hasOffTime = db.Usuarios.TemporalAsOf(hasOf).Where(a => a.Id == 1).OrderBy(a => EF.Property<DateTime>(a, "PeriodoInicial")).ToList();
foreach (var usu in usuTempFilter)
{
    Console.WriteLine(usu.Nome);
    Console.WriteLine(usu.NomeMae);
}