using System;

namespace LoggerSingleton
{
	/// <summary>
	/// This must be one instance in programm
	/// And this must be thread-safe
	/// </summary>
	class Logger
	{
		private static Logger _instance;
		// Lock object
		private static object _locker = new object();
		private static int _messageNumber;
		private Logger()
		{
		}
		// This can be property or method
		// Access to logger
		public static Logger Instance
		{
			get
			{
				// Thread-safe
				// Only one thread may be set this
				lock (_locker)
				{
					if (_instance == null)
					{
						_instance = new Logger();
						_messageNumber = 0;
					}
				}
				return _instance;
			}
		}

		public void WriteMessage(string text)
		{
			_messageNumber++;
			// Some logger logic
			// Write in file, numerate strings, else
			Console.WriteLine("{0}. {1}", _messageNumber, text);
		}
	}
}
