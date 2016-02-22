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
	class SuperTransportFactory : ITransportFactory
	{
		public Car GetCar()
		{
			return new SuperCar();
		}

		public Bike GetBike()
		{
			return new SuperBike();
		}
	}
}
