var number = 1;

do
{
    System.Console.WriteLine($"Number: {number}");
    number++;
    if (number > 7)
    {
        break;
    }
}
while(number <= 10);

int x = 0;
do 
{ 
    int y = 0; 
    do
    {
        System.Console.WriteLine($"({x},{y})");
        y++;
    }
    while(y < 5);
    x++;
}
while(x < 5);