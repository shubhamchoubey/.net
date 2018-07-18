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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        long n=arr.Length,sum=0;
        //Console.WriteLine(n);
        long[] nwar = new long[n];
        for(int i=0;i<n;i++)
        {
            sum+=arr[i];
        }
        //Console.WriteLine(sum);
        for(int j=0;j<n;j++)
        {   
            sum=sum-arr[j];
            //Console.WriteLine(sum);
            nwar[j]=sum;
            //Console.WriteLine(nwar[j]);
            sum+=arr[j];
        }
              // string.Concat(nwar.Min()," ",nwar.Max());
        Console.WriteLine(nwar.Min()+" "+nwar.Max());
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
    }
}

