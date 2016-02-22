using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportFactory.Logic.AbstractEntities;
using TransportFactory.Logic.ConcreteEntities;

namespace TransportFactory.Logic.ConcreteFactory
{
	/// <summary>
	/// Concrete factory
	/// </summary>
	class DailyTransportFactory : ITransportFactory
	{
		public Car GetCar()
		{
			return new DailyCar();
		}

		public Bike GetBike()
		{
			return new DailyBike();
		}
	}
}
