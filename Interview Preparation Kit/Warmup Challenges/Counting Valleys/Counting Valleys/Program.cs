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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        //variables
        int direction = 0;
        int currentPos = 0;
        int numValleys = 0;


        //Go throguh the entire string
        for(int i = 0; i < s.Length; i++)
        {

            //Transcribe direction
            if(s[i] == 'U')
            {
                direction = 1;
            }
            else
            {
                direction = -1;
            }

            //Move in the direction defined
            currentPos += direction;

            //If the hiker moves back to sea level and the direction is going up
            if(currentPos == 0 && direction == 1)
            {
                numValleys++;
            }
        }

        return numValleys;
    }

    static void Main(string[] args)
    {

        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        /*
        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
        */

        Console.WriteLine(result);
    }
}
