using System;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Overloaded Operators *****\n");

            // 1 Make points.
            Point ptOne = new Point(100, 100);
            Point ptTwo = new Point(40, 40);
            Point ptThree = new Point(90, 5);
            Point ptFour = new Point(0, 500);
            Point biggerPoint = ptOne + 10;

            // 2 Print points.
            Console.WriteLine("ptOne = {0}", ptOne);
            Console.WriteLine("ptTwo = {0}", ptTwo);
            Console.WriteLine("ptThree = {0}", ptThree);
            Console.WriteLine("ptFour = {0}", ptFour);
            Console.WriteLine("biggerPoint = {0}", biggerPoint);
            Console.WriteLine();


            // 3 Print operations on points.
            // 3.1 Add the points to make a bigger point.
            Console.WriteLine("ptOne + ptTwo: {0} ", ptOne + ptTwo);

            // 3.2 Subtract the points to make a smaller point.
            Console.WriteLine("ptOne - ptTwo: {0}", ptOne - ptTwo);

            // 3.3 Use change overloads.
            Console.WriteLine("ptOne + 10 = {0}", biggerPoint);
            Console.WriteLine("10 + biggerPoint = {0}", 10 + biggerPoint);

            // 3.4 Use += and -= shorthand operators.
            Console.WriteLine("ptThree += ptTwo: {0}", ptThree += ptTwo);
            Console.WriteLine("ptFour -= ptThree: {0}", ptFour -= ptThree);
            Console.ReadLine();
        }
    }
}
