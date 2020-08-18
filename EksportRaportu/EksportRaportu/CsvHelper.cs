using System.Xml.Xsl;

namespace ReportExport
{
    public class CsvHelper
    {
        const string XSL_FILE = "xslFile.xsl";
        public void TransformToCsv(string input)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            
            xslt.Load(XSL_FILE);
            xslt.Transform(input, "output.csv");
        }
    }
}
