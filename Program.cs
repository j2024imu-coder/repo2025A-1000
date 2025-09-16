
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

public class DataListIoTest
{

    public static void Main()
    {
        var resData = new byte[] { 0xAA, 0xBB, 0x01, 0x031, 0x32, 0x33, 0x34, 0x35 };
        Console.WriteLine("Check data:");
        List<byte> listData = new List<byte>(resData);
        Console.WriteLine("Byte (Hex) | Byte (Char)");
        Console.WriteLine("--------------------");

        foreach (byte b in listData)
        {
            string hexValue = b.ToString("X2");
            string charValue;
            if (b >= 32 && b <= 126)  // Check for printable ASCII characters
            {
                charValue = Encoding.ASCII.GetString(new byte[] { b });
            }
            else
            {
                charValue = ".";
            }

            Console.WriteLine($"{hexValue,-10} | {charValue}");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}

