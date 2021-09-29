using System;
using System.Collections.Generic;
using System.Text;
using XmlJsonAdapter.Abstractions;

namespace XmlJsonAdapter.Classes
{
    public class User
    {
        public void ManageFile(IXmlReadable reader,string filename)
        {
            reader.ReadXmlData(filename);
            reader.ShowData();
        }
    }
}
