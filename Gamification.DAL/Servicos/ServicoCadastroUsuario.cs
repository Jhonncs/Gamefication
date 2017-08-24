using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamification.DAL;
using Gamification.DAL.Entidades;
using Gamification.DAL.Repositorio;
using Gamification.DAL.ObjetoValor;

namespace Gamification.DAL.Servicos
{
	public class ServicoCadastroUsuario
	{

		private UsuarioRepositorio _usuarioRepositorio;

		public ServicoCadastroUsuario()
		{
			_usuarioRepositorio = new UsuarioRepositorio();
		}

		public List<Usuario> GetPorNome(string nome)
		{
			return _usuarioRepositorio.GetUsuarioPorNome(nome);
		}

		public bool AutenticaUsuario(Credencial credencial)
		{
			var usuario = _usuarioRepositorio.GetUsuarioPorLogin(credencial.Login);
			if (usuario == null)
			{
				throw new ArgumentException("Login nao existe no sistema");
			}
			return usuario.Credencial.Senha == credencial.Senha;
		}

		public void AddUsuario(Usuario usuario)
		{
			if (_usuarioRepositorio.GetUsuarioPorLogin(usuario.Credencial.Login) != null)
			{
				throw new ArgumentException("login ja existe no sistema");
			}
			_usuarioRepositorio.Insert(usuario);
		}

		public void RemoveUsuario(Usuario usuario)
		{
			_usuarioRepositorio.Delete(usuario);
		}

		public List<Usuario> GetUsuarios()
		{
			return _usuarioRepositorio.GetTodos();
		}

		public void RemovePorNome(string nome)
		{
			var usuarios = _usuarioRepositorio.GetTodos();
			foreach (var usuario in usuarios)
			{
				if (usuario.Nome == nome)
				{
					_usuarioRepositorio.Delete(usuario);
				}
			}
		}



	}
}
