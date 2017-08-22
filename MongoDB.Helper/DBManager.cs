using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MongoDB.Helper
{
	public class DBManager
	{

		public static IMongoDatabase Database { get; private set; }
		private static string MONGOCONNECTION = "mongodb://localhost";
		private static string DATABASE_NAME = "Gamification";

		static DBManager()
		{
			var client = new MongoClient(MONGOCONNECTION);
			Database = client.GetDatabase(DATABASE_NAME);	
		}

	}
}
