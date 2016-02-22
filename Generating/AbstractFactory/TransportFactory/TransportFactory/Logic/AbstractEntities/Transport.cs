using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportFactory.Logic.AbstractEntities
{
	abstract class Transport
	{
		public string MarkModel { get; }
		public double MaxSpeed { get; }
		public decimal Price { get; }
		public TransportTypes Type { get; }
		public Transport(string markModel, double maxSpeed, 
			decimal price, TransportTypes type)
		{
			MarkModel = markModel;
			MaxSpeed = maxSpeed;
			Price = price;
			Type = type;
		}

		public void Move()
		{
			// This is one of the possible behaviors
			// !!! There should be a different logic
			var moveText = string.Format("I'm move on {0}, with speed {1}, my transport cost - {2}",
				MarkModel, MaxSpeed, Price);
			Console.WriteLine(moveText);
		}
	}
}
