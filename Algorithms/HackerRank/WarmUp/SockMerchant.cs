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

class SockMerchantSolution
{

    // Complete the sockMerchant function below.
    static int SockMerchant(int n, int[] ar)
    {
        int result = 0;
        var groups = ar.GroupBy(a => a);
        foreach (var group in groups)
        {
            result += group.Count() / 2;
        }

        return result;
    }

    public static void Run()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = SockMerchant(n, ar);

        Console.WriteLine(result);
    }
}