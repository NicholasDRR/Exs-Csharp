namespace Xml;
using Base ;
using _Interfaces ;

public class SaveXml : BaseFile, ISave
{
    public void Save()
    {
        System.Console.WriteLine("Save Xml File");
    }
    public override void Name()
    {
        System.Console.WriteLine("Set Xml name");
    }
}
