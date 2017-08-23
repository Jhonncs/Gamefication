using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Helper.Interfaces;

namespace MongoDB.Helper.Repositorio
{
	public class RepositorioBase<T> : IMongoRepository<T> where T : IEntity
	{
		public IMongoCollection<T> Collection { get; private set; }


		public RepositorioBase()
		{
			Collection = DBManager.Database.GetCollection<T>(typeof(T).Name);
		}

		public void Insert(T entidade)
		{
			Collection.InsertOne(entidade);
		}

		public List<T> GetTodos()
		{		
			return Collection.Find(p => true).ToList();
		}

		public void Delete(T entidade)
		{
			Collection.DeleteOne(p => p.Id == entidade.Id);			
		}

		public T GetById(string id)
		{
			return Collection.Find(p => p.Id == new ObjectId(id)).FirstOrDefault();
		}

	}
}
