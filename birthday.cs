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

class Solution {

    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar)
    {
        int a=ar.Max(),count=0;
       // Console.WriteLine(a);
        for(int i=0;i<ar.Length;i++)
        {
           if(ar[i]==a)
               count+=1;
        }
        return count;
    }

    static void Main(string[] args) 
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

