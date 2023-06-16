namespace _Interfaces;

interface ISave
{
    void Save();

    void Compact()
    {
        System.Console.WriteLine("Compressing files");
    }
}