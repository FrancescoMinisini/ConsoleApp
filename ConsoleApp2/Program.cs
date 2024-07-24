using ConsoleApp2.Classi;
using System.ComponentModel.Design;
using System.Linq.Expressions;

int control = -1;
List<Contatto> elenco = new List<Contatto>();
Rubrica rubrica = new Rubrica();

//Inizializzo contatti
List<Contatto> contatti = new List<Contatto>
            {
                new Contatto ("Mario", "Rossi", "54645156" , "shdvxds@sgssd" ,"insegnante" , "01/01/1990", "RSSMRA90A01H501Z"),
                new Contatto ("Giulia", "Bianchi","54645156" , "shdvxds@sgssd" ,"operaio" ,  "15/03/1985", "BNCGLI85C55H501S"),
                new Contatto ("Luca", "Verdi","54645156" , "shdvxds@sgssd" , "atleta" ,  "22/07/1980", "VRDLCA80L22H501X"),
                new Contatto ("Sara", "Neri", "54645156" , "shdvxds@sgssd" ,"operaio" ,"30/10/1992", "NRSSRA92T30H501D"),
                new Contatto ("Andrea", "Galli","54645156" , "shdvxds@sgssd" ,"operaio" , "05/12/1987", "GLLNDR87T05H501G"),
                new Contatto("Elbadwy", "Abdulrhman", "123123", "abdul@gay.it" ,"mio padre" ,  "01/01/1990", "RSSMRA90A01H501Z" ),
                new Contatto("Stefano", "Davolio", "454544121", "gay@gmgail" ,"operaio" ,  "01/01/1990", "RSSMRA90A01H501Z"),
                new Contatto("Giammarco", "Mare", "987654", "mario@example.com", "insegnante",  "01/01/1990", "RSSMRA90A01H501Z")
            };
elenco.AddRange(contatti);
rubrica.elenco = elenco;

 

Dictionary<int, string> azioni   = new Dictionary<int, string>()
        {
            {0 , "Chiudi il programma"},
            {1, "Visualizza i contatti" },
            {2 ,"Aggiungi un contatto" },
            {3 , "Rimuovi un contatto" },
            {4, "Cancella la rubrica" },
            {5 ,"Visualizza informazioni contatto"}
        };
List<string> list = new List<string>()
        {
             "id_Contatto","Cognome" , "Nome" , "#Telefono" , "Email"
        };

while (control != 0)
{
    try
    {
        int id_contatto = 0;
        Console.WriteLine("\nPremere: ");
        foreach (var i in azioni) Console.WriteLine($"\n{i.Key} {i.Value}");

        control = Convert.ToInt32(Console.ReadLine());

        switch (control)
        {

            case 1:
                {
                    int j = 0;
                    //per visualizzare contatti
                    Console.Clear();
                    foreach (string field in list) Console.Write($"{field,-15} ");
                    Console.Write("\n");
                    foreach (Contatto field in rubrica.elenco)
                    {
                        j++;
                        Console.WriteLine($"{j,-15}{field.Surname,-15}{field.Name,-15}{field.Number,-15}{field.Email,-15}");
                    }
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    functions.initialize_persona(rubrica);
                    break;

                }
            case 3:
                {
                    Console.Clear();
                    Console.Write("\n Inserire id_del contatto: ");
                    id_contatto = Convert.ToInt32(Console.ReadLine());
                    if (functions.is_valid(id_contatto, rubrica)) rubrica.elenco.RemoveAt(id_contatto - 1);
                    break;
                }

            case 4:
                {
                    Console.Clear();
                    Console.Write("\nSei sicuro? [y/n]: ");
                    if (functions.is_true(Console.ReadLine())) rubrica.elenco.Clear();
                    break;
                }
            case 5:
                {
                    Console.Clear();
                    Console.Write("\nInserire id_del contatto: ");
                    id_contatto = Convert.ToInt32(Console.ReadLine());
                    if (functions.is_valid(id_contatto, rubrica)) rubrica.elenco[id_contatto - 1].GetInfo();
                    break;
                }

            default:
                {
                    if (control != 0)
                    {
                        Console.WriteLine("Hai inserito un valore non valido");
                    }
                    break;
                }

        }



    }
    catch (Exception)
    {
        Console.Clear() ;
        Console.WriteLine("\nCè stato un errore, riprova");
    }
}



