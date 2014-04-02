using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace PArticulo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string connectionString=
				"Server= Localhost;"+
				"Database = dbprueba;"+
				"User Id=root;"+
				"Password=sistemas";
			
				MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
			mySqlConnection.Open ();
			
			MySqlCommand updateMySqlCommand= mySqlConnection.CreateCommand();
			updateMySqlCommand.CommandText="update articulo set nombre=:nombre where id=!";
			updateMySqlCommand.ExecuteNonQuery();
			
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
			
			mySqlCommand.CommandText = "select * from articulo";
			
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader ();
			
			while (mySqlDataReader.Read ()){
				Console.WriteLine("id={0} nombre={1}",mySqlDataReader["id"],mySqlDataReader["nombre"]);
			}
			
		mySqlDataReader.Close();
			mySqlConnection.Close();
			string hora=DateTime.Now.ToString();
			
			
		}


		}
}

