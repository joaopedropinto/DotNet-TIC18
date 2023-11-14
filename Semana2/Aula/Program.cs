#region Foreach example
Console.WriteLine("Foreach example");
string[] colecao= { "Item1", "Item2", "Item3", "Item4" };

foreach (string item in colecao)
{
  
  Console.WriteLine(item); 
}
#endregion

#region Readline example
Console.WriteLine("Readline example\n");
Console.WriteLine("Enter your name: ");
string? name = Console.ReadLine();
Console.WriteLine($"Hello, {name}");
#endregion

#region Exercise 1
Console.WriteLine("Exercise 1\n");
for (int i = 0; i <= 30; i++){
  if (i % 3 == 0|| i % 4 == 0){
    Console.WriteLine($"{i} é divisível!");
  }
}
#endregion

#region Exercise 2
Console.WriteLine("Exercise 2\n");
int fib1 = 0, fib2 = 1, fib = 0;
Console.WriteLine(fib1);
Console.WriteLine(fib2);

while (fib <= 100){
  fib = fib1 + fib2;
  Console.WriteLine(fib);
  fib1 = fib2;
  fib2 = fib;
  
}
#endregion

#region Exercise 3
Console.WriteLine("\nExercise 3\n");

#endregion

#region Example Strings
Console.WriteLine("Example Strings");
Console.WriteLine("Please enter your name: ");
string? name1 = Console.ReadLine();
Console.WriteLine($"Hello, {name1.ToUpper()}");
Console.WriteLine($"Hello, {name1.ToLower()}");
Console.WriteLine($"Length of name: {name1.Length}");

#endregion

#region List example
Console.WriteLine("List example");
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);
numbers.Remove(3);

numbers.Add(20);
numbers.Add(4);
numbers.Sort();
numbers.Remove(4);
Console.WriteLine("List of integers:");
foreach(int number in numbers){
  Console.WriteLine(number);
  
}
Console.WriteLine($"List has {numbers.Count} elements\n");

List<List<string>> names2 = new List<List<string>>();
names2.Add(new List<string>(){"João", "Pedro", "Pinto"}); 
names2.Add(new List<string>(){"Samuel", "De", "Gois"});
foreach(List<string> names3 in names2){

  foreach(String name in names3){
    Console.WriteLine(name);
  }
}
#endregion 

#region Date example
  DateTime now = DateTime.Now;
  Console.WriteLine($"Current date and time: {now}");
  DateTime today = DateTime.Today;
  Console.WriteLine($"Todays's date: {today}");
  DateTime tomorrow = now.AddDays(1);
  Console.WriteLine($"Tomorrow's date: {tomorrow}");
  DateTime yesterday = now.AddDays(-1);
  Console.WriteLine($"Yesterday's date: {yesterday}");
  DateTime specificDate = new DateTime(2022, 02, 21);
  Console.WriteLine($"Week Day: {specificDate.DayOfWeek}");
#endregion