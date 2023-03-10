namespace ProjectFormes.Models.Formes
{
    public class Square : Shape
    {
        public double Width { get; set; }
        public Square(int width)
        {
            this.Width = width;
        }

        public override double Area()
        {
            return this.Width * this.Width;
        }
    }
}