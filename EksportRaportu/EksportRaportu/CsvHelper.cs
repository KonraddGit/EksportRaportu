using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace ReportExport
{
    public class CsvHelper
    {
        public void TransformToCsv(string input)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            const string XSL_FILE = "xslFile.xsl";
            xslt.Load(XSL_FILE);
            xslt.Transform(input, "output.csv");
        }
    }
}
