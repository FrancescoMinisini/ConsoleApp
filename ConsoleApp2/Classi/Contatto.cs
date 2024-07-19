using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classi
{
    internal class Contatto
    {
        private string name ;
        private string surname;
        private string number;
        private string email;

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public Contatto( string cognome, string nome , string numero, string mail)
        {
            Name = nome;
            Surname = cognome;
            Number = numero;
            Email = mail;
        }
        public Contatto()
        {
        }

    }

    internal class Rubrica
    {
        public List<Contatto> elenco; 

        public void Add( Contatto nuovo){
           this.elenco.Add(nuovo);
            OrdinaLista();
            }
        public void Add(List<Contatto> nuovo)
        {
            this.elenco.AddRange(nuovo);
            OrdinaLista();
        }

        public void Delete()
        {
            this.elenco.Clear();
        }

        public void OrdinaLista()
        {
            this.elenco = this.elenco.OrderBy(x=> x.Surname).ThenBy(x=> x.Name).ToList();   
        }

        public Rubrica(List<Contatto> contatti)
        {
            this.elenco = contatti;
        }

        public Rubrica()
        {
            this.elenco = new List<Contatto>();
        }

    }

}

