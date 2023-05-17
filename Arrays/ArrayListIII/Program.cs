using System.Collections;

ArrayList list = new()
                {
                    1, 2, 3, 4, 5, 6, 7
                };

list.Remove(3); // Remove item por valor (remove apenas o primeiro elemento encontrado com esse valor)
list.RemoveAt(2); // Remove item por índice
list.RemoveRange(2, 3); // Remove um número de items a partir de um índice

for (int i = 0; i < list.Count; i++)
{
    System.Console.WriteLine(list[i]);
}