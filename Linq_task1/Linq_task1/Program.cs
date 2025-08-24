using Day_01_Demo_Part_02;
using System;
namespace Linq_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = ListGenerators.ProductList;
            var customers = ListGenerators.CustomerList;

            // LINQ - Restriction Operators
            Console.WriteLine("*************LINQ - Restriction Operators*****************\n");

            Console.WriteLine("Task 1: Get all products that are out of stock.");
            #region Task 1: Get all products that are out of stock.
            var result1 = from p in products
                         where p.UnitsInStock == 0
                         select p;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in result1)
            {
                Console.WriteLine(item.ToString());
            }
            var Result1 = products.Where(products => products.UnitsInStock == 0);
            Console.WriteLine("==================================================");
            Console.WriteLine("Method Syntax:");
            foreach (var item in Result1)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 2: Get all products that are in stock and cost more than 3.00 per unit.");
            #region Task 2: Get all products that are in stock and cost more than 3.00 per unit.

            var result2 = from p in products
                         where p.UnitsInStock > 0 && p.UnitPrice > 3.00M
                        select p;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in result2)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Result2 = products.Where(products => products.UnitsInStock > 0 && products.UnitPrice > 3.00M);
            Console.WriteLine("Method Syntax:");
            foreach (var item in Result2)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");



            #endregion

            Console.WriteLine("Task 3: returns digits whose name is shorter than their value.");
            #region Task 3: returns digits whose name is shorter than their value.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var result3 = from a in Arr
                          where a.Length < Array.IndexOf(Arr, a)
                          select a;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in result3)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Result3 = Arr.Where(a => a.Length < Array.IndexOf(Arr, a));
            Console.WriteLine("Method Syntax:");
            foreach (var item in Result3)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            #endregion

            // --------------------------------------------------------------------------------------------------------------
            // LINQ - Element Operators

            Console.WriteLine("*************LINQ - Element Operators*****************\n");

            Console.WriteLine("Task 1: Get first Product out of Stock");
            #region Task 1: Get first Product out of Stock 
            var res1 = (from p in products
                        where p.UnitsInStock == 0
                        select p).First();
            Console.WriteLine("LINQ Query Syntax:");
            Console.WriteLine(res1.ToString());

            Console.WriteLine("==================================================");

            var Res1 = products.Where(products => products.UnitsInStock == 0).First();

            Console.WriteLine("Method Syntax:");
            Console.WriteLine(Res1.ToString());
            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 2: Return the first product whose Price > 1000, unless there is no match, in which case null is returned.");
            #region Task 2: Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            var res2 = (from p in products
                        where p.UnitPrice > 1000M
                        select p).FirstOrDefault();

            Console.WriteLine("LINQ Query Syntax:");
            if (res2 != null)
                Console.WriteLine(res2.ToString());
            else
                Console.WriteLine("No match found, returned null.");

            Console.WriteLine("==================================================");

            var Res2 = products.Where(products => products.UnitPrice > 1000M).FirstOrDefault();
            Console.WriteLine("Method Syntax:");

            if (Res2 != null)
                Console.WriteLine(Res2.ToString());
            else
                Console.WriteLine("No match found, returned null.");
            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 3: Retrieve the second number greater than 5");
            #region Task 3: Retrieve the second number greater than 5 
            int[] Arr2 =  { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var res3 = (from a in Arr2
                        where a > 5
                        select a).Skip(1).First();
            Console.WriteLine("LINQ Query Syntax:");
            Console.WriteLine(res3.ToString());
            Console.WriteLine("==================================================");
            var Res3 = Arr2.Where(a => a > 5).Skip(1).First();
            Console.WriteLine("Method Syntax:");
            Console.WriteLine(Res3.ToString());
            Console.WriteLine("==================================================");

            #endregion

            // --------------------------------------------------------------------------------------------------------------
            // LINQ - Ordering Operators

            Console.WriteLine("*************LINQ - Ordering Operators*****************\n");

            Console.WriteLine("Task 1: Sort a list of products by name");
            #region Task 1: Sort a list of products by name

            var res4 = from p in products
                       orderby p.ProductName
                       select p;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res4)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Res4 = products.OrderBy(products => products.ProductName);
            Console.WriteLine("Method Syntax:");
            foreach (var item in Res4)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 2: Uses a custom comparer to do a case-insensitive sort of the words in an array.");
            #region Task 2: Uses a custom comparer to do a case-insensitive sort of the words in an array.
            string[] Arr3 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var res5 = from a in Arr3
                       orderby a.ToLower()
                       select a;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res5)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Res5 = Arr3.OrderBy(a => a.ToLower());
            Console.WriteLine("Method Syntax:");
            foreach (var item in Res5)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 3: Sort a list of products by units in stock from highest to lowest.");
            #region Task 3: Sort a list of products by units in stock from highest to lowest.
            var res6 = from p in products 
                       orderby p.UnitsInStock descending
                       select p;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res6)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Res6 = products.OrderByDescending(p=> p.UnitsInStock);
            Console.WriteLine("Method Syntax:");
            foreach (var item in Res6)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 4: Sort a list of digits, first by length of their name, and then alphabetically by the name itself.");
            #region Task 4: Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            string[] Arr4 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var res7 = from a in Arr4
                       orderby a.Length,a    
                       select a;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res7)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Res7 = Arr4.OrderBy(a=> a.Length).ThenBy(a => a);
            Console.WriteLine("Method Syntax:");
            foreach (var item in Res7)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 5: Sort first by word length and then by a case-insensitive sort of the words in an array.");
            #region Task 5: Sort first by word length and then by a case-insensitive sort of the words in an array.
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var res8 = from w in words
                       orderby w.Length, w.ToLower()
                       select w;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res8)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Res8 = words.OrderBy(w=> w.Length).ThenBy(w=> w.ToLower());
            Console.WriteLine("Method Syntax:");    
            foreach (var item in Res8)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");

            #endregion

            Console.WriteLine("Task 6: Sort a list of products, first by category, and then by unit price, from highest to lowest ");
            #region Task 6: Sort a list of products, first by category, and then by unit price, from highest to lowest 
            var res9 = from p in products 
                       orderby p.Category , p.UnitPrice descending
                       select p;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res9)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Res9 = products.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            Console.WriteLine( "Method Syntax:");
            foreach (var item in Res9)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");

            #endregion

            Console.WriteLine("Task 7: Sort first by word length and then by a case-insensitive descending sort of the words in an array.");
            #region Task 7: Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            string[] Arr5 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var res10 = from a in Arr5
                        orderby a.Length, a.ToLower() descending
                        select a;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res10)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Res10 = Arr5.OrderBy(a => a.Length).ThenByDescending(a => a.ToLower());
            Console.WriteLine("Method Syntax:");
            foreach (var item in Res10)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");

            #endregion

            Console.WriteLine("Task 8: Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.");
            #region Task 8: Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] Arr6 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
              var res11 = from a in Arr6
                        where a.Length > 1 && a[1] == 'i'
                        select a;
            res11 = res11.Reverse();
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res11)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Res11 = Arr6.Where(a => a.Length > 1 && a[1] == 'i').Reverse();
            Console.WriteLine("Method Syntax:");
            foreach (var item in Res11)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");

            #endregion

            // LINQ – Transformation Operators
            Console.WriteLine("*************LINQ – Transformation Operators*****************\n");

            Console.WriteLine("Task 1: Return a sequence of just the names of a list of products.");
            #region Task 1: Return a sequence of just the names of a list of products.
            var res12 = from p in products
                        select p.ProductName;
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res12)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Res12 = products.Select(p => p.ProductName);
            Console.WriteLine("Method Syntax:");
            foreach (var item in Res12)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 2: Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).");
            #region Task 2: Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            string[] Arr7 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var res13 = from a in Arr7
                        select new { Upper = a.ToUpper(), Lower = a.ToLower() };
            Console.WriteLine(
                "LINQ Query Syntax:");
            foreach (var item in res13)
                {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            var Res13 = Arr7.Select(a => new { Upper = a.ToUpper(), Lower = a.ToLower() });
            Console.WriteLine(
                "Method Syntax:");
            foreach (var item in Res13)
                {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 3: Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.");
            #region Task 3: Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            var res14 = from p in products
                        select new { p.ProductName, p.Category, Price = p.UnitPrice };
                
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res14)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            Console.WriteLine(
                "Method Syntax:");
            var Res14 = products.Select(p => new { p.ProductName, p.Category, Price = p.UnitPrice });
            foreach (var item in Res14)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 4: Determine if the value of ints in an array match their position in the array.");
            #region Task 4: Determine if the value of ints in an array match their position in the array.
            int[] Arr8 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var res15 = from a in Arr8
                        select new { num = a, IsMatch = a == Array.IndexOf(Arr8, a) };
            foreach (var item in res15)
            {
                Console.WriteLine($"{item.num}: {item.IsMatch}");
            }
            Console.WriteLine("==================================================");
            Console.WriteLine("Method Syntax:");
            var Res15 = Arr8.Select(a => new { num = a, IsMatch = a == Array.IndexOf(Arr8, a) });
            foreach (var item in Res15)
            {
                Console.WriteLine($"{item.num}: {item.IsMatch}");
            }
            Console.WriteLine("==================================================");

            #endregion

            Console.WriteLine("Task 5: Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.");
            #region Task 5: Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            
            var res16 = from a in numbersA
                        from b in numbersB
                        where a < b
                        select new { a, b };
            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res16)
            {
                Console.WriteLine($"{item.a} is less than {item.b}");
            }
            Console.WriteLine("==================================================");
            var Res16 = numbersA.SelectMany(a => numbersB, (a, b) => new { a, b }).Where(pair => pair.a < pair.b);
            Console.WriteLine(
                "Method Syntax:");
            foreach (var item in Res16)
            {
                Console.WriteLine($"{item.a} is less than {item.b}");
            }
            Console.WriteLine("==================================================");

            #endregion

            Console.WriteLine("Task 6: Select all orders where the order total is less than 500.00.");
            #region Task 6: Select all orders where the order total is less than 500.00.

            var res17 = from c in customers
                       from o in c.Orders
                       where o.Total < 500.00m
                       select new { c.CompanyName, o.OrderID, o.Total };

            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res17)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("==================================================");
            Console.WriteLine("Method Syntax:");

            var Res17 = customers
                .SelectMany(c => c.Orders, (c, o) => new { c.CompanyName, o.OrderID, o.Total })
                .Where(x => x.Total < 500.00m);

            foreach (var item in Res17)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("==================================================");
            #endregion

            Console.WriteLine("Task 7: Select all orders where the order was made in 1998 or later.");
            #region Task 7: Select all orders where the order was made in 1998 or later.

            var res18 = from c in customers
                       from o in c.Orders
                       where o.OrderDate.Year >= 1998
                       select new { c.CompanyName, o.OrderID, o.OrderDate };

            Console.WriteLine("LINQ Query Syntax:");
            foreach (var item in res18)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("==================================================");
            Console.WriteLine("Method Syntax:");

            var Res18 = customers
                .SelectMany(c => c.Orders, (c, o) => new { c.CompanyName, o.OrderID, o.OrderDate })
                .Where(x => x.OrderDate.Year >= 1998);

            foreach (var item in Res18)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("==================================================");
            #endregion

        }
    }
}