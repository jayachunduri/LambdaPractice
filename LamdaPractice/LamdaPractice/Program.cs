using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> kayakProducts = products.Where(x => x.Contains("Kayak") || x.Contains("kayak")).ToList();

            //print the kayakProducts to the console using a foreach loop.
            Console.WriteLine("Kayak list");
            foreach (var item in kayakProducts)
                Console.Write(", " +item);

            Console.WriteLine();
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            IEnumerable<string> shoeProducts = products.Where(x => x.Contains("Shoes") || x.Contains("shoes"));

            Console.WriteLine("\nShoe Products");
            //print the shoeProducts to the console using a foreach loop or string.Join().
            Console.WriteLine(string.Join(", ", shoeProducts));

            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.Contains("ball") || x.Contains("Ball")).ToList();

            //print the ballProducts to the console using a foreach loop or string.Join().
            Console.WriteLine("\nBall Products");
            Console.WriteLine(string.Join(", ", ballProducts));

            //sort ballProducts alphabetically and print them to the console.
            Console.WriteLine("\nBall Products in ascending order");
            Console.WriteLine(ballProducts.OrderBy(x => x));

            //add six more items to the products list using .add().
            products.Add("Cricket Bat");
            products.Add("Wickets");
            products.Add("Snow Board");
            products.Add("Roller Skates");
            products.Add("Chess Board");
            products.Add("Chess Coins");


            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine("\nProduct with the longest name");
            Console.WriteLine(products.OrderByDescending(x => x.Length).First());

            //print the product with the shortest name to the console using OrderByDesceding() and the .First() extension.
            Console.WriteLine("\nProduct with the shortest name");
            Console.WriteLine(products.OrderBy(x => x.Length).First());
            Console.WriteLine(products.OrderByDescending(x => x.Length).Last());

            //print the product with the 4th shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine("\nProduct with the 4th shortest name");
            //Console.WriteLine(String.Join(", ", products.OrderBy(x => x.Length)));
            Console.WriteLine(String.Join(", ", products.OrderBy(x => x.Length).Skip(3).Take(1)));
            

            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine("\nBall Product with the 2nd longest name");
            Console.WriteLine(String.Join(", ", ballProducts.OrderByDescending(x => x.Length).Skip(1).Take(1)));

            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            List<string> reverseProducts = products.OrderByDescending(x => x.Length).ToList();

            //print out the reversedProducts to the console using a foreach loop.
            Console.WriteLine("\nReverse Products");
            foreach (var item in reverseProducts)
                Console.Write(item + ", ");

            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.
            Console.WriteLine("\nProducts in the Descending order");
            foreach (var item in products.OrderByDescending(x => x.Length))
                Console.WriteLine(item);
            //Note: you will not use a variable to store your list

            Console.ReadKey();
        }
    }
}