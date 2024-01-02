using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdKonwersjaOdlaczanie
{
    public int KbId { get; set; }

    public DateTime KbGodzinaDodania { get; set; }

    public bool KbAktywne { get; set; }

    public string? KbDodatkoweInfo { get; set; }

    public int KbZaIleAkcja { get; set; }

    public string? KbOsobaKonwertujaca { get; set; }

    public bool KbKonwersjaRozp { get; set; }

    public virtual ICollection<PdKonwersjaInfo> PdKonwersjaInfos { get; set; } = new List<PdKonwersjaInfo>();
}
