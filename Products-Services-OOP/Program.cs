using System;

namespace Products_Services_OOP {
    class Program {
        static void Main(string[] args) {
            Products b_widget = new Products("Basic Widget", 10, 2500);
            Products a_widget = new Products("Advanced Widget", 25, 1500);
            Products s_widget = new Products("Supreme Widget", 50, 1000);
            //Products[] product = { b_widget, a_widget, s_widget };



            //foreach (Products pro in product) {
            //    var p = pro.GetRevenue();

            //    Console.WriteLine($" total revenue for products is { p}");
            //}
            Services b_services = new Services("Basic Service", 25, 1000);
            Services a_services = new Services("Priority Service", 50, 550);
            Services s_services = new Services("24x7 Service", 100, 750);

            Sales[] items = { b_widget, a_widget, s_widget, b_services, a_services, s_services };
            foreach(Sales itm in items) {
                var n = itm.Print();
                Console.WriteLine(n);
                
            }
            decimal p = 0;
            foreach (Sales pro in items) {
                
                p = p + pro.GetTotals();
                
            }
            Console.WriteLine($"Total Sales is {p}");
            //var t = b_widget.GetTotals() + a_widget.GetTotals() + s_widget.GetTotals() + b_services.GetTotals() + a_services.GetTotals() + s_services.GetTotals();
            //Console.WriteLine($"Sum of all sales totals is {t}");
            // Console.WriteLine("Total sales of products and services is 240,000");
        }
    }
}
