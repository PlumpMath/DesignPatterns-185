using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportFactory.Logic.AbstractEntities;

namespace TransportFactory.Logic
{
	/// <summary>
	/// Abstract factory
	/// </summary>
	interface ITransportFactory
	{
		Car GetCar();
		Bike GetBike();
	}
}
