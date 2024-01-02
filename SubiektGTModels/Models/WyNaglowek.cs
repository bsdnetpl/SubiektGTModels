using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyNaglowek
{
    public int WnglId { get; set; }

    public string WnglNazwa { get; set; } = null!;

    public string WnglTresc { get; set; } = null!;

    public byte[]? WnglLogo { get; set; }

    public int WnglTypNaglowka { get; set; }

    public int WnglLogoX { get; set; }

    public int WnglLogoY { get; set; }

    public int WnglTrescX { get; set; }

    public int WnglTrescY { get; set; }

    public int WnglWysokosc { get; set; }

    public bool WnglDrukujLogo { get; set; }

    public int WnglLogoWysokosc { get; set; }

    public int WnglLogoSzerokosc { get; set; }

    public bool WnglStandardowy { get; set; }

    public int WnglTrescSzerokosc { get; set; }

    public virtual ICollection<WyWzorzec> WyWzorzecWzwNaglowekRaportus { get; set; } = new List<WyWzorzec>();

    public virtual ICollection<WyWzorzec> WyWzorzecWzwNaglowekStronies { get; set; } = new List<WyWzorzec>();

    public virtual ICollection<WyWzorzec> WyWzorzecWzwStopkaRaportus { get; set; } = new List<WyWzorzec>();

    public virtual ICollection<WyWzorzec> WyWzorzecWzwStopkaStronies { get; set; } = new List<WyWzorzec>();
}
