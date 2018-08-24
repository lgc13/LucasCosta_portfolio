using System;

namespace a5
{
	public class Car : Vehicle
	{
		private string style;

		public string Style
		{
			get { return style; }
			set { style = value; }
		}

		public Car()
		{
			this.Style = "Default style";

			Console.WriteLine("\nCreating derived object from default constructor (accepts no arguments):");
		}

		public Car(string mn = "Manufacturer", string mk = "Make", string md = "Model", string st = "Style")
			: base(md, mk, md)
		{
			this.Style = st;

			Console.WriteLine("\nCreating derived object from parameterized constructor (accepts arguments):");
		}

		public override string GetObjectInfo(string sep)
		{
			return base.GetObjectInfo(sep) + sep + Style;
		}
	}
}