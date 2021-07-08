using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar objCar = new EconomyCar();
            CarAccessoriesDecorator carAccessoriesDecorator = new BasicAccessories(objCar);
            carAccessoriesDecorator = new AdvancedAccessories(carAccessoriesDecorator);

            Console.WriteLine($"Car Detials: {carAccessoriesDecorator.GetDescription()}");
            Console.WriteLine("\n\n");
            Console.WriteLine($"Total Prices: {carAccessoriesDecorator.GetCost()}");
        }
    }
}
