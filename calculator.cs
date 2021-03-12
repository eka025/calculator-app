using System;
using System.Text;
using System.Collections.Generic;


namespace CalculatorConsoleApp
{
    class program
    {
        
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a,int b)
        {
            return a / b;
        }
    }
}

namespace progamming_kalkulator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi kalkulator ;D";

            int menu;
            double total = 0;
            double a, b;
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("1. Pertambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("--------------");

            Console.WriteLine("silahkan pilih : ");
            menu = int.Parse(Console.ReadLine());

            if (menu > 4 || menu < 1)
            {
                Console.WriteLine("Menu Tidak valid");
                Environment.Exit(0);
            }

            Console.Write("Masukkan nilai a = ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai b = ");
            b = double.Parse(Console.ReadLine());


            switch (menu)
            {
                case 1:
                    total = a + b;
                    break;
                case 2:
                    total = a - b;
                    break;
                case 3:
                    total = a * b;
                    break;
                case 4:
                    total = a / b;
                    break;

            }
            
          
            Console.WriteLine();   

            Console.WriteLine("Hasil dari dari {0} + {1} = {2}", a, b, total);

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
    }
}