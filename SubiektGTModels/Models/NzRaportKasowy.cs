using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzRaportKasowy
{
    public int RkId { get; set; }

    public int RkIdKasy { get; set; }

    public int? RkProgram { get; set; }

    public int RkIdUtworzyl { get; set; }

    public string RkNr { get; set; } = null!;

    public bool RkZatwierdzony { get; set; }

    public int? RkIdZatwierdzil { get; set; }

    public DateTime? RkDataZatwierdzenia { get; set; }

    public int RkStatusKsiegowy { get; set; }

    public DateTime RkData { get; set; }

    public DateTime RkOkresOd { get; set; }

    public DateTime RkOkresDo { get; set; }

    public int? RkIdKategorii { get; set; }

    public string RkUwagi { get; set; } = null!;

    public virtual ICollection<NzRaportKasowyDokumentKasowy> NzRaportKasowyDokumentKasowies { get; set; } = new List<NzRaportKasowyDokumentKasowy>();

    public virtual ICollection<NzRaportKasowyStan> NzRaportKasowyStans { get; set; } = new List<NzRaportKasowyStan>();

    public virtual DksKasa RkIdKasyNavigation { get; set; } = null!;

    public virtual SlKategorium? RkIdKategoriiNavigation { get; set; }

    public virtual PdUzytkownik RkIdUtworzylNavigation { get; set; } = null!;

    public virtual PdUzytkownik? RkIdZatwierdzilNavigation { get; set; }
}
