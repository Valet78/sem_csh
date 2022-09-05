using System;
using System.Globalization;
public class MainClass
{
    
    public static void Main()
    {
        string num_str = "5.25";
        System.Globalization.NumberFormatInfo numFormat = new System.Globalization.NumberFormatInfo();
        numFormat.NumberDecimalSeparator = ".";
        float number = float.Parse(num_str, numFormat);
        Console.WriteLine(number);
        
    }
}