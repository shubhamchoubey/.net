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

    // Complete the diagonalDifference function below.
    static int diagonalDifference(int[][] arr) 
    {
        int suma=0,order=arr.Length,noa,nob,sumb=0;
        int x=(order+1)/2,y=order-x;
        
        //Console.WriteLine(x);
        for(int i=0;i<order;i++)
        {
            for(int j=0;j<order;j++)
            {
                //if(i==x && j==x)
                  //  suma+=arr[i][j];sumb+=arr[i][j];
                if(j==i)
                { 
                    suma+=arr[i][j];
                   // Console.WriteLine(suma);
                }
                else if(i+j==order-1)
                {
                    sumb+=arr[i][j];
                    //Console.WriteLine(sumb);
                }
            }
        }
        if(order%2!=0)
            sumb+=arr[y][y];
        //Console.WriteLine(arr[y][y]);
       // Console.WriteLine(suma);
        //Console.WriteLine(sumb);
        //noa=Math.Max(suma,sumb);
        //nob=Math.Min(suma,sumb);
        int diff=suma-sumb;
        return Math.Abs(diff);
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}

