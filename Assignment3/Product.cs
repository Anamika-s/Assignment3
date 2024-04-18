using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Product
    {
        string pcode;
        public string pname;
        int qty_in_stock, discount_allowed;
        static string brand;
        int price;
        public void GetDetails()
        {
            Console.WriteLine("Entter pcode ");
            pcode = Console.ReadLine(); ;
            Console.WriteLine("ENter pname");
            pname = Console.ReadLine();
            Console.WriteLine("Enter qty_in_stock");
            qty_in_stock = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter discount_allowed");
            discount_allowed = byte.Parse(Console.ReadLine());

            Console.WriteLine("enter price");
            price = Int16.Parse(Console.ReadLine());
        }
        static Product()
        {
            brand = "Lewis";
        }
        public void DisplayProducts()
        {
            Console.WriteLine(pcode + " " + pname + " " + qty_in_stock + " " + discount_allowed + " " + price);
        }


    }
}
