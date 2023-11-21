using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

List<string> titles = new List<string>();
List<string> descriptions = new List<string>();
List<DateTime> dueDates = new List<DateTime>();
List<DateTime> createdDates = new List<DateTime>();
List<bool> completedTasks = new List<bool>();

while (true)
{
  Console.WriteLine($"\n===== Tasks management system =====\n");
  Console.WriteLine($"1 - Create Task");
  Console.WriteLine($"2 - List Tasks");
  Console.WriteLine($"3 - Mark Task as Completed");
  Console.WriteLine($"4 - List Pending Tasks");
  Console.WriteLine($"5 - List Completed Tasks");
  Console.WriteLine($"6 - Delete Task");
  Console.WriteLine($"7 - Search Task by Keyword");
  Console.WriteLine($"8 - Display Statistics");
  Console.WriteLine($"0 - Exit");

  Console.Write("Choose an option: ");

  int opcao = int.Parse(Console.ReadLine());
  int completedTasksCount = 0;
  int pendingTasksCount = 0;
  int taskNumber;
  switch (opcao)
  {
    //Create Task
    case 1:
      string? titleInput, descriptionInput;
      DateTime dueDateInput, createdDateInput;

      Console.WriteLine($"Enter the task title:");
      titleInput = Console.ReadLine();
      titles.Add(titleInput);

      Console.WriteLine($"Enter the task description:");
      descriptionInput = Console.ReadLine();
      descriptions.Add(descriptionInput);

      Console.WriteLine($"Enter the task due date (dd/mm/yyyy):");
      dueDateInput = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
      dueDates.Add(dueDateInput);

      createdDateInput = DateTime.Now;
      createdDates.Add(createdDateInput);
      completedTasks.Add(false);

      Console.WriteLine($"Task created successfully!");
      break;

    //List tasks
    case 2:
      if (titles.Count <= 0)
      {
        Console.WriteLine($"No tasks found!");
      }
      else
      {
        Console.WriteLine($"\n=======Task list=======");
        for (int i = 0; i < titles.Count; i++)
        {
          Console.WriteLine($"{i}. {titles[i]} - Description: {descriptions[i]} - Created at: {createdDates[i]} -  Due date: {dueDates[i]:dd/MM/yyyy} - {(completedTasks[i] ? "[x]" : "[ ]")}");
        }
      }
      break;

    //Mark as completed
    case 3:
      if (titles.Count <= 0)
      {
        Console.WriteLine($"No tasks found!");
      }
      else
      {
        Console.WriteLine($"\n=======Task list=======");
        for (int i = 0; i < titles.Count; i++)
        {
          Console.WriteLine($"{i}. {titles[i]} - Description: {descriptions[i]} - Created at: {createdDates[i]} - Due date: {dueDates[i]:dd/MM/yyyy} - {(completedTasks[i] ? "[x]" : "[ ]")}");
        }
      }
      Console.Write("\nEnter the task number you want to mark as completed: ");
      taskNumber = int.Parse(Console.ReadLine());

      if (taskNumber >= 0 && taskNumber <= titles.Count)
      {
        completedTasks[taskNumber] = true;
        Console.WriteLine("Task marked as completed!");
      }
      else
      {
        Console.WriteLine("Invalid task number.");
      }
      break;

    //List pending tasks
    case 4:
      if (titles.Count <= 0)
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
            Console.WriteLine($"{i}. {titles[i]} - Description: {descriptions[i]} - Created at: {createdDates[i]} - Due date: {dueDates[i]:dd/MM/yyyy}");
          }
        }
      }
      break;
    //List completed tasks
    case 5:
      if (titles.Count <= 0)
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
            Console.WriteLine($"{i}. {titles[i]} - Description: {descriptions[i]} - Created at: {createdDates[i]} - Due date: {dueDates[i]:dd/MM/yyyy}");
          }
        }
      }
      break;

    //Delete task
    case 6:
      if (titles.Count <= 0)
      {
        Console.WriteLine($"No tasks found!");
      }
      else
      {
        Console.WriteLine($"\n=======Task list=======");
        for (int i = 0; i < titles.Count; i++)
        {
          Console.WriteLine($"{i}. {titles[i]} - Description: {descriptions[i]} - Created at: {createdDates[i]} - Due date: {dueDates[i]:dd/MM/yyyy} - {(completedTasks[i] ? "[x]" : "[ ]")}");
        }
      }
      Console.Write("\nEnter the task number you want to delete: ");
      taskNumber = int.Parse(Console.ReadLine());

      if (taskNumber >= 0 && taskNumber <= titles.Count)
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

    //Search task
    case 7:
      Console.Write("\nEnter the keyword for the search: ");
      string keyword = Console.ReadLine().ToLower();

      Console.WriteLine($"\n===== Tasks containing '{keyword}' =====");
      for (int i = 0; i < titles.Count; i++)
      {
        if (titles[i].ToLower().Contains(keyword) || descriptions[i].ToLower().Contains(keyword))
        {
          Console.WriteLine($"{i}. {titles[i]} - Description: {descriptions[i]} - Created at: {createdDates[i]} - Due date: {dueDates[i]:dd/MM/yyyy} - {(completedTasks[i] ? "[x]" : "[ ]")}");
        }
      }
      break;

    //Display statistics
    case 8:
      completedTasksCount = 0;
      pendingTasksCount = 0;

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

      if (createdDates.Count > 0)
      {
        DateTime oldestTask = createdDates.Min();
        DateTime newestTask = createdDates.Max();

        for(int i = 0; i < createdDates.Count; i++){
          if(createdDates[i] == oldestTask){
            Console.WriteLine($"Oldest Task: {titles[i]} - Description: {descriptions[i]} - Created at: {createdDates[i]} - Due date: {dueDates[i]:dd/MM/yyyy} - {(completedTasks[i] ? "[x]" : "[ ]")}");
          }
          if(createdDates[i] == newestTask){
            Console.WriteLine($"Newest Task: {titles[i]} - Description: {descriptions[i]} - Created at: {createdDates[i]} - Due date: {dueDates[i]:dd/MM/yyyy} - {(completedTasks[i] ? "[x]" : "[ ]")}");
          }
        }
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


