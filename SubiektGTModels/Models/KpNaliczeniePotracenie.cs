using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KpNaliczeniePotracenie
{
    public int NalpId { get; set; }

    public int NalpStatus { get; set; }

    public int NalpSposobRozliczenia { get; set; }

    public int NalpTyp { get; set; }

    public DateTime NalpData { get; set; }

    public int NalpIdUmowy { get; set; }

    public int NalpIdSkladnika { get; set; }

    public decimal NalpWartosc { get; set; }

    public int? NalpIdDokRozliczajacego { get; set; }

    public string NalpDokumentRozliczajacyOpis { get; set; } = null!;

    public string NalpOpis { get; set; } = null!;

    public virtual PlbUmowa NalpIdUmowyNavigation { get; set; } = null!;
}
