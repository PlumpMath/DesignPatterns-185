using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportFactory.Logic.AbstractEntities;

namespace TransportFactory.Logic.ConcreteEntities
{
	class DailyBike : Bike
	{
		public DailyBike():
			base("Alpha", 120.0, 10000m)
		{
			
		}
	}
}
