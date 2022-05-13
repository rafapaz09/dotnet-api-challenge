using dotnet_api_challenge.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Text;
using CsvHelper;
using dotnet_api_challenge.Core.Domain;
using System.Globalization;

namespace dotnet_api_challenge.Data
{
    public class Seeder
    {
        
        public static void SeedData(AppDbContext context)
        {
            using (TextReader reader = new StreamReader($"{AppDomain.CurrentDomain.BaseDirectory}Data\\002.csv", Encoding.UTF8))
            {
                CsvReader csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);      
                var orders = csvReader.GetRecords<Orders>().ToArray();
                context.Orders.AddRange(orders);
                context.SaveChanges();
            }
            
        }

    }
}
