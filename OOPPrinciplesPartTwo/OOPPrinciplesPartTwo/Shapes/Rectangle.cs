namespace OOPPrinciplesPartTwo.Shapes
{
   

   public class Rectangle : Shape
    {
        public Rectangle(double height,double width)
            :base(width, height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}
