using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace FormLibList
{
    public class SqliteDataAccess
	{
		public static List<AccountList> LoadPeople()
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var output = cnn.Query<AccountList>("select * from Person", new DynamicParameters());
				return output.AsList();
			}
		}

		public static void SavePerson(AccountList poison)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
                cnn.Execute("insert into Person (fName, lName) values (@fname, @lname)", poison);
			}
		}

		public static void DeletePerson(AccountList poison)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				cnn.Execute("delete from Person where fName = \'" + poison.fName+"\'");
			}
		}

		private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
	}
}


