namespace InterfaceExercise;

public interface IVehicle
{
    public string Engine { get; set; }
    public int Wheels { get; set; }
    public string Model { get; set; }
    public string Make { get; set; }

    void DisplayDetails();

}