// 1)
//int largest = 0;
//
//for (int times = 1; times <= 3; times++)
//{
//    System.Console.WriteLine("Enter a number");
//    int number = Convert.ToInt32(Console.ReadLine());
//    if (number > largest)
//    {
//        largest = number;
//    }
//}
//System.Console.WriteLine($"The largest number is: {largest}");

// 2)




// 3)
//var number = 1;
//var sum = 0;
//while (number <= 10)
//{
//    System.Console.Write($"{number} ");
//    sum += number;
//    number++;
//}
//System.Console.WriteLine($": {sum}");


//int number = 1;
//int sum = 0;
//do
//{
//    sum += number;
//    System.Console.Write(number +" ");
//    number++;
//}
//while(number <= 10);
//System.Console.WriteLine($": {sum}");

//int sum = 0;
//for (int number = 1; number <= 10; number++)
//{
//    sum += number;
//    System.Console.Write(number + " ");
//}
//System.Console.WriteLine($": {sum}");

// 4)

while (true)
{
    System.Console.WriteLine("\nEnter a number (999 to stop)");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 999)
        break;
    if (number > 0)
    {   
        System.Console.WriteLine($"\nMultiplication table of {number}");
        for (int init = 1; init <= 10; init++)
        {
            System.Console.WriteLine($"{number} x {init} = {number * init}");
        }
    }
    else
        System.Console.WriteLine("Enter a number greater than 0");
}