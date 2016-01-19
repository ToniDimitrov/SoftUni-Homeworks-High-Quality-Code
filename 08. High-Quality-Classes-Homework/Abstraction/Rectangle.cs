using System;

namespace Abstraction
{
    class Rectangle : Figure
    {
        private double height;
        private double width;

        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("height", "Value must be positive");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("width", "Value must be positive");
                }

                this.width = value;
            }
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            
            return surface;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);

            return perimeter;
        }
    }
}
