using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Classi
{
  
        internal class Rubrica
        {
            public List<Contatto> elenco;
            private string proprietario = string.Empty;

            public void Add(Contatto nuovo)
            {
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
                this.elenco = this.elenco.OrderBy(x => x.Surname).ThenBy(x => x.Name).ToList();
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
