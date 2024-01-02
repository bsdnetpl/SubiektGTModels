using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DnkNotaKorygujaca
{
    public int DnkId { get; set; }

    public int DnkTyp { get; set; }

    public int DnkPodtyp { get; set; }

    public int DnkMagId { get; set; }

    public int DnkNr { get; set; }

    public string? DnkNrRoz { get; set; }

    public string DnkNrPelny { get; set; } = null!;

    public string DnkMscWyst { get; set; } = null!;

    public DateTime DnkDataWyst { get; set; }

    public DateTime? DnkDataPotw { get; set; }

    public bool? DnkPotwierdzenie { get; set; }

    public int? DnkOdbiorcaId { get; set; }

    public int? DnkOdbiorcaAdreshId { get; set; }

    public string DnkWystawil { get; set; } = null!;

    public string DnkOdebral { get; set; } = null!;

    public int? DnkPersonelId { get; set; }

    public string DnkUwagi { get; set; } = null!;

    public int? DnkKatId { get; set; }

    public string DnkTytul { get; set; } = null!;

    public string DnkPodtytul { get; set; } = null!;

    public string DnkTrescDoKor { get; set; } = null!;

    public string DnkTrescPoKor { get; set; } = null!;

    public DateTime? DnkDokKorDataSprzedazy { get; set; }

    public DateTime? DnkDokKorDataWystawienia { get; set; }

    public string DnkDokKorNrDok { get; set; } = null!;

    public string DnkDokKorNrDokNab { get; set; } = null!;

    public DateTime? DnkDokKorDataZakonczenia { get; set; }

    public virtual SlKategorium? DnkKat { get; set; }

    public virtual ICollection<DnkNotaDokKorygowane> DnkNotaDokKorygowanes { get; set; } = new List<DnkNotaDokKorygowane>();
}
