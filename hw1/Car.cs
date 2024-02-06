namespace hw1;

public class Car : IVehicle
{
    public int Gaz { get; set; }
    public Car(int gaz)
    {
        Gaz=gaz;
    }
    public void Drive()
    {
        if(Gaz>0)
        {
            System.Console.WriteLine("Driving");
        }
    }
    public bool Refuel(int gaz)
    {
        
    }

}
