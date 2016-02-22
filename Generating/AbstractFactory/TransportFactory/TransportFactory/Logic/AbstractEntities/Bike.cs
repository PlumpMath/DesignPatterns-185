using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportFactory.Logic.AbstractEntities
{
	abstract class Bike : Transport
	{
		public Bike(string markModel, double maxSpeed, decimal price) : 
			base(markModel, maxSpeed, price, TransportTypes.Bike)
		{
			
		}
	}
}
