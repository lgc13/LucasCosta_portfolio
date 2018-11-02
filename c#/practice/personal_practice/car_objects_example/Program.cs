using System;

namespace a5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Author: Lucas Costa");
            Console.WriteLine();
            DateTime localDate = DateTime.Now;
            Console.WriteLine("Now: " + localDate.ToString());
            Console.WriteLine();

            Console.WriteLine("\nvehicle1 - (instantiating new object from default constructor)");
            Vehicle vehicle1 = new Vehicle();

            Console.WriteLine(vehicle1.GetObjectInfo());

            Console.WriteLine("\nvehicle2 (user input): Call parameterized base constructor (accepts arguments):");

            string p_manufacturer = "";
            string p_make = "";
            string p_model = "";
            float p_miles = 0.0f;
            float p_gallons = 0.0f;
            string p_separator = "";

            Console.Write("Manufacturer (alpha): ");
            p_manufacturer = Console.ReadLine();

            Console.Write("Make (alpha): ");
            p_make = Console.ReadLine();

            Console.Write("Model (alpha): ");
            p_model = Console.ReadLine();

            Console.Write("Miles driven (float): ");
            while (!float.TryParse(Console.ReadLine(), out p_miles))
            {
            	Console.Write("Miles must be numeric: ");
            }

            Console.Write("Gallons used (float): ");
            while (!float.TryParse(Console.ReadLine(), out p_gallons))
            {
            	Console.Write("Gallons must be numeric: ");
            }

            Console.WriteLine("\nvehicle2 - (instantiating new object, passing *only 1st arg*)\n" +
            	"(Demos why use constructor with default parameter values):");
            Console.WriteLine("*Note*: only 1st arg passed to constructor, others are defualt values.");
            Vehicle vehicle2 = new Vehicle(p_manufacturer);

            Console.WriteLine(vehicle2.GetObjectInfo());

            Console.WriteLine("\nUser input: vehicle2 - passing arg to overloaded GetObjectInfo(arg):");
            Console.Write("Delimiter (, : ;): ");

            p_separator = Console.ReadLine();

            Console.WriteLine(vehicle2.GetObjectInfo(p_separator));

            Console.WriteLine("\nvehicle2 - (instantiating new object, passing *all* vehicle args):");
            Vehicle vehicle3 = new Vehicle(p_manufacturer, p_make, p_model);

            vehicle3.SetGallons(p_gallons);
            vehicle3.SetMiles(p_miles);

            Console.WriteLine("\nUser input: vehicle3 - passing arg to overloaded (same scope - same class) GetObjectInfo(arg)");
            Console.Write("Delimiter (, : ;): ");
            p_separator = Console.ReadLine();
            Console.WriteLine(vehicle3.GetObjectInfo(p_separator));

            Console.WriteLine("\nDemonstating Polymorphism (new derived object):");
            Console.WriteLine("(User input: car1 - calling parameterized base class constructor explicitly.)\n");

            string p_style = "";

            Console.Write("Manufacturer (alpha): ");
            p_manufacturer = Console.ReadLine();

            Console.Write("Make (alpha): ");
            p_make = Console.ReadLine();

            Console.Write("Model (alpha): ");
            p_model = Console.ReadLine();

            Console.Write("Miles driven (float): ");
            while (!float.TryParse(Console.ReadLine(), out p_miles))
            {
            	Console.Write("Miles must be numeric: ");
            }

            Console.Write("Gallons used (float): ");
            while (!float.TryParse(Console.ReadLine(), out p_gallons))
            {
            	Console.Write("Gallons must be numeric: ");
            }

            Console.Write("Style (alphanumeric): ");
            p_style = Console.ReadLine();

            Console.WriteLine("\ncar1 - (instantiating new derived object, passing *all* args):");
            Car car1 = new Car(p_manufacturer, p_make, p_model, p_style);

            car1.SetGallons(p_gallons);
            car1.SetMiles(p_miles);

            Console.WriteLine("\nUser input: car1 - passing arg to overrided (different scope - inheritance) GetObjectInfo(arg):");
            Console.Write("Delimiter (, : ;): ");
            p_separator = Console.ReadLine();
            Console.WriteLine(car1.GetObjectInfo(p_separator));

            Console.WriteLine();
            Console.WriteLine("\nPress any key to exit!");
            Console.ReadKey();
        }
    }
}
