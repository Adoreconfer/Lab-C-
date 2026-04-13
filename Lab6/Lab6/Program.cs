// ========================= 
// 1) CONNECTION STRING 
// ========================= 
// TODO (student): 
// - Uzupełnij poprawny connection string do swojej instancji SQL Server 
// - Wskazówka: w SSMS sprawd ź nazwę serwera (np. "." albo "DESKTOP-XYZ") 
// - Wskazówka: Database musi by ć ContactDB 
// Przyk ład: 
// "Server=.;Database=ContactDB;Trusted_Connection=True;Encrypt=False;"; 
using Lab6.Data;
using Lab6.Models;
using System.Collections;
using System.Numerics;

const string ConnectionString = "Server=localhost\\SQLEXPRESS;Database=ContactDB;Trusted_Connection=True;TrustServerCertificate=True;";
ContactRepository repo = new ContactRepository(ConnectionString);

while (true)
{

    PrintMenu();
    string choice = Console.ReadLine() ?? "";

    try
    {
        switch (choice)
        {
            case "1":
                Create(repo); 
                break;

            case "2":
                ReadAll(repo);
                break;

            case "3":
                Search(repo);
                break;

            case "4":
                Update(repo);
                break;

            case "5":
                Delete(repo); 
                break;

            case "6":
                BulkInsertDemo(repo); 
                break;

            case "0":
                return;

            default:
                Console.WriteLine("Nieprawidłowy wybór.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Wystąpił błąd: " + ex.Message);
    }
}

static void PrintMenu()
{
    Console.WriteLine("\n=== CONTACT MANAGER (ADO.NET + DAL) ===");
    Console.WriteLine("1) Dodaj kontakt");
    Console.WriteLine("2) Pokaż wszystkie");
    Console.WriteLine("3) Wyszukaj po nazwisku");
    Console.WriteLine("4) Edytuj kontakt");
    Console.WriteLine("5) Usu ń kontakt");
    Console.WriteLine("6) Bulk insert (transakcja) - demo");
    Console.WriteLine("0) Wyjście");
    Console.Write("Wybór: ");
}

// ========================= 
// CREATE 
// ========================= 
static void Create(ContactRepository repo)
{
    Contact c = new Contact { FirstName = ReadRequired("Podaj imię: "), LastName = ReadRequired("Podaj nazwisko: "), Phone = ReadOptional("Podaj telefon: "), Email = ReadOptional("Podaj email: ") };
    int id = repo.Add(c);
    Console.WriteLine($"Id: {id}");
} 
 
    // ========================= 
    // READ 
    // ========================= 
static void ReadAll(ContactRepository repo)
{ 
    Console.WriteLine("Id | FirstName | LastName | Phone | Email");
    foreach (Contact contact in repo.GetAll())
    {
        Console.WriteLine(contact.ToString());
    }
}

// ========================= 
// SEARCH BY LAST NAME 
// ========================= 
static void Search(ContactRepository repo)
{
    string nazwisko = ReadRequired("Podaj nazwisko: ");
    Console.WriteLine("Id | FirstName | LastName | Phone | Email");
    foreach (Contact contact in repo.SearchByLastName(nazwisko))
    {
        Console.WriteLine(contact.ToString());
    }
}

// ========================= 
// UPDATE 
// ========================= 
static void Update(ContactRepository repo)
{
    Contact c = new Contact { Id = ReadInt("Podaj id: "), FirstName = ReadRequired("Podaj imię: "), LastName = ReadRequired("Podaj nazwisko: "), Phone = ReadOptional("Podaj telefon: "), Email = ReadOptional("Podaj email: ") };
    repo.Update(c);
    Console.WriteLine("Zaktualizowano");
}

// ========================= 
// DELETE 
// ========================= 
static void Delete(ContactRepository repo)
{
    repo.Delete(ReadInt("Podaj id: "));
    Console.WriteLine("Usunięto");
}

// ========================= 
// TRANSACTION (BULK INSERT) 
// ========================= 
static void BulkInsertDemo(ContactRepository repo)
{
    var contacts = new List<Contact> { 
        new Contact
        {
            Id = 3,
            FirstName = "Piotr",
            LastName = "Zieliński",
            Phone = "600700800",
            Email = "piotr@demo.pl"
        },
        new Contact
        {
            Id = 4,
            FirstName = "Maria",
            LastName = "Wiśniewska",
            Phone = "600700801",
            Email = "maria@demo.pl"
        },
        new Contact
        {
            Id = 5,
            FirstName = "Tomasz",
            LastName = "Lewandowski",
            Phone = "501222333",
            Email = "tomasz@demo.pl"
        }
    };
    repo.BulkInsert(contacts);
    Console.WriteLine("Dodano " + contacts.Count);
}

// ========================================================== 
// HELPERS 
// ========================================================== 

static string ReadRequired(string label)
{
    while (true)
    {
        Console.Write(label);
        string s = Console.ReadLine() ?? "";
        if (!string.IsNullOrWhiteSpace(s)) return s.Trim();
        Console.WriteLine("Pole nie może być puste.");
    }
}

static string? ReadOptional(string label)
{
    Console.Write(label);
    string s = Console.ReadLine() ?? "";
    s = s.Trim();
    return string.IsNullOrWhiteSpace(s) ? null : s;
}

static int ReadInt(string label)
{
    while (true)
    {
        Console.Write(label);
        if (int.TryParse(Console.ReadLine(), out int id)) return id;
        Console.WriteLine("Podaj poprawną liczbę całkowitą.");
    }
}  