#region Culture Definition

using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");
#endregion

// #region Tuple exemple

// var tuple1 = (10, 20);
// Console.WriteLine($"Tuple 1: {tuple1.Item1}, {tuple1.Item2}");
// //Tuple 1: 10, 20

// var tuple2 = (x: 5, y: 50);
// Console.WriteLine($"Tuple 2: {tuple2.x}, {tuple2.y}");
// //Tuple 2: 5, 50

// var tuple3 = (id: 10, name: "João Pedro", born: new DateTime(1999, 2, 21));
// Console.WriteLine($"Tuple 3: {tuple3.id}, {tuple3.name}, {tuple3.born}");

// List<(int id, string name, DateTime born)> list = new();
// list.Add(tuple3);
// list.Add((11, "Sandy", new DateTime(2002, 6, 21)));
// list.ForEach(x => Console.WriteLine($"Tuples: {x.id}, {x.name}, {x.born.ToShortDateString()}"));

// #endregion
 
#region Lambda Exemple

string[] people = { "Joao", "Valtencir", "Gleide", "Sandy"};
char letter = 'a';
Console.WriteLine($"People that name contains letter '{letter}': {string.Join(", ", people.Where(x => x.Contains(letter)))}");

#endregion