using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SkSesja
{
    public int SksId { get; set; }

    public string SksNumer { get; set; } = null!;

    public int SksIdUzytkownika { get; set; }

    public int SksIdKasy { get; set; }

    public DateTime SksDataOtwarcia { get; set; }

    public DateTime? SksDataZamkniecia { get; set; }

    public DateTime? SksDataRozliczenia { get; set; }

    public int? SksStatusZgodnosci { get; set; }

    public int SksIdUzOtworzyl { get; set; }

    public int? SksIdUzZatwierdzilOtwarcie { get; set; }

    public int? SksIdUzZamknal { get; set; }

    public int? SksIdUzZatwierdzilZamkniecie { get; set; }

    public string SksUwagi { get; set; } = null!;

    public virtual ICollection<DokDokument> DokDokuments { get; set; } = new List<DokDokument>();

    public virtual ICollection<NzFinanse> NzFinanses { get; set; } = new List<NzFinanse>();

    public virtual ICollection<SkStan> SkStans { get; set; } = new List<SkStan>();

    public virtual DksKasa SksIdKasyNavigation { get; set; } = null!;

    public virtual PdUzytkownik SksIdUzytkownikaNavigation { get; set; } = null!;
}
