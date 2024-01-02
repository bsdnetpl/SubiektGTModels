using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKalendarz
{
    public int SlkId { get; set; }

    public string SlkNazwa { get; set; } = null!;

    public int SlkRodzajGodzin { get; set; }

    public int? SlkGodzinaRozpoczeciaPracy { get; set; }

    public virtual ICollection<PlbUmowaParametr> PlbUmowaParametrs { get; set; } = new List<PlbUmowaParametr>();

    public virtual ICollection<SlKalendCykl> SlKalendCykls { get; set; } = new List<SlKalendCykl>();

    public virtual ICollection<SlKalendWyjatek> SlKalendWyjateks { get; set; } = new List<SlKalendWyjatek>();
}
