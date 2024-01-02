using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrkwestionariuszOsobowyPracownicy
{
    public int IdPracownika { get; set; }

    public string Imie { get; set; } = null!;

    public string Imie2 { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public DateTime DataUrodzenia { get; set; }

    public string ImieOjca { get; set; } = null!;

    public string ImieMatki { get; set; } = null!;

    public string Obywatelstwo { get; set; } = null!;

    public string DowodTozsamosciNumer { get; set; } = null!;

    public string DowodTozsamosciWydanyPrzez { get; set; } = null!;

    public DateTime? DowodTozsamosciDataWydania { get; set; }

    public string Nip { get; set; } = null!;

    public string Pesel { get; set; } = null!;

    public string ZawodWyuczony { get; set; } = null!;

    public string Szkola { get; set; } = null!;

    public int? RokUkonczeniaSzkoly { get; set; }

    public string ObowiazekObronny { get; set; } = null!;

    public string Wku { get; set; } = null!;

    public string StopienWojskowy { get; set; } = null!;

    public string NumerKsWojskowej { get; set; } = null!;

    public string NumerSpecjalnosciWojskowej { get; set; } = null!;

    public byte[]? Zdjecie { get; set; }

    public string? Wyksztalcenie { get; set; }
}
