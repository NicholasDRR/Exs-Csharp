System.Console.WriteLine("Enter the month:");
var month = Console.ReadLine().ToLower();

switch(month)
{
    case"january":
    case"march":
    case"may":
    case"july":
    case"august":
    case"october":
    case"december":
        System.Console.WriteLine("This month has 31 days");
        break;
    case"february":
         System.Console.WriteLine("This month has 28 or 29 days");
        break;
    default:
        System.Console.WriteLine("This month has 30 days");
        break;
}

System.Console.WriteLine("Your post: 1- Manager 2- Developer");
var post = Convert.ToInt32(Console.ReadLine());

switch(post)
{
    case 1:
        System.Console.WriteLine("Welcome manager!");
        break;
    case 2:
        System.Console.WriteLine("1-Jr 2-Pleno 3- Sênior");
        var xp = Convert.ToInt32(Console.ReadLine());
        switch(xp)
        {
            case 1:
                System.Console.WriteLine("Welcome Jr Developer!");
                break;
            case 2:
                System.Console.WriteLine("Welcome Pleno Developer!");
                break;
            case 3:
                System.Console.WriteLine("Welcome Sênior Developer!");
                break;
            default:
                System.Console.WriteLine("Welcome trainee!");
                break;
        }
        break;
    default:
        System.Console.WriteLine("You're in the wrong place");
        break;
}