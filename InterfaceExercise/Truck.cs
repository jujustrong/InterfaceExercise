using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public int Doors { get; set; } = 4;
    public int TowingCapacity { get; set; }
    public string Engine { get; set; }
    public int Wheels { get; set; } = 4;
    public string Model { get; set; }
    public string Make { get; set; }
    public string Country { get; set; }
    public string Logo { get; set; }
    
    public Truck(string make, string model, string engine)
    {
        Make = make;
        Model = model;
        Engine = engine;
    }
    
    
    public void DisplayDetails()
    {
        Console.WriteLine($"This is a {Make} {Model} from {Country}. \n" +
                          $"It has a towing capacity of {TowingCapacity}lbs and it" +
                          $"has a {Engine} engine. \nThis {Doors} door {Model} has {Wheels} wheels " +
                          $"and has a large {Logo} on the front.");
    }


}