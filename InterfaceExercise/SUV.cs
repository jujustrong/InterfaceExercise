using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public double SafetyRating { get; set; }
    public bool HasTrunk { get; set; }
    public string Engine { get; set; }
    public int Wheels { get; set; } = 4;
    public string Model { get; set; }
    public string Make { get; set; }
    public string Country { get; set; }
    public string Logo { get; set; }
    
    public SUV(string make, string model, string engine)
    {
        Make = make;
        Model = model;
        Engine = engine;
    }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"This is a {Make} {Model}. \n" +
                          $"It has a safety rating of {SafetyRating}/10 and it" +
                          $"has a {Engine} engine. \nThe {Model} has {Wheels} wheels " +
                          $"and was made in {Country} by the company with the {Logo}.");
        if (HasTrunk == true) { Console.WriteLine("And it has a trunk!"); }
    }

    
}    