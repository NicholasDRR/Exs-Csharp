System.Console.WriteLine("");
DateTime data_atual = DateTime.Now;
System.Console.WriteLine(($"Data atual: {data_atual}"));
System.Console.WriteLine("");

DateTime data_nova = new DateTime(2023,04, 14, 01, 01, 01);
System.Console.WriteLine($"Data criada: {data_nova}");

System.Console.WriteLine("");

System.Console.WriteLine($"Data Atual ano: {data_atual.Year}");
System.Console.WriteLine($"Data Atual mês: {data_atual.Month}");
System.Console.WriteLine($"Data Atual dia: {data_atual.Day}");
System.Console.WriteLine($"Data Atual horas: {data_atual.Hour}");
System.Console.WriteLine($"Data Atual minutos: {data_atual.Minute}");
System.Console.WriteLine($"Data Atual segundos: {data_atual.Second}");
System.Console.WriteLine($"Data Atual milisegundos: {data_atual.Millisecond}");

//Adicionando valores
System.Console.WriteLine("");
System.Console.WriteLine($"Data atual modificada: {data_atual.AddYears(2)}");
System.Console.WriteLine($"Data atual modificada: {data_atual.AddMonths(1)}");
System.Console.WriteLine($"Data atual modificada: {data_atual.AddDays(3)}");

//Obter dia do ano e da semana
System.Console.WriteLine("");
System.Console.WriteLine($"Dia do ano: {data_atual.DayOfYear}");
System.Console.WriteLine($"Dia da semana: {data_atual.DayOfWeek}");


//Data no formato curto e longo
System.Console.WriteLine("");
System.Console.WriteLine($"Data Formato Longo: {data_atual.ToLongDateString()}");
System.Console.WriteLine($"Data Formato Curto: {data_atual.ToShortDateString()}");

//Horário no formato curto e longo
System.Console.WriteLine("");
System.Console.WriteLine($"Horário Formato Longo: {data_atual.ToLongTimeString()}");
System.Console.WriteLine($"Horário Formato Curto: {data_atual.ToShortTimeString()}");