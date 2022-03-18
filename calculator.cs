using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int nomor;

            Console.WriteLine("menu calculator\n");
            Console.WriteLine("1. penambahan");
            Console.WriteLine("2. pengurangan");
            Console.WriteLine("3. perkalian");
            Console.WriteLine("4. pembagian");
            Console.WriteLine("pilih nomor 1-4");
            nomor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inputkan angka pertama = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inputkan angka kedua = ");
            b = Convert.ToInt32(Console.ReadLine());

            if (nomor == 1)
            {
                Console.WriteLine("hasil penambahan  {0} + {1} = {2}", a, b, penambahan(a, b));
            }
            else if( nomor == 2)
            {
                Console.WriteLine("hasil pengurangan  {0} - {1} = {2}", a, b, pengurangan(a, b));
            }
            else if(nomor == 3)
            {
                Console.WriteLine("hasil perkalian  {0} x {1} = {2}", a, b, perkalian(a, b));
            }
            else if(nomor == 4)
            {
                Console.WriteLine("hasil pembagian  {0} : {1} = {2}", a, b, pembagian(a, b));
            }
            


            Console.WriteLine("\ntekan enter untuk keluar");
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
	        {
		        return a+b;
	        }
        static int pengurangan(int a, int b)
	        {
		        return a-b;
	        }
        static int perkalian(int a, int b)
	        {
		        return a* b;
	        }
	    static int pembagian(int a, int b)  
	        {
		        return a/b;
	        }
       }

    }

