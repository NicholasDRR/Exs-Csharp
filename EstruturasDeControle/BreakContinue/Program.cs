for (;;)
{
    System.Console.WriteLine("Type something (X to stop)");
    var option = Console.ReadLine();
    if (option.ToUpper() == "X"){
        break;
    }
}

for (int x = 0; x <= 10; x++)
{
    if (x == 4)
        continue;
    System.Console.WriteLine("X: "+ x);
}