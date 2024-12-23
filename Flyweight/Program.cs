using Flyweight;

class Program
{
    static void Main(string[] args)
    {
        var parkingLot = new ParkingLot();
        parkingLot.AddCar("John Doe", "AB123CD", "Audi", "A7", "Black");
        parkingLot.AddCar("Jane Smith", "EF456GH", "Audi", "A7", "Black");
        parkingLot.AddCar("Alice Johnson", "IJ789KL", "Porsche", "911", "Blue");
        parkingLot.AddCar("Bob Brown", "MN012OP", "Porsche", "911", "Blue");
        parkingLot.AddCar("Charlie Jones", "QR345ST", "BMW", "M5", "Gray");

        parkingLot.DisplayCars();
    }
}