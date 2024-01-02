using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDokumentyFirmy
{
    public int? Ident { get; set; }

    public int ObjectId { get; set; }

    public string? Nazwa { get; set; }

    public DateTime? DataPrzeslania { get; set; }

    public DateTime? MiesiacRozliczeniowy { get; set; }

    public DateTime? DataWystawienia { get; set; }

    public DateTime? DataDokumentu { get; set; }

    public string? NumerDokumentu { get; set; }

    public int? IdGrupaDokumentu { get; set; }

    public string Notatka { get; set; } = null!;

    public int? TypDokumentuGlownego { get; set; }

    public int? TypDokumentuWprowadzonego { get; set; }

    public int? IdDokumentuWprowadzonego { get; set; }

    public int StatusDokumentu { get; set; }

    public int StatusOcr { get; set; }

    public int? IdSchematuImportu { get; set; }

    public int DopasowanieSchematu { get; set; }

    public bool? SchematZatwierdzony { get; set; }

    public int? IdKontrahenta { get; set; }

    public int? IdKategorii { get; set; }

    public int? TypDokumentu { get; set; }

    public string Sygnatura { get; set; } = null!;

    public bool? WprowadzDokument { get; set; }

    public int TypObiektu { get; set; }

    public string? NumerKseF { get; set; }

    public string? RodzajFakturyKseF { get; set; }

    public int? TrybWprowadzania { get; set; }

    public int? RodzajDopasowaniaSchematuImportu { get; set; }
}
