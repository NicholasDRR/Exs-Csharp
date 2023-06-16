using _Interfaces;
using Json;
using Xml;

SaveJson json = new();

json.Save();
json.Name();


SaveXml xml = new();

xml.Save();
xml.Name();

ISave saveFiles = new SaveJson();
saveFiles.Compact();
