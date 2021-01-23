using System;
using System.Collections;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string> urunler = new Dictionary<string>();
            urunler.Add("BİLGİSAYAR");
            urunler.Add("SES KARTI");

            foreach (var item in urunler.Items)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

    }
}

