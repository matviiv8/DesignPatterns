namespace Flyweight
{
    public class ParkingLot
    {
        private readonly List<Car> _cars = new List<Car>();
        private readonly CarTypeFactory _carTypeFactory = new CarTypeFactory();

        public void AddCar(string owner, string licensePlate, string make, string model, string color)
        {
            var carType = _carTypeFactory.GetCarType(make, model, color);
            var car = new Car(owner, licensePlate, carType);
            _cars.Add(car);
        }

        public void DisplayCars()
        {
            Console.WriteLine("\nDisplaying all cars in the parking lot:");
            foreach (var car in _cars)
            {
                car.Display();
            }
        }
    }
}