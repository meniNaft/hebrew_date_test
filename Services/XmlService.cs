using Hebrew_date_test.Models;
using System.Xml.Linq;

namespace Hebrew_date_test.Services
{
    public class XmlService
    {
        private readonly XDocument xDoc;
        private readonly XElement Root;
        private readonly string xmlPath;
        public XmlService()
        {
            xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\Data.xml");
            xDoc =  XDocument.Load(xmlPath);
            Root = xDoc.Root ?? throw new Exception("no root element existing");
        }

        public void AddQuery(Query newQuery)
        {
            var day = new XElement("Day", newQuery.DayInWeek);
            var dayMonth = new XElement("DayMonth", newQuery.DayInMonth);
            var month = new XElement("Month", newQuery.Month);
            var year = new XElement("Year", newQuery.Year);
            var result = new XElement("Result", newQuery.Result);
            var newItem = new XElement("Query", day, dayMonth, month, year, result);
            Root.Add(newItem);
            xDoc.Save(xmlPath);
        }
    }
}
