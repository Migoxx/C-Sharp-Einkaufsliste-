Liste();
static void Liste()
{
    List<string> einkaufsListe = new List<string>();
    string auswahl;

    do
    {
        Console.Clear();
        Console.WriteLine("Einkaufsliste Menü:"); 
        Console.WriteLine("--------------------");
        Console.WriteLine("[1]. Artikel hinzufügen");
        Console.WriteLine("[2]. Artikel entfernen");
        Console.WriteLine("[3]. Einkaufsliste anzeigen");
        Console.WriteLine("[4]. Beenden");
        Console.WriteLine(" ");
        Console.Write("Wählen Sie eine Option : ");
        auswahl = Console.ReadLine();

        switch (auswahl)
        {
            case "1":
                ArtikelHinzufügen(einkaufsListe);
                break;
            case "2":
                ArtikelEntfernen(einkaufsListe);
                break;
            case "3":
                ListeAnzeigen(einkaufsListe);
                break;
            case "4":
                Console.WriteLine("Programm wird beendet.");
                break;
            default:
                Console.WriteLine("Ungültige Auswahl. Bitte erneut versuchen.");
                break;
        }

        if (auswahl != "4")
        {
            Console.WriteLine("Drücken Sie eine beliebige Taste, um zum Menü zurückzukehren...");
            Console.ReadKey();
        }

    } while (auswahl != "4");
}

static void ArtikelHinzufügen(List<string> liste)
{
    Console.Write("Geben Sie den Namen des Artikels ein, den Sie hinzufügen möchten: ");
    string artikel = Console.ReadLine();
    liste.Add(artikel);
    Console.WriteLine(" ");
    Console.WriteLine($"{artikel} wurde zur Einkaufsliste hinzugefügt.");
    Console.WriteLine(" ");
}

static void ArtikelEntfernen(List<string> liste)
{
    Console.Write("Geben Sie den Namen des Artikels ein, den Sie entfernen möchten: ");
    Console.WriteLine(" ");
    string artikel = Console.ReadLine();
    if (liste.Remove(artikel))
    {
        Console.WriteLine($"{artikel} wurde von der Einkaufsliste entfernt.");
        Console.WriteLine(" ");
    }
    else
    {
        Console.WriteLine($"{artikel} wurde nicht in der Einkaufsliste gefunden.");
        Console.WriteLine(" ");
    }
}

static void ListeAnzeigen(List<string> liste)
{
    Console.WriteLine("Einkaufsliste:");
    Console.WriteLine(" ");
    if (liste.Count == 0)
    {
        Console.WriteLine("Leer.");
        Console.WriteLine(" ");
    }
    else
    {
        foreach (string artikel in liste)
        {
            Console.WriteLine("- " + artikel);
            Console.WriteLine(" ");
        }
    }
}