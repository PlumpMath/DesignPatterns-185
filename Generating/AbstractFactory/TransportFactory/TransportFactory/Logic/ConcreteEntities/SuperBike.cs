using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportFactory.Logic.AbstractEntities;

namespace TransportFactory.Logic.ConcreteEntities
{
	class SuperBike : Bike
	{
		public SuperBike():
				base("Kavasaki", 300.0, 750000m)
		{
			
		}
	}
}
