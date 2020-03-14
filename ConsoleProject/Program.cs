using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            sellerbo boi = new sellerbo();
            ItemBo bi = new ItemBo();
            BusinessObject b = new BusinessObject();
            while (true)
            {
                Console.WriteLine("***Welcome To e-Mart***");
                Console.WriteLine("1.Buyer");
                Console.WriteLine("2.Seller");
                Console.WriteLine("3.Admin");

                int ch = int.Parse(Console.ReadLine());
                string username;
                string id;
                //  string fname;
                // string lname;
                string email;
                int phn;
                //  string rpass;
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("1.Login");
                        Console.WriteLine("2.Register");
                        int n = int.Parse(Console.ReadLine());
                        if (n == 1)
                        {
                            Console.WriteLine("Enter name:");
                            string ur = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string pa = Console.ReadLine();
                            //bool status= b.login(ur,pa);
                            // if (status == true)
                            // {
                            boi.additem();
                            bi.display();
                            //}
                            //else
                            //{
                            //    Console.WriteLine("Invalid");
                            //}
                            //while (true)
                            //{
                            //    Console.WriteLine("1.Display My Profile ");
                            //    Console.WriteLine("2.Search An Item");
                            //    Console.WriteLine("3.Add To Cart");
                            //    int ch2 = int.Parse(Console.ReadLine());
                            //    switch (ch2)
                            //    {
                            //        case 1:
                            //            b.display();
                            //            break;
                            //        case 2:
                            //            bi.display();
                            //            break;
                            //        case 3:
                            //            break;
                            //    }
                            //}

                        }
                        else if (n == 2)
                        {

                            Console.WriteLine("Enter id:: ");
                            id = (Console.ReadLine());
                            Console.WriteLine("Enter Username");
                            username = Console.ReadLine();
                            Console.WriteLine("Email:");
                            email = Console.ReadLine();
                            Console.WriteLine("Phone Number:");
                            phn = int.Parse(Console.ReadLine());
                            Console.WriteLine("Password:");
                            DateTime d = DateTime.Now;
                            var pass = Console.ReadLine();
                            //if (pass.Length < 8 || pass.Length > 16)
                            //    Console.WriteLine("Invalid Length");
                            //else if (!pass.Any(char.IsDigit))
                            //    Console.WriteLine("Needs A Digit");
                            //else if (!pass.Any(char.IsLower))
                            //    Console.WriteLine("Needs A LowerCase");
                            //else if (!pass.Any(char.IsUpper))
                            //    Console.WriteLine("Needs A UpperCase");
                            b.reg(id, username, email, phn, d, pass);


                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break;
                    case 2:
                        Console.WriteLine("1.Login");
                        Console.WriteLine("2.Register");
                        int n1 = int.Parse(Console.ReadLine());
                        if (n1 == 1)
                        {
                            Console.WriteLine("Enter name:");
                            string ur = Console.ReadLine();
                            Console.WriteLine("Enter Password");
                            string pa = Console.ReadLine();
                            b.login(ur, pa);

                        }
                        else if (n1 == 2)
                        {

                            Console.WriteLine("Enter id:: ");
                            id = (Console.ReadLine());
                            Console.WriteLine("Enter Username");
                            username = Console.ReadLine();
                            Console.WriteLine("Email:");
                            email = Console.ReadLine();
                            Console.WriteLine("Phone Number:");
                            phn = int.Parse(Console.ReadLine());
                            Console.WriteLine("Password:");
                            DateTime d = DateTime.Now;
                            var pass = Console.ReadLine();
                            //if (pass.Length < 8 || pass.Length > 16)
                            //    Console.WriteLine("Invalid Length");
                            //else if (!pass.Any(char.IsDigit))
                            //    Console.WriteLine("Needs A Digit");
                            //else if (!pass.Any(char.IsLower))
                            //    Console.WriteLine("Needs A LowerCase");
                            //else if (!pass.Any(char.IsUpper))
                            //    Console.WriteLine("Needs A UpperCase");



                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break;
                    // seller();
                    //break;
                    case 3:
                        //   Admin();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }
    }
}
