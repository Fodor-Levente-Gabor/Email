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
            List<String> emailek = new List<String>();
            emailek.Add("alma@körte.com");
            emailek.Add("banán@körte.com");
            emailek.Add("répa@alma.com");
            emailek.Add("banán@alma.hu");
            emailek.Add("géza@körte.com");
            emailek.Add("hurka@répa.com");

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
                        Console.Clear();
                        Console.WriteLine("emailek címek:");
                        int sor = 0;
                        foreach (string email in emailek)
                        {
                            Console.WriteLine($"{sor++} {email}");
                        }
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
