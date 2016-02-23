using System;

namespace LoggerSingleton
{
	class ClientCodeOrCodeInServer
	{
		static void Main(string[] args)
		{
			var client = new ClientCodeOrCodeInServer();
			client.DoSomething();
			// Delay
			Console.ReadKey();
		}
		/// <summary>
		/// This may be method in server logic and this can log some action
		/// </summary>
		public void DoSomething()
		{
			Logger.Instance.WriteMessage("I'm start...");
			// Param
			int n = 23;
			for (int i = 0; i < n; i++)
			{
				if (i % 3 == 0)
				{
					Logger.Instance.WriteMessage(string.Format("My work in {0} from {1}", i, n));
				}
			}
			Logger.Instance.WriteMessage("I'm END!");
		}

	}
}
