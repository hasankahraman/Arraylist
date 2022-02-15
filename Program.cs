using System;
using System.Collections;
using System.Collections.Generic;

namespace Arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            ArrayList liste = new ArrayList();
            //liste.Add("Hasan");
            //liste.Add(3);
            //liste.Add(false);
            //liste.Add('T');

            //liste içindeki verilere erişim
            //Console.WriteLine(liste[1]);

           // foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            //AddRange
            Console.WriteLine("--- AddRange ---");
            //string[] renkler = {"kırmızı", "beyaz", "sarı"};
            List<int> sayilar = new List<int>(){1,2,3,4,5,6,7};

            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

             foreach (var item in liste)
            {
                Console.WriteLine(item);
            }


            //Sorting
            Console.WriteLine("--- Sort ---");
            liste.Sort();

            //Binary Search
            Console.WriteLine("--- Binary Search ---");
            Console.WriteLine(liste.BinarySearch(6));

            //Reverse
            Console.WriteLine("--- Reverse ---");
            liste.Reverse();
            foreach (var item in liste)
                Console.WriteLine(item);

            //Clear
            Console.WriteLine("--- Clear ---");
            liste.Clear();
            foreach (var item in liste)
                Console.WriteLine(item);



        }
    }
}
