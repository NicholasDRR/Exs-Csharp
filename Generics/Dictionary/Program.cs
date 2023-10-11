Dictionary<string, int> dic = new();



Console.WriteLine(dic.TryAdd("Person1", 1));
Console.WriteLine(dic.TryAdd("Person2", 2));
dic.Add("Person3", 3);
dic.Add("Person4", 4);

var contains = dic.ContainsKey("Person1");
Console.WriteLine($"Contains key Person1? = {contains}");

dic.Remove("Person1");

var contains2 = dic.ContainsValue(1);
Console.WriteLine($"Contains value 1 = {contains2}");

var getValue = dic.TryGetValue("Person1", out int valueAssociate);
Console.WriteLine($"Person1 has value? {getValue} = {valueAssociate}");

foreach (var item in dic)
{
    Console.WriteLine($"{item.Key} => {item.Value}");
}

dic.Clear();

if (dic.Count() == 0)
{
    Console.WriteLine("Empty dict");
}





Console.ReadKey();
