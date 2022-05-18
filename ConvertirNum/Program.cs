using System;
using System.Text;

void Main() { }
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

    public static string To(int numero) //Search and evaluate the Roman
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
        return roman.ToString();
    }

    public static int From( string roman)
    {
        // declare Variable
        int total = 0;
        int Actual, Anterior = 0;
        char ActualRoman, AnteriorRoman = '\0';

        for (int i = 0; i < roman.Length; i++) // "For" to locate the char in any string
        {
            ActualRoman = roman[i];
            Anterior = AnteriorRoman != '\0' ? RomanANumber[AnteriorRoman] :'\0';
            Actual = RomanANumber[ActualRoman];

            if (Anterior != 0 && Actual > Anterior)   // Anterior can't be equal to '0' and Actual greater than Anterior
            {
                total = total - (2 * Anterior) + Actual;
            }
            else 
            {
                total += Actual;
            }

            AnteriorRoman = ActualRoman;

        }
        return total;
    
    }
 

}