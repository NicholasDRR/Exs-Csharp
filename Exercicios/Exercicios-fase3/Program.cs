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

//System.Console.WriteLine("Enter A value: ");
//int a = Convert.ToInt32(Console.ReadLine());
//
//System.Console.WriteLine("Enter B value: ");
//int b = Convert.ToInt32(Console.ReadLine());
//
//System.Console.WriteLine("Enter C value: ");
//int c = Convert.ToInt32(Console.ReadLine());
//
//var delta = b * b - 4 * a * c;
//
//var x1 = (int) (-b + Math.Sqrt(delta) ) / 2 * a;
//var x2 = (int) (-b - Math.Sqrt(delta) ) / 2 * a;
//
//System.Console.WriteLine($"X1: {x1}");
//System.Console.WriteLine($"X1: {x2}");



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

//while (true)
//{
//    System.Console.WriteLine("\nEnter a number (999 to stop)");
//    int number = Convert.ToInt32(Console.ReadLine());
//    if (number == 999)
//        break;
//    if (number > 0)
//    {   
//        System.Console.WriteLine($"\nMultiplication table of {number}");
//        for (int init = 1; init <= 10; init++)
//        {
//            System.Console.WriteLine($"{number} x {init} = {number * init}");
//        }
//    }
//    else
//        System.Console.WriteLine("Enter a number greater than 0");
//}

// 5)
//string answer;
//
//do
//{
//    System.Console.WriteLine("\nWhich instruction to exit a loop? ? (X to exit)");
//    System.Console.WriteLine("a. quit");
//    System.Console.WriteLine("b. continue");
//    System.Console.WriteLine("c. break");
//    System.Console.WriteLine("d. exit");
//    answer = Console.ReadLine();
//}
//while(answer.ToUpper() != "C" && answer.ToUpper() != "X");

// 6)

//for (int init = 10; init <= 20; init++)
//{
//    if (init == 16)
//        continue;
//    if (init % 2 == 0)
//        System.Console.WriteLine($"Even number: {init}");
//
//}

//for (int init = 10; init <= 20; init+=2)
//{
//    if (init == 16)
//        continue;
//    if (init % 2 == 0)
//        System.Console.WriteLine($"Even number: {init}");
//
//}

//int init = 10;
//
//do
//{
//    if (init % 2 == 0)
//        System.Console.WriteLine($"Even number: {init}");
//    init++;
//}
//while(init <= 20);

// 7)

//System.Console.WriteLine("Number of rows:"); 
//int rows = Convert.ToInt32(Console.ReadLine());
//var asterisk = "*";
//
//for (int init = 1; init <= rows; init++)
//{
//    for (int second = 1; second <= init; second++)
//        System.Console.Write(asterisk);
//    System.Console.WriteLine();
//}

// 8)
//System.Console.WriteLine("Enter a number:");
//var number = Convert.ToInt32(Console.ReadLine());
//System.Console.Write($"Factorial of {number}: ");
//int factorial = 1;
//for (; number > 0; number--)
//{
//    factorial *= number;
//}
//System.Console.Write(factorial);

// 9)
// 2 ao 6
//var init = 2;
//do
//{  
//    var second = 1;
//    System.Console.WriteLine($"Multiplication table of {init}");
//    do
//    {
//        System.Console.WriteLine($"{init} x {second} = {init * second}");
//        second++;
//    }
//    while(second <= 10);
//    System.Console.WriteLine();
//    init++;
//}
//while(init <= 6);

// 10)

//while (true)
//{
//    System.Console.WriteLine("\nEnter your grade: (999 to stop)");
//    var grade = Convert.ToInt32(Console.ReadLine());
//    if (grade == 999)
//        break;
//    switch(grade)
//    {
//        case 10:
//            System.Console.WriteLine($"{grade}: A+");
//            break;
//        case 9:
//            System.Console.WriteLine($"{grade}: A");
//            break;
//        case 8:
//        case 7:
//            System.Console.WriteLine($"{grade}: B");
//            break;
//        case 6:
//            System.Console.WriteLine($"{grade}: C");
//            break;
//        case 5:
//            System.Console.WriteLine($"{grade}: E");
//            break;
//        case 4:
//        case 3:
//        case 2:
//        case 1:
//        case 0:
//            System.Console.WriteLine($"{grade}: F");
//            break;
//        default:
//            System.Console.WriteLine($"{grade} is invalid!");
//            break;
//    }
//}

// 11)

//System.Console.WriteLine("Enter 1.number: ");
//var number = Convert.ToInt32(Console.ReadLine());
//
//System.Console.WriteLine("Choose a operator: (+, -, /, *)");
//var nuoperator = Console.ReadLine();
//
//System.Console.WriteLine("Enter 2.number: ");
//var number2 = Convert.ToInt32(Console.ReadLine());
//
//switch (nuoperator)
//{
//    case "+":
//        System.Console.WriteLine($"{number} + {number2} = {number + number2}");
//        break;
//    case "-":
//        System.Console.WriteLine($"{number} - {number2} = {number - number2}");
//        break;
//    case "/":
//        float division;
//        if (number == 0 || number2 ==0)
//        {
//            System.Console.WriteLine("Division by zero: 0");
//        }
//        else
//        {
//            division = (float) number / (float) number2;
//            System.Console.WriteLine($"{number} / {number2} = {division}");
//        }
//        break;
//    case "*":
//        System.Console.WriteLine($"{number} * {number2} = {number * number2}");
//        break;
//}