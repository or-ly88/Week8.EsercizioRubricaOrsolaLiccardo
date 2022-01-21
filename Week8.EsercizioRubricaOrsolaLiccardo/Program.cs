// See https://aka.ms/new-console-template for more information
using Week8.Core.BusinessLayer;
using Week8.Core.Models;
using Week8.RepositoryMock;

Console.WriteLine("Hello, World!");

//Questa riga fa comunicare i progetti tra loro
IBusinessLayer bl = new BusinessLayer(new RepositoryContattiMock(), new RepositoryIndirizziMock());

bool continua = true;

while (continua)
{
    int scelta = SchermoMenu();
    continua = AnalizzaScelta(scelta);
}

int SchermoMenu()
{
    Console.WriteLine("***************Menu**************");
    //Contatti
    Console.WriteLine("\nFunzionalità Contatti");
    Console.WriteLine("1.Visualizza Contatti");
    Console.WriteLine("2.Inserire nuovo Contatto");
    Console.WriteLine("3.Eliminare Contatto senon associato a nessun indirizzo");
    //Indirizzi
    Console.WriteLine("\nFunzionalità Indirizzi");
    Console.WriteLine("4.Visualizza Indirizzi");
    Console.WriteLine("5.Inserire nuovo Indirizzo");
    Console.WriteLine("6.Eliminare un Indirizzo");
    Console.WriteLine("\n0.Exit");
    Console.WriteLine("**********************************");

    int scelta;
    Console.WriteLine("Inserisci la tua scelta: ");
    while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 6))
    {
        Console.WriteLine("Scelta errata. Inserisci una scelta corretta: ");
    }
    return scelta;
}




bool AnalizzaScelta(int scelta)
{
    switch (scelta)
    {
        case 1:
            VisualizzaContatti();
            break;
        case 2:
            InserisciNuovoContatto();
            break;
        case 3:
            EliminaContatto();
            break;
        case 4:
            VisualizzaIndirizzi();
            break;
        case 5:
            InserireNuovoIndirizzo();
            break;
        case 6:
            EliminaIndirizzo();
            break;
        case 0:
            return false;
        default:
            break;
    }
    return true; 

    void VisualizzaContatti()
    {
        List<Contatto> listaContatti = bl.GetAllContatti();

        //stampa la lista
        if (listaContatti.Count == 0)
        {
            Console.WriteLine("Lista vuota");
        }
        else
        {
            foreach (var item in listaContatti)
            {

                Console.WriteLine(item);
            }
        }

       
    }
}

void EliminaIndirizzo()
{
    Console.WriteLine("Ecco l'elenco degli indirizzi disponibili");
    VisualizzaIndirizzi();
    Console.WriteLine("Quale indirizzo vuoi eliminare? Inserisci l'ID: ");
    int id = int.Parse(Console.ReadLine());

    Esito esito = bl.RimuoviIndirizzo(id);
    Console.WriteLine(esito.Messaggio);
}

void InserireNuovoIndirizzo()
{
    //chiedo all'utente i dati per aggiungere un nuovo studente
    Console.WriteLine("Inserisci tipologia indirizzo");
    string tipologia = Console.ReadLine();
    Console.WriteLine("Inserisci la Via ");
    string via = Console.ReadLine();
    Console.WriteLine("Inserisci la Città ");
    string città = Console.ReadLine();
    Console.WriteLine("Inserisci il CAP ");
    string cap = Console.ReadLine();
    Console.WriteLine("Inserisci la Provincia ");
    string provincia = Console.ReadLine();
    Console.WriteLine("Inserisci la Nazione ");
    string nazione = Console.ReadLine();
 

    Indirizzo nuovoIndirizzo = new Indirizzo();

    nuovoIndirizzo.Via = via;
    nuovoIndirizzo.Città = città;
    nuovoIndirizzo.CAP = cap;
    nuovoIndirizzo.Provincia = provincia;
    nuovoIndirizzo.Nazione = nazione;
  

    //riga che mi serve per passare all'IbusinessLayer per farlo aggiungere
    //mi serve poi una risposta per sapere se lo ha aggiunto, quindi metto un booleano
    //così---->bool esito=bl.AddNuovoIndirizzo(nuovoIndirizzo);
    //Oppure: devinico nei models una nuova classe dove mi viene restituito sia il booleano che il messaggio
    Esito esito = bl.AddNuovoIndirizzo(nuovoIndirizzo);
    Console.WriteLine(esito.Messaggio);
}

void VisualizzaIndirizzi()
{
    List<Indirizzo> listaIndirizzi = bl.GetAllIndirizzi();

    //stampa la lista
    if (listaIndirizzi.Count == 0)
    {
        Console.WriteLine("Lista vuota");
    }
    else
    {
        foreach (var item in listaIndirizzi)
        {

            Console.WriteLine(item);
        }
    }
}

void EliminaContatto(int ContattoID)
{
    
    Console.WriteLine("Quale contatto vuoi eliminare? Inserisci l'ID: ");
    int id = int.Parse(Console.ReadLine());

    Esito esito = bl.RimuoviIndirizzo(id);
    Console.WriteLine(esito.Messaggio);
}

void InserisciNuovoContatto()
{
    //chiedo all'utente i dati per aggiungere un nuovo studente
    Console.WriteLine("Inserisci il nome del nuovo contatto");
    string nome = Console.ReadLine();
    Console.WriteLine("Inserisci il cognome del nuovo contatto");
    string cognome = Console.ReadLine();


    Contatto nuovoContatto = new Contatto();

    nuovoContatto.Nome = nome;
    nuovoContatto.Cognome = cognome;
    


    //riga che mi serve per passare all'IbusinessLayer per farlo aggiungere
    //mi serve poi una risposta per sapere se lo ha aggiunto, quindi metto un booleano
    //così---->bool esito=bl.AddNuovoContatto(nuovoContatto);
    //Oppure: devinico nei models una nuova classe dove mi viene restituito sia il booleano che il messaggio
    Esito esito = bl.AddNuovoContatto(nuovoContatto);
    Console.WriteLine(esito.Messaggio);
}