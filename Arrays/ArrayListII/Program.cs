using System.Collections;

ArrayList list = new()
                {
                    "Maria", true, " ", null
                    // 0      1     2    3
                };

int[] numbers = {1, 2, 3};

list.AddRange(numbers);
//"Maria", true, Paulo, " ", null, 3.5, 1, 2, 3
//  0       1     2      3     4    5   6  7  8

list.InsertRange(2, numbers);
//"Maria", true, 1, 2, 3 Paulo, " ", null, 3.5, 
//  0       1    2  3  4   5    S 6    7     8     

list.Add(3.5);
//"Maria", true, " ", null, 3.5
//  0       1     2    3     4

list.Insert(2, "Paulo");
//"Maria", true, Paulo, " ", null, 3.5
//  0       1     2      3     4    5