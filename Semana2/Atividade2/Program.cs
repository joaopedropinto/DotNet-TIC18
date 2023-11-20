static void main()
{
  static List<string> titles = new List<string>();
  static List<string> descriptions = new List<string>();
  static List<DateTime> dueDates = new List<DateTime>();
  static List<bool> completedTasks = new List<bool>();

  while (true)
  {

    Console.WriteLine($"\n===== Tasks management system =====\n");
    Console.WriteLine($"1. Create Task");
    Console.WriteLine($"2. List Tasks");
    Console.WriteLine($"3. Mark Task as Completed");
    Console.WriteLine($"4. List Pending Tasks");
    Console.WriteLine($"5. List Completed Tasks");
    Console.WriteLine($"6. Delete Task");
    Console.WriteLine($"7. Search Task by Keyword");
    Console.WriteLine($"8. Display Statistics");
    Console.WriteLine($"0. Exit");

    Console.Write("Choose an option: ");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
      case 1:
        CreateTask();
        break;
      case 2:
        ListTasks();
        break;
      case 3:
        MarkTaskAsCompleted();
        break;
      case 4:
        ListPendingTasks();
        break;
      case 5:
        ListCompletedTasks();
        break;
      case 6:
        break;
      case 7:
        break;
      case 8:
        break;
      case 0:
        Console.WriteLine($"Leaving...");
        return;
      default:
        Console.WriteLine($"Invalid option, try again.");
        break;
    }
  }
}

static void CreateTask()
{
  string title, description;
  DateTime dueDate;

  Console.WriteLine($"Enter the task title:");
  title = Console.ReadLine();
  titles.add(title);

  Console.WriteLine($"Enter the task description:");
  description = Console.ReadLine();
  descriptions.add(description);

  Console.WriteLine($"Enter the task due date (dd/MM/yyyy):");
  dueDate = DateTime.Parse(Console.ReadLine(), "dd/MM/yyyy", null);
  dueDates.add(dueDate);

  completedTasks.add(false);

  Console.WriteLine($"Task created successfully!");
}

static void ListTasks()
{
  if (tasks.Count <= 0)
  {
    Console.WriteLine($"No tasks found!");
  }
  else
  {
    Console.WriteLine($"=======Task list=======");
    for (int i = 0; i < tasks.Count; i++)
    {
      Console.WriteLine($"{i}. {tasks[i]} - Description: {descriptions[i]} - Due date: {dueDates[i]} - {(completedTasks[i] ? "[x]" : "[ ]")}");
    }
  }
}

static void MarkAsCompleted()
{
  ListTasks();
  Console.Write("Enter the task number you want to mark as completed: ");
  int taskNumber = int.Parse(Console.ReadLine());

  if (taskNumber > 0 && taskNumber <= titles.Count)
  {
    completedTasks[taskNumber] = true;
    Console.WriteLine("Task marked as completed!");
  }
  else
  {
    Console.WriteLine("Invalid task number.");
  }
}

static void ListPendingTasks()
{
  if (tasks.Count <= 0)
  {
    Console.WriteLine($"No tasks found!");
  }
  else
  {
    Console.WriteLine("\n===== Pending Tasks =====");
    for (int i = 0; i < titles.Count; i++)
    {
      if (!completedTasks[i])
      {
        Console.WriteLine($"{i}. {tasks[i]} - Description: {descriptions[i]} - Due date: {dueDates[i]}");
      }
    }
  }
}

static void ListCompletedTasks()
{
  if (tasks.Count <= 0)
  {
    Console.WriteLine($"No tasks found!");
  }
  else
  {
    Console.WriteLine("\n===== Completed Tasks =====");
    for (int i = 0; i < titles.Count; i++)
    {
      if (completedTasks[i])
      {
        Console.WriteLine($"{i}. {tasks[i]} - Description: {descriptions[i]} - Due date: {dueDates[i]}");
      }
    }
  }
}

static void DeleteTasks()
{
  ListTasks();
  Console.Write("Enter the task number you want to delete: ");
  int taskNumber = int.Parse(Console.ReadLine());

  if (taskNumber > 0 && taskNumber <= titles.Count)
  {
    titles.RemoveAt(taskNumber);
    descriptions.RemoveAt(taskNumber);
    dueDates.RemoveAt(taskNumber);
    completedTasks.RemoveAt(taskNumber);
    Console.WriteLine("Task deleted successfully!");
  }
  else
  {
    Console.WriteLine("Invalid task number.");
  }
}