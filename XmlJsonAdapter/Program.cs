using System;
using XmlJsonAdapter.Abstractions;
using XmlJsonAdapter.Adapters;
using XmlJsonAdapter.Classes;

namespace XmlJsonAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            XmlReader xmlReader = new XmlReader();
            user.ManageFile(xmlReader, "book.xml");
            //-------------------------------------
            //-------------------------------------
            //-------------------------------------
            JsonReader jsonReader = new JsonReader();
            IXmlReadable adapter = new XmlToJsonAdapter(jsonReader);
            user.ManageFile(adapter, "book.json");
        }
    }
}
