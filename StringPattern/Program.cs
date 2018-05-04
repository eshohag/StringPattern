using System;

namespace StringPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Three Character:");
            string originalString = Console.ReadLine();
            char[] arrayString = originalString.ToCharArray();
            for (int i = 0; i < originalString.Length; i++)
            {
                try
                {
                    string dh = arrayString[i].ToString();
                    Console.Write(dh);
                    Console.Write(",");

                }
                catch (Exception)
                {
                    throw;
                }
            }
            for (int i = 0; i < originalString.Length; i++)
            {
                for (int j = 0; j < arrayString.Length; j++)
                {
                    if (i != j)
                    {
                        try
                        {
                            Console.Write(arrayString[i]);
                            Console.Write(arrayString[j]);
                            Console.Write(",");
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
            Console.Write(originalString);
            Console.ReadKey();
        }
    }
}
