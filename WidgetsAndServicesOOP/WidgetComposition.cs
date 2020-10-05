using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OOP.Composition {

    class Widget  {

        private Product Product { get; set; }

        public int Id {
            get { return Product.Id; }
            set { Product.Id = value; }
        }
        public string Description {
            get { return Product.Description; }
            set { Product.Description = value; }
        }
        public string Unit {
            get { return Product.Unit; }
            set { Product.Unit = value; }
        }
        public double Price {
            get { return Product.Price; }
            set { Product.Price = value; }
        }

        public string Size { get; set; } = "Medium";
        public string Model { get; set; } = "Basic";

        public Widget() { 
            Product = new Product();  
        }
    }
}
