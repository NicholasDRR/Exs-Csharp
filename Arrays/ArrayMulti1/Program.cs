int[,] a= new int[2,2] {{10,11}, {12,13}};

int[,] b;
b = new int[2, 2];

b[0, 0] = 0;
b[0, 1] = 1;
b[1, 0] = 2;
b[1, 1] = 3;

System.Console.WriteLine(a[0, 0]);
System.Console.WriteLine(a[0, 1]);
System.Console.WriteLine(a[1, 0]);
System.Console.WriteLine(a[1, 1]);


System.Console.WriteLine(b[0, 0]);
System.Console.WriteLine(b[0, 1]);
System.Console.WriteLine(b[1, 0]);
System.Console.WriteLine(b[1, 1]);