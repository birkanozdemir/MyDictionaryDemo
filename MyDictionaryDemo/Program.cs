using System;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Customer Id, Customer Name
            MyDictionary<int, string> customers = new MyDictionary<int, string>();
            customers.Add(1344, "Tolga Demir");
            customers.Add(1468, "Umut Özkan");
            customers.Add(455, "Cengiz Çiftçi");

            //customers.GetCustomers();

            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("Müşteri Adı: " + customers.Values[i] + " Id: " + customers.Keys[i]);
            }
        }
    }
}
