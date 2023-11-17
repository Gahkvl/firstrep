using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int p = 443;
            int q = 773;
            Console.WriteLine($"Обране p = {p}\n" +
                $"Обране q = {q}");


            int n = p * q;
            Console.WriteLine($"Добуток n=p*q = {n}");

            int func ;
            func = (p - 1) * (q - 1);
            Console.WriteLine($"Функція Эйлера від отриманого добутку f({n})=({p}-1)*({q}-1) = {func}");

            int e = 107;
            Console.WriteLine($"Обране e = {e}");
            
            int d = (e/1) % func;
            d = 338035;
            Console.WriteLine($"Cекретний параметр d =({e}^(-1) mod({func})) = {d}");

            int m = 2456;
            Console.WriteLine($"Повідомлення m = {m}");

            int ds = (m ^ d)%n;
            ds = 124568;
            Console.WriteLine($"Секретне повідомлення(DS) = {ds}");

            string path = "massage.txt";

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                 writer.WriteLine($"Повідомлення: {m}");
                 writer.WriteLine($"Цифровий підпис: {ds} , n: {n}");
                 writer.WriteLine($"Відкритий ключ: {e}");
            }

            Console.WriteLine("Друга частина");

            long anotherM = 43567;
            int anotherDS = 22120;
            int anotherE = 19 ;
            int anotherN = 211843;
            int findM = (int)Math.Pow(anotherDS, anotherE) % anotherN;

            Console.WriteLine(findM);
            long adsa = (anotherDS ^ anotherE)% anotherN;
            Console.WriteLine(adsa);
            


        }
       
    }
}
