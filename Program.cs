using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;      //Digunakan saat Abstract Class
using Abstraction.Interface;            //Digunakan saat Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANGUN RUANG");
            Console.WriteLine();

            //BangunDatar bangundatar;  //Digunakan saat Abstract Class
            IBangunDatar bangundatar;   //Digunakan saat Interface

            Console.WriteLine("1. Persegi");
            bangundatar = new Persegi();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.WriteLine();
            Console.WriteLine("2. Persegi Panjang");
            bangundatar = new PersegiPanjang();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.WriteLine();
            Console.WriteLine("3. Segitiga");
            bangundatar = new Segitiga();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.ReadKey(true);
        }
    }
}
