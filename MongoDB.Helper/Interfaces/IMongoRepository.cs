using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoDB.Helper.Interfaces
{
	public interface IMongoRepository<T> where T : IEntity
	{
		IMongoCollection<T> Collection { get; }
	}
}
