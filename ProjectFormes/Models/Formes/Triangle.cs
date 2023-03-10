namespace ProjectFormes.Models.Formes
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(int baseTriangle, int height) {
            this.Base = baseTriangle;
            this.Height = height;
        }
        public override double Area()
        {
            return this.Base * this.Height /2;
        }
    }
}