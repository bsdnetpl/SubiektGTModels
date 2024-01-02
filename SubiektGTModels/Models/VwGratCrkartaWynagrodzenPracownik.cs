using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrkartaWynagrodzenPracownik
{
    public int IdPracownika { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string ImieOjca { get; set; } = null!;

    public string ImieMatki { get; set; } = null!;

    public DateTime DataUrodzenia { get; set; }

    public string MiejsceUrodzenia { get; set; } = null!;

    public string Pesel { get; set; } = null!;

    public string Nip { get; set; } = null!;
}
