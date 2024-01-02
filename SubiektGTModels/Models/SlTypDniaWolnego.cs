using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTypDniaWolnego
{
    public int TdwId { get; set; }

    public string TdwMnemonik { get; set; } = null!;

    public string TdwOpis { get; set; } = null!;

    public virtual ICollection<PlbUmowaWyjatekCzasuPracy> PlbUmowaWyjatekCzasuPracies { get; set; } = new List<PlbUmowaWyjatekCzasuPracy>();

    public virtual ICollection<SlKalendDzien> SlKalendDziens { get; set; } = new List<SlKalendDzien>();

    public virtual ICollection<SlKalendWyjatek> SlKalendWyjateks { get; set; } = new List<SlKalendWyjatek>();
}
