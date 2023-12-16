using System;

class GoodBinaryStringSolution
{
    static void Main(string[] args)
    {
        string[] binaryStrings = {
            "010", "1001", "110011", "1100", "101010",
            "dummy","00dummy", "010xyz", "111", "001100", "010101",
            "11110000", "00001111", "111000", "1010", "0011",
            "010011", "111010", "0001", "1101", "010110"
        };

        foreach (var binaryStr in binaryStrings)
        {
            bool isGood = IsGoodBinaryString(binaryStr);
            string resultStr = isGood ? "Good" : "Not good";
            Console.WriteLine($"{binaryStr} - {resultStr}");
        }
    }
    public static bool IsGoodBinaryString(string binaryString)
    {
        // if binary string starts from 0 the  it immediately violates the second requirment
        if (string.IsNullOrEmpty(binaryString) || binaryString[0] == '0') 
            return false;

        // If the length of binary string is odd then it would nevver satisfy the first condition-
        // i.e. equal number of 1s and 0s
        if (binaryString.Length % 2 != 0) 
            return false;

        int countZero = 0, countOne = 0;

        foreach (char c in binaryString)
        {
            if (c == '0') countZero++;
            else if (c == '1') countOne++;
            else return false;

            if (countOne < countZero) return false;
        }
        return countZero == countOne;
    }
}

