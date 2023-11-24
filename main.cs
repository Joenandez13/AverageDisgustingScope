using System;

class Program {
  public static void Main (string[] args) {

    // Initialize variables to keep track of sales totals
    double totalDanielle = 0;
    double totalEdward = 0;
    double totalFrancis = 0;
    double grandTotal = 0;

    // prompt user for initial of salesperson
    while (true)
    {
      Console.WriteLine("Enter salesperson initial (D, E or F) or Z to finish: ");
      char initial = char.ToUpper(Console.ReadKey().KeyChar);
      Console.WriteLine();

      if (initial == 'Z')
      {
        break;
      }
      else if (initial == 'D'|| initial == 'E'|| initial == 'F' )
      {
        //since valid, the prompt the amount of sale
        Console.WriteLine("Enter amount of sale: ");
        double saleAmount;
        if (double.TryParse(Console.ReadLine(), out saleAmount))
        {
          //update the respective salesperson's total
          switch (initial)
          {
          case 'D': 
              totalDanielle += saleAmount;
              break;
          case 'E':
              totalEdward += saleAmount;
              break;
          case 'F':
              totalFrancis += saleAmount;
              break;
          }
          grandTotal += saleAmount;
        }
        else 
        {
          //invalid sale amount, error
          Console.WriteLine("Error: Invalid sale amount. Please enter valid amount.");
          }}
        
        else 
        {
          //invalid initial, error
          Console.WriteLine("Error; Invalid Initial. Please enter valid initial");
          }
        }

    //display grand total
    Console.WriteLine($"Grand total: ${grandTotal}");

    //determine highest total
    string highestSalesperson = "";
    double highestTotal = 0;

    if (totalDanielle > highestTotal)
    {
      highestTotal = totalDanielle;
      highestSalesperson = "D";
    }
    if (totalEdward > highestTotal)
    {
      highestTotal = totalEdward;
      highestSalesperson = "E";
    }
    if (totalFrancis > highestTotal)
    {
      highestTotal = totalFrancis;
      highestSalesperson = "F";
    }
    //display results
    Console.WriteLine($"Highest sale: {highestSalesperson}");
      }
    }
  
