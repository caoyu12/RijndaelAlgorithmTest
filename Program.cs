using System;

namespace RijndaelAlgorithmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input: Encrypt or Decrypt?");
                Console.WriteLine("     1 - Encrypt Data");
                Console.WriteLine("     2 - Decrypt Data");
                var input = Console.ReadLine();
                int i;
                if (!int.TryParse(input, out i) || (i != 1 && i != 2))
                {
                    Console.WriteLine("Invalid input. Only accept 1 or 2!");
                }
                Console.WriteLine("Input the target text then press enter...");
                var msg = Console.ReadLine();
                if (i.Equals(1))
                {
                    Console.WriteLine("Encrypted text here:");
                    Console.WriteLine(Encryption.EncyrptData(msg));
                }
                else
                {
                    try
                    {
                        var result = Encryption.DecryptData(msg);
                        Console.WriteLine("Decrypted text here:");
                        Console.WriteLine(result);
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
