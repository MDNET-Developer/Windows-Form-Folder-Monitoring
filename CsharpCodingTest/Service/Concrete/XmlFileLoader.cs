using CsharpCodingTest.Service.Abstract;
using CsharpCodingTest.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CsharpCodingTest.Service.Concrete
{
    public class XmlFileLoader : IFileLoader
    {
        public async Task<List<Trade>> LoadAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                List<Trade> trades = new List<Trade>();
                var xmlDoc = XDocument.Load(filePath);

                foreach (var element in xmlDoc.Descendants("value"))
                {
                    trades.Add(new Trade
                    {
                        Date = DateTime.Parse(element.Attribute("date")?.Value),
                        Open = decimal.Parse(element.Attribute("open")?.Value),
                        High = decimal.Parse(element.Attribute("high")?.Value),
                        Low = decimal.Parse(element.Attribute("low")?.Value),
                        Close = decimal.Parse(element.Attribute("close")?.Value),
                        Volume = long.Parse(element.Attribute("volume")?.Value)
                    });
                }

                return trades;
            });
        }
    }
}

