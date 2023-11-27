namespace Semana3.Atividade3;
public static class App
{
  private List<Product> stock = new List<Product>();

  public static void Menu()
  {

    while (True)
    {
      Console.WriteLine("\n==== Menu ====");
      Console.WriteLine($"1. Create product");
      Console.WriteLine($"2. Consult product");
      Console.WriteLine($"3. Update stock");
      Console.WriteLine($"4. Report below limit");
      Console.WriteLine($"5. Report products between values");
      Console.WriteLine($"6. Report total stock value");
      Console.WriteLine($"7. Exit");
      Console.WriteLine($"Choose an option: ");

      int option = int.Parse(Console.ReadLine()!);

      switch (option)
      {
        case 1:
          CreateProduct();
          break;
        case 2:
          ConsultProduct();
          break;
        case 3:
          UpdateStock();
          break;
        case 4:
          ReportBelowLimit();
          break;
        case 5:
          ReportProductsBetweenValues();
          break;
        case 6:
          ReportTotalStockValue();
          break;
        case 7:
          Console.WriteLine($"Leaving...");
          return;
        default:
          Console.WriteLine($"Invalid option, try again!");
          break;
      }
    }
  }
  enum TypeTransfer
  {
    In,
    Out
  }
  static void CreateProduct()
  {
    try
    {
      Console.Write($"Enter product ID: ");
      int id = int.Parse(Console.ReadLine());

      if (stock.Any(p => p.id == id))
      {
        throw new InvalidOperationException("Product with the same ID already exists");
      }

      Console.Write("Enter product name: ");
      string name = Console.ReadLine();

      Console.Write("Enter amount: ");
      int amount = int.Parse(Console.ReadLine());

      Console.Write("Enter price(unit): ");
      double price = double.Parse(Console.ReadLine());

      stock.Add((id, name, amount, price));
      Console.WriteLine($"Product created sucesfully");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }

  static void ConsultProduct()
  {
    try
    {
      Console.WriteLine($"Enter product ID: ");
      int id = int.Parse(Console.ReadLine());

      var product = stock.FirstOrDefault(p => p.id == id);

      if (product == default)
      {
        throw new Exception("Product not found");
      }
      Console.WriteLine($"Product found: {product.id} - {product.name} - {product.amount} units - R$ {product.price}.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }

  static void UpdateStock()
  {
    try
    {
      Console.WriteLine($"Enter product ID: ");
      int id = int.Parse(Console.ReadLine());

      var product = stock.FirstOrDefault(p => p.id == id);

      if (product == null)
      {
        throw new Exception("Product not found");
      }

      Console.WriteLine($"Enter amount to update: ");
      int amount = int.Parse(Console.ReadLine());

      TypeTransfer type;

      do
      {
        Console.Write("Enter type of movement (in/out): ");
        string typeOfMovementInput = Console.ReadLine();

        if (typeOfMovementInput == "in")
        {
          type = TypeTransfer.In;
        }
        else if (typeOfMovementInput == "out")
        {
          type = TypeTransfer.Out
        }
        else
        {
          Console.WriteLine("Wrong type of movement. Try again.");
          type = TypeTransfer.In;
        }

      } while (type != TypeTransfer.In && type != TypeTransfer.Out);


      if (type == TypeTransfer.in){
        product.amount += amount;
        Console.WriteLine($"Stock updated: {product.Amount} units.");
      }
      else
      {
        if (amount > product.amount)
        {
          throw new InvalidOperationException("Insufficient stock");
        }
        product.amount -= amount;
        Console.WriteLine($"Stock updated: {product.amount - amount} units.");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
  static void ReportBelowLimit()
  {
    try
    {
      Console.WriteLine($"Enter limit: ");
      int limit = int.Parse(Console.ReadLine());

      var productsBelowLimit = stock.Where(p => p.amount < limit).ToList();

      Console.WriteLine($"Products with amount below {limit}: ");
      foreach (var product in productsBelowLimit)
      {
        Console.WriteLine($"{product.id} - {product.name} - {product.amount} units - R$ {product.price}.");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }

  static void ReportProductsBetweenValues()
  {
    try
    {
      Console.WriteLine($"Enter min value: ");
      double min = double.Parse(Console.ReadLine());

      Console.WriteLine($"Enter max value: ");
      double max = double.Parse(Console.ReadLine());

      var productsBetweenValues = stock.Where(p => p.price >= min && p.price <= max).ToList();

      Console.WriteLine($"Products with price between {min} and {max}: ");
      foreach (var product in productsBetweenValues)
      {
        Console.WriteLine($"{product.id} - {product.name} - {product.amount} units - R$ {product.price}.");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }

  static void ReportTotalStockValue(List<(int id, string name, int amount, double price)> stock)
  {
    try
    {
      double valueTotalStock = stock.Sum(p => p.amount * p.price);
      Console.WriteLine($"Total stock value: R$ {valueTotalStock}.");

      foreach (var product in stock)
      {
        Console.WriteLine($"{product.name} - Total value: R$ {product.amount * product.price}.");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
}
