using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XmlJsonAdapter.Abstractions
{
    public interface IXmlReadable
    {
      
        public void ReadXmlData(string filename);
        public void ShowData();
    }
}
