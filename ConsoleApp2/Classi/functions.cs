using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classi
{
    internal class functions
    {

         public static bool is_true(string input)
        {
            input = input.ToLower();
            switch (input)
            {
                case "y": return true;
                case "n": return false;
                default: return false;
            }

        }
        public static bool is_valid(int id_contatto, Rubrica rubrica)
        {
            if (id_contatto <= 0 || id_contatto >= rubrica.elenco.Count() + 1)
            {
                Console.WriteLine("Hai inserito un valore non valido");
                return false;
            }
            else return true;
        }
        public static void initialize_persona(Rubrica rubrica)
        {
            Contatto temp = new Contatto();
            Console.WriteLine("\nInserire Nome:  ");
            temp.Name = Console.ReadLine();
            Console.WriteLine("\nInserire Cognome:  ");
            temp.Surname = Console.ReadLine();
            Console.WriteLine("\nInserire #Telefono:  ");
            temp.Number = Console.ReadLine();
            Console.WriteLine("\nInserire Mail:  ");
            temp.Email = Console.ReadLine();
            Console.WriteLine("\nInserire Professione:  ");
            temp.Professione = Console.ReadLine();
            Console.WriteLine("\nInserire Data di nascita:  ");
            temp.DataDiNascita = Console.ReadLine();
            Console.WriteLine("\nInserire Codice Fiscale:  ");
            temp.Cf = Console.ReadLine();
            rubrica.elenco.Add(temp);
        }
    }
}
