using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.OOP.Inheritance {

    class Widget : Product {

        public string Size { get; set; } = "Medium";
        public string Model { get; set; } = "Basic";

        public Widget() : base() { }
    }
}
