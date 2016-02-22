using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportFactory.Logic.AbstractEntities;

namespace TransportFactory.Logic.ConcreteEntities
{
	class SuperCar : Car
	{
		// Is not correctly implementation of Entity
		// In real project that may be data with database, or other
		public SuperCar() :
				base("Bugatti Veyron", 405.0, 100000000m)
		{
			
		}
	}
}
