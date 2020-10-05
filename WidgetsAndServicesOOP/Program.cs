using CSharp.OOP;
using CSharp.OOP.Inheritance;

using System;

namespace WidgetsAndServicesOOP {
    class Program {
        static void Main(string[] args) {

            var products = new Product[] {
                new Widget() { Id = 1, Description = "Small, Basic Widget", Price = 50, Model = "Basic", Size = "Small" },
                new Widget() { Id = 2, Description = "Med, Adv Widget", Price = 200, Model = "Advanced", Size = "Medium" },
                new Service() { Id = 3, Description = "Service on Widget id 1", Price = 100, ServiceYears = 1, WidgetId = 1 },
                new Service() { Id = 3, Description = "Service on Widget id 2", Price = 200, ServiceYears = 2, WidgetId = 2 }   
            };

            foreach(var p in products) {
                Console.WriteLine($"Id[{p.Id}], Desc[{p.Description}], Price[{p.Price}]");
            }
        }
    }
}
