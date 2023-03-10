namespace ProjectFormes.Models.Formes
{

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }
    }
}