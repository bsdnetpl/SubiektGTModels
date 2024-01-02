using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwHbOperacjeITransakcjeSkojarzone
{
    public int HbIdTransakcji { get; set; }

    public int HbIdNaglowekTr { get; set; }

    public int NzfId { get; set; }

    public string HbNumerRachunku { get; set; } = null!;

    public int? NzfIdRachunku { get; set; }

    public int NzfStatus { get; set; }

    public int Zamkniety { get; set; }

    public int? NzfImport { get; set; }

    public int TypOperacji { get; set; }

    public DateTime? HbDataUtworzeniaWyciagu { get; set; }

    public DateTime? HbDataKsiegowania { get; set; }

    public DateTime NzfData { get; set; }

    public DateTime? NzfDataUzgodnienia { get; set; }

    public string? HbKontrahent { get; set; }

    public string? HbRachKontrahent { get; set; }

    public string? AdrhSymbol { get; set; }

    public string? AdrhNazwa { get; set; }

    public string? AdrhAdres { get; set; }

    public string? AdrhNip { get; set; }

    public string? NzfTytulem { get; set; }

    public decimal NzfWartosc { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public decimal NzfKurs { get; set; }

    public decimal NzfWartoscWaluta { get; set; }

    public string? NzfWystawil { get; set; }

    public string? HbNumerWyciagu { get; set; }

    public string? HbKodTranzakcji { get; set; }

    public string? HbOpisTranzakcji { get; set; }

    public string? HbTytul { get; set; }

    public int Skojarzone { get; set; }
}
