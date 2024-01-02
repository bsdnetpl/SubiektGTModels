using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PbDokument
{
    public int PbdId { get; set; }

    public string PbdNazwa { get; set; } = null!;

    public DateTime PbdDataPrzeslania { get; set; }

    public DateTime PbdMiesiacRozliczeniowy { get; set; }

    public DateTime PbdDataDokumentu { get; set; }

    public string PbdNumerDokumentu { get; set; } = null!;

    public int? PbdIdGrupaDokumentu { get; set; }

    public string PbdNotatka { get; set; } = null!;

    public bool PbdWprowadzDokument { get; set; }

    public int PbdRodzajDokumentuGlownego { get; set; }

    public int? PbdTypDokumentuGlownego { get; set; }

    public int? PbdTypDokumentuPowiazanego { get; set; }

    public int? PbdTypDokumentuWprowadzonego { get; set; }

    public int? PbdIdDokumentuWprowadzonego { get; set; }

    public int PbdStatus { get; set; }

    public string? PbdPowodOdrzucenia { get; set; }

    public int PbdStatusOcr { get; set; }

    public byte[]? PbdOrientacjaStron { get; set; }

    public int PbdTrybWprowadzania { get; set; }

    public int? PbdIdSchematuImportu { get; set; }

    public int PbdDopasowanieSchematu { get; set; }

    public bool PbdSchematZatwierdzony { get; set; }

    public int? PbdIdKontrahenta { get; set; }

    public int? PbdIdKategorii { get; set; }

    public int PbdTypDokumentu { get; set; }

    public DateTime? PbdDataWystawienia { get; set; }

    public DateTime? PbdDataZakonczeniaDostawy { get; set; }

    public string? PbdRodzajFaktury { get; set; }

    public string? PbdNumerKseF { get; set; }

    public virtual ICollection<PbPlik> PbPliks { get; set; } = new List<PbPlik>();

    public virtual SlGrupaDokumentow? PbdIdGrupaDokumentuNavigation { get; set; }

    public virtual SlKategorium? PbdIdKategoriiNavigation { get; set; }

    public virtual KhKontrahent? PbdIdKontrahentaNavigation { get; set; }

    public virtual ImSchematImportu? PbdIdSchematuImportuNavigation { get; set; }
}
