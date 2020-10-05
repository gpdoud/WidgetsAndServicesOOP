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

        public string Size { get; set; } = "Medium";
        public string Model { get; set; } = "Basic";

        public Widget() { 
            Product = new Product();  
        }
    }
}
