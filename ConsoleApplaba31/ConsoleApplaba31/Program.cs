Bike bike = new Bike();
bike.name = "Semen";
Bike bike1 = new Bike();
bike1.name = "Fedir";
Console.WriteLine(bike.name.ToString());
Console.WriteLine(bike.Equals(bike1));
Console.WriteLine(bike.GetHashCode());
Pedals.Move(bike);
Pedals.Speed(bike);
Helm.Turn(bike);
Wheel.Change(bike);
Frame.Paint(bike);
public class Bike
{
    public string name { get; set; }
}
public class Wheel : Bike
{
    public static void Change(Bike bike)
    {
        Console.WriteLine($"Колесо велосипеда {bike.name} змiнено");
    }
}
public class Frame : Bike
{
    public static void Paint(Bike bike)
    {
        Console.WriteLine($"Рама велосипеда {bike.name} перефарбована");
    }
}
public class Helm : Bike//кермо
{
    public static void Turn(Bike bike)
    {
        Console.WriteLine($"Велосипед {bike.name} повернув");
    }
}
public class Pedals : Bike
{
    public static void Move(Bike bike)
    {
        Console.WriteLine($"Велосипед {bike.name} їде");
    }
    public static void Speed(Bike bike)
    {
        Console.WriteLine($"Велосипед {bike.name} їде швидше");
    }
}
