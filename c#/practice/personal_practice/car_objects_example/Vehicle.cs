using System;

namespace a5
{
	public class Vehicle
	{
		private float milesTraveled, gallonsUsed;

		public string Manufacturer { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }

		public float MPG
		{
			get {
				if ( gallonsUsed <= 0.0f )
				{
					return 0.0f;
				}
				else
				{
					return milesTraveled / gallonsUsed;
				}
			}
		}

		public Vehicle()
		{
			this.Manufacturer = "GM";
			this.Make = "Chevrolet";
			this.Model = "Camaro";

			Console.WriteLine("\nCreating base object from default constructor (accepts no arguments):");
		}

		public Vehicle(string mn = "Manufacturer", string mk = "Make", string md = "Model")
		{
			this.Manufacturer = mn;
			this.Make = mk;
			this.Model = md;

			Console.WriteLine("\nCreating base object from parameterized constructor (accepts arguments):");
		}

		public void SetMiles(float m = 0.0f)
		{
			milesTraveled = m;
		}

		public void SetGallons(float g = 0.0f)
		{
			gallonsUsed = g;
		}

		public float GetMiles()
		{
			return milesTraveled;
		}

		public float GetGallons()
		{
			return gallonsUsed;
		}

		public virtual string GetObjectInfo()
		{
			return Manufacturer + " - " + Make + " - " + Model + " - " + MPG;
		}

		public virtual string GetObjectInfo(string sep)
		{
			return Manufacturer + sep + Make + sep + Model + sep + MPG;
		}
	}
}