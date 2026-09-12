using System.Text;

namespace DiplomaDefense
{
  class Program
  {
    static void Main()
    {
      string filePath = "students.csv";

      GenerateAndSaveData(filePath);

      Console.Write("Enter target group: ");
      string targetGroup = Console.ReadLine() ?? string.Empty;

      Console.Write("Enter target grade: ");
      string gradeInput = Console.ReadLine() ?? string.Empty;
      int targetGrade = Convert.ToInt32(gradeInput);

      FilterAndPrintData(filePath, targetGroup, targetGrade);

      Console.ReadKey();
    }

    static void GenerateAndSaveData(string filePath)
    {
      List<string> students = new List<string>
      {
        "Ivanov,Ivan,PI-251,5",
        "Petrov,Petr,PI-251,4",
        "Sidorov,Sidor,PI-251,3",
        "Smirnova,Anna,PI-261,5",
        "Kuznetsov,Dmitry,PI-261,4",
        "Popova,Elena,PI-261,5",
        "Volkov,Andrey,PI-241,3",
        "Morozova,Olga,PI-241,4",
        "Novikov,Sergey,PI-241,5",
        "Fedorova,Marina,PI-231,4",
        "Sokolov,Alexey,PI-231,5",
        "Mikhaylova,Irina,PI-231,3"
      };

      File.WriteAllLines(filePath, students, Encoding.UTF8);
      Console.WriteLine("Data generated and saved to " + filePath);
    }

    static void FilterAndPrintData(string filePath, string targetGroup, int targetGrade)
    {
      string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

      Console.WriteLine("\nFiltered results:");

      foreach (string line in lines)
      {
        string[] parts = line.Split(',');

        string lastName = parts[0];
        string firstName = parts[1];
        string group = parts[2];
        int grade = Convert.ToInt32(parts[3]);

        if (group == targetGroup && grade == targetGrade)
        {
          Console.WriteLine(lastName + " " + firstName + " | Group: " + group + " | Grade: " + grade);
        }
      }
    }
  }
}