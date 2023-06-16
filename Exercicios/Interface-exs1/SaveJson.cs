namespace Json;
using Base;
using _Interfaces;


public class SaveJson : BaseFile, ISave
{
    public void Save()
    {
         System.Console.WriteLine("Save Json File");
    }
    public override void Name()
    {
        System.Console.WriteLine("Set Json name");
    }
}