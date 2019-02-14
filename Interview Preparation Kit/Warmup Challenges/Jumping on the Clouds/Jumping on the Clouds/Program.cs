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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        //variables
        int minJumps = 0;

        //Go through clouds
        for (int i = 0; i < c.Length; i++)
        {
            //Check if near the end of the arraay;
            if (i <= c.Length - 2)
            {
                //If the next two spots is safe, jump there
                if (i < c.Length - 2 && c[i + 2] == 0)
                {
                    //Move an extra position
                    i++;
                }
                //Add minimum jumps
                minJumps++;
            }
        }

        return minJumps;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

        int result = jumpingOnClouds(c);

        /*
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */

        Console.WriteLine(result);
    }
}
