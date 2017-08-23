using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamification.DAL.ObjetoValor
{
	public class Credencial
	{

		public string Login { get; private set; }
		public string Senha { get; private set; }

		public Credencial(string login, string senha)
		{
			Login = login;
			Senha = senha;
		}
	}
}
