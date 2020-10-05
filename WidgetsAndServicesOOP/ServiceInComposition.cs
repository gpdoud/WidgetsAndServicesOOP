using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OOP.Composition {

    class Service {

        private Product Product { get; set; }

        public int WidgetId { get; set; }
        public int ServiceYears { get; set; } = 1;

        public Service() {
            Product = new Product();
        }
    }
}
