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

      double cubeVolume = Math.Pow(cubeEdge, 3);

      double ballVolume = sphereVolumeFactor * Math.PI * Math.Pow(ballRadius, 3);

      double wastePercent = ((cubeVolume - ballVolume) / cubeVolume) * percentMultiplier;

      Console.WriteLine($"Cube volume: {cubeVolume}");
      Console.WriteLine($"Ball volume: {ballVolume}");
      Console.WriteLine($"Waste percent: {wastePercent}");

      Console.ReadKey();
    }
  }
}