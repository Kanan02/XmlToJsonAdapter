using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using XmlJsonAdapter.Abstractions;

namespace XmlJsonAdapter.Adapters
{
    public class XmlToJsonAdapter : IXmlReadable
    {
        private IJsonReadable _json;
        public XmlToJsonAdapter(IJsonReadable json)
        {
            _json = json;
        }
        public void ReadXmlData(string filename)
        {
            _json.LoadJson(filename);
        }
        public void ShowData()
        {
            _json.ShowData();
        }
    }
}
