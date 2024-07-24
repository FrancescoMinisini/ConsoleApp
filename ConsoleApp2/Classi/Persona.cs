using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2.Classi
{
    internal class Persona
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Professione { get; set; } = string.Empty;
        public string DataDiNascita { get; set; } = string.Empty;
        public string Cf { get; set; } = string.Empty;

        public Persona(string nome, string cognome, string professione, string dataDiNascita, string cf)
        {
            this.Name = nome;
            this.Surname = cognome;
            this.Professione = professione;
            this.DataDiNascita = dataDiNascita;
            this.Cf = cf;
        }

        public Persona(string nome, string cognome, string professione, string dataDiNascita)
        {
            this.Name = nome;
            this.Surname = cognome;
            this.Professione = professione;
            this.DataDiNascita = dataDiNascita;
        }

        public Persona(string nome, string cognome, string professione)
        {
            this.Name = nome;
            this.Surname = cognome;
            this.Professione = professione;
        }

        public Persona(string nome, string cognome)
        {
            this.Name = nome;
            this.Surname = cognome;
        }

        public Persona()
        {
        }

        public virtual void GetInfo()
        {

            Console.WriteLine($"Nome: {this.Name}");
            Console.WriteLine($"Cognome: {this.Surname}");
            Console.WriteLine($"Professione: {this.Professione}");
            Console.WriteLine($"Data di Nascita: {this.DataDiNascita}");
            Console.WriteLine($"Codice Fiscale: {this.Cf}");

        }

    }
}
