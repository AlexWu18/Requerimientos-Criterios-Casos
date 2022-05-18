using System;
using System.Text;

public static class NumeroArab
{
    public static Dictionary<char, int> RomanANumber;    //Dictionary that have values in Roman
    public static Dictionary<int, string> NumberARoman;  //Dictionary in Roman

    static NumeroArab()
    {
        RomanANumber = new Dictionary<char, int> //Define the Ditionary
        {
            {'I', 1 }, {'V', 5 }, {'X', 10 },
            {'L', 50 }, {'C', 100 }, {'D', 500 }, {'M', 1000 },

        };

        NumberARoman = new Dictionary<int, string> //Define the Ditionary
        {
            {1000,"M" },{900, "CM"},{500, "D"},{400, "CD"},
            {100, "C"},{90, "XC"},{50, "L"},{40, "XL"},{10, "X"},
            {9, "IX"},{5, "V"},{4, "IV"},{1, "I"},
        };
    }

    public static string To(int numero)
    {
        var roman = new StringBuilder();
        foreach(var Cosa in NumberARoman)
        {
            while (numero >= Cosa.Key) 
            { 
                roman.Append(Cosa.Value);
                numero -= Cosa.Key;
            }
        }

    }


}