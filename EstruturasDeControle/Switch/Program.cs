System.Console.WriteLine("Purchase price: R$600");
System.Console.WriteLine("Number of installments: Min 1 Max 3");
var installments = Convert.ToInt32(Console.ReadLine());

switch(installments)
{
    case 1:
        System.Console.WriteLine($"Price of the installment: R${600 / installments}");
        break;
    case 2:
        System.Console.WriteLine($"Price of the installment: R${600 / installments}");
        break;
    case 3:
        System.Console.WriteLine($"Price of the installment:  R${600 / installments}");
        break;
    default:
        System.Console.WriteLine("Maximum number of installments: 3");
        break;
}   

System.Console.WriteLine("\nType a number:");
int number = Convert.ToInt32(Console.ReadLine());

switch(number % 2)
{
    case 0: 
        System.Console.WriteLine($"{number} is Even");
        break;
    case 1:
        System.Console.WriteLine($"{number} is Odd");
        break;
}