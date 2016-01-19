using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Methods
{
    internal class Methods
    {
        private static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("The side/s must be positive!");
            }

            bool sideACheck = sideB + sideC > sideA;
            bool sideBCheck = sideA + sideC > sideB;
            bool sideCCheck = sideA + sideB > sideC;
            if (!sideACheck || !sideBCheck || !sideCCheck)
            {
                throw new ArgumentException(
                    "A triangle with three given positive side lengths exists if and only if those side lengths satisfy the triangle inequality.");
            }

            double semiPerimeter = (sideA + sideB + sideC)/2;
            double area =
                Math.Sqrt(semiPerimeter*(semiPerimeter - sideA)*(semiPerimeter - sideB)*(semiPerimeter - sideC));

            return area;
        }

        private static string DigitToWord(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
            }

            throw new ArgumentOutOfRangeException("number", "The number is not a digit");
        }

        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("The array must have atleast 1 element and cannot be null");
            }

            int max = int.MinValue;
            foreach (int element in elements.Where(t => t >= max))
            {
                max = element;
            }

            return max;
        }

        private static string PrintInFormat(object number, string format)
        {
            string result = null;

            switch (format)
            {
                //if floating point format
                case "f":
                    result = string.Format("{0:f2}", number);
                    break;
                //if percentage format
                case "%":
                    result = string.Format("{0:p}", number);
                    break;
                //if pad right format
                case "r":
                    result = string.Format("{0,8}", number);
                    break;
                default:
                    throw new NotImplementedException("The format is not yet implemented");
            }

            return result;
        }


        private static double CalculateDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));

            return distance;
        }

        private static bool DoPointsFormHorizontalLine(double y1, double y2)
        {
            return y1.Equals(y2);
        }

        private static bool DoPointsFormVerticalLine(double x1,double x2)
        {
            return x1.Equals(x2);
        }

        private static void Main()
        {
            // Not a valid triangle
            // WriteLine(CalculateTriangleArea(3, 4, 5)); 

            Console.WriteLine(CalculateTriangleArea(5,5,5));

            Console.WriteLine(DigitToWord(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(PrintInFormat(1.3, "f"));
            Console.WriteLine(PrintInFormat(0.75, "%"));
            Console.WriteLine(PrintInFormat(2.30, "r"));

            const double x1 = 3;
            const double y1 = -1;
            const double x2 = 3;
            const double y2 = 2.5;
            Console.WriteLine(CalculateDistanceBetweenPoints(3, -1, 3, 2.5));

            var horizontal = DoPointsFormHorizontalLine(y1, y2);
            var vertical = DoPointsFormVerticalLine(x1, x2);
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", DateTime.Parse("17.03.1992"));

            Student stella = new Student("Stella", "Markova", DateTime.Parse("03.11.1993"));

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}