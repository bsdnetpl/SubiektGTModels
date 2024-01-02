using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwHbOperacje
{
    public int NzfId { get; set; }

    public int Widoczna { get; set; }

    public int? NzfIdDokumentAuto { get; set; }

    public int? NzfIdRachunku { get; set; }

    public int NzfStatus { get; set; }

    public bool NzfWydrukowana { get; set; }

    public int Zamkniety { get; set; }

    public int? NzfImport { get; set; }

    public int TypOperacji { get; set; }

    public int NzfPodtypPp { get; set; }

    public DateTime NzfData { get; set; }

    public string? AdrhSymbol { get; set; }

    public string? AdrhNazwa { get; set; }

    public string? AdrhAdres { get; set; }

    public string? AdrhNip { get; set; }

    public string? NzfTytulem { get; set; }

    public string? NzfNrFaktury { get; set; }

    public decimal NzfWartosc { get; set; }

    public decimal NzfVatpozostaloWaluta { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public decimal NzfKurs { get; set; }

    public decimal NzfWartoscWaluta { get; set; }

    public string? NzfWystawil { get; set; }

    public string? NzfNumerWyciagu { get; set; }

    public string? KatNazwa { get; set; }

    public int? NzfProgram { get; set; }

    public bool NzfGotowkowa { get; set; }

    public bool NzfObslugaRachunku { get; set; }

    public int? NzfIdRachObiektHist { get; set; }

    public int? HbStatus { get; set; }

    public int? NzfIdRachObiekt { get; set; }

    public int? NzfIdObiektu { get; set; }

    public int NzfTypObiektu { get; set; }
}
