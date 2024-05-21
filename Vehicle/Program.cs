namespace Vehicle;



internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bus bus = new Bus();
        Motocycle motocycle = new Motocycle();

        car.Start();
        car.Stop();
        car.GetDetails();

        bus.Start();
        bus.Stop(); 
        bus.GetDetails();


        motocycle.Start();
        motocycle.Stop();
        motocycle.GetDetails();

    }
}