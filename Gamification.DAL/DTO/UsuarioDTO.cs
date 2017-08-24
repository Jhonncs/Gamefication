using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamification.DAL.Entidades;

namespace Gamification.DAL.DTO
{
	public class UsuarioDTO
	{

		public string Nome { get; set; }
		public int Idade { get; set; }

		public UsuarioDTO(Usuario usuario)
		{
			Nome = usuario.Nome;
			Idade = usuario.Idade;
		}
	}
}
