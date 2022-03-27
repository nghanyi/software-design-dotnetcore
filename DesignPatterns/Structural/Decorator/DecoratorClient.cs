namespace DesignPatterns.Structural.Decorator;

public class DecoratorClient : ClientTemplate
{
    public override string Pattern => "Decorator";

    public override void RunClient()
    {
        ICar bmwCar1 = new BMWCar();
        bmwCar1.ManufactureCar();
        Console.WriteLine(bmwCar1);
        Console.WriteLine();

        var carWithDieselEngine = new DieselCarDecorator(bmwCar1);
        carWithDieselEngine.ManufactureCar();
        
        Console.WriteLine();
        
        ICar bmwCar2 = new BMWCar();
        
        var carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
        carWithPetrolEngine.ManufactureCar();
    }
}