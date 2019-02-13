using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        //Variables
        int pairs = 0;
        int counter;
        int color;

        for (int i = 0; i < ar.Length; i++)
        {
            //Keep track of duplicates and remove them from the counter
            if (ar[i] != -1)
            {
                counter = 0;
                color = ar[i];
                for (int j = 0; j < ar.Length; j++)
                {
                    if (color == ar[j])
                    {
                        ar[j] = -1;
                        counter++;
                    }
                }

                //Add up number of pairs
                counter /= 2;
                pairs += counter;
            }
        }
        return pairs;
    }

    static void Main(string[] args)
    {
        /*
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        */

        int n = 10;

        int[] ar = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };

        ;
        int result = sockMerchant(n, ar);

        /*
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
