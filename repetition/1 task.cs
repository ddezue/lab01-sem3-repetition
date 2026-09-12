using System;

namespace GeometryTask
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter the cube edge: ");
      double cubeEdge = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter the ball radius: ");
      double ballRadius = Convert.ToDouble(Console.ReadLine());

      double sphereVolumeFactor = 4.0 / 3.0;
      double percentMultiplier = 100.0;

      double cubeVolume = cubeEdge * cubeEdge * cubeEdge;

      double ballVolume = sphereVolumeFactor * Math.PI * ballRadius * ballRadius * ballRadius;

      double wastePercent = ((cubeVolume - ballVolume) / cubeVolume) * percentMultiplier;

      Console.WriteLine("Cube volume: " + cubeVolume);
      Console.WriteLine("Ball volume: " + ballVolume);
      Console.WriteLine("Waste percent: " + wastePercent);

      Console.ReadKey();
    }
  }
}