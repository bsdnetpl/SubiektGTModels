using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsefFakturyKsiegowosc
{
    public int KsefkId { get; set; }

    public int KsefkIdFaktury { get; set; }

    public int? KsefkKatId { get; set; }

    public int? KsefkIdKontrahenta { get; set; }

    public int? KsefkTypDokumentu { get; set; }

    public int KsefkTrybWprowadzania { get; set; }

    public int KsefkRodzajDokumentuGlownego { get; set; }

    public int? KsefkTypDokumentuGlownego { get; set; }

    public int? KsefkTypDokumentuPowiazanego { get; set; }

    public int? KsefkTypDokumentuWprowadzonego { get; set; }

    public int? KsefkIdDokumentuWprowadzonego { get; set; }

    public int? KsefkIdSchematuImportu { get; set; }

    public bool KsefkSchematZatwierdzony { get; set; }

    public int? KsefkIdGrupaDokumentu { get; set; }

    public DateTime? KsefkDataDokumentu { get; set; }

    public DateTime? KsefkMiesiacRozliczeniowy { get; set; }

    public string KsefkNotatkaKsiegowa { get; set; } = null!;

    public DateTime? KsefkDataZakonczeniaDostawy { get; set; }

    public DateTime? KsefkDataWystawienia { get; set; }

    public int KsefkRodzajDopasowaniaSi { get; set; }

    public bool KsefkPrzetworzonoPrzedZmianaFormy { get; set; }

    public virtual KsefFaktury KsefkIdFakturyNavigation { get; set; } = null!;

    public virtual SlGrupaDokumentow? KsefkIdGrupaDokumentuNavigation { get; set; }

    public virtual KhKontrahent? KsefkIdKontrahentaNavigation { get; set; }

    public virtual SlKategorium? KsefkKat { get; set; }
}
