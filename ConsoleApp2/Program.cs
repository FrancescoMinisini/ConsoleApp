using ConsoleApp2.Classi;

internal class Program
{   
    private static void Main(string[] args)
    { 
        int control = -1;
        int index = 0;
        List<Contatto> elenco = new List<Contatto>();
        Rubrica rubrica = new Rubrica();

        //Inizializzo abdul
        Contatto Abdul = new Contatto("Elbadwy", "Abdulrhman", "123123", "abdul");
        rubrica.Add(Abdul);
        //Console.WriteLine( $" Contatto numero: {index + 1} \n Cognome: {rubrica.elenco[index].Surname} \n Nome: {rubrica.elenco[index].Name} \n Numero di telefono: {rubrica.elenco[index].Number} \n Mail: {rubrica.elenco[index].Email}");

        Dictionary<int, string> dic = new Dictionary<int, string>()
        {
            {0 , "Chiudi il programma"},
            {1, "Visualizza i contatti" },
            {2 ,"Aggiungi un contatto" },
            {3 , "Rimuovi un contatto" },
            {4, "Cancella la rubrica" }
        };
        List<string> list = new List<string>()
        {
            "Cognome" , "Nome" , "#Telefono" , "Email"
        };
        
        Console.WriteLine($"\n{Abdul.GetType()}");
        Type type = typeof(Contatto);


        while (control != 0)
        {
            Console.WriteLine("\nPremere: ");
            foreach (int i in dic.Keys) Console.WriteLine($"\n{dic.Keys} {dic.Values}");

            control = Convert.ToInt32(Console.ReadLine());

            var a = Math.Max(0, control);

            switch (control)
            {
                case 1:
                    {
                        //per visualizzare contatti
                        Console.Clear();
                        foreach (string field in list) Console.WriteLine($"{field}       ");
                        foreach (Contatto field in rubrica.elenco)
                        {
                            Console.WriteLine($"{field.Surname}    {field.Name}    {field.Number}   {field.Email}");
                        }
                        break;
                    }
                case 2: {
                        Contatto temp = new Contatto();
                        Console.Clear();
                        Console.WriteLine("\n Inserire Nome:  ");
                        temp.Name = Console.ReadLine();
                        Console.WriteLine("\n Inserire Cognome:  ");
                        temp.Surname = Console.ReadLine();
                        Console.WriteLine("\n Inserire #Telefono:  ");
                        temp.Number = Console.ReadLine();
                        Console.WriteLine("\n Inserire Mail:  ");
                        temp.Email = Console.ReadLine();
                        break;

                    }
                case 3: { break; }

                case 4: { break; }

                default: {
                        Console.WriteLine("Hai inserito un valore non valido");
                        break; 
                    }

            }
        }

    }

}    
 