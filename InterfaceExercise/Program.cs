using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            var ferrari = new Car("Ferrari", "488 GTB", "V8");
            ferrari.MilesPerGal = 22;
            ferrari.Country = "Italy";
            ferrari.Seats = 2;
            ferrari.Logo = "Stallion";
            ferrari.DisplayDetails();
            Console.WriteLine();

            var f150 = new Truck("Ford", "F-150", "V6");
            f150.Country = "America";
            f150.Logo = "FORD";
            f150.TowingCapacity = 10000;
            f150.DisplayDetails();
            Console.WriteLine();

            var jeep = new SUV("Jeep", "Wrangler", "V6");
            jeep.Country = "America";
            jeep.Logo = "JEEP";
            jeep.SafetyRating = 7;
            jeep.HasTrunk = true;
            jeep.DisplayDetails();

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of the method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
