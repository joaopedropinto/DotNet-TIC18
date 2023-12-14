namespace Semana3.Atividade3;

public class App
{
  List<Product> stock = new List<Product>();
  public void Menu()
  {
    while (true)
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

  public enum TypeTransfer
  {
    In,
    Out
  }
  public void CreateProduct()
  {
    try
    {
      Console.Write("Enter product name: ");
      string name = Console.ReadLine();

      Console.Write("Enter amount: ");
      int amount = int.Parse(Console.ReadLine());

      Console.Write("Enter price(unit): ");
      double price = double.Parse(Console.ReadLine());

      stock.Add(new Product(name, amount, price));
      Console.WriteLine($"Product created sucesfully");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
  public void ConsultProduct()
  {
    try
    {
      Console.WriteLine($"Enter product ID: ");
      int id = int.Parse(Console.ReadLine());

      var product = stock.FirstOrDefault(p => p.ID == id);

      if (product == default)
      {
        throw new Exception("Product not found");
      }
      Console.WriteLine($"Product found: {product.ID} - {product.Name} - {product.Amount} units - R$ {product.Price}.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }


  public void UpdateStock()
  {
    try
    {
      Console.WriteLine($"Enter product ID: ");
      int id = int.Parse(Console.ReadLine());

      var product = stock.FirstOrDefault(p => p.ID == id);

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
        string MovementInput = Console.ReadLine();

        if (MovementInput == "in")
        {
          type = TypeTransfer.In;
          break;
        }
        else if (MovementInput == "out")
        {
          type = TypeTransfer.Out;
          break;
        }
        else
        {
          Console.WriteLine("Wrong type of movement. Try again.");
        }

      }while(true);

      if (type == TypeTransfer.In){
        product.Amount += amount;
        Console.WriteLine($"Stock updated: {product.Amount} units.");
      }
      else
      {
        if (amount > product.Amount)
        {
          throw new InvalidOperationException("Insufficient stock");
        }
        product.Amount -= amount;
        Console.WriteLine($"Stock updated: {product.Amount} units.");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
  public void ReportBelowLimit()
  {
    try
    {
      Console.WriteLine($"Enter limit: ");
      int limit = int.Parse(Console.ReadLine());

      var productsBelowLimit = stock.Where(p => p.Amount < limit).ToList();

      Console.WriteLine($"Products with amount below {limit}: ");
      foreach (var product in productsBelowLimit)
      {
        Console.WriteLine($"{product.ID} - {product.Name} - {product.Amount} units - R$ {product.Price}.");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }

  public void ReportProductsBetweenValues()
  {
    try
    {
      Console.WriteLine($"Enter min value: ");
      double min = double.Parse(Console.ReadLine());

      Console.WriteLine($"Enter max value: ");
      double max = double.Parse(Console.ReadLine());

      var productsBetweenValues = stock.Where(p => p.Price >= min && p.Price <= max).ToList();

      Console.WriteLine($"Products with price between {min} and {max}: ");
      foreach (var product in productsBetweenValues)
      {
        Console.WriteLine($"{product.ID} - {product.Name} - {product.Amount} units - R$ {product.Price}.");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }

  public void ReportTotalStockValue()
  {
    try
    {
      double valueTotalStock = stock.Sum(p => p.Amount * p.Price);
      Console.WriteLine($"Total stock value: R$ {valueTotalStock}.");

      foreach (var product in stock)
      {
        Console.WriteLine($"{product.Name} - Total value: R$ {product.Amount * product.Price}.");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
}