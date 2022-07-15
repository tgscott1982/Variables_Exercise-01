using System;
using System.Collections.Generic;

namespace Variables_Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            // TODO: Declare 3 constansts

            const int FinalFantasy = 7;
            const decimal Bday = 7.16m;
            const string HP = "IsolemnlyswearthatImuptonogood";


            #region Types
            // string
            // char
            // bool
            // int
            // double
            // decimal
            #endregion

            // TODO: Declare a variable for each of the types above
            // Make sure to use C# naming convention best practices 
            string a;
            char b;
            bool c;
            int d;
            double e;
            decimal f;
            // TODO: Initialize each of the variables with a value
            a = "FinalFantasy7";
            b = 's';
            c = false;
            d = 82;
            e = 10.2;
            f = 1.234567890m;
            // TODO: Write out each of the variables to the Console 
            Console.WriteLine($"{a}, {b}, {c}, {d}, {e}, {f}");

        }

    }
}
