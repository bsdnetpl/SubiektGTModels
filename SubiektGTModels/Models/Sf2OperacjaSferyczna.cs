using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class Sf2OperacjaSferyczna
{
    public int Sf2osId { get; set; }

    public int? Sf2osIdOperacji { get; set; }

    public int Sf2osIdKomponentu { get; set; }

    public string Sf2osNazwaFunkcji { get; set; } = null!;

    public string? Sf2osNazwaWyswietlana { get; set; }

    public string Sf2osOpis { get; set; } = null!;

    public int Sf2osStan { get; set; }

    public int Sf2osTyp { get; set; }

    public int Sf2osKolejnosc { get; set; }

    public int? Sf2osSkrotKlawiszowy { get; set; }

    public virtual Sf2KomponentSferyczny Sf2osIdKomponentuNavigation { get; set; } = null!;

    public virtual UiOperacja? Sf2osIdOperacjiNavigation { get; set; }
}
