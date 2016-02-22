using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportFactory.Logic;
using TransportFactory.Logic.ConcreteFactory;

namespace TransportFactory
{
	class ClientCode
	{
		static void Main(string[] args)
		{
			//ITransportFactory factory = new DailyTransportFactory();
			ITransportFactory factory = new SuperTransportFactory();
			var myBike = factory.GetBike();
			myBike.Move();
			var myCar = factory.GetCar();
			myCar.Move();

			Console.ReadKey();
		}
	}
}
