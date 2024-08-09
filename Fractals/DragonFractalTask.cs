using System;

namespace Fractals;

internal static class DragonFractalTask
{
    public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
    {
        Random random = new Random(seed);
        double x = 1;
        double y = 0;
        for (int i = 0; i < iterationsCount; i++)
        {
            int Transformation = random.Next(2);
            bool IsFirstTransformation = Transformation == 0;
            if (IsFirstTransformation)
            {
                double angle = Math.PI / 4;
                double newX = (x * Math.Cos(angle) - y * Math.Sin(angle)) / Math.Sqrt(2);
                double newY = (x * Math.Sin(angle) + y * Math.Cos(angle)) / Math.Sqrt(2);
                x = newX; y = newY;
                pixels.SetPixel(x, y);
            }
            else
            {
                double angle = (Math.PI * 3) / 4;
                double newX = (x * Math.Cos(angle) - y * Math.Sin(angle)) / Math.Sqrt(2) + 1;
                double newY = (x * Math.Sin(angle) + y * Math.Cos(angle)) / Math.Sqrt(2);
                x = newX; y = newY;
                pixels.SetPixel(x, y);
            }
        }
    }
}