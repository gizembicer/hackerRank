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

class Result
{
    public static void plusMinus(List<int> arr)
    {
        int numberOfNumbers = arr.Count;
        int numberOfPositives = 0, numberOfNegatives = 0, numberOfZeros = 0;
        arr = arr.OrderBy(x => x).ToList();
        int lastIndexOfZero = arr.LastIndexOf(0);
        if (lastIndexOfZero > -1)
        {
            numberOfNegatives = arr.IndexOf(0);
            numberOfZeros = lastIndexOfZero - numberOfNegatives + 1;
            numberOfPositives = numberOfNumbers - lastIndexOfZero - 1;
        }
        else
        {
            numberOfPositives = arr.Where(x => x > 0).Count();
            numberOfNegatives = numberOfNumbers - numberOfPositives;

        }
        decimal proportionOfPositiveValues = (decimal)numberOfPositives / (decimal)numberOfNumbers;
        decimal proportionOfNegativeValues = (decimal)numberOfNegatives / (decimal)numberOfNumbers;
        decimal proportionOfZeros = (decimal)numberOfZeros / (decimal)numberOfNumbers;
        Console.WriteLine(string.Format("{0:N6}", proportionOfPositiveValues));
        Console.WriteLine(string.Format("{0:N6}", proportionOfNegativeValues));
        Console.WriteLine(string.Format("{0:N6}", proportionOfZeros));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
