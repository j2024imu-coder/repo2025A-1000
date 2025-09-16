
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

public class DataListIoTest
{

    public static void Main()
    {
        var resData = new byte[] { 0xAA, 0xBB, 0x031, 0x32, 0x33, 0x34, 0x35 };
        List<byte> listData = new List<byte>(resData);

        Console.WriteLine("Check the data.");
        foreach (byte b in listData)
        {
            Console.Write("{0:X2}", b);
            Console.Write("({0}) ", (char)b);
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}

