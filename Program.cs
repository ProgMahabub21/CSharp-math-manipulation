using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int j = 0;
        double k=0.0;
        string l;
        // Read and save an integer, double, and String to your variables.
        j = Convert.ToInt32(Console.ReadLine());
        k = Convert.ToDouble(Console.ReadLine());
        l = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine("{0}",i+j);
        // Print the sum of the double variables on a new line.
        double sum =d+k;
        string sum1dec = sum.ToString("N1");                //scaling the output of a variable upto specific range with string func.
        //sum.ToString("0.0");
        Console.WriteLine("{0}",sum1dec);
        // Concatenate and print the String variables on a new line
        
        // The 's' variable above should be printed first.
        Console.WriteLine("{0}",s+l);
    }
}