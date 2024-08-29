using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public int Seats { get; set; }
    public int MilesPerGal { get; set; }
    public string Engine { get; set; }
    public int Wheels { get; set; } = 4;
    public string Model { get; set; }
    public string Make { get; set; }
    public string Country { get; set; } 
    public string Logo { get; set; }

    public Car(string make, string model, string engine)
    {
        Make = make;
        Model = model;
        Engine = engine;
    }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"This is a {Make} {Model} from {Country}. \n" +
                          $"It is a {Seats} seater with {Wheels} wheels and it gets {MilesPerGal}mpg. \n" +
                          $"It has a {Engine} engine and a {Logo} on the front!");
    }

    
}