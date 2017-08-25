using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gamification.DAL.Entidades;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Helper.Interfaces;
using Gamification.DAL.ObjetoValor;

namespace Gamification.DAL.Entidades
{
	public class Usuario : IEntity
	{		
		public ObjectId Id { get; set; }
		public string Nome { get; private set; }
		public int Idade { get; private set; }
        public List<Grupo> Grupos { get; set; }
        public Identificador Identificacao { get; set; }
        public Pontuacao Pontos { get; set; }
		public Credencial Credencial { get; private set; }

		public Usuario(string nome, int idade, Credencial credencial)
		{
			Nome = nome;
			Idade = idade;
			Credencial = credencial;
		}
	}
}
