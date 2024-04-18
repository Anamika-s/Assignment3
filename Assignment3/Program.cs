namespace Assignment3
{
    internal class Program
    {
        static List<Product> products = new List<Product>();
        static List<Product> orders = new List<Product>();
        static void Main(string[] args)
        {
           
            Console.WriteLine("Identfy yourself");
            string userType = Console.ReadLine();
            switch (userType)
            {
                case "admin":
                    {
                        string c = "y";
                        {
                            while (c == "y")
                            {
                                int choice = DisplayAdminMenu();
                                switch (choice)
                                {

                                    case 1:
                                        {
                                            string ch = "y";
                                            Product product;
                                            while (ch == "y")
                                            {

                                                product = new Product();
                                                product.GetDetails();
                                                products.Add(product);
                                                Console.WriteLine("Add more");
                                                ch = Console.ReadLine();
                                            }
                                            Console.WriteLine("Repeat");
                                            c = Console.ReadLine();
                                            break;
                                        }
                                    case 2:

                                        {
                                            foreach (Product product in products)
                                            {
                                                product.DisplayProducts();
                                            }
                                            break;
                                        }
                                }
                            }
                            break;
                        }

                    }
                     
                    
                case "customer":
                    {
                        int choice = DisplayCustomerMenu();
                         switch(choice)
                        {
                            case 1:
                                {
                                    string ch = "y";
                                    while (ch == "y")
                                    {
                                        Console.WriteLine("Enter Prodcut name ");
                                        string pName = Console.ReadLine();
                                        Product product = SearchProduct(pName);
                                        if (product != null)
                                        {
                                            orders.Add(product);
                                        }
                                        Console.WriteLine("Wnt to order more product?")
                                            ;
                                        ch = Console.ReadLine();
                                    }
                                    
                                    break;
                                }
                                case 2:
                                {
                                    foreach(Product product in orders)
                                    { product.DisplayProducts(); }

                                    break;
                                }
                                case 3:
                                {
                                    Console.WriteLine("Enter Prodcut name ");
                                    string pName = Console.ReadLine();
                                    Product product = SearchProduct(pName);
                                    product.DisplayProducts();
                                    break;
                                }
                        }
                        break;
                    }
            

            }
        }
        
        public static int DisplayAdminMenu()
        {
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Diaplay List of Products");
            int choice = byte.Parse(Console.ReadLine());
            return choice;
        }
        static int DisplayCustomerMenu()
        {
            Console.WriteLine("1. Order Product");
            Console.WriteLine("2. Get Bill");
            Console.WriteLine("3. Search Product");
            int choice = byte.Parse(Console.ReadLine());
            return choice;

        }

        static Product SearchProduct(string name)
        {
            Product product = null;
            foreach(Product temp in products)
            {
                if(product.pname == name)
                {
                    return temp;
                    break;
                }
            }
            return product; 
        }
    }
}