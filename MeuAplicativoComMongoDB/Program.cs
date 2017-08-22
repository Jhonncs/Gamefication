using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamification.ObjetoDeValor;
using Gamification.Servicos;
using MongoDB.Helper.Repositorio;
using Gamefication.Entidades;

namespace MeuAplicativoComMongoDB
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var cadastroServico = new ServicoDeCadastroDeUsuario();
			while (true)
			{
				Console.WriteLine("1 para adicionar, 2 para remover, 3 autenticar");
				var opcao = Console.ReadLine();
				switch (Convert.ToInt32(opcao))
				{
					case 1:
						try
						{
							var nome = Console.ReadLine();
							var idade = Convert.ToInt32(Console.ReadLine());
							var login = Console.ReadLine();
							var senha = Console.ReadLine();
							cadastroServico.AddUsuario(new Usuario(nome, idade, new Credencial(login, senha)));
						}
						catch (ArgumentException)
						{
							Console.WriteLine("Login inserido para o usuario é invalido, já existe no sistema");
							Console.ReadLine();
						}
						break;
					case 3:
						var l = Console.ReadLine();
						var s = Console.ReadLine();
						try
						{
							var autenticado = cadastroServico.AutenticaUsuario(new Credencial(l, s));
							if (autenticado)
							{
								Console.WriteLine("Usuario foi autenticado com sucesso");
							}
							else
							{
								Console.WriteLine("Senha invalida");
							}
						}
						catch (ArgumentException)
						{
							Console.WriteLine("Login não existe no sistema");
						}
						Console.ReadLine();
						break;
					default:
						Console.WriteLine("Insira o nome");
						var remover = Console.ReadLine();
						cadastroServico.RemovePorNome(remover);
						break;
				}
				Console.Clear();
			}


		}

		public static void Imprime(Usuario usuario)
		{
			Console.WriteLine("Nome : {0}", usuario.Nome);
			Console.WriteLine("Idade : {0}", usuario.Idade);
			Console.WriteLine("Pressione para continuar...");
			Console.ReadKey();
		}
	}
}
