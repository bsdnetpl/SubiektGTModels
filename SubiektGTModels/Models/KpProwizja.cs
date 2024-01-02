using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KpProwizja
{
    public int PrId { get; set; }

    public int PrStatus { get; set; }

    public int PrSposobRozliczenia { get; set; }

    public DateTime PrData { get; set; }

    public int? PrIdUmowyOprace { get; set; }

    public int? PrIdUmowyCywilnoprawnej { get; set; }

    public int PrIdStawkiProwizyjnej { get; set; }

    public decimal PrIlosc { get; set; }

    public decimal PrWartosc { get; set; }

    public int? PrIdDokRozlWyplata { get; set; }

    public int? PrIdDokRozlRachunek { get; set; }

    public string PrDokumentRozliczajacyOpis { get; set; } = null!;

    public string PrOpis { get; set; } = null!;

    public virtual PlbUmowaCp? PrIdUmowyCywilnoprawnejNavigation { get; set; }

    public virtual PlbUmowa? PrIdUmowyOpraceNavigation { get; set; }
}
