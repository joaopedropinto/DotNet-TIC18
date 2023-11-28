namespace Semana3.Atividade3;

public class Product
{
  public Product(string name, int amount, double price)
  {
    ID = ++productID;
    Name = name;
    Amount = amount;
    Price = price;
  }
  private static int productID { get; set; } = 0;

  public int ID { get; }
  public string Name { get; set; }

  public int Amount { get; set; }

  public double Price { get; set; }
}