using System.Collections.Generic;
using MongoDB.Helper.Repositorio;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Helper.Interfaces;
using Gamefication.Entidades;
namespace Gamification.Repositorio
{
	public class UsuarioRepositorio : RepositorioBase<Usuario>
	{
		public List<Usuario> GetUsuarioPorNome(string nome)
		{
			return Collection.Find(usuarioDoBanco => usuarioDoBanco.Nome == nome).ToList();
		}

		public Usuario GetUsuarioPorLogin(string login)
		{
			return Collection.Find(usuarioDoBanco => usuarioDoBanco.Credencial.Login == login).FirstOrDefault();
		}		

	}
}
