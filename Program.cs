using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menüvezérlés
            while (true)
            {
                Console.WriteLine("0 - kilépés");
                Console.WriteLine("1 - emailek listázása");
                Console.WriteLine("2 - új email");
                Console.WriteLine("3 - email törlése");
                Console.WriteLine("4 - érvényes emailok listázása");

                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("emailek listázása");
                        break;
                    case "2": 
                        Console.WriteLine("új email");
                        break;
                    case "3":
                        Console.WriteLine("email törlése");
                        break;
                    case "4":
                        Console.WriteLine("érvényes emailok listázása");
                        break;
                    default: 
                        Console.WriteLine("rossz parancs");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
