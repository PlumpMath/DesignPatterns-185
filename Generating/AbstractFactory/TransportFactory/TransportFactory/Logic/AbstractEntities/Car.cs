using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportFactory.Logic.AbstractEntities
{
	abstract class Car : Transport
	{
		public Car(string markModel, double maxSpeed, decimal price) : 
			base(markModel, maxSpeed, price, TransportTypes.Car)
		{
			
		}
	}
}
