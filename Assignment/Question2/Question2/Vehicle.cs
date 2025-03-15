using System;
namespace Question2
{
	public class Vehicle
	{
		private string milesPerGallon;
		private string cylinders;
		private string horsepower;
		private string weight;
		private string acceleration;
		private string modelYear;
		private string carName;

        public Vehicle(string milesPerGallon,string cylinders,string horsepower,string weight,string acceleration,string modelYear,string carName)
		{
			this.milesPerGallon = milesPerGallon;
			this.cylinders = cylinders;
			this.horsepower = horsepower;
			this.weight = weight;
			this.acceleration = acceleration;
			this.modelYear = modelYear;
			this.carName = carName;
		}
        public override string ToString()
        {
            return string.Format($"{milesPerGallon,5} {cylinders,5} {horsepower,5} {weight,5} {acceleration,5} {modelYear,5} {carName,-30}");
        }

    }
}

