using System.Collections;

//var list = new ArrayList(5);
//ArrayList list = new ArrayList(5);

//ArrayList list = new();
ArrayList list = new() 
                {
                    "Gabriel", 4.5, true, " ", null
                };


//list.Add("Gabriel");
//list.Add(4.5);
//list.Add(5);
//list.Add(true);
//list.Add(" ");
//list.Add(null);


for(int i=0; i<list.Count; i++)
{
    System.Console.WriteLine(list[i]);
}


