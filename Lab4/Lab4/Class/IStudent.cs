namespace Lab4.Class
{
    public interface IStudent : IPerson
    {
        string Uczelnia { get; }
        string Kierunek { get; }
        int Rok { get; }
        int Semestr { get; }
        string WypiszPelnaNazweIUczelnie();
    }
}
