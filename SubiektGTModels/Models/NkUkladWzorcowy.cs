using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NkUkladWzorcowy
{
    public int NuwId { get; set; }

    public string NuwNazwa { get; set; } = null!;

    public int NuwSzerStrony { get; set; }

    public int NuwWysStrony { get; set; }

    public int NuwMargLewy { get; set; }

    public int NuwMargGorny { get; set; }

    public int NuwSzerNakl { get; set; }

    public int NuwWysNakl { get; set; }

    public int NuwSzerOdstep { get; set; }

    public int NuwWysOdstep { get; set; }

    public int NuwKolumny { get; set; }

    public int NuwWiersze { get; set; }

    public virtual ICollection<NkSzablon> NkSzablons { get; set; } = new List<NkSzablon>();
}
