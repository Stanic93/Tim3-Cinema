using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public enum ActiveTab
    {
        Repertoar,
        Karta,
        Racun,
        Rezervacija,
        Zaposleni,
        Film,
        Termini,
        Projekcija,
        Zanr,
        Login
    }
    public enum State
    {
        Add,
        Edit,
        Delete,
        Idle
    }
    public enum StateTab
    {
        Racun,
        Rezervacija,
        Detaljno
    }
}
