using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) 
    {
        /*
         * Write your code here.
         */
        string[] ar=s.Split(':');
        string sx=ar[2].Substring(2);
        string outcv=string.Empty;
        int x;
        if(sx == "PM")
            if(ar[0]=="12")
                outcv="12:"+ar[1]+":"+ar[2].Substring(0,2);
            else if(ar[0]=="24")
               outcv="00:"+ar[1]+":"+ar[2].Substring(0,2);
            else
            {
                x=12+Convert.ToInt16(ar[0]);
                outcv=x+":"+ar[1]+":"+ar[2].Substring(0,2);
            }
        else 
        {
            if(ar[0]=="12")
                outcv="00:"+ar[1]+":"+ar[2].Substring(0,2);
            else
                outcv=ar[0]+":"+ar[1]+":"+ar[2].Substring(0,2);
        }
        return outcv;
    }

    static void Main(string[] args) 
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}

