using System;
using Db4objects.Db4o;

namespace CRUD
{
	public class Database
	{
		static string path = AppDomain.CurrentDomain.BaseDirectory;

		public static void Insert(Model.Compra compra)
        {
			IObjectContainer db = Db4oFactory.OpenFile(path + "\\Database.yap");
			try
			{
				db.Store(compra);
			}
			finally
			{
				db.Close();
			}
		}

		public static void Insert(Model.Jogo jogo)
		{
			IObjectContainer db = Db4oFactory.OpenFile(path + "\\Database.yap");
			try
			{
				db.Store(jogo);
			}
			finally
			{
				db.Close();
			}
		}

		public static void Delete(Model.Compra compra, int qtd)
        {
			IObjectContainer db = Db4oFactory.OpenFile(path + "\\Database.yap");
			try
			{
				IObjectSet result = db.QueryByExample(compra);
				for (int o = 0; o < qtd; o++)
				{
					db.Delete(result.Next());
				}
			}
			finally
			{
				db.Close();
			}
		}
	
		public static void Delete(Model.Jogo jogo, int qtd)
        {
			IObjectContainer db = Db4oFactory.OpenFile(path + "\\Database.yap");
			try
			{
				IObjectSet result = db.QueryByExample(jogo);
				for (int o = 0; o < qtd; o++)
				{
					db.Delete(result.Next());
				}
			}
			finally
			{
				db.Close();
			}
		}
	
		public static void Retrieve(Model.Compra compra)
        {
			IObjectContainer db = Db4oFactory.OpenFile(path + "\\Database.yap");
			try
			{
				IObjectSet result = db.QueryByExample(compra);
				if (result.Count > 0)
					Console.WriteLine(result.Next());
			}
			finally
			{
				db.Close();
			}
		}
	
		public static void Retrieve(Model.Jogo jogo)
        {
			IObjectContainer db = Db4oFactory.OpenFile(path + "\\Database.yap");
			try
			{
				IObjectSet result = db.QueryByExample(jogo);
				if (result.Count > 0)
				{
					Model.Jogo j = (Model.Jogo)result.Next();
					Console.WriteLine("Jogo: " + j.nome + '\n' + j.descricao + "\nQuantidade: " + result.Count);
				}
			}
			finally
			{
				db.Close();
			}
		}
	}

}