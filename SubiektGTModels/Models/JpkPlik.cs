using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class JpkPlik
{
    public int JpkId { get; set; }

    public int JpkIdPaczki { get; set; }

    public int JpkTyp { get; set; }

    public string? JpkNazwa { get; set; }

    public DateTime JpkOkresOd { get; set; }

    public DateTime JpkOkresDo { get; set; }

    public DateTime? JpkDataWygenerowania { get; set; }

    public byte[]? JpkPlikXml { get; set; }

    public string? JpkPlikHash { get; set; }

    public bool JpkImportowany { get; set; }

    public int JpkCelZlozenia { get; set; }

    public int? JpkIdUrzeduSkarbowego { get; set; }

    public bool JpkWyeksportowany { get; set; }

    public string JpkWalutaDomyslna { get; set; } = null!;

    public int JpkWersja { get; set; }

    public int JpkRodzaj { get; set; }

    public byte[]? JpkParametryPliku { get; set; }

    public bool JpkScalony { get; set; }

    public int? JpkNumerKorekty { get; set; }

    public int JpkPodtyp { get; set; }

    public int? JpkIdDeklaracji { get; set; }

    public virtual DeklEwid? JpkIdDeklaracjiNavigation { get; set; }

    public virtual JpkPaczka JpkIdPaczkiNavigation { get; set; } = null!;

    public virtual SlUrzadSkarbowy? JpkIdUrzeduSkarbowegoNavigation { get; set; }

    public virtual JpkTyp JpkTypNavigation { get; set; } = null!;

    public virtual SlWalutum JpkWalutaDomyslnaNavigation { get; set; } = null!;

    public virtual JpkWersja JpkWersjaNavigation { get; set; } = null!;
}
