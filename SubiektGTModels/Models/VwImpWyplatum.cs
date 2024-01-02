using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwImpWyplatum
{
    public int WypId { get; set; }

    public int WypIdListyPlac { get; set; }

    public decimal WypBruttoDuze { get; set; }

    public decimal WypBrZasilkiZus { get; set; }

    public decimal? WypNeDoplaty { get; set; }

    public decimal? WypNeInnePrac { get; set; }

    public decimal WypZusfirma { get; set; }

    public decimal WypUbezpZdrowotne { get; set; }

    public decimal WypUbezpZdrowotne2 { get; set; }

    public decimal WypZusrazem { get; set; }

    public decimal WypZaliczkaNaPodatek { get; set; }

    public decimal WypFp { get; set; }

    public decimal WypFgsp { get; set; }

    public decimal? WplataPracodawcyPpkrazem { get; set; }
}
