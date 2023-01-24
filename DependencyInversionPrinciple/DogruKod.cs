using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
	public abstract class Car
	{
		public string Brand { get; set; }
		public void Start()
		{
			Console.WriteLine(Brand + " motoru çalıştı.");
		}
        public void Stop()
        {
            Console.WriteLine(Brand + " motoru durduruldu.");
        }
    }

	class CarManager
	{
		Car _car;
		public CarManager(Car car)
		{
			_car = car;
		}

		public void Start()
		{
			_car.Start();
		}
		public void Stop()
		{
			_car.Stop();
		}

	}

	class Peugeot : Car
	{

	}

	class Renault : Car
	{

	}

}