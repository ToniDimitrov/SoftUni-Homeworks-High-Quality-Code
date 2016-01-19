using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            //Throws exception
            //Console.WriteLine(FileNameUtilities.GetFileExtension("example"));
            Console.WriteLine(FileNameUtilities.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameUtilities.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameUtilities.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameUtilities.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameUtilities.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                GeometryUtilities.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                GeometryUtilities.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            GeometryUtilities.Width = 3;
            GeometryUtilities.Height = 4;
            GeometryUtilities.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", GeometryUtilities.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", GeometryUtilities.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", GeometryUtilities.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", GeometryUtilities.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", GeometryUtilities.CalcDiagonalYZ());
        }
    }
}
