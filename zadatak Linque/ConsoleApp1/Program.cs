using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class objekat
    {
        public string ime;
        public string prezime;
        public string grad;
        public DateTime date;
        public objekat() { }
        public objekat(string ime, string prezime, string grad, DateTime date) 
        {
            this.ime = ime;
            this.prezime = prezime;
            this.grad = grad;
            this.date = date;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bojana", "Ivana", "Draga", "Milica", "Tina" };
            List<string> izabrani;
            
            izabrani = names.Where(n => n.ToLower().Contains("i")).ToList();
            var izabraniSaQuery = from ne in names where ne.ToLower().Contains("i") select ne;
            Console.WriteLine("Ovo je preko QUERY upita");
            foreach (string n in izabraniSaQuery)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Ovo je preko FLUENT upita");
            foreach (string n in izabrani)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

        }
    }
}
