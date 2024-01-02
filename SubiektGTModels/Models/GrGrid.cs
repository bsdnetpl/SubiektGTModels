using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrGrid
{
    public int GrId { get; set; }

    public string GrSection { get; set; } = null!;

    public int GrIdModulu { get; set; }

    public string? GrNazwa { get; set; }

    public string GrTyp { get; set; } = null!;

    public byte[]? GrFiltrStandardowy { get; set; }

    public string? GrFiltrDodatkowy { get; set; }

    public bool GrFiltrDodatkowyZapamietywanie { get; set; }

    public bool GrFiltrDodatkowyWyliczanie { get; set; }

    public int GrStatusNowosci { get; set; }

    public int GrKolejnosc { get; set; }

    public int? GrIdFiltrKlasyfikacji { get; set; }

    public int GrTypEx { get; set; }

    public virtual KsKlasyfikatory? GrIdFiltrKlasyfikacjiNavigation { get; set; }

    public virtual ICollection<GrKomponentKalendarzowyGodzinyPracy> GrKomponentKalendarzowyGodzinyPracies { get; set; } = new List<GrKomponentKalendarzowyGodzinyPracy>();

    public virtual ICollection<GrWyszukiwanieWlasne> GrWyszukiwanieWlasnes { get; set; } = new List<GrWyszukiwanieWlasne>();
}
