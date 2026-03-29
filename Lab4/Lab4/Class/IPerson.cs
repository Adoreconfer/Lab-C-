using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Class
{
    public interface IPerson
    {
        string Imie { get; }
        string Nazwisko { get; }
        List<IPerson> Persons { get; }
        void ZwrocPelnaNazwe();
    }
}
