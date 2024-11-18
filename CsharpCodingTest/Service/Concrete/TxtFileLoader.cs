using CsharpCodingTest.Service.Abstract;
using CsharpCodingTest.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CsharpCodingTest.Service.Concrete
{
    public class TxtFileLoader : IFileLoader
    {
        public async Task<List<Trade>> LoadAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                List<Trade> trades = new List<Trade>();

                foreach (var line in File.ReadLines(filePath))
                {
                    var parts = line.Split(';');
                    trades.Add(new Trade
                    {
                        Date = DateTime.Parse(parts[0]),
                        Open = decimal.Parse(parts[1]),
                        High = decimal.Parse(parts[2]),
                        Low = decimal.Parse(parts[3]),
                        Close = decimal.Parse(parts[4]),
                        Volume = long.Parse(parts[5])
                    });
                }

                return trades;
            });
        }
    }
}
