using System;
using System.Collections.Generic;
using System.Text;

namespace Products_Services_OOP {
    public class Sales {
        public string name;
        public virtual string Print() {
            return $"{this.name}";
        }
        public virtual decimal GetTotals() {
            return 0;
        }
    }
}
