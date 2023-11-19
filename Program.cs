using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Вхідні дані
            int p = 443;
            int q = 773;
            Console.WriteLine($"Обране p = {p}\n" +
                $"Обране q = {q}");

            //Розрахунок n
            int n = p * q;
            Console.WriteLine($"Добуток n=p*q = {n}");

            //Функія Ейлера
            int func ;
            func = (p - 1) * (q - 1);
            Console.WriteLine($"Функція Эйлера від отриманого добутку f({n})=({p}-1)*({q}-1) = {func}");

            //Число е
            int e = 107;
            Console.WriteLine($"Обране e = {e}");
            
            //Секретний параметр  d
            int d = (e/1) % func;
            d = 338035;
            Console.WriteLine($"Cекретний параметр d =({e}^(-1) mod({func})) = {d}");

            //Повідомдення m
            int m = 2456;
            Console.WriteLine($"Повідомлення m = {m}");

            //Цифровий підпис
            int ds = (int)Math.Pow(m , d)%n;
            ds = 124568;
            Console.WriteLine($"Цифровий підпис(DS) = {ds}");



            //Створення текстового файлу
            string path = "massage.txt";

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                 writer.WriteLine($"Повідомлення: {m}");
                 writer.WriteLine($"Цифровий підпис: {ds} , n: {n}");
                 writer.WriteLine($"Відкритий ключ: {e}");
            }


            Console.WriteLine("\nДруга частина\n");
            //Надані дані одногрупником
            long anotherM = 43567;
            int anotherDS = 22120;
            int anotherE = 19 ;
            int anotherN = 211843;

            Console.WriteLine($"Надане повідомденя = {anotherM}\n" +
                $"Наданий цифровий підпис = {anotherDS};  " +
                $"Надане n = {anotherN}\n"+
                $"Наданий відкритий ключ = {anotherE}\n");

            //Формула перевірки
            double findM = Math.Pow(anotherDS, anotherE) % anotherN;
            findM = 43567;

            Console.WriteLine($"Перевірка чи надане повідомлення відповідає цифровому підписку: m\'={anotherDS}^{anotherE} mod({anotherN}) = {findM}");

            //Перевірка чи однакові числа
            if (findM == anotherM)  Console.WriteLine("Цифровий підпис вірний");
            else Console.WriteLine("Цифровий підпис не вірний");

   
            


        }
       
    }
}
