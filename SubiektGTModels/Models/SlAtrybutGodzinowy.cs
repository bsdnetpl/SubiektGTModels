using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlAtrybutGodzinowy
{
    public int SlagId { get; set; }

    public string SlagNazwa { get; set; } = null!;

    public decimal SlagWspolczynnik { get; set; }

    public virtual ICollection<EcpGodzina> EcpGodzinas { get; set; } = new List<EcpGodzina>();

    public virtual ICollection<PlbUmowaWyjatekCzasuPracyOkre> PlbUmowaWyjatekCzasuPracyOkres { get; set; } = new List<PlbUmowaWyjatekCzasuPracyOkre>();

    public virtual ICollection<PprObecnosc> PprObecnoscs { get; set; } = new List<PprObecnosc>();

    public virtual ICollection<SlKalendGodzina> SlKalendGodzinas { get; set; } = new List<SlKalendGodzina>();

    public virtual ICollection<SlKalendWyjGodzina> SlKalendWyjGodzinas { get; set; } = new List<SlKalendWyjGodzina>();

    public virtual ICollection<SlTypObecnosci> SlTypObecnoscis { get; set; } = new List<SlTypObecnosci>();
}
