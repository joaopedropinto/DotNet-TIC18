using Semana3.Atividade3;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

class Program
{
  static void Main()
  {
    App app = new App();
    app.Manu();
  }
}

