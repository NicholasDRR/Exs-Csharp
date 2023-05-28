namespace datasourcecs;
using studentcs;
using System.Collections.Generic;

public class DataSource
{
    public static List<Student> GetStudents()
    {
        List<Student> students = new()
        {
            new Student{ Name = "Maria", Grade = 8.75 },
            new Student{ Name = "Manoel", Grade = 6.95 },
            new Student{ Name = "Amanda", Grade = 7.25 },
            new Student{ Name = "Carlos", Grade = 6.55 },
            new Student{ Name = "Jaime", Grade = 8.50 },
            new Student{ Name = "Debora", Grade = 5.95 },
            new Student{ Name = "Alicia", Grade = 9.25 },
            new Student{ Name = "Sandra", Grade = 5.55 },
            new Student{ Name = "Marta", Grade = 7.85 },
            new Student{ Name = "SUeli", Grade = 9.15 },
        };
        return students;
        
    }

}