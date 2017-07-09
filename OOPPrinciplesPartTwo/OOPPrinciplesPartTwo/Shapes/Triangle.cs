namespace OOPPrinciplesPartTwo.Shapes
{
    
    class Triangle : Shape
    {
        public Triangle(double height, double width)
            :base(width, height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalculateSurface()
        {
            return (this.Height * this.Width) / 2;
        }
    }
}
