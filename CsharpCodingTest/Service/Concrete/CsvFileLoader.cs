using CsharpCodingTest.Service.Abstract;
using CsharpCodingTest.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CsharpCodingTest.Service.Concrete
{
    public class CsvFileLoader : IFileLoader
    {
        public async Task<List<Trade>> LoadAsync(string filePath)
        {
            return await Task.Run(() =>
            {
                List<Trade> trades = new List<Trade>();

                foreach (var line in File.ReadLines(filePath))
                {
                    var columns = line.Split(',');
                    trades.Add(new Trade
                    {
                        Date = DateTime.Parse(columns[0]),
                        Open = decimal.Parse(columns[1]),
                        High = decimal.Parse(columns[2]),
                        Low = decimal.Parse(columns[3]),
                        Close = decimal.Parse(columns[4]),
                        Volume = long.Parse(columns[5])
                    });
                }

                return trades;
            });
        }
    }
}

