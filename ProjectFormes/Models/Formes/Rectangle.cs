namespace ProjectFormes.Models.Formes{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(int height, int width) {
            this.Height = height;
            this.Width = width;
        }

        public override double Area()
        {
            return this.Width * this.Height * Math.PI;
        }
    }
}