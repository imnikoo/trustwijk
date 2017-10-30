using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Troostwik.Context;
using Troostwik.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Troostwik
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Item item1 = new Item()
                {
                    Cost = 50,
                    Name = "Computer"
                };
                Item item2 = new Item()
                {
                    Cost = 110,
                    Name = "Big computer"
                };

                db.Items.Add(item1);
                db.Items.Add(item2);

                Sale sale = new Sale()
                {
                    Items = new List<Item> { item1, item2 },
                    Name = "Morning sale",
                    Sum = 160,
                    Time = DateTime.Now,
                    AdditionalInformation = "This is curious"
                };

                db.Sales.Add(sale);
                db.SaveChanges();
            }
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
