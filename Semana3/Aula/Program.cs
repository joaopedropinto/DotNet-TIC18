#region Culture Definition

using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");
#endregion

#region Tuple exemple

var tuple1 = (10, 20);
Console.WriteLine($"Tuple 1: {tuple1.Item1}, {tuple1.Item2}");
//Tuple 1: 10, 20

var tuple2 = (x: 5, y: 50);
Console.WriteLine($"Tuple 2: {tuple2.x}, {tuple2.y}");
//Tuple 2: 5, 50

var tuple3 = (id: 10, name: "João Pedro", born: new DateTime(1999, 2, 21));
Console.WriteLine($"Tuple 3: {tuple3.id}, {tuple3.name}, {tuple3.born}");

List<(int id, string name, DateTime born)> list = new();
list.Add(tuple3);
list.Add((11, "Sandy", new DateTime(2002, 6, 21)));
list.ForEach(x => Console.WriteLine($"Tuples: {x.id}, {x.name}, {x.born.ToShortDateString()}"));

#endregion

#region Lambda Exemple

string[] people = { "Joao", "Valtencir", "Gleide", "Sandy"};
char letter = 'a';
Console.WriteLine($"People that name contains letter '{letter}': {string.Join(", ", people.Where(x => x.Contains(letter)))}");

#endregion

#region Linq exemple

var students = new List<Student>{
   new Student(1, "João Pedro", "123456789", new DateTime(1999, 2, 21), new List<string>{"123456789", "73988342986"}),
   new Student(2, "Samuel", "987654321", new DateTime(2007, 1, 4), new List<string>{"123456789", "73987654321"}),
   new Student(3, "Sandy", "123456789", new DateTime(2002, 6, 21), new List<string>{"123456789", "77988237086"})
};

var any = students.Any();
var anyHelder = students.Any(x => x.FullName.Contains("João"));
//var single = students.Single(x => x.Id == 10);
//throw exception
var singleOrDefault = students.SingleOrDefault(x => x.Id == 10);

var select = students.Select(x => x.PhoneNumbers);
var selectMany = students.SelectMany(x => x.PhoneNumbers);

var legalAge = students.Where(x => x.BirthDate <= DateTime.Today.AddYears(-18)).Select(x => x.FullName);
Console.WriteLine($"Legal age people: {string.Join(", ", legalAge)}");




public class Student
{
  public Student(int id, string fullName, string document, DateTime birthDate, List<string> phoneNumbers)
  {
    Id = id;
    FullName = fullName;
    Document = document;
    BirthDate = birthDate;
    PhoneNumbers = new List<string>(phoneNumbers);
  }

  public int Id { get; set; }
  public string FullName { get; set; }
  public string Document { get; set; }
  public DateTime BirthDate { get; set; }
  public List<string> PhoneNumbers { get; set; }
}

#endregion

#region Exception exemple

try
{
  Console.WriteLine($"Enter a number: ");
  int number = int.Parse(Console.ReadLine()!);
  Console.WriteLine($"Number: {number}");
}
catch (FormatException ex)
{
  Console.WriteLine($"Please, enter a number!");
  Console.WriteLine($"Error: {ex.Message}");
}


#endregion
