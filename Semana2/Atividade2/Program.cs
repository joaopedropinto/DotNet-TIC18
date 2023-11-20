
List<string> titles = new List<string>();
List<string> descriptions = new List<string>();
List<DateTime> dueDates = new List<DateTime>();
List<bool> completedTasks = new List<bool>();

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
      break;
    case 2:
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
      break;
    case 3:
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
      break;
    case 4:
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
      break;
    case 5:
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
      break;
    case 6:
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
      break;
    case 7:
      Console.Write("Enter the keyword for the search: ");
      string keyword = Console.ReadLine().ToLower();

      Console.WriteLine($"\n===== Tasks containing '{keyword}' =====");
      for (int i = 0; i < titles.Count; i++)
      {
        if (titles[i].ToLower().Contains(keyword) || descriptions[i].ToLower().Contains(keyword))
        {
          Console.WriteLine($"{i}. {tasks[i]} - Description: {descriptions[i]} - Due date: {dueDates[i]} - {(completedTasks[i] ? "[x]" : "[ ]")}");
        }
      }
      break;
    case 8:
      int completedTasksCount = 0;
      int pendingTasksCount = 0;

      for (int i = 0; i < completedTasks.Count; i++)
      {
        if (completedTasks[i])
        {
          completedTasksCount++;
        }
        else
        {
          pendingTasksCount++;
        }
      }

      Console.WriteLine($"\n===== Statistics =====");
      Console.WriteLine($"Completed Tasks: {completedTasksCount}");
      Console.WriteLine($"Pending Tasks: {pendingTasksCount}");

      if (dueDates.Count > 0)
      {
        DateTime oldestTask = dueDates.Min();
        DateTime newestTask = dueDates.Max();

        Console.WriteLine($"Oldest Task: {oldestTask:yyyy/MM/dd}");
        Console.WriteLine($"Newest Task: {newestTask:yyyy/MM/dd}");
      }
      else
      {
        Console.WriteLine("No tasks available for statistics.");
      }
      break;
    case 0:
      Console.WriteLine($"Leaving...");
      return;
    default:
      Console.WriteLine($"Invalid option, try again.");
      break;
  }
}


