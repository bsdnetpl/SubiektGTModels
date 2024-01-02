using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DpDokument
{
    public int DpdId { get; set; }

    public string DpdNazwa { get; set; } = null!;

    public string DpdIdBiura { get; set; } = null!;

    public string DpdSygnatura { get; set; } = null!;

    public DateTime DpdDataPrzeslania { get; set; }

    public DateTime DpdMiesiacRozliczeniowy { get; set; }

    public DateTime DpdDataDokumentu { get; set; }

    public string DpdNumerDokumentu { get; set; } = null!;

    public int? DpdIdGrupaDokumentu { get; set; }

    public string DpdNotatka { get; set; } = null!;

    public bool DpdWprowadzDokument { get; set; }

    public int DpdRodzajDokumentuGlownego { get; set; }

    public int? DpdTypDokumentuGlownego { get; set; }

    public int? DpdTypDokumentuPowiazanego { get; set; }

    public int? DpdTypDokumentuWprowadzonego { get; set; }

    public int? DpdIdDokumentuWprowadzonego { get; set; }

    public int DpdStatus { get; set; }

    public int DpdStatusOcr { get; set; }

    public byte[]? DpdOrientacjaStron { get; set; }

    public string? DpdKomentarz { get; set; }

    public int? DpdTrybPracy { get; set; }

    public int DpdTrybWprowadzania { get; set; }

    public int? DpdIdSchematuImportu { get; set; }

    public int DpdDopasowanieSchematu { get; set; }

    public bool DpdSchematZatwierdzony { get; set; }

    public int? DpdIdKontrahenta { get; set; }

    public int? DpdIdKategorii { get; set; }

    public int DpdTypDokumentu { get; set; }

    public DateTime? DpdDataWystawienia { get; set; }

    public DateTime? DpdDataZakonczeniaDostawy { get; set; }

    public string? DpdRodzajFaktury { get; set; }

    public string? DpdNumerKseF { get; set; }

    public virtual ICollection<DpPlik> DpPliks { get; set; } = new List<DpPlik>();

    public virtual SlGrupaDokumentow? DpdIdGrupaDokumentuNavigation { get; set; }

    public virtual SlKategorium? DpdIdKategoriiNavigation { get; set; }

    public virtual KhKontrahent? DpdIdKontrahentaNavigation { get; set; }

    public virtual ImSchematImportu? DpdIdSchematuImportuNavigation { get; set; }
}
