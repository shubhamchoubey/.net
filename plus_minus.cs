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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        int total=arr.Length;
        float p,n,z,countp=0,countn=0,countz=0;
       
        int i;
        for(i=0;i<total;i++)
        {
            if ( arr[i] > 0)
                countp+=1;
            else if (arr[i] < 0)
                countn+=1;
            else
                countz+=1;
        }
       // Console.WriteLine(countp);
        p=(countp/total);
        n=(countn/total);
        z=(countz/total);
        Console.WriteLine(p.ToString("N6"));
        Console.WriteLine(n.ToString("N6"));    
        Console.WriteLine(z.ToString("N6"));
    }

    static void Main(string[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        
        plusMinus(arr);
    }
}

