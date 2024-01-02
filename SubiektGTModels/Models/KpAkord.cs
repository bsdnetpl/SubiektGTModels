using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KpAkord
{
    public int AkId { get; set; }

    public int AkStatus { get; set; }

    public int AkSposobRozliczenia { get; set; }

    public DateTime AkData { get; set; }

    public int? AkIdUmowyOprace { get; set; }

    public int? AkIdUmowyCywilnoprawnej { get; set; }

    public int AkIdStawkiAkordowej { get; set; }

    public decimal AkIlosc { get; set; }

    public decimal AkWartosc { get; set; }

    public int? AkIdDokRozlWyplata { get; set; }

    public int? AkIdDokRozlRachunek { get; set; }

    public string AkDokumentRozliczajacyOpis { get; set; } = null!;

    public string AkOpis { get; set; } = null!;

    public virtual SlStawkaAkordowa AkIdStawkiAkordowejNavigation { get; set; } = null!;

    public virtual PlbUmowaCp? AkIdUmowyCywilnoprawnejNavigation { get; set; }

    public virtual PlbUmowa? AkIdUmowyOpraceNavigation { get; set; }
}
