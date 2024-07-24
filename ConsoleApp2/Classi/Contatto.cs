using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classi
{
    internal class Contatto : Persona
    {
        public string Number { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public Contatto()
        {
        }
        public Contatto(string surname, string name, string numero, string mail) : base(surname, name)
        {
            Number = numero;
            Email = mail;
        }

        public Contatto(string nome, string cognome, string numero, string mail, string professione, string dataDiNascita, string cf) : base(nome, cognome, professione, dataDiNascita, cf)
        {
            this.Number = numero;
            this.Email = mail;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Numero: {this.Number}");
            Console.WriteLine($"Mail: {this.Email}");
        }
    }
}



