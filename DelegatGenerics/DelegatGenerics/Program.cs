namespace DelegatGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Date = DateTime.Now;
            CarDelegate carDelegate = new CarDelegate(car.Wash);
            carDelegate += car.Finish;
            carDelegate(car.Date);
        }
    }
}