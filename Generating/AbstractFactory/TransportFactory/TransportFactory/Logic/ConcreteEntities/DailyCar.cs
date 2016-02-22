using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportFactory.Logic.AbstractEntities;

namespace TransportFactory.Logic.ConcreteEntities
{
	class DailyCar: Car
	{
		public DailyCar():
			base("WW Mini", 180.0, 75000m)
		{
			
		}
	}
}
