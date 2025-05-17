using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string FullName { get; set; }
    public string Group { get; set; }
    public int Score { get; set; }

    public string LastName => FullName.Split(' ')[0];
    public string FirstName => FullName.Split(' ')[1];
    public string Patronymic => FullName.Split(' ')[2];
}

class Program
{
    static void Main()
    {
        var students = LoadStudentsFromFile("students.txt");

        PrintLastNamesCount(students);
        PrintFirstNamesCount(students);
        PrintPatronymicsCount(students);
        PrintGroupsCount(students);
        PrintScoresCount(students);
        PrintMostFrequentFirstNames(students);
        PrintGroupsWithMostStudents(students);
        PrintTopScorers(students);
        PrintGroupsWithTopScorers(students);
        PrintGroupsWithMaxAverageScore(students);
    }

    private static void PrintGroupsWithMaxAverageScore(List<Student> students)
    {
        throw new NotImplementedException();
    }

    static List<Student> LoadStudentsFromFile(string filePath)
    {
        var students = new List<Student>();
        var lines = Student.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var parts = line.Split(',');
            students.Add(new Student
            {
                FullName = parts[0].Trim(),
                Group = parts[1].Trim(),
                Score = int.Parse(parts[2].Trim())
            });
        }

        return students;
    }

    static void PrintLastNamesCount(List<Student> students)
    {
        var lastNameCount = students.GroupBy(s => s.LastName)
                                     .Select(g => new { LastName = g.Key, Count = g.Count() })
                                     .ToList();

        Console.WriteLine("Перечень фамилий и количество студентов:");
        foreach (var item in lastNameCount)
        {
            Console.WriteLine($"{item.LastName}: {item.Count}");
        }
    }

    static void PrintFirstNamesCount(List<Student> students)
    {
        var firstNameCount = students.GroupBy(s => s.FirstName)
                                      .Select(g => new { FirstName = g.Key, Count = g.Count() })
                                      .ToList();

        Console.WriteLine("Перечень имён и количество студентов:");
        foreach (var item in firstNameCount)
        {
            Console.WriteLine($"{item.FirstName}: {item.Count}");
        }
    }

    static void PrintPatronymicsCount(List<Student> students)
    {
        var patronymicCount = students.GroupBy(s => s.Patronymic)
                                       .Select(g => new { Patronymic = g.Key, Count = g.Count() })
                                       .ToList();

        Console.WriteLine("Перечень отчеств и количество студентов:");
        foreach (var item in patronymicCount)
        {
            Console.WriteLine($"{item.Patronymic}: {item.Count}");
        }
    }

    static void PrintGroupsCount(List<Student> students)
    {
        var groupCount = students.GroupBy(s => s.Group)
                                 .Select(g => new { Group = g.Key, Count = g.Count() })
                                 .ToList();

        Console.WriteLine("Перечень групп и количество студентов:");
        foreach (var item in groupCount)
        {
            Console.WriteLine($"{item.Group}: {item.Count}");
        }
    }

    static void PrintScoresCount(List<Student> students)
    {
        var scoreCount = students.GroupBy(s => s.Score)
                                 .Select(g => new { Score = g.Key, Count = g.Count() })
                                 .ToList();

        Console.WriteLine("Перечень баллов и количество студентов:");
        foreach (var item in scoreCount)
        {
            Console.WriteLine($"{item.Score}: {item.Count}");
        }
    }

    static void PrintMostFrequentFirstNames(List<Student> students)
    {
        var maxCount = students.GroupBy(s => s.FirstName)
                               .Select(g => new { FirstName = g.Key, Count = g.Count() })
                               .Max(g => g.Count);

        var mostFrequentFirstNames = students.GroupBy(s => s.FirstName)
                                              .Where(g => g.Count() == maxCount)
                                              .Select(g => g.Key)
                                              .ToList();

        Console.WriteLine("Имена, встречающиеся максимальное количество раз:");
        foreach (var name in mostFrequentFirstNames)
        {
            Console.WriteLine(name);
        }
    }

    static void PrintGroupsWithMostStudents(List<Student> students)
    {
        var maxCount = students.GroupBy(s => s.Group)
                               .Select(g => new { Group = g.Key, Count = g.Count() })
                               .Max(g => g.Count);

        var groupsWithMostStudents = students.GroupBy(s => s.Group)
                                             .Where(g => g.Count() == maxCount)
                                             .Select(g => g.Key)
                                             .ToList();

        Console.WriteLine("Группы с максимальным количеством студентов:");
        foreach (var group in groupsWithMostStudents)
        {
            Console.WriteLine(group);
        }
    }

    static void PrintTopScorers(List<Student> students)
    {
        var maxScore = students.Max(s => s.Score);
        var topScorers = students.Where(s => s.Score == maxScore)
                                  .Select(s => s.FullName)
                                  .ToList();

        Console.WriteLine("Студенты с максимальным количеством баллов:");
        foreach (var scorer in topScorers)
        {
            Console.WriteLine(scorer);
        }
    }

    static void PrintGroupsWithTopScorers(List<Student> students)
    {
        var maxScore = students.Max(s => s.Score);
        var groupsWithTopScorers = students.Where(s => s.Score == maxScore)
                                            .GroupBy(s => s.Group)
                                            .Select(g => g.Key)
                                            .ToList();

        Console.WriteLine("Группы с максимальным количеством студентов, набравших максимальное количество баллов:");
        foreach (var group in groupsWithTopScorers)
        {
            Console.WriteLine(group);
        }
    }

}
