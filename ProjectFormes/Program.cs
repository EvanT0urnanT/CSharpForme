using ProjectFormes.Models.Formes;
class Programm
{
    static void Main(string[] args)
    {
        Shape[] formes = new Shape[]{ new Rectangle(12,14), new Circle(5), new Triangle(7,5), new Square(10)};
        AreaCalcultor calcultor = new AreaCalcultor();
        Console.WriteLine(calcultor.TotalArea(formes));
        Console.ReadLine();
    }
}
