using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Gamification.Rest;
using Gamification.Rest.Usuarios;
using Gamification.Servicos;
using MeuAplicativoComMongoDB;
using Nancy;
using Nancy.ModelBinding;

namespace Gamification.Rest
{
	public class UsuarioModulo : NancyModule
	{


		private ServicoDeCadastroDeUsuario _servico = new ServicoDeCadastroDeUsuario();

		public UsuarioModulo()
		{

			Post["Usuario/add"] = parameters =>
			{
				var usuarioSolicitadoParaCriar = this.Bind<UsuarioRequest>();
				try
				{
					_servico.AddUsuario(new Usuario(usuarioSolicitadoParaCriar.nome, usuarioSolicitadoParaCriar.idade,
						new ObjetoDeValor.Credencial(usuarioSolicitadoParaCriar.login, usuarioSolicitadoParaCriar.senha)));
				}
				catch (ArgumentException)
				{
					return Response.AsJson("Login do usuario ja cadastrado", HttpStatusCode.Forbidden);
				}
				return HttpStatusCode.Created;
			};

			Get["Usuario/{nome}"] = parameters =>
			{
				List<Usuario> todosUsuarios = _servico.GetPorNome(parameters.nome);
				return Response.AsJson(todosUsuarios.Select(usuario => new UsuarioDTO(usuario)).ToList());
			};

		}
	}
}